using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics.Contracts;
using System.Diagnostics;
using Sunny.UI;
using Sunny.UI.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.Threading.Tasks;


namespace LDebugAssistant.Helper
{
    public class SocketHelper
    {
        /// <summary>
        /// TCP服务器模式
        /// 参考https://blog.csdn.net/weixin_43626218/article/details/138545475
        /// </summary>
        public class TCPServer
        {

            //字段定义
            private string _ip = String.Empty;
            private int _port = -1;
            private Socket _listenSocket = null;
            private bool _isConnected = false;
            private bool _isListening = false;
            private Encoding _dataEncoding = Encoding.UTF8;
            private int _maxClientsNumber = 10;
            private Dictionary<string, Socket> _socketList = new Dictionary<string, Socket>();


            //属性定义
            public string IP { get => _ip; set => _ip = value; }
            public int Port { get => _port; set => _port = value; }
            public bool IsConnected { get => _isConnected; }
            public bool IsListening { get => _isListening; }
            public Encoding DataEncoding { get => _dataEncoding; set => _dataEncoding = value; }
            public int MaxClientsNumber { get => _maxClientsNumber; set => _maxClientsNumber = value; }
            public List<string> ClientList { get => _socketList.Keys.ToList(); }

            //事件定义
            public event EventHandler<int> DataSend;
            public event EventHandler<Dictionary<string, string>> DataReceive;
            public event EventHandler<string> ServerMessage;
            public event EventHandler<string> ClientChanged;

            public TCPServer() { }
            public TCPServer(string ip, int port)
            {
                _ip = ip;
                _port = port;
            }

            public bool StartListen()
            {
                //参数检查
                if (_ip == string.Empty || 0 >= _port || _port >= 65535)
                {
                    ServerMessage?.Invoke(this, "服务器初始化参数异常");
                }
                try
                {
                    IPAddress iPAddress = IPAddress.Parse(_ip);
                    IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, _port);
                    _listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    _listenSocket.Bind(iPEndPoint);
                    _listenSocket.Listen(_maxClientsNumber);

                    //监听任务
                    Task.Run(() =>
                    {
                        ServerMessage?.Invoke(this, "开始侦听客户端连接");
                        _isListening = true;
                        ListeningClient();
                    });
                    return true;
                }
                catch (Exception ex)
                {
                    ServerMessage?.Invoke(this, "侦听失败：" + ex.Message);
                    _isListening = false;
                    return false;
                }
            }

            public bool StopListen()
            {
                try
                {
                    _listenSocket.Close();
                    foreach (var item in _socketList)
                    {
                        item.Value.Shutdown(SocketShutdown.Both);
                        item.Value.Close();
                    }

                    ClientChanged?.Invoke("Remove", "None");
                    return true;
                }
                catch (Exception ex)
                {
                    ServerMessage?.Invoke(this, "停止侦听客户端连接失败：" + ex.Message);
                    return false;
                }
            }

            private void ListeningClient()
            {
                while (true)
                {
                    try
                    {
                        Socket socket = _listenSocket.Accept();
                        _isConnected = true;
                        string ipPort = socket.RemoteEndPoint.ToString();
                        _socketList.Add(ipPort, socket);

                        Task.Run(() =>
                        {
                            ClientChanged?.Invoke("Add", ipPort);
                            ServerMessage?.Invoke(this, $"客户端[{ipPort}]已经连接");
                            Received(socket);
                        }).ContinueWith(t =>
                        {
                            _socketList[ipPort].Close();
                            _socketList.Remove(ipPort);
                            ClientChanged?.Invoke("Remove", ipPort);
                            ServerMessage?.Invoke(this, $"客户端[{ipPort}]断开连接");
                        });
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        _isListening = false;
                        _isConnected = false;
                        ServerMessage?.Invoke(this, $"服务器停止侦听:{ex.Message}");
                        break;
                    }

                }

            }

            private void Received(object clientSocket)
            {
                Socket socket = clientSocket as Socket;
                string ipPort = socket.RemoteEndPoint.ToString(); ;
                while (true)
                {
                    try
                    {
                        if(socket.Available > 0) continue;
                        byte[] buffer = new byte[1024 * 1024];
                        int length = socket.Receive(buffer);
                        if (length <= 0) break;
                        DataParsingEngine(ipPort, buffer, length);
                    }
                    catch (Exception)
                    {
                        break;
                    }
                }
            }

            private void DataParsingEngine(string ipPort, byte[] buffer, int length)
            {
                string data = _dataEncoding.GetString(buffer, 0, length);
                Dictionary<string, string> eventArgsPara = new Dictionary<string, string>();
                eventArgsPara.Add("cilent", ipPort);
                eventArgsPara.Add("data", data);
                eventArgsPara.Add("length", length.ToString());
                DataReceive?.Invoke(this, eventArgsPara);
            }


            public bool Send(string data, string ipPort = "None")
            {
                if (_isListening)
                {
                    if (ipPort == "None")
                    {
                        foreach (var item in _socketList)
                        {
                            try
                            {
                                byte[] byteData = _dataEncoding.GetBytes(data);
                                item.Value.Send(byteData);
                                DataSend?.Invoke(this, byteData.Length);
                                return true;
                            }
                            catch (Exception)
                            {
                                _socketList[item.Key].Close();
                                _socketList.Remove(item.Key);
                                ClientChanged?.Invoke("Remove", item.Key);
                                ServerMessage?.Invoke(this, $"客户端[{item.Key}]断开连接");
                                return false;
                            }

                        }
                    }
                    else
                    {
                        try
                        {
                            byte[] byteData = _dataEncoding.GetBytes(data);
                            _socketList[ipPort].Send(byteData);
                            DataSend?.Invoke(this, byteData.Length);
                            return true;
                        }
                        catch (Exception)
                        {
                            _socketList[ipPort].Close();
                            _socketList.Remove(ipPort);

                            ClientChanged?.Invoke("Remove", ipPort);
                            ServerMessage?.Invoke(this, $"客户端[{ipPort}]断开连接");
                            return false;
                        }
                    }
                }
                return false;
            }
        }
        /// <summary>
        /// TCP客户端模式
        /// </summary>
        public class TCPClient
        {

        }
        /// <summary>
        /// UDP服务器模式
        /// </summary>
        public class UDPServer
        {

        }
        /// <summary>
        /// UDP客户端模式
        /// </summary>
        public class UDPClient
        {

        }
        /// <summary>
        /// 获取本机IPV4地址列表
        /// </summary>
        /// <returns>IPV4地址列表</returns>
        public static string[] GetIPAddress()
        {
            List<string> addressList = new List<string>();
            //添加默认本机IP
            addressList.Add("127.0.0.1");
            IPHostEntry entry = Dns.GetHostEntry(Dns.GetHostName()); ;
            IPAddress[] iPAddress = entry.AddressList;
            foreach (IPAddress ipAddress in iPAddress)
            {
                //仅获取IPV4地址列表
                if (ipAddress.AddressFamily.ToString() == "InterNetwork")
                    addressList.Add(ipAddress.ToString());
            }
            return addressList.ToArray();
        }

        public class DataReveivedEventArgs : EventArgs
        {
            public string Client { get; set; }
            public string Data { get; set; }
        }
    }
}

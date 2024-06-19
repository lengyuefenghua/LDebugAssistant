using LDebugAssistant.Helper;
using Sunny.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LDebugAssistant.Helper.SocketHelper;

namespace LDebugAssistant.Forms
{
    public partial class SocketPage : UIPage
    {
        private Color _timeStampColor = Color.OrangeRed;
        private SocketHelper.TCPServer _tcpServer;
        public SocketPage()
        {
            InitializeComponent();
        }
        private void SocketPage_Load(object sender, EventArgs e)
        {
            UpdateIPList();
        }

        private void UbtnStart_Click(object sender, EventArgs e)
        {
            if (this.cbbCommunicationProtocols.SelectedText == "TCP Server")
            {
                if (btnStart.Text == "开始侦听")
                {
                    _tcpServer = new TCPServer();
                    _tcpServer.IP = cbbCommunicationAddress.Text;
                    _tcpServer.Port = Convert.ToInt32(tbCommunicationPort.Text);
                    
                    _tcpServer.ClientChanged += UpdateClientList;
                    _tcpServer.ServerMessage += OnServerMessage;
                    _tcpServer.DataReceive += OnDataReceived;
                    _tcpServer.DataSend += OnDataSend;
                    _tcpServer.StartListen();

                    this.btnStart.Text = "停止侦听";
                }
                else
                {
                    _tcpServer.StopListen();
                    _tcpServer.ClientChanged -= UpdateClientList;
                    _tcpServer.ServerMessage -= OnServerMessage;
                    _tcpServer.DataReceive -= OnDataReceived;
                    _tcpServer.DataSend -= OnDataSend;
                    _tcpServer= null;
                    this.btnStart.Text = "开始侦听";
                }

            }


        }

        private void OnDataSend(object sender, int e)
        {
            
        }

        private void OnDataReceived(object sender, Dictionary<string, string> e)
        {
            DataDisplay(e["data"], true);
            Console.WriteLine("字节数："+e["length"]);

        }

        private void OnServerMessage(object sender, string e)
        {
            //this.ShowInfoNotifier(e);
            //MessageBox.Show(e);
            Console.WriteLine(e);
        }

        private void UpdateClientList(object sender,string e)
        {
            this.Invoke(new Action(()=>
            {
                this.tsddbCilent.DropDownItems.Clear();
                this.tsddbCilent.DropDownItems.Add("None");
                if(_tcpServer != null)
                {
                    List<string> clientList = _tcpServer.ClientList;
                    foreach (string client in clientList)
                    {
                        this.tsddbCilent.DropDownItems.Add(client);
                    }
                }
                
            }));
        }

        private void UpdateIPList()
        {
            this.cbbCommunicationAddress.Items.Clear();
            this.cbbCommunicationAddress.Items.AddRange(SocketHelper.GetIPAddress());
        }
        private void UcbAutoSave_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            _tcpServer.Send(rtbSendBox.Text, tsddbCilent.Text);
            DataDisplay(rtbSendBox.Text, true);
        }

        private void TsddbCilent_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.tsddbCilent.Text = e.ClickedItem.Text;
        }

        public void DataDisplay(string text,bool displayTimestamp)
        {
            this.Invoke(new Action(()=>
            {
                string timeStamp = displayTimestamp ? DateTime.Now.ToString("HH:mm:ss.fff ") : "";
                this.rtbDataRecv.AppendText(timeStamp,_timeStampColor);
                this.rtbDataRecv.AppendText(text+"\n",Color.Black);
                this.rtbDataRecv.SelectionStart = this.rtbDataRecv.Text.Length;
                this.rtbDataRecv.ScrollToCaret();
            }));
        }

        private void TbSendTime_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }

    public static class UIRichTextBoxColorExtensions
    {
        public static void AppendText(this UIRichTextBox rtb, string text, Color color)
        {
            rtb.SuspendLayout();
            rtb.SelectionStart = rtb.TextLength;
            rtb.SelectionLength = 0;
            rtb.SelectionColor = color;
            rtb.AppendText(text);
            rtb.SelectionColor = rtb.ForeColor;
            rtb.ScrollToCaret();
            rtb.ResumeLayout();
        }
    }
}

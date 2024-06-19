using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LDebugAssistant.Forms;
using Sunny.UI;

namespace LDebugAssistant
{
    public partial class MainForm : UIForm
    {
        SocketPage _socketPage = new SocketPage();
        SerialPortPage _serialPortPage = new SerialPortPage();
        public MainForm()
        {
            InitializeComponent();
            SelectTabPage(this.tcmPages, _socketPage);
        }

        private void TcmPages_Selected(object sender, TabControlEventArgs e)
        {
            switch (this.tcmPages.SelectedTab.Text.ToString())
            {
                case "网络调试":
                    SelectTabPage((UITabControlMenu)sender, _socketPage);
                    break;
                case "串口调试":
                    SelectTabPage((UITabControlMenu)sender, _serialPortPage);
                    break;
                default:
                    break;
            }
        }

        private void SelectTabPage(UITabControlMenu uITabControlMenu, UIPage uIPage)
        {
            uIPage.Parent = uITabControlMenu.SelectedTab;
            uIPage.TopLevel = false;
            uIPage.Dock = DockStyle.Fill;
            uIPage.Show();
        }
    }
}

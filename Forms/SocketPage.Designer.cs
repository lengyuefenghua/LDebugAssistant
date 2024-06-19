namespace LDebugAssistant.Forms
{
    partial class SocketPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SocketPage));
            this.cbbCommunicationProtocols = new Sunny.UI.UIComboBox();
            this.gbBaseSettings = new Sunny.UI.UIGroupBox();
            this.btnStart = new Sunny.UI.UIButton();
            this.btnState = new Sunny.UI.UIButton();
            this.shAutoConnnect = new Sunny.UI.UISwitch();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.tbCommunicationPort = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.cbbCommunicationAddress = new Sunny.UI.UIComboBox();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.cbAutoNewline = new Sunny.UI.UICheckBox();
            this.btnSaveData = new Sunny.UI.UIButton();
            this.btnRecvClear = new Sunny.UI.UIButton();
            this.cbAutoSave = new Sunny.UI.UICheckBox();
            this.cbRecvTimestamp = new Sunny.UI.UICheckBox();
            this.rbRecvHEX = new Sunny.UI.UIRadioButton();
            this.rbRecvASCII = new Sunny.UI.UIRadioButton();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.btnFileRead = new Sunny.UI.UIButton();
            this.btnSendClearSend = new Sunny.UI.UIButton();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.cbbSendEndSymbol = new Sunny.UI.UIComboBox();
            this.tbSendTime = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.cbSendQuickReply = new Sunny.UI.UICheckBox();
            this.cbSendTimeSnd = new Sunny.UI.UICheckBox();
            this.cbSendTimestamp = new Sunny.UI.UICheckBox();
            this.rbSendHEX = new Sunny.UI.UIRadioButton();
            this.rbSendASCII = new Sunny.UI.UIRadioButton();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.tcRecvTab = new Sunny.UI.UITabControl();
            this.tpRecvPage = new System.Windows.Forms.TabPage();
            this.rtbDataRecv = new Sunny.UI.UIRichTextBox();
            this.tpMonitorPage = new System.Windows.Forms.TabPage();
            this.tpDataDisplay = new System.Windows.Forms.TabPage();
            this.tcSendTab = new Sunny.UI.UITabControl();
            this.tpSingleSend = new System.Windows.Forms.TabPage();
            this.btnSend = new Sunny.UI.UISymbolButton();
            this.rtbSendBox = new Sunny.UI.UIRichTextBox();
            this.tpMultinomialSend = new System.Windows.Forms.TabPage();
            this.flpSendMutilSendPanl = new Sunny.UI.UIFlowLayoutPanel();
            this.tpQueueSend = new System.Windows.Forms.TabPage();
            this.tpAutoSend = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsddbCilent = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsslConnectInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSendCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslRecvCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCountClear = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsmEncodeBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmEncodeGBK = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEncodeASCII = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEncodeUTF8 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEncodeGB2312 = new System.Windows.Forms.ToolStripMenuItem();
            this.gbBaseSettings.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.tcRecvTab.SuspendLayout();
            this.tpRecvPage.SuspendLayout();
            this.tcSendTab.SuspendLayout();
            this.tpSingleSend.SuspendLayout();
            this.tpMultinomialSend.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbCommunicationProtocols
            // 
            this.cbbCommunicationProtocols.DataSource = null;
            this.cbbCommunicationProtocols.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbbCommunicationProtocols.DropDownWidth = 130;
            this.cbbCommunicationProtocols.FillColor = System.Drawing.Color.White;
            this.cbbCommunicationProtocols.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbCommunicationProtocols.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbbCommunicationProtocols.Items.AddRange(new object[] {
            "TCP Client",
            "TCP Server",
            "UDP"});
            this.cbbCommunicationProtocols.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbbCommunicationProtocols.Location = new System.Drawing.Point(66, 27);
            this.cbbCommunicationProtocols.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbCommunicationProtocols.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbbCommunicationProtocols.Name = "cbbCommunicationProtocols";
            this.cbbCommunicationProtocols.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbbCommunicationProtocols.RectColor = System.Drawing.Color.DimGray;
            this.cbbCommunicationProtocols.Size = new System.Drawing.Size(130, 23);
            this.cbbCommunicationProtocols.SymbolSize = 24;
            this.cbbCommunicationProtocols.TabIndex = 0;
            this.cbbCommunicationProtocols.Text = "TCP Server";
            this.cbbCommunicationProtocols.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbbCommunicationProtocols.Watermark = "";
            // 
            // gbBaseSettings
            // 
            this.gbBaseSettings.Controls.Add(this.btnStart);
            this.gbBaseSettings.Controls.Add(this.btnState);
            this.gbBaseSettings.Controls.Add(this.shAutoConnnect);
            this.gbBaseSettings.Controls.Add(this.uiLabel4);
            this.gbBaseSettings.Controls.Add(this.tbCommunicationPort);
            this.gbBaseSettings.Controls.Add(this.uiLabel3);
            this.gbBaseSettings.Controls.Add(this.uiLabel2);
            this.gbBaseSettings.Controls.Add(this.uiLabel1);
            this.gbBaseSettings.Controls.Add(this.cbbCommunicationAddress);
            this.gbBaseSettings.Controls.Add(this.cbbCommunicationProtocols);
            this.gbBaseSettings.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbBaseSettings.Location = new System.Drawing.Point(1, 0);
            this.gbBaseSettings.Margin = new System.Windows.Forms.Padding(0);
            this.gbBaseSettings.MinimumSize = new System.Drawing.Size(1, 1);
            this.gbBaseSettings.Name = "gbBaseSettings";
            this.gbBaseSettings.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.gbBaseSettings.RectColor = System.Drawing.Color.Gray;
            this.gbBaseSettings.Size = new System.Drawing.Size(202, 194);
            this.gbBaseSettings.TabIndex = 1;
            this.gbBaseSettings.Text = "基本配置";
            this.gbBaseSettings.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnStart.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnStart.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnStart.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnStart.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnStart.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btnStart.Location = new System.Drawing.Point(66, 163);
            this.btnStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStart.Name = "btnStart";
            this.btnStart.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnStart.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnStart.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnStart.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnStart.Size = new System.Drawing.Size(130, 23);
            this.btnStart.Style = Sunny.UI.UIStyle.Custom;
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "开始侦听";
            this.btnStart.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Click += new System.EventHandler(this.UbtnStart_Click);
            // 
            // btnState
            // 
            this.btnState.BackColor = System.Drawing.Color.Transparent;
            this.btnState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnState.FillColor = System.Drawing.Color.DimGray;
            this.btnState.FillColor2 = System.Drawing.Color.DimGray;
            this.btnState.FillDisableColor = System.Drawing.Color.DimGray;
            this.btnState.FillHoverColor = System.Drawing.Color.DimGray;
            this.btnState.FillPressColor = System.Drawing.Color.DimGray;
            this.btnState.FillSelectedColor = System.Drawing.Color.LimeGreen;
            this.btnState.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnState.ForeColor = System.Drawing.Color.DimGray;
            this.btnState.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btnState.Location = new System.Drawing.Point(10, 163);
            this.btnState.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnState.Name = "btnState";
            this.btnState.Radius = 23;
            this.btnState.RectColor = System.Drawing.Color.DimGray;
            this.btnState.RectDisableColor = System.Drawing.Color.DimGray;
            this.btnState.RectHoverColor = System.Drawing.Color.DimGray;
            this.btnState.RectPressColor = System.Drawing.Color.DimGray;
            this.btnState.RectSelectedColor = System.Drawing.Color.DimGray;
            this.btnState.Selected = true;
            this.btnState.Size = new System.Drawing.Size(23, 23);
            this.btnState.Style = Sunny.UI.UIStyle.Custom;
            this.btnState.TabIndex = 7;
            this.btnState.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // shAutoConnnect
            // 
            this.shAutoConnnect.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.shAutoConnnect.Location = new System.Drawing.Point(66, 128);
            this.shAutoConnnect.MinimumSize = new System.Drawing.Size(1, 1);
            this.shAutoConnnect.Name = "shAutoConnnect";
            this.shAutoConnnect.Size = new System.Drawing.Size(65, 23);
            this.shAutoConnnect.TabIndex = 2;
            this.shAutoConnnect.Text = "uiSwitch1";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(5, 128);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(58, 23);
            this.uiLabel4.TabIndex = 5;
            this.uiLabel4.Text = "自动重连";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbCommunicationPort
            // 
            this.tbCommunicationPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCommunicationPort.DoubleValue = 8000D;
            this.tbCommunicationPort.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCommunicationPort.IntValue = 8000;
            this.tbCommunicationPort.Location = new System.Drawing.Point(66, 95);
            this.tbCommunicationPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCommunicationPort.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbCommunicationPort.Name = "tbCommunicationPort";
            this.tbCommunicationPort.Padding = new System.Windows.Forms.Padding(5);
            this.tbCommunicationPort.RectColor = System.Drawing.Color.DimGray;
            this.tbCommunicationPort.ShowText = false;
            this.tbCommunicationPort.Size = new System.Drawing.Size(130, 23);
            this.tbCommunicationPort.TabIndex = 2;
            this.tbCommunicationPort.Text = "8000";
            this.tbCommunicationPort.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbCommunicationPort.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(5, 95);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(58, 23);
            this.uiLabel3.TabIndex = 4;
            this.uiLabel3.Text = "通讯端口";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(5, 61);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(58, 23);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "通讯地址";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(5, 27);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(58, 23);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "通讯协议";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbCommunicationAddress
            // 
            this.cbbCommunicationAddress.DataSource = null;
            this.cbbCommunicationAddress.DropDownWidth = 130;
            this.cbbCommunicationAddress.FillColor = System.Drawing.Color.White;
            this.cbbCommunicationAddress.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbCommunicationAddress.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbbCommunicationAddress.Items.AddRange(new object[] {
            "127.0.0.1"});
            this.cbbCommunicationAddress.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbbCommunicationAddress.Location = new System.Drawing.Point(66, 61);
            this.cbbCommunicationAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbCommunicationAddress.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbbCommunicationAddress.Name = "cbbCommunicationAddress";
            this.cbbCommunicationAddress.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbbCommunicationAddress.RectColor = System.Drawing.Color.DimGray;
            this.cbbCommunicationAddress.Size = new System.Drawing.Size(130, 23);
            this.cbbCommunicationAddress.SymbolSize = 24;
            this.cbbCommunicationAddress.TabIndex = 1;
            this.cbbCommunicationAddress.Text = "127.0.0.1";
            this.cbbCommunicationAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbbCommunicationAddress.Watermark = "";
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.cbAutoNewline);
            this.uiGroupBox1.Controls.Add(this.btnSaveData);
            this.uiGroupBox1.Controls.Add(this.btnRecvClear);
            this.uiGroupBox1.Controls.Add(this.cbAutoSave);
            this.uiGroupBox1.Controls.Add(this.cbRecvTimestamp);
            this.uiGroupBox1.Controls.Add(this.rbRecvHEX);
            this.uiGroupBox1.Controls.Add(this.rbRecvASCII);
            this.uiGroupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(1, 196);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.RectColor = System.Drawing.Color.DimGray;
            this.uiGroupBox1.Size = new System.Drawing.Size(202, 152);
            this.uiGroupBox1.TabIndex = 2;
            this.uiGroupBox1.Text = "接收设置";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbAutoNewline
            // 
            this.cbAutoNewline.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.cbAutoNewline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAutoNewline.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbAutoNewline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbAutoNewline.Location = new System.Drawing.Point(7, 88);
            this.cbAutoNewline.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbAutoNewline.Name = "cbAutoNewline";
            this.cbAutoNewline.Size = new System.Drawing.Size(90, 23);
            this.cbAutoNewline.Style = Sunny.UI.UIStyle.Custom;
            this.cbAutoNewline.TabIndex = 11;
            this.cbAutoNewline.Text = "自动换行";
            // 
            // btnSaveData
            // 
            this.btnSaveData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnSaveData.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnSaveData.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnSaveData.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnSaveData.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnSaveData.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveData.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btnSaveData.Location = new System.Drawing.Point(103, 122);
            this.btnSaveData.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnSaveData.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnSaveData.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnSaveData.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnSaveData.Size = new System.Drawing.Size(70, 23);
            this.btnSaveData.Style = Sunny.UI.UIStyle.Custom;
            this.btnSaveData.TabIndex = 10;
            this.btnSaveData.Text = "保存数据";
            this.btnSaveData.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnRecvClear
            // 
            this.btnRecvClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecvClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnRecvClear.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnRecvClear.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnRecvClear.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnRecvClear.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnRecvClear.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRecvClear.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btnRecvClear.Location = new System.Drawing.Point(7, 122);
            this.btnRecvClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRecvClear.Name = "btnRecvClear";
            this.btnRecvClear.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnRecvClear.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnRecvClear.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnRecvClear.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnRecvClear.Size = new System.Drawing.Size(70, 23);
            this.btnRecvClear.Style = Sunny.UI.UIStyle.Custom;
            this.btnRecvClear.TabIndex = 9;
            this.btnRecvClear.Text = "接收清空";
            this.btnRecvClear.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // cbAutoSave
            // 
            this.cbAutoSave.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.cbAutoSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAutoSave.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbAutoSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbAutoSave.Location = new System.Drawing.Point(103, 59);
            this.cbAutoSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbAutoSave.Name = "cbAutoSave";
            this.cbAutoSave.Size = new System.Drawing.Size(90, 23);
            this.cbAutoSave.Style = Sunny.UI.UIStyle.Custom;
            this.cbAutoSave.TabIndex = 3;
            this.cbAutoSave.Text = "自动保存";
            this.cbAutoSave.CheckedChanged += new System.EventHandler(this.UcbAutoSave_CheckedChanged);
            // 
            // cbRecvTimestamp
            // 
            this.cbRecvTimestamp.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.cbRecvTimestamp.Checked = true;
            this.cbRecvTimestamp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbRecvTimestamp.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbRecvTimestamp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbRecvTimestamp.Location = new System.Drawing.Point(7, 59);
            this.cbRecvTimestamp.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbRecvTimestamp.Name = "cbRecvTimestamp";
            this.cbRecvTimestamp.Size = new System.Drawing.Size(90, 23);
            this.cbRecvTimestamp.Style = Sunny.UI.UIStyle.Custom;
            this.cbRecvTimestamp.TabIndex = 2;
            this.cbRecvTimestamp.Text = "时间戳";
            // 
            // rbRecvHEX
            // 
            this.rbRecvHEX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbRecvHEX.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbRecvHEX.Location = new System.Drawing.Point(103, 29);
            this.rbRecvHEX.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbRecvHEX.Name = "rbRecvHEX";
            this.rbRecvHEX.RadioButtonColor = System.Drawing.Color.DimGray;
            this.rbRecvHEX.Size = new System.Drawing.Size(90, 23);
            this.rbRecvHEX.TabIndex = 1;
            this.rbRecvHEX.Text = "HEX";
            // 
            // rbRecvASCII
            // 
            this.rbRecvASCII.Checked = true;
            this.rbRecvASCII.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbRecvASCII.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbRecvASCII.Location = new System.Drawing.Point(7, 29);
            this.rbRecvASCII.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbRecvASCII.Name = "rbRecvASCII";
            this.rbRecvASCII.RadioButtonColor = System.Drawing.Color.DimGray;
            this.rbRecvASCII.Size = new System.Drawing.Size(90, 23);
            this.rbRecvASCII.TabIndex = 0;
            this.rbRecvASCII.Text = "ASCII";
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.btnFileRead);
            this.uiGroupBox2.Controls.Add(this.btnSendClearSend);
            this.uiGroupBox2.Controls.Add(this.uiLabel7);
            this.uiGroupBox2.Controls.Add(this.cbbSendEndSymbol);
            this.uiGroupBox2.Controls.Add(this.tbSendTime);
            this.uiGroupBox2.Controls.Add(this.uiLabel5);
            this.uiGroupBox2.Controls.Add(this.cbSendQuickReply);
            this.uiGroupBox2.Controls.Add(this.cbSendTimeSnd);
            this.uiGroupBox2.Controls.Add(this.cbSendTimestamp);
            this.uiGroupBox2.Controls.Add(this.rbSendHEX);
            this.uiGroupBox2.Controls.Add(this.rbSendASCII);
            this.uiGroupBox2.Controls.Add(this.uiLabel6);
            this.uiGroupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox2.Location = new System.Drawing.Point(1, 350);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.RectColor = System.Drawing.Color.DimGray;
            this.uiGroupBox2.Size = new System.Drawing.Size(202, 187);
            this.uiGroupBox2.TabIndex = 3;
            this.uiGroupBox2.Text = "发送设置";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFileRead
            // 
            this.btnFileRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFileRead.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnFileRead.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnFileRead.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnFileRead.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnFileRead.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnFileRead.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFileRead.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btnFileRead.Location = new System.Drawing.Point(103, 156);
            this.btnFileRead.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFileRead.Name = "btnFileRead";
            this.btnFileRead.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnFileRead.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnFileRead.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnFileRead.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnFileRead.Size = new System.Drawing.Size(70, 23);
            this.btnFileRead.Style = Sunny.UI.UIStyle.Custom;
            this.btnFileRead.TabIndex = 15;
            this.btnFileRead.Text = "文件读取";
            this.btnFileRead.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnSendClearSend
            // 
            this.btnSendClearSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendClearSend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnSendClearSend.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnSendClearSend.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnSendClearSend.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnSendClearSend.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnSendClearSend.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSendClearSend.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btnSendClearSend.Location = new System.Drawing.Point(7, 155);
            this.btnSendClearSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSendClearSend.Name = "btnSendClearSend";
            this.btnSendClearSend.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnSendClearSend.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnSendClearSend.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnSendClearSend.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnSendClearSend.Size = new System.Drawing.Size(70, 23);
            this.btnSendClearSend.Style = Sunny.UI.UIStyle.Custom;
            this.btnSendClearSend.TabIndex = 14;
            this.btnSendClearSend.Text = "发送清空";
            this.btnSendClearSend.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(7, 125);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(58, 23);
            this.uiLabel7.TabIndex = 13;
            this.uiLabel7.Text = "结束符号";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbSendEndSymbol
            // 
            this.cbbSendEndSymbol.DataSource = null;
            this.cbbSendEndSymbol.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbbSendEndSymbol.DropDownWidth = 130;
            this.cbbSendEndSymbol.FillColor = System.Drawing.Color.White;
            this.cbbSendEndSymbol.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbSendEndSymbol.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbbSendEndSymbol.Items.AddRange(new object[] {
            "None",
            "\\r",
            "\\n",
            "\\r\\n",
            "\\n\\r"});
            this.cbbSendEndSymbol.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbbSendEndSymbol.Location = new System.Drawing.Point(103, 125);
            this.cbbSendEndSymbol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbSendEndSymbol.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbbSendEndSymbol.Name = "cbbSendEndSymbol";
            this.cbbSendEndSymbol.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbbSendEndSymbol.RectColor = System.Drawing.Color.DimGray;
            this.cbbSendEndSymbol.Size = new System.Drawing.Size(93, 23);
            this.cbbSendEndSymbol.SymbolSize = 24;
            this.cbbSendEndSymbol.TabIndex = 12;
            this.cbbSendEndSymbol.Text = "None";
            this.cbbSendEndSymbol.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbbSendEndSymbol.Watermark = "";
            // 
            // tbSendTime
            // 
            this.tbSendTime.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tbSendTime.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.tbSendTime.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.tbSendTime.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tbSendTime.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.tbSendTime.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.tbSendTime.ButtonStyleInherited = false;
            this.tbSendTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSendTime.DoubleValue = 1000D;
            this.tbSendTime.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tbSendTime.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSendTime.IntValue = 1000;
            this.tbSendTime.Location = new System.Drawing.Point(132, 95);
            this.tbSendTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSendTime.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbSendTime.Name = "tbSendTime";
            this.tbSendTime.Padding = new System.Windows.Forms.Padding(5);
            this.tbSendTime.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tbSendTime.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tbSendTime.ScrollBarStyleInherited = false;
            this.tbSendTime.ShowText = false;
            this.tbSendTime.Size = new System.Drawing.Size(47, 23);
            this.tbSendTime.Style = Sunny.UI.UIStyle.Custom;
            this.tbSendTime.TabIndex = 9;
            this.tbSendTime.Text = "1000";
            this.tbSendTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbSendTime.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.tbSendTime.Watermark = "";
            this.tbSendTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbSendTime_KeyPress);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(103, 95);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(43, 23);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 10;
            this.uiLabel5.Text = "周期";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSendQuickReply
            // 
            this.cbSendQuickReply.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.cbSendQuickReply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSendQuickReply.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSendQuickReply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbSendQuickReply.Location = new System.Drawing.Point(103, 65);
            this.cbSendQuickReply.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbSendQuickReply.Name = "cbSendQuickReply";
            this.cbSendQuickReply.Size = new System.Drawing.Size(90, 23);
            this.cbSendQuickReply.Style = Sunny.UI.UIStyle.Custom;
            this.cbSendQuickReply.TabIndex = 8;
            this.cbSendQuickReply.Text = "快速回复";
            // 
            // cbSendTimeSnd
            // 
            this.cbSendTimeSnd.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.cbSendTimeSnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSendTimeSnd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSendTimeSnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbSendTimeSnd.Location = new System.Drawing.Point(7, 95);
            this.cbSendTimeSnd.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbSendTimeSnd.Name = "cbSendTimeSnd";
            this.cbSendTimeSnd.Size = new System.Drawing.Size(90, 23);
            this.cbSendTimeSnd.Style = Sunny.UI.UIStyle.Custom;
            this.cbSendTimeSnd.TabIndex = 7;
            this.cbSendTimeSnd.Text = "定时发送";
            // 
            // cbSendTimestamp
            // 
            this.cbSendTimestamp.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.cbSendTimestamp.Checked = true;
            this.cbSendTimestamp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSendTimestamp.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSendTimestamp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbSendTimestamp.Location = new System.Drawing.Point(7, 65);
            this.cbSendTimestamp.MinimumSize = new System.Drawing.Size(1, 1);
            this.cbSendTimestamp.Name = "cbSendTimestamp";
            this.cbSendTimestamp.Size = new System.Drawing.Size(90, 23);
            this.cbSendTimestamp.Style = Sunny.UI.UIStyle.Custom;
            this.cbSendTimestamp.TabIndex = 6;
            this.cbSendTimestamp.Text = "时间戳";
            // 
            // rbSendHEX
            // 
            this.rbSendHEX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSendHEX.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbSendHEX.Location = new System.Drawing.Point(103, 35);
            this.rbSendHEX.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbSendHEX.Name = "rbSendHEX";
            this.rbSendHEX.RadioButtonColor = System.Drawing.Color.DimGray;
            this.rbSendHEX.Size = new System.Drawing.Size(90, 23);
            this.rbSendHEX.TabIndex = 5;
            this.rbSendHEX.Text = "HEX";
            // 
            // rbSendASCII
            // 
            this.rbSendASCII.Checked = true;
            this.rbSendASCII.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSendASCII.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbSendASCII.Location = new System.Drawing.Point(7, 35);
            this.rbSendASCII.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbSendASCII.Name = "rbSendASCII";
            this.rbSendASCII.RadioButtonColor = System.Drawing.Color.DimGray;
            this.rbSendASCII.Size = new System.Drawing.Size(90, 23);
            this.rbSendASCII.TabIndex = 4;
            this.rbSendASCII.Text = "ASCII";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(177, 95);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(23, 23);
            this.uiLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel6.TabIndex = 11;
            this.uiLabel6.Text = "ms";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcRecvTab
            // 
            this.tcRecvTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcRecvTab.Controls.Add(this.tpRecvPage);
            this.tcRecvTab.Controls.Add(this.tpMonitorPage);
            this.tcRecvTab.Controls.Add(this.tpDataDisplay);
            this.tcRecvTab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcRecvTab.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tcRecvTab.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tcRecvTab.ItemSize = new System.Drawing.Size(100, 30);
            this.tcRecvTab.Location = new System.Drawing.Point(206, 0);
            this.tcRecvTab.MainPage = "";
            this.tcRecvTab.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.tcRecvTab.Name = "tcRecvTab";
            this.tcRecvTab.SelectedIndex = 0;
            this.tcRecvTab.Size = new System.Drawing.Size(639, 348);
            this.tcRecvTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcRecvTab.Style = Sunny.UI.UIStyle.Custom;
            this.tcRecvTab.TabIndex = 4;
            this.tcRecvTab.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tcRecvTab.TabSelectedForeColor = System.Drawing.Color.White;
            this.tcRecvTab.TabSelectedHighColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tcRecvTab.TabUnSelectedForeColor = System.Drawing.Color.Gray;
            this.tcRecvTab.TipsFont = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // tpRecvPage
            // 
            this.tpRecvPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tpRecvPage.Controls.Add(this.rtbDataRecv);
            this.tpRecvPage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tpRecvPage.Location = new System.Drawing.Point(0, 30);
            this.tpRecvPage.Name = "tpRecvPage";
            this.tpRecvPage.Size = new System.Drawing.Size(639, 318);
            this.tpRecvPage.TabIndex = 0;
            this.tpRecvPage.Text = "数据接收";
            // 
            // rtbDataRecv
            // 
            this.rtbDataRecv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDataRecv.FillColor = System.Drawing.Color.White;
            this.rtbDataRecv.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.rtbDataRecv.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbDataRecv.Location = new System.Drawing.Point(0, 0);
            this.rtbDataRecv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbDataRecv.MinimumSize = new System.Drawing.Size(1, 1);
            this.rtbDataRecv.Name = "rtbDataRecv";
            this.rtbDataRecv.Padding = new System.Windows.Forms.Padding(2);
            this.rtbDataRecv.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.rtbDataRecv.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rtbDataRecv.ScrollBarStyleInherited = false;
            this.rtbDataRecv.ShowText = false;
            this.rtbDataRecv.Size = new System.Drawing.Size(639, 318);
            this.rtbDataRecv.Style = Sunny.UI.UIStyle.Custom;
            this.rtbDataRecv.TabIndex = 0;
            this.rtbDataRecv.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tpMonitorPage
            // 
            this.tpMonitorPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tpMonitorPage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tpMonitorPage.Location = new System.Drawing.Point(0, 40);
            this.tpMonitorPage.Name = "tpMonitorPage";
            this.tpMonitorPage.Size = new System.Drawing.Size(200, 60);
            this.tpMonitorPage.TabIndex = 1;
            this.tpMonitorPage.Text = "数据监控";
            // 
            // tpDataDisplay
            // 
            this.tpDataDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tpDataDisplay.Location = new System.Drawing.Point(0, 40);
            this.tpDataDisplay.Name = "tpDataDisplay";
            this.tpDataDisplay.Size = new System.Drawing.Size(200, 60);
            this.tpDataDisplay.TabIndex = 2;
            this.tpDataDisplay.Text = "数据显示";
            // 
            // tcSendTab
            // 
            this.tcSendTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcSendTab.Controls.Add(this.tpSingleSend);
            this.tcSendTab.Controls.Add(this.tpMultinomialSend);
            this.tcSendTab.Controls.Add(this.tpQueueSend);
            this.tcSendTab.Controls.Add(this.tpAutoSend);
            this.tcSendTab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcSendTab.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tcSendTab.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tcSendTab.ItemSize = new System.Drawing.Size(100, 30);
            this.tcSendTab.Location = new System.Drawing.Point(206, 355);
            this.tcSendTab.MainPage = "";
            this.tcSendTab.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.tcSendTab.Name = "tcSendTab";
            this.tcSendTab.SelectedIndex = 0;
            this.tcSendTab.Size = new System.Drawing.Size(639, 182);
            this.tcSendTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcSendTab.Style = Sunny.UI.UIStyle.Custom;
            this.tcSendTab.TabIndex = 5;
            this.tcSendTab.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tcSendTab.TabSelectedForeColor = System.Drawing.Color.White;
            this.tcSendTab.TabSelectedHighColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tcSendTab.TabUnSelectedForeColor = System.Drawing.Color.Gray;
            this.tcSendTab.TipsFont = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // tpSingleSend
            // 
            this.tpSingleSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tpSingleSend.Controls.Add(this.btnSend);
            this.tpSingleSend.Controls.Add(this.rtbSendBox);
            this.tpSingleSend.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tpSingleSend.Location = new System.Drawing.Point(0, 30);
            this.tpSingleSend.Name = "tpSingleSend";
            this.tpSingleSend.Size = new System.Drawing.Size(639, 152);
            this.tpSingleSend.TabIndex = 0;
            this.tpSingleSend.Text = "单项发送";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnSend.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnSend.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnSend.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnSend.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnSend.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.btnSend.Location = new System.Drawing.Point(496, 58);
            this.btnSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSend.Name = "btnSend";
            this.btnSend.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnSend.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnSend.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnSend.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnSend.Size = new System.Drawing.Size(100, 35);
            this.btnSend.Style = Sunny.UI.UIStyle.Custom;
            this.btnSend.Symbol = 361732;
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = " 发  送 ";
            this.btnSend.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // rtbSendBox
            // 
            this.rtbSendBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSendBox.FillColor = System.Drawing.Color.White;
            this.rtbSendBox.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.rtbSendBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbSendBox.Location = new System.Drawing.Point(0, 0);
            this.rtbSendBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbSendBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.rtbSendBox.Name = "rtbSendBox";
            this.rtbSendBox.Padding = new System.Windows.Forms.Padding(2);
            this.rtbSendBox.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.rtbSendBox.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.rtbSendBox.ScrollBarStyleInherited = false;
            this.rtbSendBox.ShowText = false;
            this.rtbSendBox.Size = new System.Drawing.Size(639, 152);
            this.rtbSendBox.Style = Sunny.UI.UIStyle.Custom;
            this.rtbSendBox.TabIndex = 0;
            this.rtbSendBox.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpMultinomialSend
            // 
            this.tpMultinomialSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tpMultinomialSend.Controls.Add(this.flpSendMutilSendPanl);
            this.tpMultinomialSend.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tpMultinomialSend.Location = new System.Drawing.Point(0, 40);
            this.tpMultinomialSend.Name = "tpMultinomialSend";
            this.tpMultinomialSend.Size = new System.Drawing.Size(200, 60);
            this.tpMultinomialSend.TabIndex = 1;
            this.tpMultinomialSend.Text = "多项发送";
            // 
            // flpSendMutilSendPanl
            // 
            this.flpSendMutilSendPanl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSendMutilSendPanl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.flpSendMutilSendPanl.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.flpSendMutilSendPanl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flpSendMutilSendPanl.Location = new System.Drawing.Point(0, 0);
            this.flpSendMutilSendPanl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpSendMutilSendPanl.MinimumSize = new System.Drawing.Size(1, 1);
            this.flpSendMutilSendPanl.Name = "flpSendMutilSendPanl";
            this.flpSendMutilSendPanl.Padding = new System.Windows.Forms.Padding(2);
            this.flpSendMutilSendPanl.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.flpSendMutilSendPanl.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.flpSendMutilSendPanl.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.flpSendMutilSendPanl.ScrollBarStyleInherited = false;
            this.flpSendMutilSendPanl.ShowText = false;
            this.flpSendMutilSendPanl.Size = new System.Drawing.Size(200, 60);
            this.flpSendMutilSendPanl.Style = Sunny.UI.UIStyle.Custom;
            this.flpSendMutilSendPanl.TabIndex = 0;
            this.flpSendMutilSendPanl.Text = "uiFlowLayoutPanel1";
            this.flpSendMutilSendPanl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpQueueSend
            // 
            this.tpQueueSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tpQueueSend.Location = new System.Drawing.Point(0, 40);
            this.tpQueueSend.Name = "tpQueueSend";
            this.tpQueueSend.Size = new System.Drawing.Size(200, 60);
            this.tpQueueSend.TabIndex = 2;
            this.tpQueueSend.Text = "队列发送";
            // 
            // tpAutoSend
            // 
            this.tpAutoSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.tpAutoSend.Location = new System.Drawing.Point(0, 40);
            this.tpAutoSend.Name = "tpAutoSend";
            this.tpAutoSend.Size = new System.Drawing.Size(200, 60);
            this.tpAutoSend.TabIndex = 3;
            this.tpAutoSend.Text = "自动发送";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel7,
            this.tsddbCilent,
            this.tsslConnectInfo,
            this.toolStripStatusLabel1,
            this.tsslSendCount,
            this.toolStripStatusLabel3,
            this.tsslRecvCount,
            this.tsslCountClear,
            this.toolStripStatusLabel6,
            this.tsmEncodeBtn});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(845, 23);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(44, 18);
            this.toolStripStatusLabel7.Text = "客户端";
            // 
            // tsddbCilent
            // 
            this.tsddbCilent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbCilent.Name = "tsddbCilent";
            this.tsddbCilent.Size = new System.Drawing.Size(53, 21);
            this.tsddbCilent.Text = "None";
            this.tsddbCilent.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TsddbCilent_DropDownItemClicked);
            // 
            // tsslConnectInfo
            // 
            this.tsslConnectInfo.Name = "tsslConnectInfo";
            this.tsslConnectInfo.Size = new System.Drawing.Size(151, 18);
            this.tsslConnectInfo.Spring = true;
            this.tsslConnectInfo.Text = "等待连接。。。。。。";
            this.tsslConnectInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 18);
            this.toolStripStatusLabel1.Text = "发送字节";
            // 
            // tsslSendCount
            // 
            this.tsslSendCount.Name = "tsslSendCount";
            this.tsslSendCount.Size = new System.Drawing.Size(151, 18);
            this.tsslSendCount.Spring = true;
            this.tsslSendCount.Text = "0";
            this.tsslSendCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(56, 18);
            this.toolStripStatusLabel3.Text = "接收字节";
            // 
            // tsslRecvCount
            // 
            this.tsslRecvCount.Name = "tsslRecvCount";
            this.tsslRecvCount.Size = new System.Drawing.Size(151, 18);
            this.tsslRecvCount.Spring = true;
            this.tsslRecvCount.Text = "0";
            this.tsslRecvCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslCountClear
            // 
            this.tsslCountClear.Name = "tsslCountClear";
            this.tsslCountClear.Size = new System.Drawing.Size(56, 18);
            this.tsslCountClear.Text = "计数清空";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(56, 18);
            this.toolStripStatusLabel6.Text = "编码格式";
            // 
            // tsmEncodeBtn
            // 
            this.tsmEncodeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmEncodeBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEncodeGBK,
            this.tsmEncodeASCII,
            this.tsmEncodeUTF8,
            this.tsmEncodeGB2312});
            this.tsmEncodeBtn.Image = ((System.Drawing.Image)(resources.GetObject("tsmEncodeBtn.Image")));
            this.tsmEncodeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmEncodeBtn.Name = "tsmEncodeBtn";
            this.tsmEncodeBtn.Size = new System.Drawing.Size(55, 21);
            this.tsmEncodeBtn.Text = "UTF-8";
            // 
            // tsmEncodeGBK
            // 
            this.tsmEncodeGBK.Name = "tsmEncodeGBK";
            this.tsmEncodeGBK.Size = new System.Drawing.Size(121, 22);
            this.tsmEncodeGBK.Text = "GBK";
            // 
            // tsmEncodeASCII
            // 
            this.tsmEncodeASCII.Name = "tsmEncodeASCII";
            this.tsmEncodeASCII.Size = new System.Drawing.Size(121, 22);
            this.tsmEncodeASCII.Text = "ASCII";
            // 
            // tsmEncodeUTF8
            // 
            this.tsmEncodeUTF8.Name = "tsmEncodeUTF8";
            this.tsmEncodeUTF8.Size = new System.Drawing.Size(121, 22);
            this.tsmEncodeUTF8.Text = "UTF-8";
            // 
            // tsmEncodeGB2312
            // 
            this.tsmEncodeGB2312.AutoSize = false;
            this.tsmEncodeGB2312.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmEncodeGB2312.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmEncodeGB2312.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmEncodeGB2312.Name = "tsmEncodeGB2312";
            this.tsmEncodeGB2312.Size = new System.Drawing.Size(100, 22);
            this.tsmEncodeGB2312.Text = "GB2312";
            // 
            // SocketPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(845, 562);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tcSendTab);
            this.Controls.Add(this.tcRecvTab);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.gbBaseSettings);
            this.Name = "SocketPage";
            this.PageIndex = 1001;
            this.Text = "SocketPage";
            this.Load += new System.EventHandler(this.SocketPage_Load);
            this.gbBaseSettings.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.tcRecvTab.ResumeLayout(false);
            this.tpRecvPage.ResumeLayout(false);
            this.tcSendTab.ResumeLayout(false);
            this.tpSingleSend.ResumeLayout(false);
            this.tpMultinomialSend.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIComboBox cbbCommunicationProtocols;
        private Sunny.UI.UIGroupBox gbBaseSettings;
        private Sunny.UI.UIComboBox cbbCommunicationAddress;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox tbCommunicationPort;
        private Sunny.UI.UISwitch shAutoConnnect;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIButton btnStart;
        private Sunny.UI.UIButton btnState;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIRadioButton rbRecvHEX;
        private Sunny.UI.UIRadioButton rbRecvASCII;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UICheckBox cbAutoSave;
        private Sunny.UI.UICheckBox cbRecvTimestamp;
        private Sunny.UI.UIButton btnSaveData;
        private Sunny.UI.UIButton btnRecvClear;
        private Sunny.UI.UICheckBox cbAutoNewline;
        private Sunny.UI.UICheckBox cbSendQuickReply;
        private Sunny.UI.UICheckBox cbSendTimeSnd;
        private Sunny.UI.UICheckBox cbSendTimestamp;
        private Sunny.UI.UIRadioButton rbSendHEX;
        private Sunny.UI.UIRadioButton rbSendASCII;
        private Sunny.UI.UITextBox tbSendTime;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UIComboBox cbbSendEndSymbol;
        private Sunny.UI.UITabControl tcRecvTab;
        private System.Windows.Forms.TabPage tpRecvPage;
        private System.Windows.Forms.TabPage tpMonitorPage;
        private Sunny.UI.UITabControl tcSendTab;
        private System.Windows.Forms.TabPage tpSingleSend;
        private System.Windows.Forms.TabPage tpMultinomialSend;
        private System.Windows.Forms.TabPage tpQueueSend;
        private System.Windows.Forms.TabPage tpAutoSend;
        private Sunny.UI.UIButton btnFileRead;
        private Sunny.UI.UIButton btnSendClearSend;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslSendCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tsslRecvCount;
        private System.Windows.Forms.ToolStripStatusLabel tsslCountClear;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripDropDownButton tsmEncodeBtn;
        private System.Windows.Forms.ToolStripMenuItem tsmEncodeGBK;
        private System.Windows.Forms.ToolStripMenuItem tsmEncodeASCII;
        private System.Windows.Forms.ToolStripMenuItem tsmEncodeUTF8;
        private System.Windows.Forms.ToolStripMenuItem tsmEncodeGB2312;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripDropDownButton tsddbCilent;
        private System.Windows.Forms.ToolStripStatusLabel tsslConnectInfo;
        private System.Windows.Forms.TabPage tpDataDisplay;
        private Sunny.UI.UIRichTextBox rtbDataRecv;
        private Sunny.UI.UIRichTextBox rtbSendBox;
        private Sunny.UI.UISymbolButton btnSend;
        private Sunny.UI.UIFlowLayoutPanel flpSendMutilSendPanl;
    }
}
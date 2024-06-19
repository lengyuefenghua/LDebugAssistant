namespace LDebugAssistant
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tcmPages = new Sunny.UI.UITabControlMenu();
            this.SocketDebug = new System.Windows.Forms.TabPage();
            this.SerialPortDebug = new System.Windows.Forms.TabPage();
            this.tcmPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcmPages
            // 
            this.tcmPages.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcmPages.Controls.Add(this.SocketDebug);
            this.tcmPages.Controls.Add(this.SerialPortDebug);
            this.tcmPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcmPages.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcmPages.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tcmPages.ItemSize = new System.Drawing.Size(150, 40);
            this.tcmPages.Location = new System.Drawing.Point(2, 36);
            this.tcmPages.Multiline = true;
            this.tcmPages.Name = "tcmPages";
            this.tcmPages.SelectedIndex = 0;
            this.tcmPages.Size = new System.Drawing.Size(996, 562);
            this.tcmPages.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcmPages.TabIndex = 0;
            this.tcmPages.Selected += new System.Windows.Forms.TabControlEventHandler(this.TcmPages_Selected);
            // 
            // SocketDebug
            // 
            this.SocketDebug.Location = new System.Drawing.Point(151, 0);
            this.SocketDebug.Name = "SocketDebug";
            this.SocketDebug.Size = new System.Drawing.Size(845, 562);
            this.SocketDebug.TabIndex = 0;
            this.SocketDebug.Text = "网络调试";
            this.SocketDebug.UseVisualStyleBackColor = true;
            // 
            // SerialPortDebug
            // 
            this.SerialPortDebug.Location = new System.Drawing.Point(151, 0);
            this.SerialPortDebug.Name = "SerialPortDebug";
            this.SerialPortDebug.Size = new System.Drawing.Size(645, 462);
            this.SerialPortDebug.TabIndex = 1;
            this.SerialPortDebug.Text = "串口调试";
            this.SerialPortDebug.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tcmPages);
            this.ExtendSymbol = 57474;
            this.ExtendSymbolOffset = new System.Drawing.Point(0, 4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2, 36, 2, 2);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.ShowDragStretch = true;
            this.Text = "LDebugAssistant";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.tcmPages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControlMenu tcmPages;
        private System.Windows.Forms.TabPage SocketDebug;
        private System.Windows.Forms.TabPage SerialPortDebug;
    }
}


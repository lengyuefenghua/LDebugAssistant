namespace LDebugAssistant.Forms
{
    partial class SerialPortPage
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
            this.uiScrollingText1 = new Sunny.UI.UIScrollingText();
            this.SuspendLayout();
            // 
            // uiScrollingText1
            // 
            this.uiScrollingText1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiScrollingText1.Location = new System.Drawing.Point(2, 2);
            this.uiScrollingText1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiScrollingText1.Name = "uiScrollingText1";
            this.uiScrollingText1.Size = new System.Drawing.Size(786, 35);
            this.uiScrollingText1.TabIndex = 0;
            this.uiScrollingText1.Text = "SrialPortPage";
            // 
            // SerialPortPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(845, 562);
            this.Controls.Add(this.uiScrollingText1);
            this.Name = "SerialPortPage";
            this.PageIndex = 1002;
            this.Text = "SerialPortPage";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIScrollingText uiScrollingText1;
    }
}
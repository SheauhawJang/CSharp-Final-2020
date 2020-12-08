namespace CSharp_Final
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
            this.BoardPanel = new System.Windows.Forms.Panel();
            this.OpenRecordDialog = new System.Windows.Forms.OpenFileDialog();
            this.InfoPanelI = new System.Windows.Forms.Panel();
            this.NamePanelI = new System.Windows.Forms.Panel();
            this.InfoPanelII = new System.Windows.Forms.Panel();
            this.NamePanelII = new System.Windows.Forms.Panel();
            this.ClockPanelI = new System.Windows.Forms.Panel();
            this.ClockPanelII = new System.Windows.Forms.Panel();
            this.ColorPictureII = new System.Windows.Forms.PictureBox();
            this.HeadPictureII = new System.Windows.Forms.PictureBox();
            this.ColorPictureI = new System.Windows.Forms.PictureBox();
            this.HeadPictureI = new System.Windows.Forms.PictureBox();
            this.InfoPanelI.SuspendLayout();
            this.InfoPanelII.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureII)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadPictureII)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadPictureI)).BeginInit();
            this.SuspendLayout();
            // 
            // BoardPanel
            // 
            this.BoardPanel.BackColor = System.Drawing.Color.BurlyWood;
            this.BoardPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BoardPanel.Location = new System.Drawing.Point(50, 50);
            this.BoardPanel.Name = "BoardPanel";
            this.BoardPanel.Size = new System.Drawing.Size(750, 750);
            this.BoardPanel.TabIndex = 0;
            this.BoardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BoradPanel_Paint);
            this.BoardPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BoardPanel_MouseUp);
            // 
            // OpenRecordDialog
            // 
            this.OpenRecordDialog.FileName = "openFileDialog1";
            // 
            // InfoPanelI
            // 
            this.InfoPanelI.Controls.Add(this.ColorPictureI);
            this.InfoPanelI.Controls.Add(this.ClockPanelI);
            this.InfoPanelI.Controls.Add(this.NamePanelI);
            this.InfoPanelI.Controls.Add(this.HeadPictureI);
            this.InfoPanelI.Location = new System.Drawing.Point(825, 50);
            this.InfoPanelI.Name = "InfoPanelI";
            this.InfoPanelI.Size = new System.Drawing.Size(200, 360);
            this.InfoPanelI.TabIndex = 1;
            // 
            // NamePanelI
            // 
            this.NamePanelI.Location = new System.Drawing.Point(0, 300);
            this.NamePanelI.Name = "NamePanelI";
            this.NamePanelI.Size = new System.Drawing.Size(200, 60);
            this.NamePanelI.TabIndex = 1;
            // 
            // InfoPanelII
            // 
            this.InfoPanelII.Controls.Add(this.ColorPictureII);
            this.InfoPanelII.Controls.Add(this.ClockPanelII);
            this.InfoPanelII.Controls.Add(this.NamePanelII);
            this.InfoPanelII.Controls.Add(this.HeadPictureII);
            this.InfoPanelII.Location = new System.Drawing.Point(825, 440);
            this.InfoPanelII.Name = "InfoPanelII";
            this.InfoPanelII.Size = new System.Drawing.Size(200, 360);
            this.InfoPanelII.TabIndex = 1;
            // 
            // NamePanelII
            // 
            this.NamePanelII.Location = new System.Drawing.Point(0, 300);
            this.NamePanelII.Name = "NamePanelII";
            this.NamePanelII.Size = new System.Drawing.Size(200, 60);
            this.NamePanelII.TabIndex = 1;
            // 
            // ClockPanelI
            // 
            this.ClockPanelI.Location = new System.Drawing.Point(60, 240);
            this.ClockPanelI.Name = "ClockPanelI";
            this.ClockPanelI.Size = new System.Drawing.Size(140, 60);
            this.ClockPanelI.TabIndex = 1;
            // 
            // ClockPanelII
            // 
            this.ClockPanelII.Location = new System.Drawing.Point(60, 240);
            this.ClockPanelII.Name = "ClockPanelII";
            this.ClockPanelII.Size = new System.Drawing.Size(140, 60);
            this.ClockPanelII.TabIndex = 1;
            // 
            // ColorPictureII
            // 
            this.ColorPictureII.BackgroundImage = global::CSharp_Final.Properties.Resources.BlackPool;
            this.ColorPictureII.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ColorPictureII.Location = new System.Drawing.Point(10, 250);
            this.ColorPictureII.Name = "ColorPictureII";
            this.ColorPictureII.Size = new System.Drawing.Size(40, 40);
            this.ColorPictureII.TabIndex = 2;
            this.ColorPictureII.TabStop = false;
            // 
            // HeadPictureII
            // 
            this.HeadPictureII.BackgroundImage = global::CSharp_Final.Properties.Resources.Head_II;
            this.HeadPictureII.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeadPictureII.Location = new System.Drawing.Point(0, 0);
            this.HeadPictureII.Name = "HeadPictureII";
            this.HeadPictureII.Size = new System.Drawing.Size(200, 240);
            this.HeadPictureII.TabIndex = 0;
            this.HeadPictureII.TabStop = false;
            // 
            // ColorPictureI
            // 
            this.ColorPictureI.BackgroundImage = global::CSharp_Final.Properties.Resources.WhitePool;
            this.ColorPictureI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ColorPictureI.Location = new System.Drawing.Point(10, 250);
            this.ColorPictureI.Name = "ColorPictureI";
            this.ColorPictureI.Size = new System.Drawing.Size(40, 40);
            this.ColorPictureI.TabIndex = 2;
            this.ColorPictureI.TabStop = false;
            // 
            // HeadPictureI
            // 
            this.HeadPictureI.BackgroundImage = global::CSharp_Final.Properties.Resources.Head_I;
            this.HeadPictureI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeadPictureI.Location = new System.Drawing.Point(0, 0);
            this.HeadPictureI.Name = "HeadPictureI";
            this.HeadPictureI.Size = new System.Drawing.Size(200, 240);
            this.HeadPictureI.TabIndex = 0;
            this.HeadPictureI.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 921);
            this.Controls.Add(this.InfoPanelII);
            this.Controls.Add(this.InfoPanelI);
            this.Controls.Add(this.BoardPanel);
            this.Name = "MainForm";
            this.Text = "五子棋对战程序";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.InfoPanelI.ResumeLayout(false);
            this.InfoPanelII.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureII)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadPictureII)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadPictureI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BoardPanel;
        private System.Windows.Forms.OpenFileDialog OpenRecordDialog;
        private System.Windows.Forms.Panel InfoPanelI;
        private System.Windows.Forms.PictureBox ColorPictureI;
        private System.Windows.Forms.Panel ClockPanelI;
        private System.Windows.Forms.Panel NamePanelI;
        private System.Windows.Forms.PictureBox HeadPictureI;
        private System.Windows.Forms.Panel InfoPanelII;
        private System.Windows.Forms.PictureBox ColorPictureII;
        private System.Windows.Forms.Panel ClockPanelII;
        private System.Windows.Forms.Panel NamePanelII;
        private System.Windows.Forms.PictureBox HeadPictureII;
    }
}


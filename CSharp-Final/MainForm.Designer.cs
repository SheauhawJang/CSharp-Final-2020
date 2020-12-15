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
            this.components = new System.ComponentModel.Container();
            this.OpenRecordDialog = new System.Windows.Forms.OpenFileDialog();
            this.InfoPanelI = new System.Windows.Forms.Panel();
            this.ClockPanelI = new System.Windows.Forms.Panel();
            this.NamePanelI = new System.Windows.Forms.Panel();
            this.InfoPanelII = new System.Windows.Forms.Panel();
            this.ClockPanelII = new System.Windows.Forms.Panel();
            this.NamePanelII = new System.Windows.Forms.Panel();
            this.TimerI = new System.Windows.Forms.Timer(this.components);
            this.TimerII = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BoardPanel = new System.Windows.Forms.Panel();
            this.UndoButton = new System.Windows.Forms.Button();
            this.PeaceButton = new System.Windows.Forms.Button();
            this.SurrenderButton = new System.Windows.Forms.Button();
            this.TipButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ColorPictureII = new System.Windows.Forms.PictureBox();
            this.HeadPictureII = new System.Windows.Forms.PictureBox();
            this.ColorPictureI = new System.Windows.Forms.PictureBox();
            this.HeadPictureI = new System.Windows.Forms.PictureBox();
            this.InfoPanelI.SuspendLayout();
            this.InfoPanelII.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureII)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadPictureII)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadPictureI)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenRecordDialog
            // 
            this.OpenRecordDialog.FileName = "openFileDialog1";
            // 
            // InfoPanelI
            // 
            this.InfoPanelI.BackColor = System.Drawing.Color.Transparent;
            this.InfoPanelI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InfoPanelI.Controls.Add(this.ColorPictureI);
            this.InfoPanelI.Controls.Add(this.ClockPanelI);
            this.InfoPanelI.Controls.Add(this.NamePanelI);
            this.InfoPanelI.Controls.Add(this.HeadPictureI);
            this.InfoPanelI.Location = new System.Drawing.Point(850, 50);
            this.InfoPanelI.Name = "InfoPanelI";
            this.InfoPanelI.Size = new System.Drawing.Size(200, 360);
            this.InfoPanelI.TabIndex = 1;
            this.InfoPanelI.Paint += new System.Windows.Forms.PaintEventHandler(this.InfoPanel_Paint);
            // 
            // ClockPanelI
            // 
            this.ClockPanelI.BackColor = System.Drawing.Color.Transparent;
            this.ClockPanelI.Location = new System.Drawing.Point(60, 240);
            this.ClockPanelI.Name = "ClockPanelI";
            this.ClockPanelI.Size = new System.Drawing.Size(140, 60);
            this.ClockPanelI.TabIndex = 1;
            this.ClockPanelI.Paint += new System.Windows.Forms.PaintEventHandler(this.ClockPanel_Paint);
            // 
            // NamePanelI
            // 
            this.NamePanelI.BackColor = System.Drawing.Color.Transparent;
            this.NamePanelI.Location = new System.Drawing.Point(0, 300);
            this.NamePanelI.Name = "NamePanelI";
            this.NamePanelI.Size = new System.Drawing.Size(200, 60);
            this.NamePanelI.TabIndex = 1;
            // 
            // InfoPanelII
            // 
            this.InfoPanelII.BackColor = System.Drawing.Color.Transparent;
            this.InfoPanelII.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InfoPanelII.Controls.Add(this.ColorPictureII);
            this.InfoPanelII.Controls.Add(this.ClockPanelII);
            this.InfoPanelII.Controls.Add(this.NamePanelII);
            this.InfoPanelII.Controls.Add(this.HeadPictureII);
            this.InfoPanelII.Location = new System.Drawing.Point(850, 440);
            this.InfoPanelII.Name = "InfoPanelII";
            this.InfoPanelII.Size = new System.Drawing.Size(200, 360);
            this.InfoPanelII.TabIndex = 1;
            this.InfoPanelII.Paint += new System.Windows.Forms.PaintEventHandler(this.InfoPanel_Paint);
            // 
            // ClockPanelII
            // 
            this.ClockPanelII.BackColor = System.Drawing.Color.Transparent;
            this.ClockPanelII.Location = new System.Drawing.Point(60, 240);
            this.ClockPanelII.Name = "ClockPanelII";
            this.ClockPanelII.Size = new System.Drawing.Size(140, 60);
            this.ClockPanelII.TabIndex = 1;
            this.ClockPanelII.Paint += new System.Windows.Forms.PaintEventHandler(this.ClockPanel_Paint);
            // 
            // NamePanelII
            // 
            this.NamePanelII.BackColor = System.Drawing.Color.Transparent;
            this.NamePanelII.Location = new System.Drawing.Point(0, 300);
            this.NamePanelII.Name = "NamePanelII";
            this.NamePanelII.Size = new System.Drawing.Size(200, 60);
            this.NamePanelII.TabIndex = 1;
            // 
            // TimerI
            // 
            this.TimerI.Interval = 1000;
            this.TimerI.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TimerII
            // 
            this.TimerII.Interval = 1000;
            this.TimerII.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Location = new System.Drawing.Point(1100, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 75);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.StartButton_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.StartButton_Paint);
            this.panel1.MouseEnter += new System.EventHandler(this.StartButton_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.StartButton_MouseLeave);
            // 
            // BoardPanel
            // 
            this.BoardPanel.BackColor = System.Drawing.Color.BurlyWood;
            this.BoardPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BoardPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BoardPanel.Location = new System.Drawing.Point(50, 50);
            this.BoardPanel.Name = "BoardPanel";
            this.BoardPanel.Size = new System.Drawing.Size(750, 750);
            this.BoardPanel.TabIndex = 0;
            this.BoardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BoardPanel_Paint);
            this.BoardPanel.Layout += new System.Windows.Forms.LayoutEventHandler(this.BoardPanel_Layout);
            this.BoardPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BoardPanel_MouseUp);
            // 
            // UndoButton
            // 
            this.UndoButton.Font = new System.Drawing.Font("仿宋", 16F);
            this.UndoButton.Location = new System.Drawing.Point(1100, 440);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(100, 40);
            this.UndoButton.TabIndex = 6;
            this.UndoButton.Text = "悔棋";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // PeaceButton
            // 
            this.PeaceButton.Font = new System.Drawing.Font("仿宋", 16F);
            this.PeaceButton.Location = new System.Drawing.Point(1250, 500);
            this.PeaceButton.Name = "PeaceButton";
            this.PeaceButton.Size = new System.Drawing.Size(100, 40);
            this.PeaceButton.TabIndex = 6;
            this.PeaceButton.Text = "求和";
            this.PeaceButton.UseVisualStyleBackColor = true;
            this.PeaceButton.Click += new System.EventHandler(this.PeaceButton_Click);
            // 
            // SurrenderButton
            // 
            this.SurrenderButton.Font = new System.Drawing.Font("仿宋", 16F);
            this.SurrenderButton.Location = new System.Drawing.Point(1100, 500);
            this.SurrenderButton.Name = "SurrenderButton";
            this.SurrenderButton.Size = new System.Drawing.Size(100, 40);
            this.SurrenderButton.TabIndex = 6;
            this.SurrenderButton.Text = "认输";
            this.SurrenderButton.UseVisualStyleBackColor = true;
            this.SurrenderButton.Click += new System.EventHandler(this.SurrenderButton_Click);
            // 
            // TipButton
            // 
            this.TipButton.Font = new System.Drawing.Font("仿宋", 16F);
            this.TipButton.Location = new System.Drawing.Point(1250, 440);
            this.TipButton.Name = "TipButton";
            this.TipButton.Size = new System.Drawing.Size(100, 40);
            this.TipButton.TabIndex = 6;
            this.TipButton.Text = "禁手";
            this.TipButton.UseVisualStyleBackColor = true;
            this.TipButton.Click += new System.EventHandler(this.TipButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1250, 300);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 120);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1100, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 120);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ColorPictureII
            // 
            this.ColorPictureII.BackColor = System.Drawing.Color.Transparent;
            this.ColorPictureII.BackgroundImage = global::CSharp_Final.Properties.Resources.WhitePool;
            this.ColorPictureII.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ColorPictureII.Location = new System.Drawing.Point(10, 250);
            this.ColorPictureII.Name = "ColorPictureII";
            this.ColorPictureII.Size = new System.Drawing.Size(40, 40);
            this.ColorPictureII.TabIndex = 2;
            this.ColorPictureII.TabStop = false;
            // 
            // HeadPictureII
            // 
            this.HeadPictureII.BackColor = System.Drawing.Color.Transparent;
            this.HeadPictureII.BackgroundImage = global::CSharp_Final.Properties.Resources.Head_II;
            this.HeadPictureII.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeadPictureII.Location = new System.Drawing.Point(-3, 0);
            this.HeadPictureII.Name = "HeadPictureII";
            this.HeadPictureII.Size = new System.Drawing.Size(200, 240);
            this.HeadPictureII.TabIndex = 0;
            this.HeadPictureII.TabStop = false;
            // 
            // ColorPictureI
            // 
            this.ColorPictureI.BackColor = System.Drawing.Color.Transparent;
            this.ColorPictureI.BackgroundImage = global::CSharp_Final.Properties.Resources.BlackPool;
            this.ColorPictureI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ColorPictureI.Location = new System.Drawing.Point(10, 250);
            this.ColorPictureI.Name = "ColorPictureI";
            this.ColorPictureI.Size = new System.Drawing.Size(40, 40);
            this.ColorPictureI.TabIndex = 2;
            this.ColorPictureI.TabStop = false;
            // 
            // HeadPictureI
            // 
            this.HeadPictureI.BackColor = System.Drawing.Color.Transparent;
            this.HeadPictureI.BackgroundImage = global::CSharp_Final.Properties.Resources.Head_I;
            this.HeadPictureI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeadPictureI.Location = new System.Drawing.Point(-3, 0);
            this.HeadPictureI.Name = "HeadPictureI";
            this.HeadPictureI.Size = new System.Drawing.Size(200, 240);
            this.HeadPictureI.TabIndex = 0;
            this.HeadPictureI.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 841);
            this.Controls.Add(this.TipButton);
            this.Controls.Add(this.SurrenderButton);
            this.Controls.Add(this.PeaceButton);
            this.Controls.Add(this.UndoButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InfoPanelII);
            this.Controls.Add(this.InfoPanelI);
            this.Controls.Add(this.BoardPanel);
            this.Name = "MainForm";
            this.Text = "连珠五子棋对战程序";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.InfoPanelI.ResumeLayout(false);
            this.InfoPanelII.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureII)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadPictureII)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadPictureI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Timer TimerI;
        private System.Windows.Forms.Timer TimerII;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel BoardPanel;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button PeaceButton;
        private System.Windows.Forms.Button SurrenderButton;
        private System.Windows.Forms.Button TipButton;
    }
}


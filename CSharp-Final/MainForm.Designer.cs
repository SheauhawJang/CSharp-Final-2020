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
            this.ColorPictureI = new System.Windows.Forms.PictureBox();
            this.ClockPanelI = new System.Windows.Forms.Panel();
            this.NamePanelI = new System.Windows.Forms.Panel();
            this.HeadPictureI = new System.Windows.Forms.PictureBox();
            this.InfoPanelII = new System.Windows.Forms.Panel();
            this.ColorPictureII = new System.Windows.Forms.PictureBox();
            this.ClockPanelII = new System.Windows.Forms.Panel();
            this.NamePanelII = new System.Windows.Forms.Panel();
            this.HeadPictureII = new System.Windows.Forms.PictureBox();
            this.TimerI = new System.Windows.Forms.Timer(this.components);
            this.TimerII = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Panel();
            this.BoardPanel = new System.Windows.Forms.Panel();
            this.UndoButton = new System.Windows.Forms.Button();
            this.PeaceButton = new System.Windows.Forms.Button();
            this.SurrenderButton = new System.Windows.Forms.Button();
            this.TipButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RecordButton = new System.Windows.Forms.Panel();
            this.ConfigButton = new System.Windows.Forms.Panel();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.全局ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始对局ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读取棋谱ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.对局配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.对局PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.悔棋ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.请求和棋ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.认输ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.禁手点提示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplayTimer = new System.Windows.Forms.Timer(this.components);
            this.InfoPanelI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadPictureI)).BeginInit();
            this.InfoPanelII.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureII)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadPictureII)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenRecordDialog
            // 
            this.OpenRecordDialog.FileName = "openFileDialog1";
            this.OpenRecordDialog.Filter = "棋谱文件|*.record|所有文件|*.*";
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
            this.NamePanelI.Paint += new System.Windows.Forms.PaintEventHandler(this.NamePanel_Paint);
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
            this.NamePanelII.Paint += new System.Windows.Forms.PaintEventHandler(this.NamePanel_Paint);
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
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.StartButton.Location = new System.Drawing.Point(1100, 200);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(250, 75);
            this.StartButton.TabIndex = 4;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            this.StartButton.Paint += new System.Windows.Forms.PaintEventHandler(this.StartButton_Paint);
            this.StartButton.MouseEnter += new System.EventHandler(this.StartButton_MouseEnter);
            this.StartButton.MouseLeave += new System.EventHandler(this.StartButton_MouseLeave);
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
            this.UndoButton.Enabled = false;
            this.UndoButton.Font = new System.Drawing.Font("仿宋", 16F);
            this.UndoButton.Location = new System.Drawing.Point(1100, 640);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(100, 40);
            this.UndoButton.TabIndex = 6;
            this.UndoButton.Text = "悔棋";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // PeaceButton
            // 
            this.PeaceButton.Enabled = false;
            this.PeaceButton.Font = new System.Drawing.Font("仿宋", 16F);
            this.PeaceButton.Location = new System.Drawing.Point(1250, 700);
            this.PeaceButton.Name = "PeaceButton";
            this.PeaceButton.Size = new System.Drawing.Size(100, 40);
            this.PeaceButton.TabIndex = 6;
            this.PeaceButton.Text = "求和";
            this.PeaceButton.UseVisualStyleBackColor = true;
            this.PeaceButton.Click += new System.EventHandler(this.PeaceButton_Click);
            // 
            // SurrenderButton
            // 
            this.SurrenderButton.Enabled = false;
            this.SurrenderButton.Font = new System.Drawing.Font("仿宋", 16F);
            this.SurrenderButton.Location = new System.Drawing.Point(1100, 700);
            this.SurrenderButton.Name = "SurrenderButton";
            this.SurrenderButton.Size = new System.Drawing.Size(100, 40);
            this.SurrenderButton.TabIndex = 6;
            this.SurrenderButton.Text = "认输";
            this.SurrenderButton.UseVisualStyleBackColor = true;
            this.SurrenderButton.Click += new System.EventHandler(this.SurrenderButton_Click);
            // 
            // TipButton
            // 
            this.TipButton.Enabled = false;
            this.TipButton.Font = new System.Drawing.Font("仿宋", 16F);
            this.TipButton.Location = new System.Drawing.Point(1250, 640);
            this.TipButton.Name = "TipButton";
            this.TipButton.Size = new System.Drawing.Size(100, 40);
            this.TipButton.TabIndex = 6;
            this.TipButton.Text = "禁手点";
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
            // RecordButton
            // 
            this.RecordButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.RecordButton.Location = new System.Drawing.Point(1100, 440);
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.Size = new System.Drawing.Size(250, 75);
            this.RecordButton.TabIndex = 4;
            this.RecordButton.Click += new System.EventHandler(this.RecordButton_Click);
            this.RecordButton.Paint += new System.Windows.Forms.PaintEventHandler(this.StartButton_Paint);
            this.RecordButton.MouseEnter += new System.EventHandler(this.StartButton_MouseEnter);
            this.RecordButton.MouseLeave += new System.EventHandler(this.StartButton_MouseLeave);
            // 
            // ConfigButton
            // 
            this.ConfigButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ConfigButton.Location = new System.Drawing.Point(1100, 540);
            this.ConfigButton.Name = "ConfigButton";
            this.ConfigButton.Size = new System.Drawing.Size(250, 75);
            this.ConfigButton.TabIndex = 4;
            this.ConfigButton.Click += new System.EventHandler(this.ConfigButton_Click);
            this.ConfigButton.Paint += new System.Windows.Forms.PaintEventHandler(this.StartButton_Paint);
            this.ConfigButton.MouseEnter += new System.EventHandler(this.StartButton_MouseEnter);
            this.ConfigButton.MouseLeave += new System.EventHandler(this.StartButton_MouseLeave);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全局ToolStripMenuItem,
            this.对局PToolStripMenuItem,
            this.关于AToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1424, 25);
            this.MenuStrip.TabIndex = 7;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // 全局ToolStripMenuItem
            // 
            this.全局ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始对局ToolStripMenuItem,
            this.读取棋谱ToolStripMenuItem,
            this.对局配置ToolStripMenuItem});
            this.全局ToolStripMenuItem.Name = "全局ToolStripMenuItem";
            this.全局ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.全局ToolStripMenuItem.Text = "全局(&G)";
            // 
            // 开始对局ToolStripMenuItem
            // 
            this.开始对局ToolStripMenuItem.Name = "开始对局ToolStripMenuItem";
            this.开始对局ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.开始对局ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.开始对局ToolStripMenuItem.Text = "开始对局";
            this.开始对局ToolStripMenuItem.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // 读取棋谱ToolStripMenuItem
            // 
            this.读取棋谱ToolStripMenuItem.Name = "读取棋谱ToolStripMenuItem";
            this.读取棋谱ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.读取棋谱ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.读取棋谱ToolStripMenuItem.Text = "读取棋谱";
            // 
            // 对局配置ToolStripMenuItem
            // 
            this.对局配置ToolStripMenuItem.Name = "对局配置ToolStripMenuItem";
            this.对局配置ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.对局配置ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.对局配置ToolStripMenuItem.Text = "对局配置";
            this.对局配置ToolStripMenuItem.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // 对局PToolStripMenuItem
            // 
            this.对局PToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.悔棋ToolStripMenuItem,
            this.请求和棋ToolStripMenuItem,
            this.认输ToolStripMenuItem,
            this.禁手点提示ToolStripMenuItem});
            this.对局PToolStripMenuItem.Name = "对局PToolStripMenuItem";
            this.对局PToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.对局PToolStripMenuItem.Text = "对局(&P)";
            // 
            // 悔棋ToolStripMenuItem
            // 
            this.悔棋ToolStripMenuItem.Enabled = false;
            this.悔棋ToolStripMenuItem.Name = "悔棋ToolStripMenuItem";
            this.悔棋ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.悔棋ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.悔棋ToolStripMenuItem.Text = "悔棋";
            this.悔棋ToolStripMenuItem.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // 请求和棋ToolStripMenuItem
            // 
            this.请求和棋ToolStripMenuItem.Enabled = false;
            this.请求和棋ToolStripMenuItem.Name = "请求和棋ToolStripMenuItem";
            this.请求和棋ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.请求和棋ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.请求和棋ToolStripMenuItem.Text = "请求和棋";
            this.请求和棋ToolStripMenuItem.Click += new System.EventHandler(this.PeaceButton_Click);
            // 
            // 认输ToolStripMenuItem
            // 
            this.认输ToolStripMenuItem.Enabled = false;
            this.认输ToolStripMenuItem.Name = "认输ToolStripMenuItem";
            this.认输ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.认输ToolStripMenuItem.Text = "认输";
            this.认输ToolStripMenuItem.Click += new System.EventHandler(this.SurrenderButton_Click);
            // 
            // 禁手点提示ToolStripMenuItem
            // 
            this.禁手点提示ToolStripMenuItem.Enabled = false;
            this.禁手点提示ToolStripMenuItem.Name = "禁手点提示ToolStripMenuItem";
            this.禁手点提示ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.禁手点提示ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.禁手点提示ToolStripMenuItem.Text = "禁手点提示";
            this.禁手点提示ToolStripMenuItem.Click += new System.EventHandler(this.TipButton_Click);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.关于AToolStripMenuItem.Text = "关于(&A)";
            // 
            // ReplayTimer
            // 
            this.ReplayTimer.Interval = 1000;
            this.ReplayTimer.Tick += new System.EventHandler(this.ReplayTimer_Tick);
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
            this.Controls.Add(this.ConfigButton);
            this.Controls.Add(this.RecordButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.InfoPanelII);
            this.Controls.Add(this.InfoPanelI);
            this.Controls.Add(this.BoardPanel);
            this.Controls.Add(this.MenuStrip);
            this.Name = "MainForm";
            this.Text = "连珠五子棋对战程序";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.InfoPanelI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadPictureI)).EndInit();
            this.InfoPanelII.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureII)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadPictureII)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel StartButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel BoardPanel;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button PeaceButton;
        private System.Windows.Forms.Button SurrenderButton;
        private System.Windows.Forms.Button TipButton;
        private System.Windows.Forms.Panel RecordButton;
        private System.Windows.Forms.Panel ConfigButton;
        public System.Windows.Forms.MenuStrip MenuStrip;
        public System.Windows.Forms.ToolStripMenuItem 全局ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 开始对局ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 读取棋谱ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 对局配置ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 对局PToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 悔棋ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 请求和棋ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 认输ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 禁手点提示ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.Timer ReplayTimer;
    }
}


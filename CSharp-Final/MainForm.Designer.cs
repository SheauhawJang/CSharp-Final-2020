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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.RecordButton = new System.Windows.Forms.Panel();
            this.ConfigButton = new System.Windows.Forms.Panel();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.全局ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始对局ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读取棋谱ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.对局配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.对局ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.悔棋ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.请求和棋ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.认输ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.禁手点提示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.暂停继续播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中止播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplayTimer = new System.Windows.Forms.Timer(this.components);
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.ComputerPictureII = new System.Windows.Forms.PictureBox();
            this.ComputerPictureI = new System.Windows.Forms.PictureBox();
            this.AITimer = new System.Windows.Forms.Timer(this.components);
            this.InfoPanelI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadPictureI)).BeginInit();
            this.InfoPanelII.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPictureII)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadPictureII)).BeginInit();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPictureII)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPictureI)).BeginInit();
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
            this.HeadPictureI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
            this.HeadPictureII.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
            this.StartButton.Location = new System.Drawing.Point(1100, 250);
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
            this.BoardPanel.DoubleClick += new System.EventHandler(this.BoardPanel_DoubleClick);
            this.BoardPanel.Layout += new System.Windows.Forms.LayoutEventHandler(this.BoardPanel_Layout);
            this.BoardPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BoardPanel_MouseUp);
            // 
            // UndoButton
            // 
            this.UndoButton.Enabled = false;
            this.UndoButton.Font = new System.Drawing.Font("仿宋", 16F);
            this.UndoButton.Location = new System.Drawing.Point(1100, 690);
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
            this.PeaceButton.Location = new System.Drawing.Point(1250, 750);
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
            this.SurrenderButton.Location = new System.Drawing.Point(1100, 750);
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
            this.TipButton.Location = new System.Drawing.Point(1250, 690);
            this.TipButton.Name = "TipButton";
            this.TipButton.Size = new System.Drawing.Size(100, 40);
            this.TipButton.TabIndex = 6;
            this.TipButton.Text = "禁手点";
            this.TipButton.UseVisualStyleBackColor = true;
            this.TipButton.Click += new System.EventHandler(this.TipButton_Click);
            // 
            // RecordButton
            // 
            this.RecordButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.RecordButton.Location = new System.Drawing.Point(1100, 490);
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
            this.ConfigButton.Location = new System.Drawing.Point(1100, 590);
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
            this.对局ToolStripMenuItem,
            this.关于ToolStripMenuItem});
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
            this.读取棋谱ToolStripMenuItem.Click += new System.EventHandler(this.RecordButton_Click);
            // 
            // 对局配置ToolStripMenuItem
            // 
            this.对局配置ToolStripMenuItem.Name = "对局配置ToolStripMenuItem";
            this.对局配置ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.对局配置ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.对局配置ToolStripMenuItem.Text = "对局配置";
            this.对局配置ToolStripMenuItem.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // 对局ToolStripMenuItem
            // 
            this.对局ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.悔棋ToolStripMenuItem,
            this.请求和棋ToolStripMenuItem,
            this.认输ToolStripMenuItem,
            this.禁手点提示ToolStripMenuItem,
            this.toolStripSeparator1,
            this.暂停继续播放ToolStripMenuItem,
            this.中止播放ToolStripMenuItem});
            this.对局ToolStripMenuItem.Name = "对局ToolStripMenuItem";
            this.对局ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.对局ToolStripMenuItem.Text = "对局(&P)";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // 暂停继续播放ToolStripMenuItem
            // 
            this.暂停继续播放ToolStripMenuItem.Enabled = false;
            this.暂停继续播放ToolStripMenuItem.Name = "暂停继续播放ToolStripMenuItem";
            this.暂停继续播放ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.暂停继续播放ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.暂停继续播放ToolStripMenuItem.Text = "暂停/继续播放";
            this.暂停继续播放ToolStripMenuItem.Click += new System.EventHandler(this.BoardPanel_DoubleClick);
            // 
            // 中止播放ToolStripMenuItem
            // 
            this.中止播放ToolStripMenuItem.Enabled = false;
            this.中止播放ToolStripMenuItem.Name = "中止播放ToolStripMenuItem";
            this.中止播放ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.中止播放ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.中止播放ToolStripMenuItem.Text = "中止播放";
            this.中止播放ToolStripMenuItem.Click += new System.EventHandler(this.中止播放ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.关于ToolStripMenuItem.Text = "关于(&A)";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // ReplayTimer
            // 
            this.ReplayTimer.Interval = 1000;
            this.ReplayTimer.Tick += new System.EventHandler(this.ReplayTimer_Tick);
            // 
            // LogoPicture
            // 
            this.LogoPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPicture.Location = new System.Drawing.Point(1100, 60);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(250, 150);
            this.LogoPicture.TabIndex = 8;
            this.LogoPicture.TabStop = false;
            // 
            // ComputerPictureII
            // 
            this.ComputerPictureII.BackgroundImage = global::CSharp_Final.Properties.Resources.Head_II;
            this.ComputerPictureII.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ComputerPictureII.Image = global::CSharp_Final.Properties.Resources.computer_unused;
            this.ComputerPictureII.Location = new System.Drawing.Point(1250, 350);
            this.ComputerPictureII.Name = "ComputerPictureII";
            this.ComputerPictureII.Size = new System.Drawing.Size(100, 120);
            this.ComputerPictureII.TabIndex = 5;
            this.ComputerPictureII.TabStop = false;
            this.ComputerPictureII.Click += new System.EventHandler(this.ComputerPicture_Click);
            // 
            // ComputerPictureI
            // 
            this.ComputerPictureI.BackgroundImage = global::CSharp_Final.Properties.Resources.Head_I;
            this.ComputerPictureI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ComputerPictureI.Image = global::CSharp_Final.Properties.Resources.computer_unused;
            this.ComputerPictureI.Location = new System.Drawing.Point(1100, 350);
            this.ComputerPictureI.Name = "ComputerPictureI";
            this.ComputerPictureI.Size = new System.Drawing.Size(100, 120);
            this.ComputerPictureI.TabIndex = 5;
            this.ComputerPictureI.TabStop = false;
            this.ComputerPictureI.Click += new System.EventHandler(this.ComputerPicture_Click);
            // 
            // AITimer
            // 
            this.AITimer.Tick += new System.EventHandler(this.AITimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 841);
            this.Controls.Add(this.LogoPicture);
            this.Controls.Add(this.TipButton);
            this.Controls.Add(this.SurrenderButton);
            this.Controls.Add(this.PeaceButton);
            this.Controls.Add(this.UndoButton);
            this.Controls.Add(this.ComputerPictureII);
            this.Controls.Add(this.ComputerPictureI);
            this.Controls.Add(this.ConfigButton);
            this.Controls.Add(this.RecordButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.InfoPanelII);
            this.Controls.Add(this.InfoPanelI);
            this.Controls.Add(this.BoardPanel);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPictureII)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPictureI)).EndInit();
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
        private System.Windows.Forms.PictureBox ComputerPictureI;
        private System.Windows.Forms.PictureBox ComputerPictureII;
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
        public System.Windows.Forms.ToolStripMenuItem 对局ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 悔棋ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 请求和棋ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 认输ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 禁手点提示ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Timer ReplayTimer;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Timer AITimer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripMenuItem 暂停继续播放ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 中止播放ToolStripMenuItem;
    }
}


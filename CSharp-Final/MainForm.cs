using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

using CSharp_Final.Manager;
using CSharp_Final.Properties;

namespace CSharp_Final
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
        }

        private void BoardPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen linePen = new Pen(Color.Black) { Width = NetConfig.LineWidth };
            SolidBrush markBrush = new SolidBrush(Color.Black);
            // Heng
            int xbegin = NetConfig.NetR, xend = NetConfig.NetEnd;
            int thisy = NetConfig.NetR;
            for (int i = 0; i < NetConfig.NetSize; ++i)
            {
                Point lp = new Point(xbegin, thisy);
                Point rp = new Point(xend, thisy);
                g.DrawLine(linePen, lp, rp);
                thisy += NetConfig.NetD;
            }
            // Zong
            int ybegin = NetConfig.NetR, yend = NetConfig.NetEnd;
            int thisx = NetConfig.NetR;
            for (int i = 0; i < NetConfig.NetSize; ++i)
            {
                Point lp = new Point(thisx, ybegin);
                Point rp = new Point(thisx, yend);
                g.DrawLine(linePen, lp, rp);
                thisx += NetConfig.NetD;
            }
            // Marks
            foreach (Location mark in NetConfig.MarkLocation)
            {
                Size size = new Size(NetConfig.MarkD, NetConfig.MarkD);
                g.FillEllipse(markBrush, mark.GetRectangle(size));
            }
            // Points
            for (int i = 0; i < Piece.History.Count; ++i)
                Piece.DrawPiece((Panel)sender, Piece.History[i], i);
            // WinLine
            Piece.DrawWinLine((Panel)sender);
            // Tips
            TipShow.Tips.Clear();
        }

        private void BoardPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (!PlayAccess.Ability) return;
            Location loc = Manager.Location.GetFromPoint(e.Location);
            Piece.SetCheckPiece(loc, (Panel)sender);
        }

        private void BoardPanel_Layout(object sender, LayoutEventArgs e)
        {
            PlayAccess.Area = (Panel)sender;
            //PlayAccess.UpdateCursor(Piece.History.Count & 1);
        }

        private void ClockPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Graphics g = panel.CreateGraphics();
            Font font = new Font("Consolas", 18);
            StringFormat format = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Rectangle rect = new Rectangle(new Point(0, 0), panel.Size);
            int time = sender == ClockPanelI ? Clock.PlayerI : Clock.PlayerII;
            SolidBrush fontBrush = new SolidBrush(Color.Black);
            g.DrawString(Clock.ToStringFromTime(time), font, fontBrush, rect, format);
        }

        private void MainForm_Load_Control()
        {
            Localisation.Culture = new CultureInfo(Config.EnConfig.Lang);
            ReplayTimer.Interval = Config.EnConfig.Speed;
            Text = Localisation.ApplicationName;
            Font buttonfont = new Font(Localisation.SmallButtonFont,
                Convert.ToSingle(Localisation.SmallButtonFontSize));
            UndoButton.Font = SurrenderButton.Font = PeaceButton.Font
                = TipButton.Font = buttonfont;
            UndoButton.Text = Localisation.Undo;
            SurrenderButton.Text = Localisation.Surrender;
            PeaceButton.Text = Localisation.PeaceB;
            TipButton.Text = Localisation.Bantip;
            HeadPictureI.BackgroundImage = Avatar.GetBitmap
                (Config.PlayerI.Avatar, 0);
            HeadPictureII.BackgroundImage = Avatar.GetBitmap
                (Config.PlayerII.Avatar, 1);

            开始对局ToolStripMenuItem.Text = Localisation.StartGame;
            读取棋谱ToolStripMenuItem.Text = Localisation.RecordGame;
            对局配置ToolStripMenuItem.Text = Localisation.ConfigGame;
            悔棋ToolStripMenuItem.Text = Localisation.Undo;
            认输ToolStripMenuItem.Text = Localisation.Surrender;
            请求和棋ToolStripMenuItem.Text = Localisation.PeaceBF;
            禁手点提示ToolStripMenuItem.Text = Localisation.BantipF;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Config.GetConfig();
            MainForm_Load_Control();
            Clock.SetTimer(TimerI, TimerII);
            Clock.SetPanel(InfoPanelI, InfoPanelII);
            ButtonAccess.MainForm = this;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Clock.Tick(sender == TimerI ? 0 : 1);
            ClockPanelI.Invalidate();
            ClockPanelII.Invalidate();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Announcement.StartGame();
            ButtonAccess.SetStartButton(false);
            ButtonAccess.SetToolButton(true);
            Refresh();
        }

        private void InfoPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Graphics g = panel.Parent.CreateGraphics();
            Pen pen = new Pen(Color.Black) { Width = 4 };
            Point point = panel.Location;
            point.Offset(-3, -3);
            Size size = new Size(panel.Width + 6, panel.Height + 6);
            Rectangle rect = new Rectangle(point, size);
            g.DrawRectangle(pen, rect);
        }

        private void StartButton_MouseEnter(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            control.BackColor = Color.LightPink;
        }

        private void StartButton_MouseLeave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            control.BackColor = Color.PaleVioletRed;
        }

        private void StartButton_Paint(object sender, PaintEventArgs e)
        {
            Control control = (Control)sender;
            Graphics g = control.CreateGraphics();
            Font font = new Font(Localisation.ButtonFont, 32);
            Point location = new Point(0, Convert.ToInt32(Localisation.ButtonFontSize));
            Size size = control.Size;
            Rectangle rect = new Rectangle(location, size);
            SolidBrush brush = new SolidBrush(Color.Black);
            StringFormat format = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            string text = "";
            if (control == StartButton)
                text = Localisation.StartGame;
            if (control == RecordButton)
                text = Localisation.RecordGame;
            if (control == ConfigButton)
                text = Localisation.ConfigGame;
            g.DrawString(text, font, brush, rect, format);
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            UndoPiece.Undo(BoardPanel);
        }

        private void TipButton_Click(object sender, EventArgs e)
        {
            TipShow.Tip(BoardPanel);
        }
        private void PeaceButton_Click(object sender, EventArgs e)
        {
            PeacePiece.Peace();
        }
        private void SurrenderButton_Click(object sender, EventArgs e)
        {
            SurrenderPiece.Surrender(Piece.CurrectColorID ^ 1);
        }

        private void NamePanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Graphics g = panel.CreateGraphics();
            Font font = new Font("Consolas", 18);
            StringFormat format = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            Rectangle rect = new Rectangle(new Point(0, 0), panel.Size);
            Player time = sender == NamePanelI ? Config.PlayerI : Config.PlayerII;
            SolidBrush fontBrush = new SolidBrush(Color.Black);
            g.DrawString(time.Name, font, fontBrush, rect, format);
        }

        private void ConfigButton_Click(object sender, EventArgs e)
        {
            ConfigForm form = new ConfigForm();
            form.ShowDialog();
            MainForm_Load_Control();
            Refresh();
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            if (OpenRecordDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Replayer.ReplayStart(Record.InputRecord(OpenRecordDialog.FileName));
                    ReplayTimer.Start();
                    ButtonAccess.SetStartButton(false);
                    Refresh();
                }
                catch { }
            }
        }

        private void ReplayTimer_Tick(object sender, EventArgs e)
        {
            Replayer.ReplayNext(BoardPanel, (Timer)sender);
        }
    }
}

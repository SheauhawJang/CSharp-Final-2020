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

using GlobalManager;

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

        private void BoradPanel_Paint(object sender, PaintEventArgs e)
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
                Point markPoint = mark.CenterPoint;
                markPoint.Offset(-NetConfig.MarkR, -NetConfig.MarkR);
                Size size = new Size(NetConfig.MarkD, NetConfig.MarkD);
                Rectangle rect = new Rectangle(markPoint, size);
                g.FillEllipse(markBrush, rect);
            }
            // Points
            for (int i = 0; i < Piece.History.Count; ++i)
                Piece.DrawPiece((Panel)sender, Piece.History[i], i);
            // WinLine
            Piece.DrawWinLine((Panel)sender);
        }

        private void BoardPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Location loc = GlobalManager.Location.GetFromPoint(e.Location);
            Piece.SetCheckPiece(loc, (Panel)sender);
        }

        private void OpenRecordDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

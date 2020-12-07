using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using CSharp_Final;
using CSharp_Final.Properties;
using RecordManager;

namespace GlobalManager
{
    public static class NetConfig
    {
        public static int NetR => 25;
        public static int NetD => 2 * NetR;
        public static int NetSize => 15;
        public static int NetTotal => NetD * NetSize;
        public static int NetEnd => NetTotal - NetR;
        public static int LineWidth => 2;
        public static int WinLineWidth => 5;
        public static int PieceR => 20;
        public static int PieceD => 2 * PieceR;
        public static int MarkR => 5;
        public static int MarkD => 2 * MarkR;
        const int markDis = 3;
        public static Location[] MarkLocation { get; } = new Location[]
        {
            new Location(NetSize / 2, NetSize / 2),
            new Location(markDis, markDis),
            new Location(NetSize - 1 - markDis, markDis),
            new Location(markDis, NetSize - 1 - markDis),
            new Location(NetSize - 1 - markDis, NetSize - 1 - markDis)
        };
        public static bool InRange(int x) => x >= 0 && x < NetSize;
    }
    public struct Manhattan
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Manhattan(int x, int y) { X = x; Y = y; }
        public static Manhattan operator *(Manhattan a, int b)
        { return new Manhattan { X = a.X * b, Y = a.Y * b }; }
        public static Manhattan operator *(int a, Manhattan b) => b * a;
        public static Manhattan operator -(Manhattan a) => (-1) * a;
        public int Distance { get => X + Y; }
    }
    public struct Location
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public static int Range => NetConfig.NetSize;
        public bool InRange => NetConfig.InRange(X) && NetConfig.InRange(Y);
        public Location(int x, int y) { X = x; Y = y; }
        public void Offset(int x, int y) { X += x; Y += y; }
        public void Offset(Manhattan p) { Offset(p.X, p.Y); }
        public Location GetOffset(int x, int y)
        {
            Location ans = this;
            ans.Offset(x, y);
            return ans;
        }
        public string Name => string.Format("{0}{1}", 
            (char)(NetConfig.NetSize - X + 'A'), NetConfig.NetSize - Y);
        public Location GetOffset(Manhattan p) { return GetOffset(p.X, p.Y); }
        public static Location operator +(Location a, Manhattan b) => a.GetOffset(b);
        public static Location operator +(Manhattan b, Location a) => a.GetOffset(b);
        public static Manhattan operator -(Location a, Location b) => new Manhattan(a.X - b.X, a.Y - b.Y);
        public static int NullNumber => -65536;
        public static Location Null { get; } = new Location(NullNumber, NullNumber);
        public bool IsNull => X == Null.X && Y == Null.Y;

        public static Location GetFromPoint(Point e) => new Location(e.X / NetConfig.NetD, e.Y / NetConfig.NetD);
        public Point CenterPoint => new Point(X * NetConfig.NetD + NetConfig.NetR,
            Y * NetConfig.NetD + NetConfig.NetR);
    }
    public class PieceInfo
    {
        public int Id { get; set; }
        public static Color ColorFromInt(int x) => (x & 1) == 0 ? Color.Black : Color.White;
        public Color Color { get => ColorFromInt(Id); }
        public bool Empty => Id < 0;
        public static int NullNumber => -65536;
        public PieceInfo() { Id = NullNumber; }
        public PieceInfo(int x) { Id = x; }
    }
    public class ConnectInfo
    {
        public int[] Connect { get; set; } = new int[] { 0, 0, 0, 0 };
        public Location[] ConnectFather { get; set; }
            = new Location[4] { Location.Null, Location.Null, Location.Null, Location.Null };
        public Location[] ConnectMother
        {
            get
            {
                Location[] mothers = ConnectFather;
                for (int i = 0; i < 4; ++i)
                    if (!mothers[i].IsNull)
                        mothers[i].Offset(ConnectWay[i] * (Connect[i] - 1));
                return mothers;
            }
        }
        public static Manhattan[] ConnectWay { get; }
            = new Manhattan[] { new Manhattan(0, 1), new Manhattan(1, 1), 
                            new Manhattan(1, 0), new Manhattan(-1, 1) };
    }
    public class PieceInfoSet
    {
        public List<Location> History { get; set; } = new List<Location>();
        public PieceInfo[,] Pieces { get; set; } 
            = new PieceInfo[NetConfig.NetSize, NetConfig.NetSize];
        public ConnectInfo[,] Connects { get; set; } 
            = new ConnectInfo[NetConfig.NetSize, NetConfig.NetSize];
        public PieceInfo PieceAt(Location loc) => Pieces[loc.X, loc.Y];
        public ConnectInfo ConnectAt(Location loc) => Connects[loc.X, loc.Y];
        public bool AliveAt(Location loc) => loc.InRange && PieceAt(loc).Empty;
        public PieceInfoSet()
        {
            for (int i = 0; i < NetConfig.NetSize; ++i)
                for (int j = 0; j < NetConfig.NetSize; ++j)
                     Pieces[i, j] = new PieceInfo();
        }
        public void UpdateConnect()
        {
            for (int i = 0; i < NetConfig.NetSize; ++i)
                for (int j = 0; j < NetConfig.NetSize; ++j)
                    Connects[i, j] = new ConnectInfo();

            for (int i = 0; i < NetConfig.NetSize; ++i)
                for (int j = 0; j < NetConfig.NetSize; ++j)
                {
                    if (Pieces[i, j].Empty)
                        continue;
                    for (int w = 0; w < 4; ++w)
                        if (Connects[i, j].ConnectFather[w].IsNull)
                        {
                            Location org = new Location(i, j);
                            Location now = new Location(i, j);
                            Connects[i, j].Connect[w] = 1;
                            Connects[i, j].ConnectFather[w] = org;
                            while (true)
                            {
                                now.Offset(ConnectInfo.ConnectWay[w]);
                                if (!now.InRange)
                                    break;
                                if (PieceAt(now).Empty)
                                    break;
                                if (PieceAt(now).Color != Pieces[i, j].Color)
                                    break;
                                ++Connects[i, j].Connect[w];
                            }
                            now = org;
                            for (int n = 1; n < Connects[i, j].Connect[w]; ++n)
                            {
                                now.Offset(ConnectInfo.ConnectWay[w]);
                                ConnectAt(now).Connect[w] = Connects[i, j].Connect[w];
                                ConnectAt(now).ConnectFather[w] = org;
                            }
                        }
                }
        }
    }
    public static class Piece
    {
        public static Bitmap BlackPiece { get => Resources.BlackPiece; }
        public static Bitmap WhitePiece { get => Resources.WhitePiece; }
        public static PieceInfoSet InfoSet { get; private set; } = new PieceInfoSet();
        public static List<Location> History
        {
            get => InfoSet.History;
            set => InfoSet.History = value;
        }
        public static PieceInfo[,] Infos
        { 
            get => InfoSet.Pieces; 
            set => InfoSet.Pieces = value; 
        }
        public static Color CurrectColor { get => PieceInfo.ColorFromInt(History.Count); }
        public static PieceInfo GetInfo(Location loc) => Infos[loc.X, loc.Y];
        public static Location WinFather { get; private set; } = Location.Null;
        public static Location WinMother { get; private set; } = Location.Null;
        public static void DrawPiece(Control sender, Location loc, int i)
        {
            Control panel = sender;
            Graphics g = panel.CreateGraphics();
            Color color = (i & 1) == 0 ? Color.Black : Color.White;
            Color reColor = (i & 1) == 1 ? Color.Black : Color.White;
            Point centerPoint = loc.CenterPoint;
            Point piecePoint = centerPoint;
            piecePoint.Offset(-NetConfig.PieceR, -NetConfig.PieceR);
            Size size = new Size(NetConfig.PieceD, NetConfig.PieceD);
            Rectangle rect = new Rectangle(piecePoint, size);
            if (color == Color.Black)
                g.DrawImage(BlackPiece, piecePoint);
            else if (color == Color.White)
                g.DrawImage(WhitePiece, piecePoint);
            Font font = new Font("Arial", 24);
            StringFormat format = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            GraphicsPath path = new GraphicsPath();
            path.AddString(Convert.ToString(i + 1), font.FontFamily,
                (int)font.Style, font.Size, rect, format);
            SolidBrush fontBrush = new SolidBrush(reColor);
            g.FillPath(fontBrush, path);
        }
        public static void DrawWinLine(Control sender)
        {
            if (WinFather.IsNull)
                return;
            Pen win = new Pen(Color.Red)
            {
                Width = NetConfig.WinLineWidth
            };
            Graphics g = sender.CreateGraphics();
            g.DrawLine(win, WinFather.CenterPoint, WinMother.CenterPoint);
        }
        public static void SetCheckPiece(Location loc, Control sender, bool replay = false)
        {
            int checkAns = SetPiece(loc, sender);
            if (checkAns >= 10)
            {
                int way = checkAns - 10;
                WinFather = InfoSet.ConnectAt(loc).ConnectFather[way];
                WinMother = InfoSet.ConnectAt(loc).ConnectMother[way];
                DrawWinLine(sender);
                MessageBox.Show(string.Format("{0}赢了", (History.Count & 1) == 1 ? "黑方" : "白方"),
                    "游戏结束", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!replay)
                {
                    Record record = new Record(History);
                    record.OutputRecord();
                }
            }
        }
        static int SetPiece(Location loc, Control sender)
        {
            int checkAns = CheckPiece(loc, sender);
            string BanedInfo = "您犯规了！\n原因：", BanedTitle = "禁手警告";
            switch (checkAns)
            {
                case 1:
                    DrawPiece(sender, loc, History.Count);
                    InfoSet.PieceAt(loc).Id = History.Count;
                    History.Add(loc);
                    InfoSet.UpdateConnect();
                    for (int i = 0; i < 4; ++i)
                        if (InfoSet.ConnectAt(loc).Connect[i] >= 5)
                            return i + 10;
                    return 0;
                case -33:
                    BanedInfo += "三三禁手"; break;
                case -44:
                    BanedInfo += "四四禁手"; break;
                case -6:
                    BanedInfo += "长连禁手"; break;
                default:
                    return -1;
            }
            MessageBox.Show(BanedInfo, BanedTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return -2;
        }
        static int CheckPiece(Location loc, Control sender)
        {
            if (!loc.InRange) return 0;
            if (History.Contains(loc)) return 0;
            if (CurrectColor == Color.Black)
            {
                int ban = CheckPieceRule(loc);
                if (ban < 0)
                    return ban;
            }
            return 1;
        }
        static int CheckPieceRule(Location loc)
        {
            int ban = CheckPieceRuleUnsafe(loc);
            InfoSet.PieceAt(loc).Id = PieceInfo.NullNumber;
            InfoSet.UpdateConnect();
            return ban;
        }
        static int CheckPieceRuleUnsafe(Location loc)
        {
            InfoSet.PieceAt(loc).Id = History.Count;
            InfoSet.UpdateConnect();
            PieceInfo nowPiece = InfoSet.PieceAt(loc);
            ConnectInfo nowConnect = InfoSet.ConnectAt(loc);
            for (int i = 0; i < 4; ++i)
                if (nowConnect.Connect[i] == 5)
                    return 2;
            for (int i = 0; i < 4; ++i)
                if (nowConnect.Connect[i] >= 6)
                    return -6;
            int san = 0, yon = 0;
            for (int i = 0; i < 4; ++i)
            {
                Manhattan off = ConnectInfo.ConnectWay[i];
                Location[] parentP = new Location[2];
                parentP[0] = nowConnect.ConnectFather[i].GetOffset(-off);
                parentP[1] = nowConnect.ConnectFather[i].GetOffset(off * nowConnect.Connect[i]);
                int alive = 0;

                for (int k = 0; k < 2; ++k)
                    if (InfoSet.AliveAt(parentP[k]))
                    {
                        ++alive;
                        Manhattan nowoff = off * (k == 0 ? -1 : 1);
                        Location island = parentP[k].GetOffset(nowoff);
                        if (island.InRange && !InfoSet.PieceAt(island).Empty
                            && InfoSet.PieceAt(island).Color == nowPiece.Color)
                        {
                            int islandnum = InfoSet.ConnectAt(island).Connect[i];
                            if (islandnum + nowConnect.Connect[i] == 3)
                                if (InfoSet.AliveAt(parentP[k ^ 1])
                                    && InfoSet.AliveAt(island.GetOffset(nowoff * islandnum)))
                                    ++san;
                        }
                        if (island.InRange && !InfoSet.PieceAt(island).Empty
                            && InfoSet.PieceAt(island).Color == nowPiece.Color)
                            if (InfoSet.ConnectAt(island).Connect[i] + nowConnect.Connect[i] == 4)
                                ++yon;
                    }
                if (nowConnect.Connect[i] == 4 && alive >= 1) ++yon;
                if (nowConnect.Connect[i] == 3 && alive == 2) ++san;
            }
            if (yon >= 2)
                return -44;
            if (san >= 2)
                return -33;
            return 1;
        }
    }
}

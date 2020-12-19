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
using System.Collections;

using CSharp_Final.Properties;

namespace CSharp_Final.Manager
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
    public struct Location : IComparable
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
        public Point GetCorner(Size size)
        {
            Point piecePoint = CenterPoint;
            piecePoint.Offset(-size.Width / 2, -size.Height / 2);
            return piecePoint;
        }
        public Rectangle GetRectangle(Size size)
        {
            return new Rectangle(GetCorner(size), size);
        }
        public static Size PieceSize => new Size(NetConfig.PieceD, NetConfig.PieceD);
        public Point PieceCorner => GetCorner(PieceSize);
        public Rectangle PieceRectangle => GetRectangle(PieceSize);
        public Rectangle NetRectangle => GetRectangle(new Size(NetConfig.NetD, NetConfig.NetD));
        public int CompareTo(object obj)
        {
            Location b = (Location)obj;
            if (X.CompareTo(b.X) != 0)
                return X.CompareTo(b.X);
            if (Y.CompareTo(b.Y) != 0)
                return Y.CompareTo(b.Y);
            return 0;
        }
    }
    public class PieceInfo : ICloneable
    {
        public int Id { get; set; }
        public static Color ColorFromInt(int x) => 
            (x & 1) == 0 ? Color.Black : Color.White;

        public object Clone() => MemberwiseClone();
        public int ColorId => Id & 1;
        public Color Color => ColorFromInt(Id);
        public bool Empty => Id < 0;
        public static int NullNumber => -65536;
        public PieceInfo() { Id = NullNumber; }
        public PieceInfo(int x) { Id = x; }
    }
    public class ConnectInfo : ICloneable
    {
        public int[] Connect { get; set; } = new int[] { 0, 0, 0, 0 };
        public Location[] ConnectFather { get; set; }
            = new Location[4] { Location.Null, Location.Null, Location.Null, Location.Null };

        public object Clone()
        {
            return new ConnectInfo
            {
                Connect = (int[])Connect.Clone(),
                ConnectFather = (Location[])ConnectFather.Clone()
            };
        }
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
    public class PieceInfoSet : ICloneable
    {
        public List<Location> History { get; set; } = new List<Location>();
        public PieceInfo[,] Pieces { get; set; } 
            = new PieceInfo[NetConfig.NetSize, NetConfig.NetSize];
        public ConnectInfo[,] Connects { get; set; } 
            = new ConnectInfo[NetConfig.NetSize, NetConfig.NetSize];
        public object Clone()
        {
            PieceInfoSet nobj = new PieceInfoSet();
            for (int i = 0; i < Pieces.GetLength(0); ++i)
                for (int j = 0; j < Pieces.GetLength(1); ++j)
                    nobj.Pieces[i, j] = (PieceInfo)Pieces[i, j].Clone();
            for (int i = 0; i < Connects.GetLength(0); ++i)
                for (int j = 0; j < Connects.GetLength(1); ++j)
                    nobj.Connects[i, j] = (ConnectInfo)Connects[i, j].Clone();
            foreach (Location loc in History)
                nobj.History.Add(loc);
            return nobj;
        }
        public ref PieceInfo PieceAt(Location loc) => ref Pieces[loc.X, loc.Y];
        public ref ConnectInfo ConnectAt(Location loc) => ref Connects[loc.X, loc.Y];
        public bool AliveAt(Location loc) => loc.InRange && PieceAt(loc).Empty;
        public bool AliveAt(int x, int y) => AliveAt(new Location(x, y));
        public PieceInfoSet()
        {
            for (int i = 0; i < NetConfig.NetSize; ++i)
                for (int j = 0; j < NetConfig.NetSize; ++j)
                    Pieces[i, j] = new PieceInfo();
            for (int i = 0; i < NetConfig.NetSize; ++i)
                for (int j = 0; j < NetConfig.NetSize; ++j)
                    Connects[i, j] = new ConnectInfo();
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
    public static class Announcement
    {
        public static bool Playing { get; set; } = false;
        public static void Announce(WinningInfo info)
        {
            PlayAccess.Ability = false;
            PlayAccess.UpdateCursor();
            Clock.Stop();
            BackCalculate.NowThread = null;
            ButtonAccess.SetStartButton(true);
            ButtonAccess.SetReplayButton(false);
            ButtonAccess.SetToolButton(false);
            List<Location> his = Piece.History;
            string boxtext = string.Format("{0}{1}\n",
                info.Winner == 0 ? Localisation.PlayerBlack : Localisation.PlayerWhite,
                Localisation.WinNotice);
            if (info.Winner < 0)
                boxtext = string.Format("{0}\n", Localisation.PeaceNotice);
            if (info.Winner == -2)
                boxtext = "";
            switch (info.WinWay)
            {
                case "TIMEOUT":
                    boxtext += string.Format("{2}:{0}{1}\n",
                        info.Winner == 1 ? Localisation.PlayerBlack : Localisation.PlayerWhite,
                        Localisation.TimeoutNotice, Localisation.ReasonNotice);
                    break;
                case "SURRENDER":
                    boxtext += string.Format("{2}:{0}{1}\n",
                        info.Winner == 1 ? Localisation.PlayerBlack : Localisation.PlayerWhite,
                        Localisation.SurrenderNotice, Localisation.ReasonNotice);
                    break;
                case "REQUEST":
                    boxtext += string.Format("{1}:{0}\n",
                        Localisation.PeaceRequestNotice, Localisation.ReasonNotice);
                    break;
            }
            if (!PlayAccess.Replay)
            {
                Record record = new Record(his, info);
                record.OutputRecord();
                boxtext += string.Format("{1}{0}\n", record.FileName, Localisation.RecordSaveNotice);
            }
            else
            {
                PlayAccess.Replay = false; 
                boxtext += string.Format("{0}\n", Localisation.RecordEnd);

            }
            MessageBox.Show(boxtext, Localisation.GameOver, MessageBoxButtons.OK, MessageBoxIcon.Information);
            BGM.Play(0);
        }

        public static void StartGame()
        {
            Piece.Clear();
            PlayAccess.Ability = true;
            PlayAccess.UpdateCursor(0);
            Clock.Start();
            BGM.Play(1);
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
        public static int CurrectId => History.Count;
        public static int CurrectColorId => CurrectId & 1;
        public static Color CurrectColor => PieceInfo.ColorFromInt(History.Count);
        public static PieceInfo GetInfo(Location loc) => Infos[loc.X, loc.Y];
        public static Location WinFather { get; private set; } = Location.Null;
        public static Location WinMother { get; private set; } = Location.Null;
        public static void Clear()
        {
            InfoSet = new PieceInfoSet();
            WinFather = WinMother = Location.Null;
        }
        readonly static int[,] lineD = new int[4, 2] { { 1, 0 }, { -1, 0 }, { 0, 1 }, { 0, -1 } };
        public static void DrawPiece(Control sender, Location loc, int i, bool noti = false)
        {
            Control panel = sender;
            List<Location> tips = new List<Location>();
            foreach (Location tip in TipShow.Tips)
                tips.Add(tip);
            foreach (Location tip in tips)
                panel.Invalidate(tip.NetRectangle);
            Graphics g = panel.CreateGraphics();
            Color color = (i & 1) == 0 ? Color.Black : Color.White;
            Color reColor = (i & 1) == 1 ? Color.Black : Color.White;
            if (color == Color.Black)
                g.DrawImage(BlackPiece, loc.PieceCorner);
            else if (color == Color.White)
                g.DrawImage(WhitePiece, loc.PieceCorner);
            Rectangle rect = loc.PieceRectangle;
            Font font = new Font("Arial", i >= 99 ? 12 : 18);
            StringFormat format = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            SolidBrush fontBrush = new SolidBrush(noti ? Color.Red : reColor);
            g.DrawString(Convert.ToString(i + 1), font, fontBrush, rect, format);
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

        public static void RemovePiece(Control sender)
        {
            Location last = History.Last();
            Clock.Swap(CurrectColorId);
            InfoSet.PieceAt(last) = new PieceInfo();
            History.Remove(last);
            InfoSet.UpdateConnect();
            PlayAccess.UpdateCursor(CurrectColorId);
            sender.Invalidate(last.NetRectangle);
        }
        public static void SetCheckPiece(Location loc, Control sender, bool ai = false)
        {
            int checkAns = SetPiece(loc, sender);
            if (checkAns >= 1)
            {
                int way = checkAns >> 1;
                WinFather = InfoSet.ConnectAt(loc).ConnectFather[way];
                WinMother = InfoSet.ConnectAt(loc).ConnectMother[way];
                DrawWinLine(sender);
                SoundE.PlayWinnerPiece();
                if (!PlayAccess.Replay)
                {
                    WinningInfo info = new WinningInfo { Winner = CurrectColorId ^ 1 };
                    Announcement.Announce(info);
                }
            }
            else if (History.Count == NetConfig.NetSize * NetConfig.NetSize 
                && !PlayAccess.Replay)
            {
                WinningInfo info = new WinningInfo { Winner = -1 };
                Announcement.Announce(info);
            }
        }
        static int SetPiece(Location loc, Control sender)
        {
            int checkAns = CheckPiece(loc);
            string BanedInfo = Localisation.BanInfo, BanedTitle = Localisation.BanTitle;
            switch (checkAns)
            {
                case 1:
                    Location last = History.Count > 0 ? History.Last() : Location.Null;
                    DrawPiece(sender, loc, History.Count, true);
                    Clock.Swap(CurrectColorId);
                    InfoSet.PieceAt(loc).Id = History.Count;
                    History.Add(loc);
                    InfoSet.UpdateConnect(); 
                    PlayAccess.UpdateCursor(CurrectColorId);
                    SoundE.PlaySetPiece();
                    if (!last.IsNull)
                        DrawPiece(sender, last, History.Count - 2, false);
                    for (int i = 0; i < 4; ++i)
                        if (InfoSet.ConnectAt(loc).Connect[i] >= 5)
                            return (i << 1) | 1;
                    if (CheckExciting(loc) != null)
                        BGM.Play(2);
                    return 0;
                case -33:
                    BanedInfo += Localisation.BanT33; break;
                case -44:
                    BanedInfo += Localisation.BanT44; break;
                case -6:
                    BanedInfo += Localisation.BanTLong; break;
                default:
                    return -1;
            }
            MessageBox.Show(BanedInfo, BanedTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return -2;
        }
        public static int CheckPiece(Location loc, PieceInfoSet p = null)
        {
            if (!loc.InRange) return 0;
            if (History.Contains(loc)) return 0;
            if (CurrectColorId == 0)
            {
                int ban = CheckPieceRule(loc, p ?? Piece.InfoSet);
                if (ban < 0)
                    return ban;
            }
            return 1;
        }
        public static Location[] CheckExciting(Location loc, PieceInfoSet InfoSet = null)
        {
            if (InfoSet == null)
                InfoSet = Piece.InfoSet;
            PieceInfo nowPiece = InfoSet.PieceAt(loc);
            ConnectInfo nowConnect = InfoSet.ConnectAt(loc);
            for (int i = 0; i < 4; ++i)
                if (nowConnect.Connect[i] == 5)
                    return null;
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
                            --alive;
                            int sum = InfoSet.ConnectAt(island).Connect[i] + nowConnect.Connect[i];
                            if (sum >= 4 && (sum == 4 || nowPiece.ColorId == 1))
                                return new Location[1] { parentP[k] };
                        }
                    }
                if (nowConnect.Connect[i] == 4 && alive >= 1)
                {
                    if (!InfoSet.AliveAt(parentP[0]) || CheckPieceRule(parentP[0], InfoSet) < 0)
                        return new Location[1] { parentP[1] };
                    if (!InfoSet.AliveAt(parentP[1]) || CheckPieceRule(parentP[1], InfoSet) < 0)
                        return new Location[1] { parentP[0] };
                    return parentP;
                }
            }
            return null;
        }
        static int CheckPieceRule(Location loc, PieceInfoSet InfoSet)
        {
            int ban = CheckPieceRuleUnsafe(loc, InfoSet);
            InfoSet.PieceAt(loc).Id = PieceInfo.NullNumber;
            InfoSet.UpdateConnect();
            return ban;
        }
        static int CheckPieceRuleUnsafe(Location loc, PieceInfoSet InfoSet)
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
                        Manhattan renowoff = nowoff * -1;
                        Location island = parentP[k] + nowoff;
                        if (island.InRange && !InfoSet.PieceAt(island).Empty
                            && InfoSet.PieceAt(island).Color == nowPiece.Color)
                            if (InfoSet.ConnectAt(island).Connect[i] + nowConnect.Connect[i] == 4)
                                ++yon;
                        if (island.InRange && !InfoSet.PieceAt(island).Empty
                            && InfoSet.PieceAt(island).Color == nowPiece.Color)
                        {
                            --alive;
                            int islandnum = InfoSet.ConnectAt(island).Connect[i];
                            if (islandnum + nowConnect.Connect[i] == 3)
                            {
                                int sanalive = 0;
                                if (InfoSet.AliveAt(parentP[k ^ 1]))
                                {
                                    Location ren = parentP[k ^ 1] + renowoff;
                                    if (!(ren.InRange && !InfoSet.PieceAt(ren).Empty
                                        && InfoSet.PieceAt(ren).Color == nowPiece.Color))
                                        ++sanalive;
                                }
                                if (InfoSet.AliveAt(island.GetOffset(nowoff * islandnum)))
                                {
                                    Location ren = island + nowoff * islandnum + nowoff;
                                    if (!(ren.InRange && !InfoSet.PieceAt(ren).Empty
                                        && InfoSet.PieceAt(ren).Color == nowPiece.Color))
                                        ++sanalive;
                                }
                                if (sanalive == 2)
                                    ++san;
                            }
                        }
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
    public class WinningInfo
    {
        public int Winner { get; set; }
        public string WinWay { get; set; } = "";
    }
    public static class Clock
    {
        public static int PlayerI { get; set; }
        public static int PlayerII { get; set; }
        static Timer timerI, timerII, aiTimer;
        static Panel playerI, playerII;
        readonly static Color nowColor = Color.SpringGreen;
        public static void SetTimer(Timer a, Timer b)
        {
            if (timerI == null)
                timerI = a;
            if (timerII == null)
                timerII = b;
        }
        public static void SetAITimer(Timer c) => aiTimer = c;
        public static void SetPanel(Panel a, Panel b)
        {
            if (playerI == null)
                playerI = a;
            if (playerII == null)
                playerII = b;
        }

        public static string ToStringFromTime(int time)
        {
            int hour = time / 60 / 60;
            int mint = time / 60 % 60;
            int secd = time % 60;
            string ans = "";
            if (Config.EnConfig.Time >= 60 * 60)
                ans += string.Format("{0:00}:", hour);
            if (Config.EnConfig.Time >= 60)
                ans += string.Format("{0:00}:", mint);
            ans += string.Format("{0:00}", secd);
            return ans;
        }

        public static void Tick(int player)
        {
            int rmn = player == 0 ? --PlayerI : --PlayerII;
            if (rmn == 0)
            {
                WinningInfo info = new WinningInfo
                {
                    Winner = player ^ 1,
                    WinWay = "TIMEOUT"
                };
                Announcement.Announce(info);
            }
        }

        public static void Start()
        {
            PlayerI = PlayerII = Config.EnConfig.Time;
            if (!PlayAccess.Replay)
            {
                timerI.Start();
                aiTimer.Start();
                PlayAccess.Ability = Config.PlayerI.AI == 0;
                PlayAccess.UpdateCursor(0);
            }
            playerI.BackColor = nowColor;
        }

        public static void Stop()
        {
            timerI.Stop();
            timerII.Stop();
            aiTimer.Stop();
            playerI.BackColor = playerII.BackColor = Color.Transparent;
        }

        public static void Swap(int now)
        {
            if (now == 0)
            {
                if (!PlayAccess.Replay)
                {
                    timerI.Stop();
                    timerII.Start();
                }
                playerI.BackColor = Color.Transparent;
                playerII.BackColor = nowColor;
            }
            else
            {
                if (!PlayAccess.Replay)
                {
                    timerI.Start();
                    timerII.Stop();
                }
                playerI.BackColor = nowColor;
                playerII.BackColor = Color.Transparent;
            }
            if (!PlayAccess.Replay)
            {
                Player checker = now == 0 ? Config.PlayerII : Config.PlayerI;
                PlayAccess.Ability = checker.AI == 0;
                PlayAccess.UpdateCursor(now ^ 1);
            }
        }
    }
}

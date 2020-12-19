using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;

namespace CSharp_Final.Manager
{
    public class Envalue
    {
        private readonly int mycolor = 0;
        private readonly int cchoser = 0;

        public Envalue(int color = 0, int choser = 0, PieceInfoSet p = null)
        {
            mycolor = color;
            cchoser = choser;
            SetInfo(p);
        }
        public static long GetValue(int color = 0, int choser = 0, PieceInfoSet p = null) =>
            new Envalue(color, choser, p).Value;
        Location[,,] links;
        int[,] linksize;
        bool[,,] selfs;
        public int[,,] sets;
        public static int ed = 0;
        public long Value
        {
            get
            {
                if (sets == null)
                    FillSets();
                ++ed;
                long ans = 0;
                if (sets[3, 0, 1] > 0)
                    return 1L << 50;
                if (sets[3, 1, 1] > 0)
                    return -(1L << 50);
                if (cchoser != mycolor && sets[2, 0, 2] * 2 + sets[2, 0, 0] + sets[2, 0, 1] >= 2)
                    return 1L << 40;
                if (cchoser == mycolor && sets[2, 1, 2] * 2 + sets[2, 1, 0] + sets[2, 1, 1] >= 2)
                    return -(1L << 40);
                if (sets[2, 0, 2] * 2 + sets[2, 0, 0] + sets[2, 0, 1] >= 2)
                    return 1L << 40;
                if (sets[2, 1, 2] * 2 + sets[2, 1, 0] + sets[2, 1, 1] >= 2)
                    return -(1L << 40);
                for (int i = 0; i < 3; ++i)
                    for (int j = 0; j < 2; ++j)
                        for (int k = 0; k < 3; ++k)
                        {
                            long x = 1L << 12 * i + 4 * k;
                            if (j != cchoser)
                                x <<= 2;
                            if (j == 0)
                                ans += x * sets[i, j, k];
                            else
                                ans -= x * sets[i, j, k];
                        }
                return ans;
            }
        }

        public PieceInfoSet Info { get; set; } = new PieceInfoSet();
        public void SetInfo(PieceInfoSet infoSet = null)
        {
            if (infoSet == null)
                Info = Piece.InfoSet;
            else
                Info = infoSet;
        }
        void Add(bool alive, int color, int direct, Location now)
        {
            now = Info.ConnectAt(now).ConnectFather[direct];
            if (selfs[now.X, now.Y, direct])
                return;
            selfs[now.X, now.Y, direct] = true;
            ++sets[Math.Min(Info.ConnectAt(now).Connect[direct] - 2, 3), 
                color == mycolor ? 0 : 1, alive ? 2 : 0];
        }
        void Add(bool alive, int color, int direct, Location now, Location island)
        {
            now = Info.ConnectAt(now).ConnectFather[direct];
            island = Info.ConnectAt(island).ConnectFather[direct];
            for (int i = 0; i < 10; ++i)
                if (links[now.X, now.Y, i].Equals(island))
                    return;
            links[now.X, now.Y, ++linksize[now.X, now.Y]] = island;
            links[island.X, island.Y, ++linksize[island.X, island.Y]] = now;
            ++sets[Math.Min(Info.ConnectAt(now).Connect[direct] 
                + Info.ConnectAt(island).Connect[direct] - 2,3), color == mycolor ? 0 : 1, alive ? 1 : 0];
        }

        public void FillSets()
        {
            links = new Location[NetConfig.NetSize, NetConfig.NetSize, 10];
            selfs = new bool[NetConfig.NetSize, NetConfig.NetSize, 4];
            linksize = new int[NetConfig.NetSize, NetConfig.NetSize];
            sets = new int[4, 2, 3];
            for (int i = 0; i < NetConfig.NetSize; ++i)
                for (int j = 0; j < NetConfig.NetSize; ++j)
                    for (int k = 0; k < 10; ++k)
                        links[i, j, k] = Location.Null;
            for (int i = 0; i < NetConfig.NetSize; ++i)
                for (int j = 0; j < NetConfig.NetSize; ++j)
                {
                    Location now = new Location(i, j);
                    PieceInfo nowPiece = Info.Pieces[i, j];
                    ConnectInfo nowConnect = Info.Connects[i, j];
                    for (int w = 0; w < 4; ++w)
                    {
                        if (nowConnect.Connect[w] >= 5)
                        {
                            Add(true, nowPiece.ColorId, w, now);
                            continue;
                        }

                        Manhattan off = ConnectInfo.ConnectWay[w];
                        Location[] parentP = new Location[2];
                        parentP[0] = nowConnect.ConnectFather[w].GetOffset(-off);
                        parentP[1] = nowConnect.ConnectFather[w].GetOffset(off * nowConnect.Connect[w]);
                        int alive = 0;
                        for (int k = 0; k < 2; ++k)
                            if (Info.AliveAt(parentP[k]))
                            {
                                ++alive;
                                Manhattan nowoff = off * (k == 0 ? -1 : 1);
                                Location island = parentP[k].GetOffset(nowoff);
                                if (island.InRange && !Info.PieceAt(island).Empty
                                    && Info.PieceAt(island).Color == nowPiece.Color)
                                {
                                    --alive;
                                    int islandnum = Info.ConnectAt(island).Connect[w];
                                    int sum = islandnum + nowConnect.Connect[w];
                                    if (sum >= 4 && (sum == 4 || nowPiece.ColorId == 1))
                                    {
                                        ConnectInfo islandCon = Info.ConnectAt(island);
                                        List<Location> locations = new List<Location>();
                                        for (int index = 0; index < islandnum; ++index)
                                            locations.Add(islandCon.ConnectFather[w] +
                                                ConnectInfo.ConnectWay[w] * index);
                                        for (int index = 0; index < nowConnect.Connect[w]; ++index)
                                            locations.Add(nowConnect.ConnectFather[w] +
                                                ConnectInfo.ConnectWay[w] * index);
                                        Add(false, nowPiece.ColorId, w, now, island);
                                    }
                                }
                            }
                        if (nowConnect.Connect[w] == 4 && alive >= 1)
                            Add(alive == 2, nowPiece.ColorId, w, now);
                        alive = 0;
                        for (int k = 0; k < 2; ++k)
                            if (Info.AliveAt(parentP[k]))
                            {
                                ++alive;
                                Manhattan nowoff = off * (k == 0 ? -1 : 1);
                                Manhattan renowoff = nowoff * -1;
                                Location island = parentP[k] + nowoff;
                                if (island.InRange && !Info.PieceAt(island).Empty
                                    && Info.PieceAt(island).Color == nowPiece.Color)
                                {
                                    --alive;
                                    int islandnum = Info.ConnectAt(island).Connect[w];
                                    if (islandnum + nowConnect.Connect[w] <= 3)
                                    {
                                        int sanalive = 0;
                                        if (Info.AliveAt(parentP[k ^ 1]))
                                        {
                                            Location ren = parentP[k ^ 1] + renowoff;
                                            if (!(nowPiece.ColorId == 0 && 
                                                ren.InRange && !Info.PieceAt(ren).Empty
                                                && Info.PieceAt(ren).Color == nowPiece.Color))
                                                ++sanalive;
                                        }
                                        if (Info.AliveAt(island.GetOffset(nowoff * islandnum)))
                                        {
                                            Location ren = island + nowoff * islandnum + nowoff;
                                            if (!(nowPiece.ColorId == 0 && 
                                                ren.InRange && !Info.PieceAt(ren).Empty
                                                && Info.PieceAt(ren).Color == nowPiece.Color))
                                                ++sanalive;
                                        }
                                        if (sanalive >= 1)
                                            Add(sanalive == 2, nowPiece.ColorId, w, now, island);
                                    }
                                }
                            }
                        if (nowConnect.Connect[w] == 3 && alive >= 1)
                            Add(alive == 2, nowPiece.ColorId, w, now);
                        if (nowConnect.Connect[w] == 2 && alive >= 1)
                            Add(alive == 2, nowPiece.ColorId, w, now);
                    }
                }
        }
    }

    public static class SearchTree
    {
        public static Location NowThread { get; set; } = Location.Null;
        static PieceInfoSet p;
        readonly static Random tool = new Random();
        static bool CheckAliveLoc(Location center)
        {
            if (!p.AliveAt(center))
                return false;
            for (int i = -2; i <= +2; ++i)
            {
                if (i == 0) continue;
                for (int j = 0; j < 4; ++j)
                {
                    Location now = center + ConnectInfo.ConnectWay[j] * i;
                    if (now.InRange && !p.PieceAt(now).Empty)
                        return true;
                }
            }
            return false;
        }
        static bool CheckAliveLoc(int x, int y)
            => CheckAliveLoc(new Location(x, y));
        static Location[] GetAliveLoc(bool check = false)
        {
            List<Location> ans = new List<Location>();
            for (int i = 0; i < NetConfig.NetSize; ++i)
                for (int j = 0; j < NetConfig.NetSize; ++j)
                    if (CheckAliveLoc(i, j))
                        if (!check || Piece.CheckPiece(new Location(i, j), p) >= 0)
                            ans.Add(new Location(i, j));
            return ans.ToArray();
        }
        static void AddPiece(Location loc, int id)
        {
            p.PieceAt(loc).Id = id;
            p.UpdateConnect();
        }
        static void RemovePiece(Location loc)
        {
            p.PieceAt(loc).Id = PieceInfo.NullNumber;
        }
        public static RichTextBox Box;
        public static Location Choose
        {
            get
            {
                p = (PieceInfoSet)Piece.InfoSet.Clone();
                if (Piece.CurrectId == 0)
                {
                    int l, r;
                    l = r = NetConfig.NetSize / 2;
                    while (tool.Next(2) == 0)
                    {
                        --l;
                        ++r;
                        if (l == -1)
                            l = r = NetConfig.NetSize / 2;
                    }
                    if (r == l)
                        return new Location(l, l);
                    int side = tool.Next(4);
                    int def = tool.Next(r - l);
                    switch (side)
                    {
                        case 0:
                            return new Location(l, l + def);
                        case 1:
                            return new Location(r, l + def);
                        case 2:
                            return new Location(l + def, l);
                        default:
                            return new Location(l + def, r);
                    }
                }
                else
                {
                    int dep = 0;
                    if (Piece.CurrectColorId == 0 && Config.PlayerI.AI == 2)
                        dep = 1;
                    if (Piece.CurrectColorId == 1 && Config.PlayerII.AI == 2)
                        dep = 1;
                    Location[] locs = GetAliveLoc(Piece.CurrectColorId == 0);
                    foreach(Location loc in locs)
                    {
                        AddPiece(loc, Piece.CurrectColorId);
                        for (int w = 0; w < 4; ++w)
                            if (p.ConnectAt(loc).Connect[w] >= 5)
                            {
                                locs = new Location[] { loc };
                                break;
                            }
                        RemovePiece(loc);
                        if (locs.Length == 1)
                            return loc;
                    }    
                    for (int i = 0; i < NetConfig.NetSize && locs.Length > 2; ++i)
                        for (int j = 0; j < NetConfig.NetSize && locs.Length > 2; ++j)
                            if (!p.Pieces[i, j].Empty && p.Pieces[i, j].ColorId != Piece.CurrectColorId)
                                locs = Piece.CheckExciting(new Location(i, j), p) ?? locs;
                    Shuffle(ref locs);
                    long max = -(1L << 62);
                    Location best = Location.Null;
                    foreach (Location loc in locs)
                    {
                        AddPiece(loc, Piece.CurrectColorId);
                        long next = Search(1, 1L << 61, max, Piece.CurrectColorId, dep);
                        if (next > max)
                        {
                            max = next;
                            best = loc;
                        }
                        RemovePiece(loc);
                    }
                    if (-max > 1L << 45)
                        return Location.Null;
                    return best;
                }
            }
        }
        static void Swap<T>(ref T a, ref T b)
        {
            T tmp = b;
            b = a;
            a = tmp;
        }
        static Location[] Shuffle(ref Location[] locarr)
        {
            for (int i = 0; i < locarr.Length; ++i)
                Swap(ref locarr[i], ref locarr[tool.Next(i, locarr.Length)]);
            return locarr;
        }
        static long Search(int dep, long alpha, long beta, int mycolor, int maxdep = 0)
        {
            int choser = (mycolor + dep) & 1;
            Location[] locs = GetAliveLoc(choser == 0);
            foreach (Location loc in locs)
            {
                AddPiece(loc, choser);
                for (int w = 0; w < 4; ++w)
                    if (p.ConnectAt(loc).Connect[w] >= 5)
                    {
                        locs = new Location[] { loc };
                        break;
                    }
                RemovePiece(loc);
                if (locs.Length == 1)
                    break;
            }
            if (locs.Length > 1)
                for (int i = 0; i < NetConfig.NetSize && locs.Length > 2; ++i)
                    for (int j = 0; j < NetConfig.NetSize && locs.Length > 2; ++j)
                        if (!p.Pieces[i, j].Empty && p.Pieces[i, j].ColorId != choser)
                            locs = Piece.CheckExciting(new Location(i, j), p) ?? locs;
            Shuffle(ref locs);
            long minmax = (dep & 1) == 0 ? -(1L << 60) : +(1L << 60);
            foreach (Location loc in locs)
            {
                AddPiece(loc, choser);
                bool win = false;
                for (int i = 0; i < 4; ++i)
                    if (p.ConnectAt(loc).Connect[i] >= 5)
                        win = true;
                long ncho;
                if (win)
                    ncho = (dep & 1) == 0 ? (1L << 60) : -(1L << 60);
                else
                    ncho = dep <= maxdep ?
                        Search(dep + 1, alpha, beta, mycolor, maxdep) : 
                        new Envalue(mycolor, mycolor, p).Value;
                if ((dep & 1) == 0)
                    minmax = Math.Max(ncho, minmax);
                else
                    minmax = Math.Min(ncho, minmax);
                RemovePiece(loc);
                if ((dep & 1) == 0)
                    beta = Math.Max(beta, minmax);
                else
                    alpha = Math.Min(alpha, minmax);
                if (beta >= alpha)
                    break;
            }
            return minmax;
        }
    }

    public class AnswerSaver
    {
        public Location Ans { get; set; } = Location.Null;
        public void Get()
        {
            Ans = SearchTree.Choose;
        }
    }

    public class BackCalculate
    {
        public static AnswerSaver Saver { get; set; }
        public static System.Threading.Thread NowThread { get; set; }
    }
}

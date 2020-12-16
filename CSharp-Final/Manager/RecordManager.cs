using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using CSharp_Final.Properties;

namespace CSharp_Final.Manager
{
    public class RecordInfoExpection : ApplicationException
    {
        public RecordInfoExpection(string info) : base(info) { } 
    }
    public class Record
    {
        public List<char> Hex { get; private set; }
        public BigInteger Dec { get; private set; }
        public List<Location> History { get; private set; }
        readonly static int size = NetConfig.NetSize;
        public string DateName { get; private set; }
        public string FileName => string.Format("Records/Record-{0}.record", DateName);
        public WinningInfo Result { get; private set; }
        static char ToHexChar(int x)
        {
            if (x > size || x < 0)
                return '!';
            if (x < 10)
                return (char)(x + '0');
            if (x < 10 + 26)
                return (char)(x - 10 + 'A');
            if (x < 36 + 26)
                return (char)(x - 36 + 'a');
            return '!';
        }
        static int ToDecDight(char x)
        {
            if (x >= '0' && x <= '9')
                return x - '0';
            if (x >= 'A' && x <= 'Z')
                return x - 'A' + 10;
            if (x >= 'a' && x <= 'z')
                return x - 'a' + 36;
            return 0;
        }
        static BigInteger ToBigInteger(List<char> s)
        {
            BigInteger ans = 0;
            foreach (char ch in s)
                ans = ans * size + ToDecDight(ch);
            return ans;
        }
        static List<char> ToCharList(BigInteger x) => string.Format("{0:X}", x).ToList();
        public Record(List<Location> his, WinningInfo winner)
        {
            History = his;
            Result = winner;
            Hex = new List<char>();
            foreach (Location loc in History)
            {
                Hex.Add(ToHexChar(loc.X));
                Hex.Add(ToHexChar(loc.Y));
            }
            Hex.Add(ToHexChar(size));
            if (Result.Winner < 0)
                Hex.Add(ToHexChar(size));
            else
                Hex.Add(ToHexChar(Result.Winner));
            foreach (char ch in Result.WinWay)
                for (int di = 0; di < 16; ++di)
                    Hex.Add(ToHexChar((ch >> di) & 1));
            Dec = ToBigInteger(Hex);
            DateTime now = DateTime.Now;
            DateName = string.Format("{0:0000}{1:00}{2:00}{3:00}{4:00}{5:00}",
                now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);
        }
        const int hashA = 998244353, hashB = 1000000007, hashC = 19260817;
        public static long GetHashCode(BigInteger x, int p, int b)
        {
            long ans = 0;
            while (x > 0)
            {
                ans = (long)(ans * b + x % 10) % p;
                x /= 10;
            }
            return ans;
        }
        public static long GetHashCode(List<char> vs, int p, int b)
        {
            long ans = 0;
            foreach (char step in vs)
                ans = (ans * b + step) % p;
            return ans;
        }
        public void OutputRecord()
        {
            Directory.CreateDirectory("./Records");
            StreamWriter save = new StreamWriter(FileName);
            save.WriteLine("Written by Sheauhaw Jang");
            save.WriteLine(DateName);
            save.WriteLine(new string(Hex.ToArray()));
            save.WriteLine(GetHashCode(Hex, hashA, hashC));
            save.WriteLine(GetHashCode(Hex, hashB, hashC));
            save.WriteLine(Dec);
            save.WriteLine(GetHashCode(Dec, hashA, hashC));
            save.WriteLine(GetHashCode(Dec, hashB, hashC));
            for (int i = 0; i < History.Count; ++i)
                save.WriteLine("{2}: ({0}, {1})", History[i].X, History[i].Y, 
                    (i & 1) == 0 ? "Black" : "White");
            if (Result.Winner > 0)
                save.WriteLine(string.Format("Winner is {0}.",
                    Result.Winner == 0 ? "Black" : "White"));
            else
                save.WriteLine("Peace");
            save.WriteLine(Result.WinWay);
            save.Close();
        }
        public static Record InputRecord(string fileName)
        {
            Record ans = new Record(new List<Location>(), new WinningInfo());
            try
            {
                StreamReader save = new StreamReader(fileName);
                save.ReadLine(); save.ReadLine();
                List<char> hex = save.ReadLine().ToList();
                long hexHA = Convert.ToInt64(save.ReadLine());
                long hexHB = Convert.ToInt64(save.ReadLine());
                BigInteger dec = BigInteger.Parse(save.ReadLine());
                long decHA = Convert.ToInt64(save.ReadLine());
                long decHB = Convert.ToInt64(save.ReadLine());
                save.Close();
                if (GetHashCode(hex, hashA, hashC) != hexHA)
                    throw new RecordInfoExpection("First_Hash_HEX");
                if (GetHashCode(hex, hashB, hashC) != hexHB)
                    throw new RecordInfoExpection("Second_Hash_HEX");
                if (GetHashCode(dec, hashA, hashC) != decHA)
                    throw new RecordInfoExpection("First_Hash_DEC");
                if (GetHashCode(dec, hashB, hashC) != decHB)
                    throw new RecordInfoExpection("Second_Hash_DEC");
                if (ToBigInteger(hex) != dec)
                    throw new RecordInfoExpection("HEX_DEC_Diff");
                ans.Hex = hex;
                ans.Dec = dec;
                int i = 0;
                for (i = 0; hex[i] != ToHexChar(size); i += 2)
                    ans.History.Add(new Location(ToDecDight(hex[i]), ToDecDight(hex[i + 1])));
                ans.Result.Winner = hex[i + 1] == ToHexChar(size) ? -1 : ToDecDight(hex[i + 1]);
                for (i += 2; i < hex.Count; i += 16)
                {
                    int p = 0;
                    for (int j = 0; j < 16; ++j)
                        if ((ToDecDight(hex[i + j]) & 1) == 1)
                            p |= 1 << j;
                    ans.Result.WinWay += (char)p;
                }
            }
            catch
            {
                MessageBox.Show(Localisation.RecordFileError, Localisation.RecordError, 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new RecordInfoExpection("Error!");
            }
            return ans;
        }
    }

    public static class Replayer
    {
        public static List<Location> History { get; private set; }
        public static WinningInfo Result { get; private set; }
        public static void ReplayStart(Record record)
        {
            History = record.History;
            Result = record.Result;
            PlayAccess.Replay = true;
            Piece.Clear();
            Clock.Start();
        }
        public static void ReplayNext(Control sender, Timer timer)
        {
            if (Piece.CurrectID == History.Count)
            {
                timer.Stop();
                Announcement.Announce(Result);
                return;
            }
            Piece.SetCheckPiece(History[Piece.CurrectID], sender);
        }
    }
}

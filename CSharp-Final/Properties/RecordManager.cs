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

using GlobalManager;

namespace RecordManager
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
        static char ToHexChar(int x)
        {
            if (x >= size || x < 0)
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
        public Record(List<Location> his)
        {
            History = his;
            Hex = new List<char>();
            foreach (Location loc in History)
            {
                Hex.Add(ToHexChar(loc.X));
                Hex.Add(ToHexChar(loc.Y));
            }
            Dec = ToBigInteger(Hex);
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
            DateTime now = DateTime.Now;
            Directory.CreateDirectory("./Records");
            string dateName = string.Format("{0:0000}{1:00}{2:00}{3:00}{4:00}{5:00}",
                now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);
            string fileName = string.Format("Records/Record-{0}.record", dateName);
            StreamWriter save = new StreamWriter(fileName);
            save.WriteLine("Written by Sheauhaw Jang");
            save.WriteLine(dateName);
            save.WriteLine(new string(Hex.ToArray()));
            save.WriteLine(GetHashCode(Hex, hashA, hashC));
            save.WriteLine(GetHashCode(Hex, hashB, hashC));
            save.WriteLine(Dec);
            save.WriteLine(GetHashCode(Dec, hashA, hashC));
            save.WriteLine(GetHashCode(Dec, hashB, hashC));
            for (int i = 0; i < History.Count; ++i)
                save.WriteLine("{2}: ({0}, {1})", History[i].X, History[i].Y, 
                    (i & 1) == 0 ? "Black" : "White");
            save.Close();
        }
        public static Record InputRecord(string fileName)
        {
            Record ans = new Record(new List<Location>());
            try
            {
                StreamReader save = new StreamReader(fileName);
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
                for (int i = 0; i < ans.Hex.Count; i += 2)
                    ans.History.Add(new Location(ToDecDight(hex[i]), ToDecDight(hex[i + 1])));
            }
            catch
            {
                ans = new Record(new List<Location>());
                MessageBox.Show("文件已损坏！", "棋谱错误", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ans;
        }
    }
}

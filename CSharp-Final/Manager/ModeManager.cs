using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using System.Runtime.InteropServices;

using CSharp_Final.Properties;

namespace CSharp_Final.Manager
{
    public static class PlayAccess
    {
        public static bool Ability { get; set; } = false;
        public static bool Replay { get; set; } = false;
        static Control area;
        public static void SetControl(Control a)
        {
            if (area == null)
                area = a;
        }
        public static void UpdateCursor(int x = -1)
        {
            if (area == null)
                return;

            if (!Ability)
                area.Cursor = Cursors.Arrow;
            else if (x == 0)
                area.Cursor = Config.CursorBlack;
            else if (x == 1)
                area.Cursor = Config.CursorWrite;
            else
                area.Cursor = Cursors.Hand;
        }
    }
    public class Player
    {
        public bool AI { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
    }
    public class EConfig
    {
        public int Time { get; set; } = 3600;
        public string Lang { get; set; } = "ja-JP";
    }

    public static class Config
    {
        public static Player PlayerI { get; set; } = new Player();
        public static Player PlayerII { get; set; } = new Player();
        public static EConfig EConfig { get; set; } = new EConfig();
        public static Cursor CursorWrite { get; } = 
            new Cursor(new MemoryStream(Resources.WhiteCursor));
        public static Cursor CursorBlack { get; } =
            new Cursor(new MemoryStream(Resources.BlackCursor));
        readonly static List<char> ingore = new List<char>() { ' ', '\t', ';' };
        const char bigSplitor = ':';
        const char smallSplitor = '=';
        public static void GetConfig()
        {
            StreamReader config;
            try
            {
                config = new StreamReader("./config.txt");
            }
            catch { return; }
            try
            {
                string pro = config.ReadLine();
                while (pro.Contains(bigSplitor))
                {
                    pro = pro.Trim();
                    string info = config.ReadLine();
                    for (int i = 0; i < info.Length; ++i)
                        if (ingore.Contains(info[i]))
                        {
                            info.Remove(i, 1);
                            --i;
                        }
                    while (true)
                    {
                        if (info.Contains(bigSplitor))
                        {
                            pro = info;
                            break;
                        }
                        string[] infos = info.Split(smallSplitor);
                        switch (pro.Split(bigSplitor)[0])
                        {
                            case "PlayerI":
                                switch (infos[0])
                                {
                                    case "Name":
                                        PlayerI.Name = infos[1];
                                        break;
                                    case "Avatar":
                                        PlayerI.Avatar = infos[1];
                                        break;
                                }
                                break;
                            case "PlayerII":
                                switch (infos[0])
                                {
                                    case "Name":
                                        PlayerII.Name = infos[1];
                                        break;
                                    case "Avatar":
                                        PlayerII.Avatar = infos[1];
                                        break;
                                }
                                break;
                            case "Environment":
                                switch (infos[0])
                                {
                                    case "Time":
                                        EConfig.Time = Convert.ToInt32(infos[1]);
                                        break;
                                    case "Lang":
                                        EConfig.Lang = infos[1];
                                        break;
                                }
                                break;
                        }
                        if (config.EndOfStream)
                            return;
                        info = config.ReadLine();
                    }
                }
            }
            catch { }
            finally { config.Close(); }
        }

        public static void WriteConfig()
        {

        }
    }
}

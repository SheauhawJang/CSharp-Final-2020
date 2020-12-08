using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Manager
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
        public static void UpdateCursor()
        {
            if (area == null)
                return;
            area.Cursor = Ability ? Cursors.Hand : Cursors.Arrow;
        }
    }
    public class Player
    {
        public string Name { get; internal set; }
        public string Avatar { get; internal set; }
    }
    public class EConfig
    {
        public int Time { get; internal set; } = 60;
    }

    public static class Config
    {
        public static Player PlayerI { get; set; } = new Player();
        public static Player PlayerII { get; set; } = new Player();
        public static EConfig EConfig { get; set; } = new EConfig();
        readonly static List<char> ingore = new List<char>() { ' ', '\t', ';' };
        const char bigSplitor = ':';
        const char smallSplitor = '=';
        public static void GetConfig()
        {
            try
            {
                StreamReader config = new StreamReader("./config.txt");
                string pro = config.ReadLine();
                while (pro.Contains(bigSplitor))
                {
                    for (int i = 0; i < pro.Length; ++i)
                        if (ingore.Contains(pro[i]))
                        {
                            pro.Remove(i, 1);
                            --i;
                        }
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
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Drawing;

using CSharp_Final.Properties;

namespace CSharp_Final.Manager
{
    public static class PlayAccess
    {
        public static bool Ability { get; set; } = false;
        public static bool Replay { get; set; } = false;
        static Control area;
        public static Cursor CursorBlack { get; } =
            new Cursor(new MemoryStream(Resources.BlackCursor));
        public static Cursor CursorWhite { get; } =
            new Cursor(new MemoryStream(Resources.WhiteCursor));
        public static Control Area
        {
            private get => area;
            set { if (area == null) area = value; }
        }
        public static void UpdateCursor(int x = -1)
        {
            if (area == null)
                return;

            if (!Ability)
                area.Cursor = Cursors.Arrow;
            else if (x == 0)
                area.Cursor = CursorBlack;
            else if (x == 1)
                area.Cursor = CursorWhite;
            else
                area.Cursor = Cursors.Hand;
        }
    }
    public static class ButtonAccess
    {
        static MainForm mainForm;
        public static MainForm MainForm
        {
            private get => mainForm;
            set { if (mainForm == null) mainForm = value; }
        }
        public static void SetStartButton(bool access)
        {
            mainForm.Controls["StartButton"].Enabled = access;
            mainForm.Controls["RecordButton"].Enabled = access;
            mainForm.Controls["ComputerPictureI"].Enabled = access;
            mainForm.Controls["ComputerPictureII"].Enabled = access;
            mainForm.开始对局ToolStripMenuItem.Enabled = access;
            mainForm.读取棋谱ToolStripMenuItem.Enabled = access;
        }
        public static void SetToolButton(bool access)
        {
            mainForm.Controls["UndoButton"].Enabled = access;
            mainForm.Controls["TipButton"].Enabled = access;
            mainForm.Controls["SurrenderButton"].Enabled = access;
            mainForm.Controls["PeaceButton"].Enabled = access;
            mainForm.悔棋ToolStripMenuItem.Enabled = access;
            mainForm.请求和棋ToolStripMenuItem.Enabled = access;
            mainForm.认输ToolStripMenuItem.Enabled = access;
            mainForm.禁手点提示ToolStripMenuItem.Enabled = access;
        }
        public static void SetReplayButton(bool access)
        {
            mainForm.暂停继续播放ToolStripMenuItem.Enabled = access;
            mainForm.中止播放ToolStripMenuItem.Enabled = access;
        }
    }
    public class Player
    {
        public int AI { get; set; } = 0;
        public string Name { get; set; }
        public string Avatar { get; set; }

        public Player(string name = "NULL", string avatar = "")
        {
            Name = name;
            Avatar = avatar;
        }
    }
    public class EConfig
    {
        public int Time { get; set; } = 3600;
        public string Lang { get; set; } = "zh-CN";
        public int Speed { get; set; } = 300;
        public int AISpeed { get; set; } = 300;

        public bool Music { get; set; } = true;
        public bool Sound { get; set; } = true;

    }

    public static class Config
    {
        readonly static string[] defname =
            new string[2] { "Sheauhaw Jang", "KON Automaton" };
        public static Player PlayerI { get; set; } = new Player(defname[0]);
        public static Player PlayerII { get; set; } = new Player(defname[1]);
        public static EConfig EnConfig { get; set; } = new EConfig();
        static string Container(string s)
        {
            for (int i = 0; i < s.Length; ++i)
                if (s[i] == ' ' || s[i] == '\t' || s[i] == '&')
                {
                    char th = s[i];
                    s = s.Remove(i, 1);
                    --i;
                    if (th == '&')
                        break;
                }
            return s;
        }

        static bool IsPro(string s, char ch)
        {
            for (int i = 0; i < s.Length; ++i)
                if (s[i] == '&')
                    return false;
                else if (s[i] == ch)
                    return true;
            return false;
        }
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
                if (config.EndOfStream)
                    return;
                string pro = config.ReadLine();
                while (IsPro(pro, bigSplitor))
                {
                    pro = Container(pro);
                    if (config.EndOfStream)
                        return;
                    string info = config.ReadLine();
                    while (true)
                    {
                        if (IsPro(info, bigSplitor))
                        {
                            pro = info;
                            break;
                        }
                        info = Container(info);
                        string[] infos = info.Split(smallSplitor);
                        string infoHead = infos[0];
                        string infoContain = string.Join(
                            Convert.ToString(smallSplitor), infos, 
                            1, infos.Length - 1);
                        switch (pro.Split(bigSplitor)[0])
                        {
                            case "PlayerI":
                                switch (infoHead)
                                {
                                    case "Name":
                                        if (infoContain.Length > 0)
                                            PlayerI.Name = infoContain;
                                        else
                                            PlayerI.Name = defname[0];
                                        break;
                                    case "Avatar":
                                        PlayerI.Avatar = infoContain;
                                        break;
                                }
                                break;
                            case "PlayerII":
                                switch (infoHead)
                                {
                                    case "Name":
                                        if (infoContain.Length > 0)
                                            PlayerII.Name = infoContain;
                                        else
                                            PlayerII.Name = defname[1];
                                        break;
                                    case "Avatar":
                                        PlayerII.Avatar = infoContain;
                                        break;
                                }
                                break;
                            case "Environment":
                                switch (infoHead)
                                {
                                    case "Time":
                                        int xt = Convert.ToInt32(infoContain);
                                        if (xt >= 1 && xt < 100 * 60 * 60)
                                            EnConfig.Time = xt;
                                        break;
                                    case "Lang":
                                        EnConfig.Lang = infoContain;
                                        break;
                                    case "Speed":
                                        int xv = Convert.ToInt32(infoContain);
                                        if (xv >= 1 && xv <= 10 * 1000)
                                            EnConfig.Speed = xv;
                                        break;
                                    case "AI":
                                        int xi = Convert.ToInt32(infoContain);
                                        if (xi >= 1 && xi <= 10 * 1000)
                                            EnConfig.AISpeed = xi;
                                        break;
                                    case "Music":
                                        EnConfig.Music = infoContain == "1";
                                        break;
                                    case "Sound":
                                        EnConfig.Sound = infoContain == "1";
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
            StreamWriter config;
            try
            {
                config = new StreamWriter("./config.txt");
            }
            catch { return; }
            config.WriteLine("PlayerI :");
            config.WriteLine("\tName = &{0}", PlayerI.Name);
            config.WriteLine("\tAvatar = &{0}", PlayerI.Avatar);
            config.WriteLine("PlayerII :");
            config.WriteLine("\tName = &{0}", PlayerII.Name);
            config.WriteLine("\tAvatar = &{0}", PlayerII.Avatar);
            config.WriteLine("Environment :");
            config.WriteLine("\tTime = &{0}", EnConfig.Time);
            config.WriteLine("\tLang = &{0}", EnConfig.Lang);
            config.WriteLine("\tSpeed = &{0}", EnConfig.Speed);
            config.WriteLine("\tAI = &{0}", EnConfig.AISpeed);
            config.WriteLine("\tMusic = &{0}", EnConfig.Music ? 1 : 0);
            config.WriteLine("\tSound = &{0}", EnConfig.Sound ? 1 : 0);
            config.Close();
        }
    }

    public static class Avatar
    {
        public static Bitmap GetBitmap(string path, Bitmap def)
        {
            try { return new Bitmap(path); }
            catch { return def; }
        }
        public static Bitmap GetBitmap(string path, int id = 0)
        {
            if (id == 0)
                return GetBitmap(path, Resources.Head_I);
            else
                return GetBitmap(path, Resources.Head_II);
        }
    }
}

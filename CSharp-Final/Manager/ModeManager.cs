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
                area.Cursor = Config.CursorBlack;
            else if (x == 1)
                area.Cursor = Config.CursorWrite;
            else
                area.Cursor = Cursors.Hand;
        }
    }
    public static class ButtonAccess
    {
        static Form mainForm;
        public static Form MainForm
        {
            private get => mainForm;
            set { if (mainForm == null) mainForm = value; }
        }
        public static void SetStartButton(bool access)
        {
            mainForm.Controls["StartButton"].Enabled = access;
            mainForm.Controls["RecordButton"].Enabled = access;
        }
        public static void SetToolButton(bool access)
        {
            mainForm.Controls["UndoButton"].Enabled = access;
            mainForm.Controls["TipButton"].Enabled = access;
            mainForm.Controls["SurrenderButton"].Enabled = access;
            mainForm.Controls["PeaceButton"].Enabled = access;
        }
    }
    public class Player
    {
        public bool AI { get; set; }
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
    }

    public static class Config
    {
        public static Player PlayerI { get; set; } = new Player("Sheauhaw Jang");
        public static Player PlayerII { get; set; } = new Player("KON Automaton");
        public static EConfig EnConfig { get; set; } = new EConfig();
        public static Cursor CursorWrite { get; } = 
            new Cursor(new MemoryStream(Resources.WhiteCursor));
        public static Cursor CursorBlack { get; } =
            new Cursor(new MemoryStream(Resources.BlackCursor));
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
                string pro = Container(config.ReadLine());
                while (pro.Contains(bigSplitor))
                {
                    if (config.EndOfStream)
                        return;
                    string info = Container(config.ReadLine());
                    while (true)
                    {
                        if (info.Contains(bigSplitor))
                        {
                            pro = info;
                            break;
                        }
                        string[] infos = info.Split(smallSplitor);
                        string infoHead = infos[0];
                        string infoContain = string.Join(" ", infos, 1, infos.Length - 1);
                        switch (pro.Split(bigSplitor)[0])
                        {
                            case "PlayerI":
                                switch (infoHead)
                                {
                                    case "Name":
                                        if (infoContain.Length > 0)
                                            PlayerI.Name = infoContain;
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
                                        EnConfig.Time = Convert.ToInt32(infoContain);
                                        break;
                                    case "Lang":
                                        EnConfig.Lang = infoContain;
                                        break;
                                }
                                break;
                        }
                        if (config.EndOfStream)
                            return;
                        info = Container(config.ReadLine());
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

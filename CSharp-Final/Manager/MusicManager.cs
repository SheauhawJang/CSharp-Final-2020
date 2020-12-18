using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Media;

using CSharp_Final.Properties;

namespace CSharp_Final.Manager
{
    public static class BGM
    {
        public static MediaPlayer Welcome { get; set; } = new MediaPlayer();
        public static MediaPlayer Begin { get; set; } = new MediaPlayer();
        public static MediaPlayer Exciting { get; set; } = new MediaPlayer();
        static void MediaLoop(object sender, EventArgs e)
        {
            MediaPlayer media = (MediaPlayer)sender;
            media.Position = new TimeSpan(0);
        }
        static void MediaExcitingLoop(object sender, EventArgs e)
        {
            MediaPlayer media = (MediaPlayer)sender;
            media.Stop();
            Begin.Position = new TimeSpan(0);
            Begin.Play();
        }
        public static void Initialize()
        {
            Welcome.Open(new Uri("./sounds/Welcome.wav", UriKind.Relative));
            Begin.Open(new Uri("./sounds/Begin.wav", UriKind.Relative));
            Exciting.Open(new Uri("./sounds/Ending.wav", UriKind.Relative));
            Welcome.MediaEnded += MediaLoop;
            Begin.MediaEnded += MediaLoop;
            Exciting.MediaEnded += MediaExcitingLoop;
        }
        public static int Current { get; private set; } = 0;
        public static MediaPlayer[] Players { get; private set; }
            = new MediaPlayer[3] { Welcome, Begin, Exciting };

        public static void Play(int index = -1)
        {
            if (index >= 0 && index < 3)
                Current = index;
            for (int i = 0; i < 3; ++i)
                if (i == Current && Config.EnConfig.Music)
                    Players[i].Play();
                else
                    Players[i].Stop();
            if (index == 2)
                Current = 1;
        }
        public static void Stop()
        {
            foreach (MediaPlayer p in Players)
                p.Stop();
        }
    }

    public static class SoundE
    {
        public static MediaPlayer SetPiece { get; private set; } = new MediaPlayer();
        public static MediaPlayer WinnerPiece { get; private set; } = new MediaPlayer();
        static void MediaLoop(object sender, EventArgs e)
        {
            MediaPlayer media = (MediaPlayer)sender;
            media.Stop();
        }
        public static void Initialize()
        {
            SetPiece.Open(new Uri("./sounds/SetPiece.wav", UriKind.Relative));
            WinnerPiece.Open(new Uri("./sounds/WinnerPiece.wav", UriKind.Relative));
            SetPiece.MediaEnded += MediaLoop;
            WinnerPiece.MediaEnded += MediaLoop;
        }

        public static void PlaySetPiece()
        {
            if (Config.EnConfig.Sound)
                SetPiece.Play();
        }

        public static void PlayWinnerPiece()
        {
            if (Config.EnConfig.Sound)
                WinnerPiece.Play();
        }
    }
}

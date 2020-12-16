using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

using CSharp_Final.Properties;
namespace CSharp_Final.Manager
{
    public static class UndoPiece
    {
        public static void Undo(Control sender)
        {
            if (Piece.History.Count == 0)
                return;
            string name = Piece.CurrectColorID == 1 ?
                Localisation.PlayerBlack : Localisation.PlayerWhite;
            if (MessageBox.Show(string.Format("{0}{1}",
                name, Localisation.UndoAsk),
                Localisation.UndoInfo, MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Piece.RemovePiece(sender);
                MessageBox.Show(string.Format("{0}{1}", name,
                    Localisation.UndoNotice), Localisation.UndoInfo,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    public static class TipShow
    {
        public static List<Location> Tips { get; set; } = new List<Location>();
        public static void Tip(Control sender)
        {
            Graphics g = sender.CreateGraphics();
            for (int i = 0; i < NetConfig.NetSize; ++i)
                for (int j = 0; j < NetConfig.NetSize; ++j)
                {
                    Location loc = new Location(i, j);
                    if (Piece.CheckPiece(loc) < 0)
                    {
                        g.DrawImage(Resources.Ban, loc.PieceCorner);
                        Tips.Add(loc);
                    }
                }
        }
    }
    public static class PeacePiece
    {
        public static void Peace()
        {
            string name = Piece.CurrectColorID == 0 ?
                Localisation.PlayerBlack : Localisation.PlayerWhite;
            if (MessageBox.Show(string.Format("{0}{1}",
                name, Localisation.PeaceAsk),
                Localisation.PeaceInfo, MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                WinningInfo info = new WinningInfo
                {
                    Winner = -1,
                    WinWay = "REQUEST"
                };
                Announcement.Announce(info);
            }
        }
    }

    public static class SurrenderPiece
    {
        public static void Surrender(int id)
        {
            WinningInfo info = new WinningInfo
            {
                Winner = id,
                WinWay = "SURRENDER"
            };
            Announcement.Announce(info);
        }
    }

}

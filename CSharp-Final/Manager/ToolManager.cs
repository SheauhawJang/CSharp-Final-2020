using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CSharp_Final.Properties;
namespace CSharp_Final.Manager
{
    public class UndoPiece
    {
        public static void Undo()
        {
            if (Piece.History.Count == 0)
                return;
            string name = Piece.CurrectColorID == 1 ? 
                Localisation.PlayerBlack : Localisation.PlayerWhite;
            if (MessageBox.Show(string.Format("{0}{1}", 
                name, Localisation.UndoAsk), 
                Localisation.Undo, MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(string.Format("{0}{1}", name,
                    Localisation.UndoNotice), Localisation.Undo, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Piece.RemovePiece();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CSharp_Final.Manager;
using CSharp_Final.Properties;

namespace CSharp_Final
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ClearConfigButton_Click(object sender, EventArgs e)
        {
            Config.GetConfig();
            PlayerINameText.Text = Config.PlayerI.Name;
            PlayerIAvatarText.Text = Config.PlayerI.Avatar;
            PlayerIAvatarPicture.BackgroundImage = 
                Avatar.GetBitmap(Config.PlayerI.Avatar, 0);
            PlayerIINameText.Text = Config.PlayerII.Name;
            PlayerIIAvatarText.Text = Config.PlayerII.Avatar;
            PlayerIIAvatarPicture.BackgroundImage = 
                Avatar.GetBitmap(Config.PlayerII.Avatar, 1);
            TimerLimitUpdown.Value = Config.EnConfig.Time;
            ReplaySpeedUpdown.Value = Config.EnConfig.Speed;
            switch (Config.EnConfig.Lang)
            {
                case "zh-CN":
                    LangCombo.SelectedIndex = 1;
                    break;
                case "zh-TW":
                    LangCombo.SelectedIndex = 2;
                    break;
                case "ja-JP":
                    LangCombo.SelectedIndex = 3;
                    break;
                default:
                    LangCombo.SelectedIndex = 0;
                    break;
            }
        }

        private void PlayerAvatarText_TextChanged(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            PictureBox picture = text == PlayerIAvatarText ?
                PlayerIAvatarPicture : PlayerIIAvatarPicture;
            Bitmap def = text == PlayerIAvatarText ?
                Resources.Head_I : Resources.Head_II;
            picture.BackgroundImage = Avatar.GetBitmap(text.Text, def);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Config.PlayerI.Name = PlayerINameText.Text;
            Config.PlayerI.Avatar = PlayerIAvatarText.Text;
            Config.PlayerII.Name = PlayerIINameText.Text;
            Config.PlayerII.Avatar = PlayerIIAvatarText.Text;
            Config.EnConfig.Time = (int)TimerLimitUpdown.Value;
            Config.EnConfig.Speed = (int)ReplaySpeedUpdown.Value;
            switch (LangCombo.SelectedIndex)
            {
                case 1:
                    Config.EnConfig.Lang = "zh-CN";
                    break;
                case 2:
                    Config.EnConfig.Lang = "zh-TW";
                    break;
                case 3:
                    Config.EnConfig.Lang = "ja-JP";
                    break;
                default:
                    Config.EnConfig.Lang = "en-US";
                    break;
            }
            Config.WriteConfig();
            Config.GetConfig();
            Close();
        }

        private void PlayerAvatorOpenButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            TextBox text = button == PlayerIAvatorOpenButton ?
                PlayerIAvatarText : PlayerIIAvatarText;
            if (AvatarOpenDialog.ShowDialog() == DialogResult.OK)
                text.Text = AvatarOpenDialog.FileName;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearAvatarButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            TextBox text = button == ClearIAvatarButton ?
                PlayerIAvatarText : PlayerIIAvatarText;
            text.Clear();
        }

        private void ConfigForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("???", "?", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}

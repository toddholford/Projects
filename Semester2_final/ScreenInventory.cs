using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PT4
{
    public partial class ScreenInventory : UserControl
    {
        private MainForm _form;
        private Game _game;
        //private Bag _bag;

        public ScreenInventory()
        {
            InitializeComponent();
            
        }
        
        public MainForm Form
        {
            get { return _form; }
            set { _form = value; }
        }

        private void btnNextLevel_Click(object sender, EventArgs e)
        {
            _form.SwitchScreen(ScreenId.COMBAT);

            var snd = new SoundPlayer(
                PT4.Properties.Resources.Blip_Select);
            snd.Play();

        }

        private void ScreenInventory_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible && _form != null)
            {
                _game = _form.Game;
                for (int i = 0; i < _game.Enemy.Bag.Count; ++i)
                {
                    listBoxLoot.Items.Add(_game.Enemy.Bag.RemoveAt(i));
                }
                lblScreenName.Text = $"Inventory ({_game.Level})";
            }
        }

        private void btnEquip_Click(object sender, EventArgs e)
        {

        }

        private void btnSell_Click(object sender, EventArgs e)
        {

        }

        private void btnDrop_Click(object sender, EventArgs e)
        {

        }

        private void btnUse_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Game Files (*.sav)|*.sav";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Game.SaveGame(dlg.FileName, _game);
            }

            var snd = new SoundPlayer(
                PT4.Properties.Resources.Blip_Select);
            snd.Play();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Game Files (*.sav)|*.sav";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _form.Game = Game.LoadGame(dlg.FileName);
                _form.SwitchScreen(ScreenId.INVENTORY);

            }

            var snd = new SoundPlayer(
                PT4.Properties.Resources.Blip_Select);
            snd.Play();
        }
    }
}

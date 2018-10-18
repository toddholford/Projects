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
    public partial class ScreenStart : UserControl
    {
        private MainForm _form;
        private Game _game;

        public ScreenStart()
        {
            InitializeComponent();

            //_game = _form.Game;

            pbPlaySelectedIcon.Visible = false;
            pbLoadSelectedIcon.Visible = false;
        }

        public MainForm Form
        {
            get { return _form; }
            set { _form = value; }
        }

        //public Game Game
        //{
        //    get { return _game; }
        //    set { _game = value; }
        //}

        //ADDITIONAL STYLING - PLAY BUTTON----------------------------------
        private void btnPlay_MouseEnter(object sender, EventArgs e)
        {
            pbPlaySelectedIcon.Visible = true;
            btnPlay.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPlay.UseVisualStyleBackColor = false;
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            pbPlaySelectedIcon.Visible = false;
            btnPlay.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPlay.UseVisualStyleBackColor = false;
        }

        private void btnPlay_MouseDown(object sender, MouseEventArgs e)
        {
            btnPlay.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }
        //-------------------------------------------------------------------


        //ADDITIONAL STYLING - LOAD BUTTON-----------------------------------
        private void btnLoadGame_MouseEnter(object sender, EventArgs e)
        {
            pbLoadSelectedIcon.Visible = true;
            btnLoadGame.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLoadGame.UseVisualStyleBackColor = false;
        }
        
        private void btnLoadGame_MouseLeave(object sender, EventArgs e)
        {
            pbLoadSelectedIcon.Visible = false;
            btnLoadGame.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLoadGame.UseVisualStyleBackColor = false;
        }
        
        private void btnLoadGame_MouseDown(object sender, MouseEventArgs e)
        {
            btnLoadGame.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }
        //--------------------------------------------------------------------


        private void btnPlay_Click(object sender, EventArgs e)
        {
            _game = _form.Game;
            _form.SwitchScreen(ScreenId.COMBAT);
            
            var snd = new SoundPlayer(
                PT4.Properties.Resources.Blip_Select);
            snd.Play();
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Game Files (*.sav)|*.sav";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _form.Game = Game.LoadGame(dlg.FileName);
                _form.SwitchScreen(ScreenId.INVENTORY);

                var snd = new SoundPlayer(
                PT4.Properties.Resources.Blip_Select);
                snd.Play();

            }
        }
        

    }
}

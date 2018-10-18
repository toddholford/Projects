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
    public partial class ScreenEnd : UserControl
    {
        private MainForm _form;
        private Game _game;

        public ScreenEnd()
        {
            InitializeComponent();
            
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

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            _form.SwitchScreen(ScreenId.START);

            _game = _form.Game;

            var snd = new SoundPlayer(
                PT4.Properties.Resources.Blip_Select);
            snd.Play();

        }
    }
}

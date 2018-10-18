using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT4
{
    public partial class MainForm : Form
    {
        private MainForm _form;
        private Game _game;

        private int _level = 0;

        public MainForm()
        {
            InitializeComponent();

            _game = new Game();
            
            screenStart.Form = this;
            screenCombat.Form = this;
            screenInventory.Form = this;
            screenEnd1.Form = this;
            
            screenStart.Visible = true;
            screenCombat.Visible = false;
            screenInventory.Visible = false;
            screenEnd1.Visible = false;
        }

        public int Level
        {
            get { return _level; }
        }

        public Game Game
        {
            get { return _game; }
            set { _game = value; }
        }

        public void NextLevel()
        {
            ++_level;
        }

        public void SwitchScreen(ScreenId screen)
        {
            screenStart.Visible = false;
            screenCombat.Visible = false;
            screenInventory.Visible = false;
            screenEnd1.Visible = false;

            switch (screen)
            {
                case ScreenId.START:
                    screenStart.Visible = true;
                    break;
                case ScreenId.COMBAT:
                    screenCombat.Visible = true;
                    break;
                case ScreenId.INVENTORY:
                    screenInventory.Visible = true;
                    break;
                case ScreenId.END:
                    screenEnd1.Visible = true;
                    break;
                default:
                    break;
            }
        }

        public MainForm Form
        {
            get { return _form; }
            set { _form = value; }
        }

    }
}

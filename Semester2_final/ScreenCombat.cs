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
    public partial class ScreenCombat : UserControl
    {
        private MainForm _form;
        private Character _player;
        private Character _enemy;
        private CharacterFactory _characterFactory = new CharacterFactory();
        private Game _game;
        
        private Random _rand = new Random();
        private ToolTip _tooltip = new ToolTip();
        
        public ScreenCombat()
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
            _form.SwitchScreen(ScreenId.INVENTORY);
            _game.NextLevel();
            

            var snd = new SoundPlayer(
                PT4.Properties.Resources.Blip_Select);
            snd.Play();

        }

        //ADDITIONAL STYLING - ATTACK BUTTON-------------------------------
        private void btnAttack_MouseEnter(object sender, EventArgs e)
        {
            btnAttack.Width = 260;
            btnAttack.Height = 80;
            btnAttack.BackgroundImageLayout = ImageLayout.Stretch;
            btnAttack.Location.X.Equals(452);
            btnAttack.Location.Y.Equals(483);

            btnAttack.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAttack.UseVisualStyleBackColor = false;
        }

        private void btnAttack_MouseLeave(object sender, EventArgs e)
        {
            btnAttack.Width = 250;
            btnAttack.Height = 70;
            btnAttack.BackgroundImageLayout = ImageLayout.Stretch;
            btnAttack.Location.X.Equals(452);
            btnAttack.Location.Y.Equals(483);

            btnAttack.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAttack.UseVisualStyleBackColor = false;
        }

        private void btnAttack_MouseDown(object sender, MouseEventArgs e)
        {
            btnAttack.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }
        //-----------------------------------------------------------------

        
        //ADDITIONAL STYLING - GUARD BUTTON--------------------------------
        private void btnGuard_MouseEnter(object sender, EventArgs e)
        {
            btnGuard.Width = 240;
            btnGuard.Height = 190;
            btnGuard.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuard.Location.X.Equals(452);
            btnGuard.Location.Y.Equals(483);

            btnGuard.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnGuard.UseVisualStyleBackColor = false;
        }

        private void btnGuard_MouseLeave(object sender, EventArgs e)
        {
            btnGuard.Width = 230;
            btnGuard.Height = 180;
            btnGuard.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuard.Location.X.Equals(452);
            btnGuard.Location.Y.Equals(483);

            btnGuard.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnGuard.UseVisualStyleBackColor = false;
        }

        private void btnGuard_MouseDown(object sender, MouseEventArgs e)
        {
            btnGuard.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }
        //------------------------------------------------------------------


        //ADDITIONAL STYLING - HEAL BUTTON----------------------------------
        private void btnHeal_MouseEnter(object sender, EventArgs e)
        {
            btnHeal.Width = 90;
            btnHeal.Height = 165;
            btnHeal.BackgroundImageLayout = ImageLayout.Zoom;
            btnHeal.Location.X.Equals(452);
            btnHeal.Location.Y.Equals(483);

            btnHeal.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnHeal.UseVisualStyleBackColor = false;
        }

        private void btnHeal_MouseLeave(object sender, EventArgs e)
        {
            btnHeal.Width = 85;
            btnHeal.Height = 155;
            btnHeal.BackgroundImageLayout = ImageLayout.Zoom;
            btnHeal.Location.X.Equals(752);
            btnHeal.Location.Y.Equals(512);

            btnHeal.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnHeal.UseVisualStyleBackColor = false;
        }

        private void btnHeal_MouseDown(object sender, MouseEventArgs e)
        {
            btnHeal.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }
        //-------------------------------------------------------------------

        private void btnAttack_Click(object sender, EventArgs e)
        {
            
            //_game.NextLevel();

            var snd = new SoundPlayer(
                PT4.Properties.Resources.Blip_Select);
            snd.Play();

            if (_player.IsDead != true)
            {
                int playerDamage = PlayerAttack(_player.TotalATK, _enemy.TotalDEF);
                int enemyDamage = EnemyAttack(_enemy.TotalATK, _player.TotalDEF);

                _enemy.ApplyDamage(playerDamage);

                if (_enemy.IsDead != true)
                {
                    _player.ApplyDamage(enemyDamage);
                }
                
                lblPlayerName.Text = string.Format("{0}", _player.Name);
                lblPlayerHp.Text = string.Format("HP: {0}", _player.HP);
                lblPlayerAtk.Text = string.Format("ATK: {0}", _player.TotalATK);
                lblPlayerDef.Text = string.Format("DEF: {0}", _player.TotalDEF);

                lblEnemyType.Text = string.Format("{0}", _enemy.Name);
                lblEnemyHp.Text = string.Format("HP: {0}", _enemy.HP);
                lblEnemyAtk.Text = string.Format("ATK: {0}", _enemy.TotalATK);
                lblEnemyDef.Text = string.Format("DEF: {0}", _enemy.TotalDEF);
            }
            else
            {
                btnAttack.Enabled = false;
                btnGuard.Enabled = false;
                btnHeal.Enabled = false;
                btnNextLevel.Enabled = false;

                _form.SwitchScreen(ScreenId.END);
            }
            CheckPlayerDead();
            CheckEnemyDead();

        }

        private void btnGuard_Click(object sender, EventArgs e)
        {
            
            //_game.NextLevel();

            var snd = new SoundPlayer(
                PT4.Properties.Resources.Blip_Select);
            snd.Play();

            if (_player.IsDead != true)
            {
                int playerDamage = PlayerGuard(_player.TotalATK, _enemy.TotalDEF);
                int enemyDamage = EnemyGuard(_enemy.TotalATK, _player.TotalDEF);

                _enemy.ApplyDamage(enemyDamage);
                _player.ApplyDamage(playerDamage);

                lblPlayerName.Text = string.Format("{0}", _player.Name);
                lblPlayerHp.Text = string.Format("HP: {0}", _player.HP);
                lblPlayerAtk.Text = string.Format("ATK: {0}", _player.TotalATK);
                lblPlayerDef.Text = string.Format("DEF: {0}", _player.TotalDEF);

                lblEnemyType.Text = string.Format("{0}", _enemy.Name);
                lblEnemyHp.Text = string.Format("HP: {0}", _enemy.HP);
                lblEnemyAtk.Text = string.Format("ATK: {0}", _enemy.TotalATK);
                lblEnemyDef.Text = string.Format("DEF: {0}", _enemy.TotalDEF);
            }
            else
            {
                btnAttack.Enabled = false;
                btnGuard.Enabled = false;
                btnHeal.Enabled = false;
                btnNextLevel.Enabled = false;
            }
            CheckPlayerDead();
            CheckEnemyDead();

        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            var snd = new SoundPlayer(
                PT4.Properties.Resources.Blip_Select);
            snd.Play();

            int healing = _rand.Next(15, 30);
            _player.ApplyHeal(healing);

            lblPlayerHp.Text = string.Format("HP: {0}", _player.HP);
        }

        public int PlayerAttack(int playerATK, int enemyDEF)
        {
            int damage;
            return damage = ((playerATK + _player.Weapon.ATK) - (enemyDEF + _enemy.Helmet.DEF + _enemy.Vest.DEF)) + _rand.Next(0, 4);
        }

        public int EnemyAttack(int enemyATK, int playerDEF)
        {
            int damage;
            return damage = ((enemyATK + _enemy.Weapon.ATK) - (playerDEF + _player.Helmet.DEF + _player.Vest.DEF)) + _rand.Next(0, 4);
        }

        public int PlayerGuard(int playerATK, int enemyDEF)
        {
            int damage;
            return damage = ((playerATK + _player.Weapon.ATK) - (enemyDEF + _enemy.Helmet.DEF + _enemy.Vest.DEF)) / 2 + _rand.Next(0, 3);
        }

        public int EnemyGuard(int enemyATK, int playerDEF)
        {
            int damage;
            return damage = ((enemyATK + _enemy.Weapon.ATK) - (playerDEF + _player.Helmet.DEF + _player.Vest.DEF)) / 2 + _rand.Next(0, 3);
        }

        public void CheckPlayerDead()
        {
            if (_player.IsDead.Equals(true))
            {
                _form.SwitchScreen(ScreenId.END);
            }
        }

        public void CheckEnemyDead()
        {
            if (_enemy.HP <= 0)
            {
                btnNextLevel.Visible = true;
            }
            else
            {
                btnNextLevel.Visible = false;
            }
        }

        private void ScreenCombat_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible && _form != null)
            {
                _game = _form.Game;
                lblScreenName.Text = $"Combat ({_game.Level})";

                btnNextLevel.Visible = false;
                

                //SPAWN CHARACTER - PLAYER-------------------------------------
                //_player = _characterFactory.SpawnPlayer();
                _player = _game.Player;

                lblPlayerName.Text = string.Format("{0}", _player.Name);
                lblPlayerHp.Text = string.Format("HP: {0}", _player.HP);
                lblPlayerAtk.Text = string.Format("ATK: {0}", _player.TotalATK);
                lblPlayerDef.Text = string.Format("DEF: {0}", _player.TotalDEF);

                pbHeroHelmet.BackgroundImage = _player.Helmet.Image;
                pbHeroVest.BackgroundImage = _player.Vest.Image;
                pbHeroWeapon.BackgroundImage = _player.Weapon.Image;
                pbHeroPotion.BackgroundImage = _player.Potion.Image;

                //_game.Player = _player;
                //-------------------------------------------------------------


                //SPAWN CHARACTER - ENEMY--------------------------------------
                _enemy = _game.Enemy;

                lblEnemyType.Text = string.Format("{0}", _enemy.Name);
                lblEnemyHp.Text = string.Format("HP: {0}", _enemy.HP);
                lblEnemyAtk.Text = string.Format("ATK: {0}", _enemy.TotalATK);
                lblEnemyDef.Text = string.Format("DEF: {0}", _enemy.TotalDEF);

                pbEnemyHelmet.BackgroundImage = _enemy.Helmet.Image;
                pbEnemyVest.BackgroundImage = _enemy.Vest.Image;
                pbEnemyWeapon.BackgroundImage = _enemy.Weapon.Image;
                pbEnemyPotion.BackgroundImage = _enemy.Potion.Image;

                //_game.Enemy = _enemy;
                //-------------------------------------------------------------


                //TOOLTIPS - EQUIPPED ITEMS------------------------------------
                _tooltip.IsBalloon = true;
                _tooltip.ToolTipTitle = "Item Info";

                _tooltip.SetToolTip(pbHeroHelmet, _player.Helmet.ToString());
                _tooltip.SetToolTip(pbHeroVest, _player.Vest.ToString());
                _tooltip.SetToolTip(pbHeroWeapon, _player.Weapon.ToString());
                _tooltip.SetToolTip(pbHeroPotion, _player.Potion.ToString());

                _tooltip.SetToolTip(pbEnemyHelmet, _enemy.Helmet.ToString());
                _tooltip.SetToolTip(pbEnemyVest, _enemy.Vest.ToString());
                _tooltip.SetToolTip(pbEnemyWeapon, _enemy.Weapon.ToString());
                _tooltip.SetToolTip(pbEnemyPotion, _enemy.Potion.ToString());
                //--------------------------------------------------------------


                btnAttack.Width = 250;
                btnAttack.Height = 70;
                btnGuard.Width = 230;
                btnGuard.Height = 180;
                btnHeal.Width = 85;
                btnHeal.Height = 155;
                //lblscreenname.text = $"Combat ({_form.Level})";
                
            }
        }

    }
}

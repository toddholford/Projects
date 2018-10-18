using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT4
{
    [Serializable]
    public class Character
    {
        protected string _name;
        protected int _hp;
        protected int _atk;
        protected int _def;
        protected bool _dead;
        protected Bag _bag;
        protected EquippedItems _equipped;
        protected Armor _helmet;
        protected Armor _vest;
        protected Weapon _weapon;
        protected Potion _potion;

        public Character(string name, int hp, int atk, int def)
        {
            _name = name;
            _hp = hp;
            _atk = atk;
            _def = def;
            _bag = new Bag(40);
            _dead = false;
        }

        public void ApplyDamage(int damage)
        {
            if (damage < 1)
            {
                damage = 1;
                _hp -= damage;
            }
            else
            {
                _hp -= damage;
            }

            if (HP <= 0)
            {
                _hp = 0;
                _dead = true;
            }
        }

        public void ApplyHeal(int healing)
        {
            _hp += healing;
        }

        public string Name
        {
            get { return _name; }
        }

        public int HP
        {
            get { return _hp; }
        }

        public int TotalATK
        {
            get { return _atk; }
        }

        public int TotalDEF
        {
            get { return _def; }
        }

        public bool IsDead
        {
            get { return _dead; }
        }

        public Bag Bag
        {
            get { return _bag; }
            set { _bag = value; }
        }

        public EquippedItems Equipped
        {
            get { return _equipped; }
            set { _equipped = value; }
        }

        public Armor Helmet
        {
            get { return _helmet; }
            set { _helmet = value; }
        }

        public Armor Vest
        {
            get { return _vest; }
            set { _vest = value; }
        }

        public Weapon Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }

        public Potion Potion
        {
            get { return _potion; }
            set { _potion = value; }
        }

    }
}

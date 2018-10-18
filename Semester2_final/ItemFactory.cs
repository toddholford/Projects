using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT4
{
    [Serializable]
    public class ItemFactory
    {
        private Random _rand = new Random();

        public ItemFactory()
        { }

        public Armor SpawnHelmet()
        {
            return new Armor(
                new Guid(),
                RandomizeName(_helmetNames),
                _rand.Next(1, 10),
                RandomizeImage(_helmetImages),
                true,
                3.3,
                InventorySlotId.HELMET,
                100
            );
        }

        public Armor SpawnVest()
        {
            return new Armor(
                new Guid(),
                RandomizeName(_vestNames),
                _rand.Next(1, 10),
                RandomizeImage(_vestImages),
                false,
                4.5,
                InventorySlotId.VEST,
                234
            );
        }

        public Weapon SpawnWeapon()
        {
            return new Weapon(
                new Guid(),
                RandomizeName(_weaponNames),
                _rand.Next(1, 10),
                RandomizeImage(_weaponImages),
                true,
                2.3,
                InventorySlotId.WEAPON,
                550
            );
        }

        public Potion SpawnPotion()
        {
            return new Potion(
                new Guid(),
                RandomizeName(_potionNames),
                _rand.Next(1, 10),
                RandomizeImage(_potionImages),
                true,
                2.3,
                InventorySlotId.WEAPON,
                550
            );
        }

        public Junk SpawnJunk()
        {
            return new Junk(
                new Guid(),
                RandomizeName(_weaponNames),
                RandomizeImage(_weaponImages),
                true,
                2.3,
                InventorySlotId.WEAPON,
                550
            );
        }

        ////Helmet name and image array
        private string[] _helmetNames = new string[]
            {
                "Magic Master", "Evil Below", "Heroic Light"
            };
        private Image[] _helmetImages = new Image[]
            {
                PT4.Properties.Resources.helmet1,
                PT4.Properties.Resources.helmet2,
                PT4.Properties.Resources.helmet3
            };

        //Vest name and image array
        private string[] _vestNames = new string[]
            {
                "Cold Cast", "Dark Cloak", "Minister Robes"
            };
        private Image[] _vestImages = new Image[]
            {
                PT4.Properties.Resources.vest1,
                PT4.Properties.Resources.vest2,
                PT4.Properties.Resources.vest3
            };

        //Weapon name and image array
        private string[] _weaponNames = new string[]
            {
                "Transistor", "Pure Nail", "Hyper Blade"
            };
        private Image[] _weaponImages = new Image[]
            {
                PT4.Properties.Resources.weapon1,
                PT4.Properties.Resources.weapon2,
                PT4.Properties.Resources.weapon3
            };

        //Potion name and image array
        private string[] _potionNames = new string[]
            {
                "Potion of QuickHeal", "Potion of Healing Drops", "Potion of Superior Healing"
            };
        private Image[] _potionImages = new Image[]
            {
                PT4.Properties.Resources.potion1,
                PT4.Properties.Resources.potion2,
                PT4.Properties.Resources.potion3
            };

        //Junk name and image array
        //private string[] _junkNames = new string[]
        //    {
        //        "Transistor", "Pure Nail", "Hyper Blade"
        //    };
        //private Image[] _junkImages = new Image[]
        //    {
        //        PT4.Properties.Resources.weapon1,
        //        PT4.Properties.Resources.weapon2,
        //        PT4.Properties.Resources.weapon3
        //    };

        private string RandomizeName(string[] names)
        {
            return names[_rand.Next(0, names.Length)];
        }

        private Image RandomizeImage(Image[] images)
        {
            return images[_rand.Next(0, images.Length)];
        }
    }
}

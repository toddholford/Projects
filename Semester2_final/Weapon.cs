using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT4
{
    [Serializable]
    public class Weapon : Item
    {
        protected int _atk;

        public Weapon
            (
            Guid id,
            string name,
            int atk,
            Image img,
            bool natural,
            double weight,
            InventorySlotId slot,
            int goldValue) : base(id, name, img, natural, weight, slot, goldValue)
        {
            _atk = atk;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Attack: {ATK}";
        }

        public int ATK
        {
            get { return _atk; }
        }
    }
}

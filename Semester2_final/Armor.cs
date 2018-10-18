using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT4
{
    [Serializable]
    public class Armor : Item
    {
        protected int _def;

        public Armor
            (
            Guid id,
            string name,
            int def,
            Image img,
            bool natural,
            double weight,
            InventorySlotId slot,
            int goldValue) : base(id, name, img, natural, weight, slot, goldValue)
        {
            _def = def;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Defense: {DEF}";
        }

        public int DEF
        {
            get { return _def; }
        }
    }
}

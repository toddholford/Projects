using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT4
{
    [Serializable]
    public class Potion : Item
    {
        protected int _healValue;

        public Potion
            (
            Guid id,
            string name,
            int healValue,
            Image img,
            bool natural,
            double weight,
            InventorySlotId slot,
            int goldValue) : base(id, name, img, natural, weight, slot, goldValue)
        {
            _healValue = healValue;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Healing: {HealValue}";
        }

        public int HealValue
        {
            get { return _healValue; }
        }
    }
}

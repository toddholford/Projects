using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT4
{
    [Serializable]
    public class Junk : Item
    {
        public Junk
            (
            Guid id,
            string name,
            Image img,
            bool natural,
            double weight,
            InventorySlotId slot,
            int goldValue) : base(id, name, img, natural, weight, slot, goldValue)
        { }
        
    }
}

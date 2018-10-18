using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT4
{
    [Serializable]
    public class EquippedItems : IEnumerable<Item>
    {
        private Dictionary<InventorySlotId, Item> _item;

        public EquippedItems(Dictionary<InventorySlotId, Item> item)
        {
            
        }

        public void Equip(InventorySlotId slot, Item item)
        {
            Item oldItem = _item[slot];
            _item[slot] = item;
            _item.Add(slot, item);
        }

        public Item Unequip(InventorySlotId slot)
        {
            Item oldItem = _item[slot];
            _item[slot] = null;
            return oldItem;
        }

        public IEnumerator<Item> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //public Item this[InventorySlotId slot]
        //{
        //    _item[]
        //}

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT4
{
    [Serializable]
    public class Bag : IEnumerable<Item>
    {
        private List<Item> _items;
        private float _totalWeight;
        private float _maxWeight;

        public Bag(float maxWeight)
        {
            _items = new List<Item>();
            _totalWeight = 0;
            _maxWeight = maxWeight;
        }

        public void Add(Item item)
        {
            if (item == null) { throw new NullReferenceException(); }

            float itemWeight = (float)item.Weight;
            if (itemWeight + _totalWeight > _maxWeight)
            {
                throw new ArgumentException("There is no room");
            }
            else
            {
                _items.Add(item);
                _totalWeight += itemWeight;
            }
        }

        public Item RemoveAt(int index)
        {
            if (index >= 0)
            {
                Item removedItem = _items[index];
                _items.RemoveAt(index);
                _totalWeight -= (float)removedItem.Weight;
                return removedItem;
            }
            else
            {
                return null;
            }
        }

        public Item RemoveById(Guid id)
        {
            for (int i = 0; i < _items.Count; ++i)
            {
                if (id.Equals(_items[i].Id))
                {
                    return _items[i];
                }
            }
            return null;
        }

        public IEnumerator<Item> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        public int Count
        {
            get
            {
                return _items.Count;
            }
        }

        public float TotalWeight
        {
            get { return _totalWeight; }
        }

        public float MaxWeight
        {
            get { return _maxWeight; }
        }

        public Item this[int index]
        {
            get { return _items[index]; }
        }

    }
}

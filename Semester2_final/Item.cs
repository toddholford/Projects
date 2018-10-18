using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT4
{
    [Serializable]
    public abstract class Item
    {
        protected Guid _id;
        protected string _name;
        protected Image _image;
        protected bool _natural;
        protected double _weight;
        protected InventorySlotId _slot;
        protected int _goldValue;

        public Item(
            Guid id,
            string name,
            Image img,
            bool natural,
            double weight,
            InventorySlotId slot,
            int goldValue)
        {
            _id = id;
            _name = name;
            _image = img;
            _natural = natural;
            _weight = weight;
            _slot = slot;
            _goldValue = goldValue;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public Guid Id
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
        }

        public Image Image
        {
            get { return _image; }
        }

        public bool IsNatural
        {
            get { return _natural; }
        }

        public double Weight
        {
            get { return _weight; }
        }

        public InventorySlotId Slot
        {
            get { return _slot; }
        }

        public int GoldValue
        {
            get { return _goldValue; }
        }
    }
}

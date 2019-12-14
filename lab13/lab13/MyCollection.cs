using System;
using System.Collections.Generic;
using System.Text;
using MyLib;
namespace lab13
{
    class MyCollection : MyQueue<Transport>
    {
        public MyCollection() : base()
        { }
        public MyCollection(Transport nw) : base(nw) { }
        public MyCollection(Transport[] arr) : base(arr) { }

        public virtual bool Remove(int index)
        {
            int c = Count;
            RemoveAt(index);
            if (c > Count) return true;
            else return false;
        }

        public override void Add(Transport item)
        {
            base.Add(item);
        }
        public virtual void Add(Transport[] arr) //+
        {
            foreach (Transport it in arr)
            {
                base.Add(it);
            }
        }

        public virtual void AddDefault()//+
        {
            base.Add(new Transport());
        }
        public override Transport this[int index]
        {
            get
            {
                return base[index];
            }
            set
            {
                base[index] = value;
            }
        }
        
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

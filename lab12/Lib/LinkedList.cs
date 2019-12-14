using System;
using System.Collections;
using System.Text;
using MyLib;

namespace Lib
{
    public class MyLinkedList : IEnumerable, ICloneable
    {
        static Random rand = new Random();


        Transport data;
        MyLinkedList next = null;
        MyLinkedList prev = null;
        MyLinkedList first = null;
        MyLinkedList end = null;
        int count = 0;
        public MyLinkedList()
        {
            data = new Transport();
        }

        public MyLinkedList(Transport d)
        {
            if (d == null) throw new ArgumentNullException();

            data = d;
            count++;
        }

        public MyLinkedList(MyLinkedList c)
        {
            while (c != null)
            {
                MyLinkedList list = c;
                list.next = c.next;
                list.prev = c.prev;
                c = c.next;
                if (list.prev == null)
                    end = list;
                if (list.next == null)
                {
                    first = list;
                }
            }
        }

        public int Count => count;

        public MyLinkedList(int capacity)
        {
            if (capacity < 0) throw new Exception();
            int speed, countMen;
            for (int i = 0; i < capacity; i++)
            {

                speed = rand.Next(1, 800);
                countMen = rand.Next(3, 1000);

                Add(new Transport(speed, countMen));
            }
        }

        public int Add(Transport d)
        {
            MyLinkedList nw = new MyLinkedList(d);
            if (first == null)
            {
                first = nw;
            }
            else
            {
                nw.next = end;
                end.prev = nw;
            }
            end = nw;
            count++;
            return (count - 1);
        }

        public Transport this[int index]
        {
            get
            {
                if (index < 0 || index >= count) throw new IndexOutOfRangeException();
                MyLinkedList cur = end;
                for (int i = 0; i < index; i++)
                {
                    cur = cur.next;
                }
                return cur.data;
            }
            set
            {
                if (value == null) throw new ArgumentNullException();
                if (index < 0 || index >= count) throw new IndexOutOfRangeException();
                MyLinkedList cur = end;
                for (int i = 0; i < index; i++)
                {
                    cur = cur.next;
                }
                cur.data = value;
            }
        }

        public int Contains(Transport value)
        {
            if (value == null) throw new Exception();
            int i = 0;
            foreach (Transport it in this)
            {
                if (value.Equals(it)) return i;
                i++;
            }
            return -1;
        }

        public void CopyTo(Array array, int index)
        {
            if (index < count)
            {
                int k = index;
                foreach (Transport it in this)
                {
                    array.SetValue(it, k);
                    k++;
                }
            }
            else throw new IndexOutOfRangeException();
        }

        public void Clear()
        {
            first = null;
            end = null;
            count = 0;
        }

        public void Insert(int index, Transport value)
        {
            if (index < 0 || index >= count) throw new IndexOutOfRangeException();
            if (value == null) throw new Exception();
            if (index == 0)
            {
                Add(value);
                return;
            }
            MyLinkedList cur = end;
            for (int i = 0; i < index - 1; i++)
            {
                cur = cur.next;
            }
            MyLinkedList p = new MyLinkedList(value);
            p.next = cur.next;
            p.prev = cur;
            cur.next = p;
            count++;
        }

        public void Remove(Transport value)
        {
            if (value == null) throw new Exception();
            if (count == 1 && data.Equals(value))
            {
                Clear();
                return;
            }
            MyLinkedList cur = end;
            if (cur.data.Equals(value))
            {
                end = end.next;
                end.prev = null;
                count--;
                return;
            }
            while (cur.next != null)
            {
                if (cur != null)
                    if (cur.data.Equals(value))
                    {
                        cur.next.prev = cur.prev;
                        cur.prev.next = cur.next;
                        count--;
                        return;
                    }
                cur = cur.next;
            }
            if (cur.data.Equals(value))
            {
                cur.prev.next = null;
                count--;
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count) throw new IndexOutOfRangeException();

            if (index == 0)
            {
                end = end.next;
                count--;
                return;
            }
            MyLinkedList cur = end;
            while (cur.next != null)
            {
                cur = cur.next;
            }
            if (cur.next != null)
            {
                cur.next.prev = cur.prev;
                cur.prev.next = cur.next;
            }
            else
            {
                cur.prev.next = null;
            }
            count--;

            if (index == count - 1)
            {
                first = cur;
            }

        }

        public void RemoveSeveralEl()
        {
            MyLinkedList cur = end;
            while (cur != null)
            {
                if (cur.data.Speed % 2 == 0)
                {
                    Remove(cur.data);
                }
                cur = cur.next;
            }
        }


        public override string ToString()
        {
            MyLinkedList cur = end;
            string s = "";
            while (cur != null)
            {
                s += cur.data + "\n";
                cur = cur.next;
            }
            return s;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is MyLinkedList)) throw new TypeAccessException();
            if (obj == null) throw new ArgumentNullException();

            MyLinkedList o = obj as MyLinkedList;
            MyLinkedList cur = end;
            foreach (MyLinkedList it in cur)
            {
                if (!o.data.Equals(cur.data)) return false;
                o = o.next;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public IEnumerator GetEnumerator()
        {
            MyLinkedList cur = end;
            while (cur != null)
            {
                yield return cur.data;
                cur = cur.next;
            }
        }

        public object Clone()
        {
            return new MyLinkedList(this);
        }
    }
}

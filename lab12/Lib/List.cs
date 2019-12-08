using System;
using MyLib;
using System.Collections; // для интерфейса

namespace Lib
{
    public class MyList : IList, ICloneable
    {
        static Random rand = new Random();
        Transport data;
        MyList next = null;
        MyList first = null;
        MyList end = null;
        int count = 0;

        public MyList()
        {
            data = new Transport();
        }
        public MyList(object value)
        {
            if (value is Transport)
            {
                if (value != null)
                {
                    data = value as Transport;
                    count++;
                }
                else throw new ArgumentNullException();
            }
            else
            {
                throw new TypeAccessException();
            }
        }

        public MyList(int capacity)
        {
            if (capacity >= 0)
            {
                for (int i = 0; i < capacity; i++)
                {
                    int speed = rand.Next(1, 800);
                    int countMen = rand.Next(3, 1000);

                    Add(new Transport(speed, countMen));
                }
            }
            else
                throw new Exception();
        }

        public object this[int index]
        {
            get
            {
                if (index < count && index >= 0)
                {
                    MyList cur = end;
                    for (int i = 0; i < index; i++)
                    {
                        cur = cur.next;
                    }
                    return cur.data;
                }
                else throw new IndexOutOfRangeException();
            }
            set
            {

                if (value is Transport)
                {
                    data = (Transport)value;
                }
                else
                {
                    throw new TypeAccessException("Invalid type value");
                }
            }
        }

        public bool IsFixedSize => true;

        public bool IsReadOnly => false;

        public int Count => count;

        public bool IsSynchronized => false;

        public object SyncRoot => data;

        public int Add(object value)
        {
            if (value is Transport)
            {
                if (value == null) throw new ArgumentNullException();
                MyList item = new MyList(value);
                if (first == null)
                {
                    first = item;
                }
                else
                {
                    item.next = end;
                }
                end = item;
                count++;

                return (count - 1);
            }
            else
            {
                throw new TypeAccessException();
            }
        }

        public void Clear()
        {
            first = null;
            end = null;
            count = 0;
        }

        public bool Contains(object value)
        {
            if (value is Transport)
            {
                if (value == null) throw new Exception();
                Transport cur = value as Transport;
                foreach (Transport it in this)
                {
                    if (cur.Equals(it)) return true;
                }
                return false;
            }
            else
            {
                throw new TypeAccessException();
            }
        }

        public void CopyTo(Array array, int index)
        {
            if (index < count)
            {
                int k = index;
                foreach (Transport it in this)
                {
                    array.SetValue((object)it, k);
                    k++;
                }
            }
            else throw new IndexOutOfRangeException();
        }

        public IEnumerator GetEnumerator()
        {
            MyList cur = end;
            while (cur != null)
            {
                yield return cur.data;
                cur = cur.next;
            }
        }

        public int IndexOf(object value)
        {
            if (value is Transport)
            {
                if (value == null) throw new Exception();
                if (Contains(value))
                {
                    int cris = 0;
                    MyList cur = end;
                    for (int i = 0; i < count; i++)
                    {
                        if (cur.data.Equals(value))
                        {
                            cris = i;
                            break;
                        }
                        cur = cur.next;
                    }
                    return cris;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                throw new TypeAccessException();
            }
        }

        public void Insert(int index, object value)
        {
            if (!(value is Transport)) throw new TypeAccessException();
            if (index < 0 || index >= count) throw new IndexOutOfRangeException();
            if (value == null) throw new Exception();
            if (index == 0)
            {
                Add(value);
                return;
            }
            MyList cur = end;
            for (int i = 0; i < index - 1; i++)
            {
                cur = cur.next;
            }
            MyList p = new MyList(value);
            p.next = cur.next;
            cur.next = p;
            count++;
        }

        public void Remove(object value)
        {
            if (!(value is Transport)) throw new TypeAccessException();
            if (value == null) throw new Exception();
            if (count == 1 && data.Equals(value))
            {
                Clear();
                return;
            }
            MyList cur = end;
            if (cur.data.Equals(value))
            {
                end = end.next;
                count--;
                return;
            }
            for (int i = 0; i < count; i++)
            {
                if (cur.next != null)
                    if (cur.next.data.Equals(value))
                    {
                        cur.next = cur.next.next;
                        count--;
                        break;
                    }
                cur = cur.next;
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
            MyList cur = end;
            for (int i = 0; i < index - 1; i++)
            {
                cur = cur.next;
            }
            cur.next = cur.next.next;
            if (index == count - 1)
            {
                first = cur;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is MyList)) throw new TypeAccessException();
            if (obj == null) throw new ArgumentNullException();
            MyList cur = end;
            MyList o = obj as MyList;
            if (count != o.count) return false;
            foreach (Transport it in o)
            {
                if (!it.Equals(cur.data)) return false;
                cur = cur.next;
            }
            return true;
        }

        public override string ToString()
        {
            MyList cur = end;
            string s = "";
            while (cur != null)
            {
                s += cur.data + "\n";
                cur = cur.next;
            }
            return s;
        }

        public object Clone()
        {
            MyList nw = new MyList();
            nw.Clear();
            MyList k = end;
            foreach (MyList it in k)
            {
                nw.Add(it);
            }
            return nw;
        }
    }
}

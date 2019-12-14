using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using MyLib;

namespace Lib
{
    class ComparerQueue : IComparer<Transport>
    {
        public int Compare(Transport x, Transport y)
        {
            if (x.Speed.CompareTo(y.Speed) != 0)
            {
                return x.Speed.CompareTo(y.Speed);
            }
            else if (x.CountMen.CompareTo(y.CountMen) != 0)
            {
                return x.CountMen.CompareTo(y.CountMen);
            }
            else
            {
                return 0;
            }
        }
    }
    public class MyQueue<T> : IList<T>, ICloneable, IComparable<T>
    {
        T data;
        MyQueue<T> next;
        MyQueue<T> begin = null;
        MyQueue<T> end = null;
        int count = 0;
        public MyQueue()
        { count = 0; }
        public MyQueue(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Add(array[i]);
            }
        }
        public MyQueue(T obj)
        {
            Add(obj);
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count) throw new IndexOutOfRangeException("Введенный индекс вне границ очереди!");
                int i = 0; MyQueue<T> cur = end;
                while (i < count - index - 1) { cur = cur.next; i++; }
                return cur.data;
            }
            set
            {
                if (index < 0 || index >= Count) throw new IndexOutOfRangeException("Введенный индекс вне границ очереди!");
                if (value == null) throw new ArgumentNullException("Попытка ввода пустого элемента");
                int i = 0; MyQueue<T> cur = end;
                while (i <= count - index - 1) cur = cur.next;
                cur.data = value;
            }
        }

        public int Count => count;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            if (item == null) throw new ArgumentNullException("Попытка ввода пустого элемента");
            if (end == null)
            {
                MyQueue<T> cur = new MyQueue<T>();
                cur.data = item;
                end = cur;
                begin = end;
                count++;
                return;
            }
            else
            {
                MyQueue<T> nwE = new MyQueue<T>();
                nwE.data = item;
                nwE.next = end;
                end = nwE;
                count++;
            }
        }

        public void Clear()
        {
            end = null;
            begin = null;
            count = 0;
        }

        public bool Contains(T item)
        {
            foreach (T it in this)
            {
                if (it.Equals(item)) return true;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null) throw new ArgumentException("Пустой массив!");
            MyQueue<T> cur = end;
            for (int i = arrayIndex; i < array.Length; i++)
            {
                array[i] = cur.data;
                cur = cur.next;
            }
        }

        public int IndexOf(T item)
        {
            if (item == null) throw new ArgumentNullException("Элемент пуст");
            MyQueue<T> cur = this.end;
            int index = Count;
            while (cur != null)
            {
                if (cur.data.Equals(item)) { index--; return index; }
                index--;
                cur = cur.next;
            }
            return -1;  // если не найден
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > Count) throw new Exception($"Индекс должен быть меньше {Count}..");
            if (index == 0)
            {
                MyQueue<T> cur = new MyQueue<T>();
                cur.data = item;
                cur.next = null;
                begin.next = cur;
                begin = cur;
                count++;
            }
            else
            {
                if (index == Count)
                {
                    Add(item);
                    return;
                }
                MyQueue<T> cur = end;
                for (int i = 0; i < count - index - 1; i++)
                {
                    cur = cur.next;
                }
                MyQueue<T> nwE = new MyQueue<T>();
                nwE.data = item;
                nwE.next = cur.next;
                cur.next = nwE;
                count++;
            }
        }

        public bool Remove(T item)
        {
            if (count == 1 && end.data.Equals(item))
            {
                Clear();
                return true;
            }
            if (item == null) throw new Exception("Невозможно удалить пустой элемент");
            int index = IndexOf(item);
            if (index == -1) return false;
            if (index == count - 1 && end.data.Equals(item))
            {
                end = end.next;
                return true;
            }
            MyQueue<T> cur = end;
            for (int i = 0; i < count - index; i++)
            {
                if (cur.next.data.Equals(item))
                {
                    if (cur.next == begin)
                    {
                        cur.next = null;
                        begin = cur;
                        count--;
                        return true;
                    }
                    cur.next = cur.next.next;

                    count--;
                    return true;
                }

                cur = cur.next;
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            Remove(this[index]);
        }

        public void Pop()
        {
            RemoveAt(0);
        }

        // метод интерфейса IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            MyQueue<T> ts = end;
            while (ts != null)
            {
                yield return ts.data;
                ts = ts.next;
            }
        }

        // метод интерфейса IEnumerable<T>, который наследуется от интерфейса IEnumerable
        public IEnumerator<T> GetEnumerator()
        {
            MyQueue<T> cur = end;
            while (cur != null)
            {
                yield return cur.data;
                cur = cur.next;
            }
        }

        public object Clone()
        {
            if (end == null) return null;
            MyQueue<T> cur = end;
            MyQueue<T> copy = new MyQueue<T>();
            foreach (T it in cur)
            {
                copy.Add(it);
            }
            return copy;
        }

        public int CompareTo(T other)
        {
            if (data.Equals(other))
            {
                return 0;
            }
            else if (data.GetHashCode() < other.GetHashCode())
                return -1;
            else
            {
                return 1;
            }
        }

        public override string ToString()
        {
            string s = "";
            foreach (T it in this)
            {
                s += it + "\n";
            }
            return s;
        }
    }
}

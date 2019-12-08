using System;
using System.Collections;
using MyLib;

namespace Lib
{
    // неполучившийся нумератор для дерева
    //class MyTreeEnumerator : IEnumerator
    //{
    //    Transport Transport;
    //    Data left;
    //    Data right;

    //    Data root;
    //    Data pos;
    //    static bool f = false;
    //    static bool add;
    //    public MyTreeEnumerator(Data root)
    //    {
    //        this.root = root;
    //        pos = root;
    //        Transport = root.data;
    //        left = root.left;
    //        right = root.right;
    //    }

    //    public object Current
    //    {
    //        get
    //        {
    //            if (add)
    //            {
    //                add = false;
    //                f = false;
    //                return pos.data;
    //            }
    //            else
    //            {
    //                return null;
    //            }
    //        }
    //    }

    //    bool Move(Data t)
    //    {
    //        bool flag = false;
    //        if (t.left != null && !f)
    //        {
    //            flag = Move(t.left);
    //            flag = true;
    //            f = true;
    //            if (t.right != null && !f)
    //            {
    //                Move(t.right);
    //                flag = true;
    //                f = true;
    //            }
    //        }
    //        else
    //        {
    //            if (t.right != null && !f)
    //            {
    //                Move(t.right);
    //                flag = true;
    //                f = true;
    //            }
    //        }
    //        return flag;
    //    }
    //    public bool MoveNext()
    //    {
    //        add = Move(pos);
    //        return add;
    //    }

    //    public void Reset()
    //    {
    //        pos = root;
    //    }
    //}

    class Data
    {
        public Transport data;
        public Data left;
        public Data right;
        public static int count = 0;
    }
    public class MyTree //: IEnumerable // для перебора foreach
    {
        static Random rand = new Random();
        Data main = null;

        #region Recurcy function
        int GetLevelRecurcy(Data cur)
        {
            int h = 0;
            if (cur != null)
            {
                int lft, rgt;
                lft = GetLevelRecurcy(cur.left);
                rgt = GetLevelRecurcy(cur.right);
                int maxLevel = (lft > rgt) ? lft : rgt;
                h = maxLevel + 1;
            }
            return h;
        }
        int GetFactor(Data t)
        {
            int l = GetLevelRecurcy(t.left);
            int r = GetLevelRecurcy(t.right);

            int factor = l - r;
            return factor;
        }

        #region Balance
        Data LeftLeftRotation(Data t)
        {
            Data tmp = t.left;
            if (tmp != null)
            {
                t.left = tmp.right;
                tmp.right = t;
            }
            else
            {
                tmp = RightRightRotation(t);
            }

            return tmp;
        }
        Data RightRightRotation(Data t)
        {
            Data tmp = t.right;
            if (tmp != null)
            {
                t.right = tmp.left;
                tmp.left = t;
            }
            else
            {
                tmp = LeftLeftRotation(t);
            }
            return tmp;
        }
        Data LeftRightRotation(Data t)
        {
            Data tmp = t.left;
            t.left = RightRightRotation(tmp);
            return LeftLeftRotation(t);
        }
        Data RightLeftRotation(Data t)
        {
            Data tmp = t.right;
            t.right = LeftLeftRotation(tmp);
            return RightRightRotation(t);
        }
        Data Balanse(Data t)
        {
            int factor = GetFactor(t);
            if (factor > 1)
            {
                if (GetLevelRecurcy(t.left) > 0)
                {
                    t = LeftLeftRotation(t);
                }
                else
                {
                    t = LeftRightRotation(t);
                }
            }
            else
            {
                if (factor < -1)
                {
                    if (GetLevelRecurcy(t.right) > 0)
                    {
                        t = RightLeftRotation(t);
                    }
                    else
                    {
                        t = RightRightRotation(t);
                    }
                }
            }
            return t;
        }
        #endregion
        Data Insert(Data t, Transport Transport)
        {

            if (t == null)
            {
                t = new Data();
                t.data = Transport;
            }
            else
            if (t.data.GetName[0] > Transport.GetName[0] ||
                (t.data.GetMagazineCost > Transport.GetMagazineCost &&
                t.data.GetName[0] == Transport.GetName[0]))
            {

                Data cris = Insert(t.left, Transport);
                t.left = cris;
                t = Balanse(t);
            }
            else
            if (t.data.GetName[0] < Transport.GetName[0] ||
                (t.data.GetMagazineCost < Transport.GetMagazineCost &&
                t.data.GetName[0] == Transport.GetName[0]))
            {
                Data cris = Insert(t.right, Transport);
                t.right = cris;
                t = Balanse(t);
            }
            return t;
        }

        Transport SearchCharBeginNameRecurcy(char liter, Data cur)
        {
            Transport c = null;
            if (cur != null)
            {
                if (cur.data.GetName[0] == liter)
                {
                    return cur.data;
                }
                else
                if (cur.data.GetName[0] > liter)
                {
                    c = SearchCharBeginNameRecurcy(liter, cur.left);
                }
                else
                {
                    c = SearchCharBeginNameRecurcy(liter, cur.right);
                }
            }
            return c;
        }

        string Show(Data t, string s, int level = 0)
        {
            if (t != null)
            {
                s = Show(t.left, s, level + 5);
                s += t.data.ShowMyTree(level) + "\n";
                s = Show(t.right, s, level + 5);
            }
            return s;
        }

        bool EqualsRecurcy(Data t, Data obj, bool flag = true)
        {
            if (!flag) return flag;
            if (t.left != null && obj.left != null) flag = EqualsRecurcy(t.left, obj.left, flag);
            else return false;
            if (t.right != null && obj.right != null) flag = EqualsRecurcy(t.right, obj.right, flag);
            else return false;

            if (t.data.Equals(obj.data)) return true;
            else return false;
        }

        #endregion

        public MyTree() { }
        public MyTree(Transport sproot)
        {
            if (sproot == null) throw new ArgumentNullException();
            main = new Data();
            main.data = sproot;
            Data.count++;
        }
        public MyTree(Transport[] arr)
        {
            int c = arr.Length;
            for (int i = 0; i < c; i++)
            {
                AddElement(arr[i]);
            }
        }
        public MyTree(int capacity)
        {
            
            for (int i = 0; i < capacity; i++)
            {
                int speed = rand.Next(1, 800);
                int countMen = rand.Next(3, 1000);

                AddElement(new Transport(speed, countMen));
            }
        }

        #region Public function

        public void AddElement(Transport sproot)
        {
            //AddElementRecurcy(this, sproot);
            if (main == null)
            {
                main = new Data();
                main.data = sproot;
                Data.count++;
                return;
            }
            Data.count++;
            main = Insert(main, sproot);
        }

        // перемещение по дереву, раскомментировать на свой страх и риск))
        //public UMyTree GetRoot => root;
        //public UMyTree GetLeft => left;
        //public UMyTree GetRight => right;

        public Transport SearchCharBeginName(char liter) => SearchCharBeginNameRecurcy(liter, main);
        public int GetCount => Data.count;
        public void Clear()
        {
            main = null;
            Data.count = 0;
        }
        //public Transport this[int index]
        //{
        //    get
        //    {
        //        if (index < 0 || index >= count) throw new ArgumentOutOfRangeException();
        //        GetElementRecurcy(this, 0, index);
        //        return indexTransport;
        //    }
        //}

        //public void CopyTo(Array array, int index)
        //{
        //    try
        //    {
        //        for (int i = 0; i < count; i++)
        //        {
        //            array.SetValue(this[i], index);
        //            index++;
        //        }
        //    }
        //    catch
        //    {
        //        return;
        //    }
        //}

        //public MyTree GetBalancedSearhMyTree()
        //{
        //    Transport[] arr = new Transport[count];
        //    CopyTo(arr, 0);
        //    Array.Sort(arr);
        //    return new MyTree(arr);
        //}
        public override bool Equals(object o)
        {
            if (o is MyTree)
            {
                MyTree obj = o as MyTree;
                if (GetLevelRecurcy(main) != obj.GetLevelRecurcy(obj.main)) return false;
                return EqualsRecurcy(main, obj.main);
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            string s = "";
            s = Show(main, s);
            return s;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}


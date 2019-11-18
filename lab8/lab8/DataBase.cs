using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using Newtonsoft.Json;

//В типизированном файле хранится информация об автобусах, находящихся в автобусном парке
//(номер маршрута, ФИО водителя, номер автобуса, состояние автобуса 
//(в парке или на маршруте)). Программа должна
//a. Добавлять, удалять, корректировать, позволять просматривать записи файла.
//b.Выводить:
//i.информацию о водителе по шаблону (2 первые буквы фамилии);
//ii.список водителей автобусов, находящихся на маршруте.
namespace lab8
{
    public class Bus
    {

        public string NumberRoute { get; set; }
        public string NameDriver { get; set; }
        public string NameBus { get; set; }
        public bool Where { get; set; }//0-in the park, 1 - in the route
        public Bus(string numberRoute, string nameDriver, string nameBus, bool where)
        {
            NumberRoute = numberRoute;
            NameDriver = nameDriver;
            NameBus = nameBus;
            Where = where;
        }
    }
    public class DataBase
    {
        public Bus[] List;
        Random rnd = new Random();

        public DataBase(int size = 0)
        {
            List = new Bus[size];
        }

        public void AddBus(string numberRoute, string nameDriver, string nameBus, bool where)
        {
            Bus newElement = new Bus(numberRoute, nameDriver, nameBus, where);
            Array.Resize(ref List, List.Length + 1);
            List[List.Length - 1] = newElement;
        }
        public void AddBus(Bus newElement)
        {
            Array.Resize(ref List, List.Length + 1);
            List[List.Length - 1] = newElement;
        }

        private Bus[] add(string numberRoute, string nameDriver, string nameBus, bool where)
        {

            Bus[] newList = new Bus[List.Length + 1];
            for (int i = 0; i < List.Length; i++)
            {
                newList[i] = List[i];
            }
            List = newList;
            return List;
        }
        public int Length()
        {
            return List.Length;
        }

        public Bus[] getList()
        {
            return List;
        }
        public bool Empty()
        {
            if (List != null)
                return List.Length != 0;
            else return false;
        }
        public void Clear()
        {
            Array.Clear(List, 0, List.Length);
        }

        public void SortOfNumberRoure()
        {
            Bus temp;
            for (int i = 0; i < List.Length - 1; i++)
            {
                for (int j = i + 1; j < List.Length; j++)
                {
                    int a = Int32.Parse(List[i].NumberRoute);
                    int b = Int32.Parse(List[j].NumberRoute);
                    if (a > b)
                    {
                        temp = List[i];
                        List[i] = List[j];
                        List[j] = temp;
                    }
                }
            }
        }
        public void SortOfNameDriver()
        {
            for (int i = 0; i < List.Length; i++)
            {
                for (int j = 0; j < List.Length - 1; j++)
                {
                    if (needToReOrder(List[j].NameDriver, List[j + 1].NameDriver))
                    {
                        Bus s = List[j];
                        List[j] = List[j + 1];
                        List[j + 1] = s;
                    }
                }
            }
        }
        public void SortOfNameBus()
        {
            for (int i = 0; i < List.Length; i++)
            {
                for (int j = 0; j < List.Length - 1; j++)
                {
                    if (needToReOrder(List[j].NameBus, List[j + 1].NameBus))
                    {
                        Bus s = List[j];
                        List[j] = List[j + 1];
                        List[j + 1] = s;
                    }
                }
            }
        }
        private bool needToReOrder(string s1, string s2)
        {
            for (int i = 0; i < (s1.Length > s2.Length ? s2.Length : s1.Length); i++)
            {
                if (s1.ToCharArray()[i] < s2.ToCharArray()[i]) return false;
                if (s1.ToCharArray()[i] > s2.ToCharArray()[i]) return true;
            }
            return false;
        }
        

        public bool Search(string el)
        {
            bool ok = false;
            for (int i = 0; i < List.Length; i++)
            {
                if (List[i].NameBus == el)
                {
                    ok = true;
                    return ok;
                }
            }
            return ok;
        }
        public bool Search2(string el)
        {
            int q = 0;
            for (int i = 0; i < List.Length; i++)
            {
                if (List[i].NameBus == el)
                {
                    q++;
                }
                if (q >= 2)
                {
                    return true;
                }
            }
            return false;
        }
        private int searchDel(string input)
        {
            for (int i = 0; i < List.Length; i++)
            {
                if (List[i].NameBus == input)
                {
                    List[i].NameBus = "-DELETED";
                    return i;
                }
            }
            return -1;
        }
        public int DeleteEl(string input)
        {
            Bus[] newList = new Bus[List.Length - 1];
            int ok = searchDel(input);
            if (ok != -1)
            {
                for (int i = 0; i < ok; i++)
                {
                    newList[i] = List[i];
                }
                for (int i = ok; i < newList.Length; i++)
                {
                    newList[i] = List[i + 1];
                }
                List = newList;
            }

            return ok;
        }
        public void DeleteRepeat()
        {
            Bus[] newList;
            newList = List.Distinct().ToArray();
            List = newList;
        }
        public int GetLength()
        {
            return List.Length;
        }
        public Bus this[int i]
        {
            get { return List[i]; }
            set { List[i] = value; }
        }
    }
}

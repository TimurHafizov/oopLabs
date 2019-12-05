using System;
using System.Collections.Generic;
using System.Text;
using MyLib;
using CheckerInputConsole;
using System.Diagnostics;

namespace lab11
{
    
    class TestCollection
    {
        static Random rand = new Random();

        LinkedList<Transport> Transports = new LinkedList<Transport>();
        LinkedList<string> vs = new LinkedList<string>();
        Dictionary<Transport, Avtomobile> keyValues = new Dictionary<Transport, Avtomobile>();
        Dictionary<string, Avtomobile> stringValues = new Dictionary<string, Avtomobile>();

        static string[] bodyTypes = { "Cедан", "Минивэн", "Лимузин", "Хардтоп", "Кабриолет" };

        public TestCollection(int size = 0, int generation = 1)
        {
            for (int i = 0; i < size; i++)
            {
                string bodyType = bodyTypes[rand.Next(0, 4)];
                int speed = rand.Next(0, 400);
                int countMen = rand.Next(1, 1000);

                if (generation != 1)
                {
                    Console.WriteLine("Тип кузова: ");
                    bodyType = Console.ReadLine();
                    Console.WriteLine("Скорость: ");
                    speed = Input.IntCheckConsole();
                    Console.WriteLine("Количество пассажиров: ");
                    countMen = Input.IntCheckConsole();
                }
                Avtomobile t = new Avtomobile(bodyType, speed, countMen);

                Transports.AddLast(t.BaseTransport());//двусвязный список транспорта
                vs.AddLast(t.BaseTransport().ToString());//двусвязный список строк
                keyValues.Add(Transports.Last.Value, t);//словарь транспорт автомобиль
                stringValues.Add(vs.Last.Value, t);//словарь строка автомобиль
            }
        }

        #region Test Method "Contain" on linked list

        public long[] TCollLinkListProd()
        {
            Output.ShowGreen("Тест метода Contains по двунаправленному списку <Transport>");
            Transport first, center, last, empty;
            long[] vs = new long[4];//массив времени
            first = Transports.First.Value;
            var k = Transports.First;
            for (int i = 0; i < Transports.Count / 2; i++)
            {
                k = Transports.First.Next;
            }
            center = k.Value;//центральный элемент
            last = Transports.Last.Value;//последний элемент
            empty = new Transport();
            Stopwatch t1 = new Stopwatch();
            t1.Start();
            if (Transports.Contains(first))
            {
                Console.WriteLine();
            }
            t1.Stop();
            vs[0] = t1.ElapsedTicks;
            Output.ShowGreen(t1.ElapsedTicks + " ticks -- Время нахождения первого элемента.");

            t1.Restart();
            if (Transports.Contains(center))
            {
                Console.WriteLine();
            }
            t1.Stop();
            vs[1] = t1.ElapsedTicks;
            Output.ShowGreen(t1.ElapsedTicks + " ticks -- Время нахождения серединного элемента.");

            t1.Restart();
            if (Transports.Contains(last))
            {
                Console.WriteLine();
            }
            t1.Stop();
            vs[2] = t1.ElapsedTicks;
            Output.ShowGreen(t1.ElapsedTicks + " ticks -- Время нахождения последнего элемента.");

            t1.Restart();
            if (!Transports.Contains(empty))
            {
                Console.WriteLine();
            }
            t1.Stop();
            vs[3] = t1.ElapsedTicks;
            Output.ShowGreen(t1.ElapsedTicks + " ticks -- Время нахождения несуществующего элемента.");

            return vs;
        }

        public long[] TCollLinkListString()
        {
            Output.ShowGreen("Тест метода Contains по двунаправленному списку <string>");
            string first, center, last, empty;
            long[] arr = new long[4];
            first = vs.First.Value;
            var k = vs.First;
            for (int i = 0; i < vs.Count / 2; i++)
            {
                k = vs.First.Next;
            }
            center = k.Value;
            last = vs.Last.Value;
            empty = "несуществующий элемент";
            Stopwatch t1 = new Stopwatch();
            t1.Start();
            if (vs.Contains(first))
            {
                Console.WriteLine();
            }
            t1.Stop();
            arr[0] = t1.ElapsedTicks;
            Output.ShowGreen(t1.ElapsedTicks + " ticks -- Время нахождения первого элемента.");

            t1.Restart();
            if (vs.Contains(center))
            {
                Console.WriteLine();
            }
            t1.Stop();
            arr[1] = t1.ElapsedTicks;
            Output.ShowGreen(t1.ElapsedTicks + " ticks -- Время нахождения серединного элемента.");

            t1.Restart();
            if (vs.Contains(last))
            {
                Console.WriteLine();
            }
            t1.Stop();
            arr[2] = t1.ElapsedTicks;
            Output.ShowGreen(t1.ElapsedTicks + " ticks -- Время нахождения последнего элемента.");

            t1.Restart();
            if (!vs.Contains(empty))
            {
                Console.WriteLine();
            }
            t1.Stop();
            arr[3] = t1.ElapsedTicks;
            Output.ShowGreen(t1.ElapsedTicks + " ticks -- Время нахождения несуществующего элемента.");

            Console.WriteLine();

            return arr;
        }
        #endregion

        #region Test Method "ContainKey" in Dictionary 
        public long[] TCollDictProdAvtomobileKey()
        {
            Output.ShowGreen("Тест метода ContainKey по словарю <Transport,Avtomobile>");
            Transport first = new Transport(11, 11), center = new Transport(12, 12), last = new Transport(13, 13), empty;
            long[] vs = new long[4];
            int k = 0;
            foreach (var item in keyValues)
            {
                if (k == 0)
                {
                    first = item.Key;
                }
                if (k == keyValues.Count / 2 - 1)
                {
                    center = item.Key;
                }
                if (k == keyValues.Count - 1)
                {
                    last = item.Key;
                }
                k++;
            }
            empty = new Transport();

            Stopwatch t2 = new Stopwatch();
            t2.Start();
            if (keyValues.ContainsKey(first))
            {
                Console.WriteLine();
            }
            t2.Stop();
            vs[0] = t2.ElapsedTicks;
            Output.ShowGreen(t2.ElapsedTicks + " ticks -- время поиска в словаре первого элемента");

            t2.Restart();
            if (keyValues.ContainsKey(center))
            {
                Console.WriteLine();
            }
            t2.Stop();
            vs[1] = t2.ElapsedTicks;
            Output.ShowGreen(t2.ElapsedTicks + " ticks -- время поиска в словаре cрединного элемента");

            t2.Restart();
            if (keyValues.ContainsKey(last))
            {
                Console.WriteLine();
            }
            t2.Stop();
            vs[2] = t2.ElapsedTicks;
            Output.ShowGreen(t2.ElapsedTicks + " ticks -- время поиска в словаре последнего элемента");

            t2.Restart();
            if (!keyValues.ContainsKey(empty))
            {
                Console.WriteLine();
            }
            t2.Stop();
            vs[3] = t2.ElapsedTicks;
            Output.ShowGreen(t2.ElapsedTicks + " ticks -- время поиска в словаре несуществующего элемента");

            return vs;
        }

        public long[] TCollDictStringAvtomobileKey()
        {
            Output.ShowGreen("Тест метода ContainKey по словарю <Transport,Avtomobile>");
            string first = "", center = "", last = "", empty;
            long[] vs = new long[4];
            int k = 0;
            foreach (var item in stringValues)
            {
                if (k == 0)
                {
                    first = item.Key;
                }
                if (k == keyValues.Count / 2 - 1)
                {
                    center = item.Key;
                }
                if (k == keyValues.Count - 1)
                {
                    last = item.Key;
                }
                k++;
            }
            empty = "empty contains";

            Stopwatch t2 = new Stopwatch();
            t2.Start();
            if (stringValues.ContainsKey(first))
            {
                Console.WriteLine();
            }
            t2.Stop();
            vs[0] = t2.ElapsedTicks;
            Output.ShowGreen(t2.ElapsedTicks + " ticks -- время поиска в словаре первого элемента");

            t2.Restart();
            if (stringValues.ContainsKey(center))
            {
                Console.WriteLine();
            }
            t2.Stop();
            vs[1] = t2.ElapsedTicks;
            Output.ShowGreen(t2.ElapsedTicks + " ticks -- время поиска в словаре срединного элемента");

            t2.Restart();
            if (stringValues.ContainsKey(last))
            {
                Console.WriteLine();
            }
            t2.Stop();
            vs[2] = t2.ElapsedTicks;
            Output.ShowGreen(t2.ElapsedTicks + " ticks -- время поиска в словаре последнего элемента");

            t2.Restart();
            if (!stringValues.ContainsKey(empty))
            {
                Console.WriteLine();
            }
            t2.Stop();
            vs[3] = t2.ElapsedTicks;
            Output.ShowGreen(t2.ElapsedTicks + " ticks -- время поиска в словаре несуществующего элемента");

            return vs;
        }


        #endregion

        #region Test Method "ContainsValue" in Dictionary

        public long[] TCollDictProdAvtomobileValue()
        {
            Output.ShowGreen("Тест метода ConstainsValue для коллкекции с типами <Transport, Avtomobile>");
            Avtomobile first = new Avtomobile("Седан"),
                center = new Avtomobile("Кабриолет"),
                last = new Avtomobile("Лимузин"),
                empty = new Avtomobile();
            long[] vs = new long[4];
            int k = 0;
            foreach (var i in keyValues)
            {
                if (k == 0)
                {
                    first = i.Value;
                }
                if (k == keyValues.Count / 2 - 1)
                {
                    center = i.Value;
                }
                if (k == keyValues.Count - 1)
                {
                    last = i.Value;
                }
                k++;
            }
            Stopwatch t3 = new Stopwatch();
            t3.Start();
            if (keyValues.ContainsValue(first))
            {
                Console.WriteLine();
            }
            t3.Stop();
            vs[0] = t3.ElapsedTicks;
            Output.ShowGreen(t3.ElapsedTicks + " ticks -- Время поиска первого элемента");

            t3.Restart();
            if (keyValues.ContainsValue(center))
            {
                Console.WriteLine();
            }
            t3.Stop();
            vs[1] = t3.ElapsedTicks;
            Output.ShowGreen(t3.ElapsedTicks + " ticks -- Время поиска срединного элемента");

            t3.Restart();
            if (keyValues.ContainsValue(last))
            {
                Console.WriteLine();
            }
            t3.Stop();
            vs[2] = t3.ElapsedTicks;
            Output.ShowGreen(t3.ElapsedTicks + " ticks -- Время поиска последнего элемента");

            t3.Restart();
            if (!keyValues.ContainsValue(empty))
            {
                Console.WriteLine();
            }
            t3.Stop();
            vs[3] = t3.ElapsedTicks;
            Output.ShowGreen(t3.ElapsedTicks + " ticks -- Время поиска несуществующего элемента");

            return vs;
        }

        public long[] TCollDictStringAvtomobileValue()
        {
            Output.ShowGreen("Тест метода ConstainsValue для коллкекции с типами <string, Avtomobile>");
            Avtomobile first = new Avtomobile("Cедан"),
                center = new Avtomobile("Кабриолет"),
                last = new Avtomobile("Лимузин"),
                empty = new Avtomobile();
            long[] vs = new long[4];
            int k = 0;
            foreach (var i in stringValues)
            {
                if (k == 0)
                {
                    first = i.Value;
                }
                if (k == stringValues.Count / 2 - 1)
                {
                    center = i.Value;
                }
                if (k == stringValues.Count - 1)
                {
                    last = i.Value;
                }
                k++;
            }
            Stopwatch t3 = new Stopwatch();
            t3.Start();
            if (stringValues.ContainsValue(first))
            {
                Console.WriteLine();
            }
            t3.Stop();
            vs[0] = t3.ElapsedTicks;
            Output.ShowGreen(t3.ElapsedTicks + " ticks -- Время поиска первого элемента");

            t3.Restart();
            if (stringValues.ContainsValue(center))
            {
                Console.WriteLine();
            }
            t3.Stop();
            vs[1] = t3.ElapsedTicks;
            Output.ShowGreen(t3.ElapsedTicks + " ticks -- Время поиска срединного элемента");

            t3.Restart();
            if (stringValues.ContainsValue(last))
            {
                Console.WriteLine();
            }
            t3.Stop();
            vs[2] = t3.ElapsedTicks;
            Output.ShowGreen(t3.ElapsedTicks + " ticks -- Время поиска последнего элемента");

            t3.Restart();
            if (!stringValues.ContainsValue(empty))
            {
                Console.WriteLine();
            }
            t3.Stop();
            vs[3] = t3.ElapsedTicks;
            Output.ShowGreen(t3.ElapsedTicks + " ticks -- Время поиска несуществующего элемента");

            return vs;
        }
        #endregion
        #region Test Method "ContainKey" in Dictionary 
        public long[] TCollDictProdToyKey()
        {
            Output.ShowGreen("Тест метода ContainKey по словарю <Transport,Toy>");
            Transport first = new Transport(11, 11), center = new Transport(12, 12), last = new Transport(13, 13), empty;
            long[] vs = new long[4];
            int k = 0;
            foreach (var item in keyValues)
            {
                if (k == 0)
                {
                    first = item.Key;
                }
                if (k == keyValues.Count / 2 - 1)
                {
                    center = item.Key;
                }
                if (k == keyValues.Count - 1)
                {
                    last = item.Key;
                }
                k++;
            }
            empty = new Transport();

            Stopwatch t2 = new Stopwatch();
            t2.Start();
            if (keyValues.ContainsKey(first))
            {
                Console.WriteLine();
            }
            t2.Stop();
            vs[0] = t2.ElapsedTicks;
            Output.ShowGreen(t2.ElapsedTicks + " ticks -- время поиска в словаре первого элемента");

            t2.Restart();
            if (keyValues.ContainsKey(center))
            {
                Console.WriteLine();
            }
            t2.Stop();
            vs[1] = t2.ElapsedTicks;
            Output.ShowGreen(t2.ElapsedTicks + " ticks -- время поиска в словаре cрединного элемента");

            t2.Restart();
            if (keyValues.ContainsKey(last))
            {
                Console.WriteLine();
            }
            t2.Stop();
            vs[2] = t2.ElapsedTicks;
            Output.ShowGreen(t2.ElapsedTicks + " ticks -- время поиска в словаре последнего элемента");

            t2.Restart();
            if (!keyValues.ContainsKey(empty))
            {
                Console.WriteLine();
            }
            t2.Stop();
            vs[3] = t2.ElapsedTicks;
            Output.ShowGreen(t2.ElapsedTicks + " ticks -- время поиска в словаре несуществующего элемента");

            return vs;
        }

        public long[] TCollDictStringToyKey()
        {
            Output.ShowGreen("Тест метода ContainKey по словарю <Transport,Avtomobile>");
            string first = "", center = "", last = "", empty;
            long[] vs = new long[4];
            int k = 0;
            foreach (var item in stringValues)
            {
                if (k == 0)
                {
                    first = item.Key;
                }
                if (k == keyValues.Count / 2 - 1)
                {
                    center = item.Key;
                }
                if (k == keyValues.Count - 1)
                {
                    last = item.Key;
                }
                k++;
            }
            empty = "empty contains";

            Stopwatch t2 = new Stopwatch();
            t2.Start();
            if (stringValues.ContainsKey(first))
            {
                Console.WriteLine();
            }
            t2.Stop();
            vs[0] = t2.ElapsedTicks;
            Output.ShowGreen(t2.ElapsedTicks + " ticks -- время поиска в словаре первого элемента");

            t2.Restart();
            if (stringValues.ContainsKey(center))
            {
                Console.WriteLine();
            }
            t2.Stop();
            vs[1] = t2.ElapsedTicks;
            Output.ShowGreen(t2.ElapsedTicks + " ticks -- время поиска в словаре срединного элемента");

            t2.Restart();
            if (stringValues.ContainsKey(last))
            {
                Console.WriteLine();
            }
            t2.Stop();
            vs[2] = t2.ElapsedTicks;
            Output.ShowGreen(t2.ElapsedTicks + " ticks -- время поиска в словаре последнего элемента");

            t2.Restart();
            if (!stringValues.ContainsKey(empty))
            {
                Console.WriteLine();
            }
            t2.Stop();
            vs[3] = t2.ElapsedTicks;
            Output.ShowGreen(t2.ElapsedTicks + " ticks -- время поиска в словаре несуществующего элемента");

            return vs;
        }

        #endregion
    }
}

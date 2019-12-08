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
                int speed = rand.Next(3, 10000);
                int countMen = rand.Next(2, 10000);

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

                Transports.AddLast(t.BaseTransport());//двунаправленный список транспорта
                vs.AddLast(t.BaseTransport().ToString());//двусвязный список строк
                keyValues.Add(Transports.Last.Value, t);//словарь транспорт автомобиль
                stringValues.Add(vs.Last.Value, t);//словарь строка автомобиль
            }
        }
        public long[] TCollLinkListTran()
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
            bool ok1 = Transports.Contains(first);
            t1.Stop();
            if (ok1)
            {
                Output.ShowGreen(t1.ElapsedTicks + " - Время нахождения первого элемента.");
                vs[0] = t1.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t1.ElapsedTicks * (-1)) + " - Время нахождения первого элемента.");
                vs[0] = (t1.ElapsedTicks * (-1));
            }

            t1.Restart();
            ok1 = Transports.Contains(center);
            t1.Stop();
            if (ok1)
            {
                Output.ShowGreen(t1.ElapsedTicks + " - Время нахождения центрального элемента.");
                vs[1] = t1.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t1.ElapsedTicks * (-1)) + " - Время нахождения центрального элемента.");
                vs[1] = (t1.ElapsedTicks * (-1));
            }

            t1.Restart();
            ok1 = Transports.Contains(last);
            t1.Stop();
            if (ok1)
            {
                Output.ShowGreen(t1.ElapsedTicks + " - Время нахождения последнего элемента.");
                vs[2] = t1.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t1.ElapsedTicks * (-1)) + " - Время нахождения последнего элемента.");
                vs[2] = (t1.ElapsedTicks * (-1));
            }


            t1.Restart();
            ok1 = Transports.Contains(empty);
            t1.Stop();
            if (ok1)
            {
                Output.ShowGreen(t1.ElapsedTicks + " - Время нахождения не существующего элемента.");
                vs[3] = t1.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t1.ElapsedTicks * (-1)) + " - Время нахождения не существующего элемента.");
                vs[3] = (t1.ElapsedTicks * (-1));
            }
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
            bool ok = vs.Contains(first);
            t1.Stop();
            if (ok)
            {
                Output.ShowGreen(t1.ElapsedTicks + " - Время нахождения первого элемента.");
                arr[0] = t1.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t1.ElapsedTicks * (-1)) + " - Время нахождения первого элемента.");
                arr[0] = t1.ElapsedTicks;
            }

            t1.Restart();
            ok = vs.Contains(center);
            t1.Stop();
            if (ok)
            {
                Output.ShowGreen(t1.ElapsedTicks + " - Время нахождения центрального элемента.");
                arr[1] = t1.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t1.ElapsedTicks * (-1)) + " - Время нахождения центрального элемента.");
                arr[1] = t1.ElapsedTicks;
            }


            t1.Restart();
            ok = vs.Contains(last);
            t1.Stop();
            if (ok)
            {
                Output.ShowGreen(t1.ElapsedTicks + " - Время нахождения последнего элемента.");
                arr[2] = t1.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t1.ElapsedTicks * (-1)) + " - Время нахождения последнего элемента.");
                arr[2] = t1.ElapsedTicks;
            }

            t1.Restart();
            ok = vs.Contains(empty);
            t1.Stop();
            if (ok)
            {
                Output.ShowGreen(t1.ElapsedTicks + " - Время нахождения не существущего элемента.");
                arr[3] = t1.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t1.ElapsedTicks * (-1)) + " - Время нахождения не существующего элемента.");
                arr[3] = t1.ElapsedTicks;
            }

            Console.WriteLine();

            return arr;
        }

        public long[] TCollDictTranAvtomobileKey()
        {
            Output.ShowGreen("Тест метода ContainKey по словарю <Transport,Avtomobile>");
            Transport first = new Transport(),
                center = new Transport(),
                last = new Transport(),
                empty;
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
            empty = new Transport(100000000, 100000000);//такого элемента нет тк элементы рандомятся с меньшим диапазоном

            Stopwatch t2 = new Stopwatch();
            t2.Start();
            bool ok = keyValues.ContainsKey(first);
            t2.Stop();
            if (ok)
            {
                Output.ShowGreen(t2.ElapsedTicks + " - время поиска в словаре первого элемента");
                vs[0] = t2.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t2.ElapsedTicks * (-1)) + " - время поиска в словаре первого элемента");
                vs[0] = t2.ElapsedTicks;
            }

            t2.Restart();
            ok = keyValues.ContainsKey(center);
            t2.Stop();
            if (ok)
            {
                Output.ShowGreen(t2.ElapsedTicks + " - время поиска в словаре центрального элемента");
                vs[1] = t2.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t2.ElapsedTicks * (-1)) + " - время поиска в словаре центрального элемента");
                vs[1] = t2.ElapsedTicks;
            }

            t2.Restart();
            ok = keyValues.ContainsKey(last);
            t2.Stop();
            if (ok)
            {
                Output.ShowGreen(t2.ElapsedTicks + " - время поиска в словаре последнего элемента");
                vs[2] = t2.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t2.ElapsedTicks * (-1)) + " - время поиска в словаре последнего элемента");
                vs[2] = t2.ElapsedTicks;
            }

            t2.Restart();
            ok = keyValues.ContainsKey(empty);
            t2.Stop();
            if (ok)
            {
                Output.ShowGreen(t2.ElapsedTicks + " - время поиска в словаре не существующего элемента");
                vs[3] = t2.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t2.ElapsedTicks * (-1)) + " - время поиска в словаре не существующего элемента");
                vs[3] = t2.ElapsedTicks;
            }

            return vs;
        }

        public long[] TCollDictStringAvtomobileKey()
        {
            Output.ShowGreen("Тест метода ContainKey по словарю <string, Avtomobile>");
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
            bool ok = stringValues.ContainsKey(first);
            t2.Stop();
            if (ok)
            {
                Output.ShowGreen(t2.ElapsedTicks + " - время поиска в словаре первого элемента");
                vs[0] = t2.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t2.ElapsedTicks * (-1)) + " - время поиска в словаре первого элемента");
                vs[0] = t2.ElapsedTicks;
            }


            t2.Restart();
            ok = stringValues.ContainsKey(center);
            t2.Stop();
            if (ok)
            {
                Output.ShowGreen(t2.ElapsedTicks + " - время поиска в словаре центрального элемента");
                vs[1] = t2.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t2.ElapsedTicks * (-1)) + " - время поиска в словаре центрального элемента");
                vs[1] = t2.ElapsedTicks;
            }

            t2.Restart();
            ok = stringValues.ContainsKey(last);
            t2.Stop();
            if (ok)
            {
                Output.ShowGreen(t2.ElapsedTicks + " - время поиска в словаре последнего элемента");
                vs[2] = t2.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t2.ElapsedTicks * (-1)) + " - время поиска в словаре последнего элемента");
                vs[2] = t2.ElapsedTicks;
            }

            t2.Restart();
            ok = stringValues.ContainsKey(empty);
            t2.Stop();
            if (ok)
            {
                Output.ShowGreen(t2.ElapsedTicks + " - время поиска в словаре не существующего элемента");
                vs[3] = t2.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t2.ElapsedTicks * (-1)) + " - время поиска в словаре не существующего элемента");
                vs[3] = t2.ElapsedTicks;
            }

            return vs;
        }

        public long[] TCollDictProdAvtomobileValue()
        {
            Output.ShowGreen("Тест метода ConstainsValue для коллкекции с типами <Transport, Avtomobile>");
            Avtomobile first = new Avtomobile(),
                center = new Avtomobile(),
                last = new Avtomobile(),
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
            bool ok = keyValues.ContainsValue(first);
            t3.Stop();
            if (ok)
            {
                Output.ShowGreen(t3.ElapsedTicks + " - Время поиска первого элемента");
                vs[0] = t3.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t3.ElapsedTicks * (-1)) + " - Время поиска первого элемента");
                vs[0] = t3.ElapsedTicks;
            }


            t3.Restart();
            ok = keyValues.ContainsValue(center);
            t3.Stop();
            if (ok)
            {
                Output.ShowGreen(t3.ElapsedTicks + " - Время поиска центрального элемента");
                vs[1] = t3.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t3.ElapsedTicks * (-1)) + " - Время поиска центрального элемента");
                vs[1] = t3.ElapsedTicks;
            }


            t3.Restart();
            ok = keyValues.ContainsValue(last);
            t3.Stop();
            if (ok)
            {
                Output.ShowGreen(t3.ElapsedTicks + " - Время поиска последнего элемента");
                vs[2] = t3.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t3.ElapsedTicks * (-1)) + " - Время поиска последнего элемента");
                vs[2] = t3.ElapsedTicks;
            }


            t3.Restart();
            ok = keyValues.ContainsValue(empty);
            t3.Stop();
            if (ok)
            {
                Output.ShowGreen(t3.ElapsedTicks + " - Время поиска не существующего элемента");
                vs[3] = t3.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t3.ElapsedTicks * (-1)) + " - Время поиска не существующего элемента");
                vs[3] = t3.ElapsedTicks;
            }

            return vs;
        }

        public long[] TCollDictStringAvtomobileValue()
        {
            Output.ShowGreen("Тест метода ConstainsValue для коллкекции с типами <string, Avtomobile>");
            Avtomobile first = new Avtomobile(),
                center = new Avtomobile(),
                last = new Avtomobile(),
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
            bool ok = stringValues.ContainsValue(first);
            t3.Stop();
            if (ok)
            {
                Output.ShowGreen(t3.ElapsedTicks + " - Время поиска первого элемента");
                vs[0] = t3.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t3.ElapsedTicks * (-1)) + " - Время поиска первого элемента");
                vs[0] = t3.ElapsedTicks;
            }

            t3.Restart();
            ok = stringValues.ContainsValue(center);
            t3.Stop();
            if (ok)
            {
                Output.ShowGreen(t3.ElapsedTicks + " - Время поиска центрального элемента");
                vs[1] = t3.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t3.ElapsedTicks * (-1)) + " - Время поиска центрального элемента");
                vs[1] = t3.ElapsedTicks;
            }

            t3.Restart();
            ok = stringValues.ContainsValue(last);
            t3.Stop();
            if (ok)
            {
                Output.ShowGreen(t3.ElapsedTicks + " - Время поиска последнего элемента");
                vs[2] = t3.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t3.ElapsedTicks * (-1)) + " - Время поиска последнего элемента");
                vs[2] = t3.ElapsedTicks;
            }

            t3.Restart();
            ok = stringValues.ContainsValue(empty);
            t3.Stop();
            if (ok)
            {
                Output.ShowGreen(t3.ElapsedTicks + " - Время поиска не существующего элемента");
                vs[3] = t3.ElapsedTicks;
            }
            else
            {
                Output.ShowRed((t3.ElapsedTicks * (-1)) + " - Время поиска не существующего элемента");
                vs[3] = t3.ElapsedTicks;
            }
            return vs;
        }
    }
    //было
    //Stopwatch t = new Stopwatch();
    //t.Start();
    //if (stringValues.ContainsValue(empty))
    //{
    //    Console.Writeline();
    //}
    //t.Stop();
    //Console.Writeline(t3.ElapsedTicks + " - Время поиска не существующего элемента");
    //стало
    //t3.Restart();
    //ok = stringValues.ContainsValue(empty);
    //t3.Stop();
    //if (ok)
    //{
    //    Output.ShowGreen(t3.ElapsedTicks + " - Время поиска не существующего элемента");
    //    vs[3] = t3.ElapsedTicks;
    //}
    //else
    //{
    //    Output.ShowRed((t3.ElapsedTicks * (-1)) + " - Время поиска не существующего элемента");
    //    vs[3] = t3.ElapsedTicks;
    //}
}

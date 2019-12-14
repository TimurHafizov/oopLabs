using System;
using System.Linq;
using MyLib;
using CheckerInputConsole;
using System.Collections.Generic;

namespace lab14
{
    class Program
    {
        static string[] MasName = { "Универсал", "Купе", "Лимузин", "Микроавтобус", "Кабиролет" };
        static string[] MasNameOfExpress = { "Красная стрела", "Полярная стрела", "Восток", "Арктика", "Белоруссия" };
        static readonly Random rand = new Random();

        const string MainMenu = @"1. Просмотреть коллекцию
2. (Множества) Объединить экспресс-поезда и автомобили из каждого вокзала
3. (Выборка) Транспорт во всем городе, количество пассажиров которого меньше 100
4. (Счётчик) Количество поездов на вокзале, количество вагонов которых больше 30
5. (Агрегация) Среднее арифметическое количества вагонов у экспресс поездов
6. (Группировка) Сгруппировать автомобили по типу кузова
7. (Cчетчик) Сумма всех пассажиров в городе";

        private static void RandomGen(ref MyQueue<Transport> list, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i % 4 == 0)
                    list.Add(new Transport(rand.Next(1, 800), rand.Next(1, 1000)));
                else if (i % 3 == 0)
                    list.Add(new Avtomobile(MasName[rand.Next(0, 4)], rand.Next(1, 300), rand.Next(1, 10)));
                else if (i % 2 == 0)
                    list.Add(new Rain(rand.Next(1, 100), rand.Next(1, 400), rand.Next(1, 1000)));
                else
                    list.Add(new Express(MasNameOfExpress[rand.Next(0, 4)], rand.Next(1, 100), rand.Next(1, 800), rand.Next(1, 1000)));
            }
        }
        private static bool LinqOrExten()
        {
            while (true)
            {
                Console.WriteLine(@"1. Linq
2. Расширяющий метод");
                int vib = Input.IntCheckConsole();
                switch (vib)
                {
                    case 1:
                        return true;
                    case 2:
                        return false;
                    default: Console.WriteLine("Некорректный ввод!"); break;
                }
            }
        }
        private static void ShowQueue(MyQueue<Transport> list)
        {
            foreach (var i in list)
            {
                Output.ShowGreen(i.ToString());
            }
        }

        private static void Request4EXTEN(List<MyQueue<Transport>> list1)
        {
            var ok = list1.SelectMany(i => i.Where(j => j is Express)).Union(list1.SelectMany(i => i.Where(j => j is Avtomobile)));
            ShowOtv(ok);
        }

        private static void Request4LINQ(List<MyQueue<Transport>> list1)
        {
            var ok = (from i in list1
                      from j in i
                      where j is Express
                      select j).Union(from i in list1
                                      from j in i
                                      where j is Avtomobile
                                      select j);
            ShowOtv(ok);
        }

        private static void Request1EXTEN(List<MyQueue<Transport>> list1)
        {
            var ok = list1.SelectMany(i => i.Where(j => j.CountMen < 100).Select(j => j));
            ShowOtv(ok);
        }

        private static void Request1LINQ(List<MyQueue<Transport>> list1)
        {
            var ok = from i in list1
                     from j in i
                     where j.CountMen < 100
                     select j;
            ShowOtv(ok);
        }

        private static void Request2EXTEN(List<MyQueue<Transport>> list1, int k)
        {
            int ok = list1[k].Select(i => i).
                Where(i => i is Rain).
                Select(i => (i as Rain).NumberVan > 30).Count();
            Output.ShowGreen(ok.ToString());
        }

        private static void Request2LINQ(List<MyQueue<Transport>> list1, int k)
        {
            int ok = (from i in list1[k]
                      where i is Rain
                      where (i as Rain).NumberVan > 30
                      select i).Count();//немедленный
            Output.ShowGreen(ok.ToString());
        }

        private static void Request3EXTEN(List<MyQueue<Transport>> list1)
        {
            var ok = list1.SelectMany(j => j.
            Where(i => i is Express)).
            Select(i => (i as Express).NumberVan).Average();
            Output.ShowGreen(ok.ToString());
        }

        private static void Request3LINQ(List<MyQueue<Transport>> list1)
        {
            var ok = (from j in list1
                      from i in j
                      where i is Express
                      select (i as Express).NumberVan).Average();
            Console.WriteLine(ok);
        }

        private static void Request5EXTEN(List<MyQueue<Transport>> list1)
        {
            var ok = list1.SelectMany(i => i.Where(j => j is Avtomobile)).GroupBy(j => (j as Avtomobile).BodyType);

            foreach (var grouping in ok)
            {
                Output.ShowGreen("\n\n Тип кузова: " + grouping.Key + ":");
                foreach (var name in grouping)
                    Console.WriteLine(name);
            }
            Console.WriteLine("\n\n");
        }

        private static void Request5LINQ(List<MyQueue<Transport>> list1)
        {
            var ok = from j in list1
                     from i in j
                     where i is Avtomobile
                     group i by (i as Avtomobile).BodyType;

            foreach (var grouping in ok)
            {
                Output.ShowGreen("\n\n Тип кузова: " + grouping.Key + ":");
                foreach (var name in grouping)
                    Console.WriteLine(name);
            }
            Console.WriteLine("\n\n");
        }

        private static void Request6EXTEN(List<MyQueue<Transport>> list1)
        {
            var ok = list1.SelectMany(i => i.Select(j => j.CountMen)).Sum();
            Output.ShowGreen(ok.ToString());
        }

        private static void Request6LINQ(List<MyQueue<Transport>> list1)
        {
            var ok = (from j in list1
                      from i in j
                      select i.CountMen).Sum();
            Output.ShowGreen(ok.ToString());
        }

        private static void ShowOtv(IEnumerable<Transport> list)
        {
            foreach (var i in list)
            {
                Output.ShowGreen(i.ToString());
            }
        }

        static void Main(string[] args)
        {
            List<MyQueue<Transport>> list1 = new List<MyQueue<Transport>>();

            bool ok = true;
            Console.WriteLine("Введите количество вокзалов в городе");
            int n1 = Input.IntCheckConsole();
            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine($"Введите количество транспорта {i + 1} -го вокзала");
                int n2 = Input.IntCheckConsole();
                MyQueue<Transport> cris = new MyQueue<Transport>();
                RandomGen(ref cris, n2);
                list1.Add(cris);
            }
            while (ok)
            {
                Console.WriteLine(MainMenu);
                Console.WriteLine("Введите значение: ");
                int vib = Input.IntCheckConsole();
                int q = 0;
                bool onLinq = true;
                switch (vib)
                {
                    case 1:
                        foreach (var it in list1)
                        {
                            Output.ShowRed($"Вокзал {q + 1}");
                            ShowQueue(it);
                            q++;
                        }
                        break;
                    case 2:
                        onLinq = LinqOrExten();
                        if (onLinq)
                            Request4LINQ(list1);
                        else
                            Request4EXTEN(list1);
                        break;
                    case 3:
                        onLinq = LinqOrExten();
                        if (onLinq)
                            Request1LINQ(list1);
                        else
                            Request1EXTEN(list1);
                        break;
                    case 4:
                        Console.WriteLine("Введите номер вокзала");
                        int k = Input.IntCheckConsole();
                        while (k < 1 || k > n1 + 1)
                        {
                            Console.WriteLine("Введите номер вокзала");
                            k = Input.IntCheckConsole();
                        }
                        onLinq = LinqOrExten();
                        if (onLinq)
                            Request2LINQ(list1, k - 1);
                        else
                            Request2EXTEN(list1, k - 1);
                        break;
                    case 5:
                        onLinq = LinqOrExten();
                        if (onLinq)
                            Request3LINQ(list1);
                        else
                            Request3EXTEN(list1);
                        break;
                    case 6:
                        onLinq = LinqOrExten();
                        if (onLinq)
                            Request5LINQ(list1);
                        else
                            Request5EXTEN(list1);
                        break;
                    case 7:
                        onLinq = LinqOrExten();
                        if (onLinq)
                            Request6LINQ(list1);
                        else
                            Request6EXTEN(list1);
                        break;
                    default:
                        Output.ShowRed("Неопознанное значение!");
                        break;
                }
            }
        }
    }
}

using System;
//автомобиль, поезд, транспортное средство, экспресс;
namespace lab10
{

    class Program
    {
        static Random rand = new Random();
        static void NewStroke()
        {
            Console.WriteLine();
        }
        static void ShowRed(string s)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed; // устанавливаем цвет
            Console.WriteLine(s);
            Console.ResetColor(); // сбрасываем в стандартный
        }
        static void ShowGreen(string s)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen; // устанавливаем цвет
            Console.WriteLine(s);
            Console.ResetColor(); // сбрасываем в стандартный
        }
        static void CheckInput(out int param, string s = "Введите значение: ")
        {
            param = 0;
            while (true)
            {
                Console.Write(s);
                if (!int.TryParse(Console.ReadLine(), out param))
                {

                    Console.WriteLine("Ошибка ввода!");
                }
                else
                {
                    if (param >= 0) break;
                    else
                    {
                        Console.WriteLine("Ошибка ввода!");
                    }
                }
            }
        }
        static void ScriptDemo()
        {
            ShowGreen("Создается массив объектов состоящий из объектов Транспорт, Автомобиль, Поезд, Экспресс");
            Transport t1 = new Transport();
            t1.CountMen = 1000;
            t1.Speed = 1000;

            Avtomobile t2 = new Avtomobile();
            t2.CountMen = 4;
            t2.Speed = 100;
            t2.BodyType = "Седан";

            Rain t3 = new Rain();
            t3.CountMen = 800;
            t3.Speed = 200;
            t3.NumberVan = 23;

            Express e = new Express();
            e.CountMen = 500;
            e.Speed = 500;
            e.NumberVan = 10;
            e.NameExpress = "Ласточка";

            Transport[] mas = new Transport[4];
            mas[0] = t1;
            mas[1] = t2;
            mas[2] = t3;
            mas[3] = e;
            ShowGreen("Вызывается виртуальный метод Info() переопределенный для каждого класса");
            for (int i = 0; i < 4; i++)
            {
                mas[i].Info();
            }

            ShowGreen("Вызывается не виртуальный метод каждого класса Sound()");



            for (int i = 0; i < 4; i++)
            {
                if (mas[i] is Rain)
                {
                    if (mas[i] is Express)
                    {
                        (mas[i] as Express).SoundExpress();
                    }
                    else
                    {
                        (mas[i] as Rain).SoundRain();
                    }
                }
                else if (mas[i] is Avtomobile)
                {
                    (mas[i] as Avtomobile).SoundAvto();
                }
                else
                {
                    mas[i].SoundTransport();
                }
            }

        }

        static void Request1(Transport[] mas)
        {
            int n = 0;
            Console.WriteLine("Введите n");
            CheckInput(out n);
            bool ok = false;
            foreach (Transport el in mas)
            {
                if (el is Avtomobile)
                {
                    Avtomobile avto = (Avtomobile)el;
                    if (avto.Speed > n)
                    {
                        avto.Info();
                        ok = true;
                    }
                }
            }
            if (!ok) ShowRed("Таких автомобилей нет!");
        }
        static void Request2(Transport[] mas)
        {
            int n = 0;
            Console.WriteLine("Введите n");
            CheckInput(out n);
            bool ok = false;
            foreach (Transport el in mas)
            {
                if (el is Rain)
                {
                    Rain rain = (Rain)el;
                    if (rain.NumberVan > n)
                    {
                        rain.Info();
                        ok = true;
                    }
                }
            }
            if (!ok) ShowRed("Таких автомобилей нет!");
        }
        static void Request3(Transport[] mas)
        {
            int n = 0;
            Console.WriteLine("Введите n");
            CheckInput(out n);
            bool ok = false;
            foreach (Transport el in mas)
            {
                if (el.CountMen < n)
                {
                    el.Info();
                    ok = true;
                }
            }
            if (!ok) ShowRed("Такого транспорта нет!");

        }
        static void ShowMas(Transport[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] is Avtomobile)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    mas[i].Info();
                    Console.ResetColor();
                }
                else if (mas[i] is Express)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    mas[i].Info();
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    mas[i].Info();
                    Console.ResetColor();
                }

            }
        }


        static void Script3()
        {
            string[] MasName = { "Универсал", "Купе", "Лимузин", "Микроавтобус", "Кабиролет" };
            string[] MasNameOfExpress = { "Красная стрела", "Полярная стрела", "Восток", "Арктика", "Белоруссия" };
            int n = 0;
            Console.WriteLine("На сколько элементов создать массив, в котором выполнять запросы?");
            CheckInput(out n);

            Transport[] mas = new Transport[n];

            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0)
                {
                    Rain a = new Rain(rand.Next(1, 10), rand.Next(100, 200), rand.Next(50, 2000));
                    mas[i] = a;
                }
                else
                if (i % 2 == 0)
                {
                    Avtomobile a = new Avtomobile(MasName[rand.Next(0, 4)], rand.Next(100, 400), rand.Next(2, 5));
                    mas[i] = a;
                }
                else
                if (i % 1 == 0)
                {
                    Express a = new Express(MasNameOfExpress[rand.Next(0, 4)], rand.Next(1, 10), rand.Next(100, 200), rand.Next(50, 2000));
                    mas[i] = a;
                }
                else
                {
                    Avtomobile a = new Avtomobile(MasName[rand.Next(0, 4)], rand.Next(100, 400), rand.Next(2, 5));
                    mas[i] = a;
                }
            }
            ShowMas(mas);
            ShowGreen("СОРТИРОВКА ПО КОЛИЧЕСТВУ ЧЕЛОВЕК");
            Array.Sort(mas, new Comperrr());
            ShowMas(mas);
            ShowGreen("СОРТИРОВКА ПО СКОРОСТИ");
            Array.Sort(mas);
            ShowMas(mas);

            ShowGreen("Создание объекта с последующим клонированием");
            Rain t1 = new Rain(3, 1, 2);
            t1.Info();
            Transport t2 = (Rain)t1.Clone();
            t2.Info();
            ((Transport)t2).Info();


        }
        static void ScriptRequest()
        {
            string[] MasName = { "Универсал", "Купе", "Лимузин", "Микроавтобус", "Кабиролет" };
            string[] MasNameOfExpress = { "Красная стрела", "Полярная стрела", "Восток", "Арктика", "Белоруссия" };
            int n = 0;
            Console.WriteLine("На сколько элементов создать массив, в котором выполнять запросы?");
            CheckInput(out n);

            Transport[] mas = new Transport[n];

            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0)
                {
                    Rain a = new Rain(rand.Next(1, 10), rand.Next(100, 200), rand.Next(50, 2000));
                    mas[i] = a;
                }
                else
                if (i % 2 == 0)
                {
                    Avtomobile a = new Avtomobile(MasName[rand.Next(0, 4)], rand.Next(100, 400), rand.Next(2, 5));
                    mas[i] = a;
                }
                else
                if (i % 1 == 0)
                {
                    Express a = new Express(MasNameOfExpress[rand.Next(0, 4)], rand.Next(1, 10), rand.Next(100, 200), rand.Next(50, 2000));
                    mas[i] = a;
                }
                else
                {
                    Avtomobile a = new Avtomobile(MasName[rand.Next(0, 4)], rand.Next(100, 400), rand.Next(2, 5));
                    mas[i] = a;
                }
            }
            ShowMas(mas);
            bool flag = false;
            while (!flag)
            {
                Console.WriteLine(@"1. Показать автомобили, чья скорость выше n.
2. Показать поезда и экспрессы, числа вагонов которых больше n.
3. Показать транспорт, количество пассажиров которого меньше n.
5. Показать массив.
6. Выход");
                CheckInput(out int choise);
                switch (choise)
                {
                    case 1:
                        Request1(mas);
                        break;
                    case 2:
                        Request2(mas);
                        break;
                    case 3:
                        Request3(mas);
                        break;
                    case 5:
                        ShowMas(mas);
                        break;
                    case 6:
                        flag = !flag;
                        break;

                    default:
                        ShowRed("Введено неопрознанное значение!");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            bool flag = false;
            while (!flag)
            {
                Console.WriteLine(@"1. Демонстрация виртуальных функций.
2.Выполнение запросов.
3. Демонстрация реализации интерфейсов.
4. Выход");
                CheckInput(out int choise);
                switch (choise)
                {
                    case 1:
                        ScriptDemo();
                        break;
                    case 2:
                        ScriptRequest();
                        break;
                    case 3:
                        Script3();
                        break;
                    case 4:
                        flag = !flag;
                        break;

                    default:
                        ShowRed("Введено неопрознанное значение!");
                        break;
                }
            }

        }

    }
}

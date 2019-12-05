using System;
using System.Collections;
using System.Collections.Generic;
using CheckerInputConsole;
using MyLib;


namespace lab11
{
    class Program
    {
        static Random rand = new Random();
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
        static void ShowYellow(string s)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow; // устанавливаем цвет
            Console.WriteLine(s);
            Console.ResetColor(); // сбрасываем в стандартный
        }
        static void ShowBlue(string s)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue; // устанавливаем цвет
            Console.WriteLine(s);
            Console.ResetColor(); // сбрасываем в стандартный
        }
        static void Menu(string s)
        {
            Console.Write(s);
        }
        const string mainMenu = @"Задание 1: Коллекция - стек
1. Сгенерировать рандомные элементы в стек.
2. Просмотреть стек.
3. Удалить последний добавленный элемент в стеке.
4. Отсортировать коллекцию (по скорости).
5. Найти элемент по его индексу в коллекции.
6. Запросы

Задание 2: Обобщённая коллекция - list<T>
7. Сгенерировать рандомные элементы в список.
8. Просмотреть список.
9. Удалить элемент списка по ключу.
10. Отсортировать коллекцию (по имени).
11. Найти элемент.
12. Запросы

Задание 3. 
13. Создать коллекцию TestCollection
14. Демонстрация времени поиска по коллекции LinkedList.
15. Демонстрация времени поиска по коллекции Dictionary (по ключу).
16. Демонстрация времени поиска по коллекции Dictionary (по значению).

17. Выход из программы.

Введие значение: ";
        const string request = @"Запрос 1: Посчитать количество объектов типа Rain.
Запрос 2: Посчитать количество транспорта, у которого количество пассажиров меньше n.
Запрос 3: Посчитать количество экспресс поездов, у которых количество вагонов больше n.

Введите значение: ";

        const string pushMenu = @"1. Добавить в коллекцию объект типа Transport.
2. Добавить в коллекцию объект типа Avtomobile.
3. Добавить в коллекцию объект типа Rain.
4. Добавить в коллекцию объект типа Express.";



        #region Пушеры в стек и лист
        static object Push<T>() where T : Transport, new()
        {
            Console.WriteLine(@"1. Ручной ввод
2. Параметры по умолчанию.");
            int choise;
            choise = Input.IntCheckConsole();
            switch (choise)
            {
                case 1:
                    T cris = new T();
                    Console.WriteLine("Скорость: ");
                    int speed = Input.IntCheckConsole();
                    Console.WriteLine("Количество человек: ");
                    int countMen = Input.IntCheckConsole();

                    if (cris is Rain)
                    {
                        Console.WriteLine("Количество вагонов: ");
                        int numberVan = Input.IntCheckConsole();
                        if (cris is Express)
                        {
                            Console.WriteLine("Название экспресса: ");
                            string name = Console.ReadLine();
                            return new Express(name, numberVan, speed, countMen);
                        }
                        else
                        {
                            return new Rain(numberVan, speed, countMen);
                        }

                    }
                    else
                    if (cris is Avtomobile)
                    {
                        Console.WriteLine("Тип кузова: ");
                        string bodyType = Console.ReadLine();

                        return new Avtomobile(bodyType, speed, countMen);
                    }
                    else
                    {
                        return new Transport(speed, countMen);
                    }
                case 2:
                    return new T();
            }
            return new T();
        }
        static void Push(ref Stack stack)
        {
            Menu(pushMenu);
            int choise = Input.IntCheckConsole();
            switch (choise)
            {
                case 1:
                    stack.Push(Push<Transport>());
                    break;
                case 2:
                    stack.Push(Push<Avtomobile>());
                    break;
                case 3:
                    stack.Push(Push<Rain>());
                    break;
                case 4:
                    stack.Push(Push<Express>());
                    break;
                default:
                    break;
            }
        }

        static void Push<T>(ref List<T> ts) where T : Transport
        {
            Menu(pushMenu);
            int choise = Input.IntCheckConsole();
            switch (choise)
            {
                case 1:
                    ts.Add((T)Push<Transport>());
                    break;
                case 2:
                    ts.Add((T)Push<Avtomobile>());
                    break;
                case 3:
                    ts.Add((T)Push<Rain>());
                    break;
                case 4:
                    ts.Add((T)Push<Express>());
                    break;
                default:
                    break;
            }

        }
        #endregion
        #region Requests
        static void RequestStack(Stack stack)
        {
            Menu(request);
            int counter = 0;
            int choise = Input.IntCheckConsole();
            switch (choise)
            {
                case 1:
                    counter = 0;
                    foreach (var item in stack)
                    {
                        if (item is Rain)
                        {
                            counter++;
                        }
                    }
                    ShowGreen("Количество объектов типа \"Rain\": " + counter);
                    break;
                case 2:
                    Console.WriteLine("Введите n: ");
                    int col = Input.IntCheckConsole();
                    counter = 0;
                    foreach (var item in stack)
                    {
                        if (item is Transport)
                        {
                            Transport k = item as Transport;
                            if (k.CountMen < col)
                            {
                                counter++;
                            }
                        }
                    }
                    ShowGreen($"Количество транспорта, скорость которого меньше {col}: {counter}");

                    break;
                case 3:
                    Console.WriteLine("Введите n: ");
                    int colVan = Input.IntCheckConsole();
                    counter = 0;
                    foreach (var item in stack)
                    {
                        if (item is Express)
                        {
                            Express k = item as Express;

                            if (k.NumberVan > colVan)
                            {
                                counter++;
                            }
                        }
                    }
                    ShowGreen($"Количество экспресс поездов, скорость которых больше чем {colVan}: {counter}");
                    break;
            }
        }

        static void RequestList(List<Transport> ls)
        {
            int counter = 0;
            Menu(request);
            int choise = Input.IntCheckConsole();
            switch (choise)
            {
                case 1:
                    counter = 0;
                    foreach (var item in ls)
                    {
                        if (item is Rain)
                        {
                            counter++;
                        }
                    }
                    ShowGreen("Количество объектов типа \"Rain\": " + counter);
                    break;
                case 2:
                    Console.WriteLine("Введите n: ");
                    int col = Input.IntCheckConsole();
                    counter = 0;
                    foreach (var item in ls)
                    {
                        if (item.CountMen < col)
                        {
                            counter++;
                        }
                    }
                    ShowGreen($"Количество транспорта, количество пасскажиров которого меньше {col}: {counter}");

                    break;
                case 3:
                    Console.WriteLine("Введите n: ");
                    int colVan = Input.IntCheckConsole();
                    counter = 0;
                    foreach (var item in ls)
                    {
                        if (item is Express)
                        {
                            Express k = item as Express;

                            if (k.NumberVan > colVan)
                            {
                                counter++;
                            }
                        }
                    }
                    ShowGreen($"Количество экспресс поездов, количество вагонов которых больше чем {colVan}: {counter}");
                    break;
            }

        }
        #endregion

        static void ShowStack(Stack stack)
        {
            foreach (var i in stack)
            {
                if (i is Avtomobile)
                {
                    ShowYellow(i.ToString());
                }
                else if (i is Rain)
                {
                    if (i is Express)
                    {
                        ShowGreen(i.ToString());
                    }
                    else
                    {
                        ShowBlue(i.ToString());
                    }
                }
                else
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
        static void ShowList(List<Transport> ls)
        {
            foreach (var i in ls)
            {
                if (i is Avtomobile)
                {
                    ShowYellow(i.ToString());
                }
                else if (i is Rain)
                {
                    if (i is Express)
                    {
                        ShowGreen(i.ToString());
                    }
                    else
                    {
                        ShowBlue(i.ToString());
                    }
                }
                else
                {
                    Console.WriteLine(i.ToString());
                }
            }
        }
        static void PushRandomInStack(ref Stack stack)
        {
            string[] MasName = { "Универсал", "Купе", "Лимузин", "Микроавтобус", "Кабиролет" };
            string[] MasNameOfExpress = { "Красная стрела", "Полярная стрела", "Восток", "Арктика", "Белоруссия" };
            int n = 0;
            Console.WriteLine("Сколько элементов добавить?");

            n = Input.IntCheckConsole();

            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0)
                {
                    Rain a = new Rain(rand.Next(1, 10), rand.Next(100, 200), rand.Next(50, 2000));
                    stack.Push(a);
                }
                else
                if (i % 2 == 0)
                {
                    Avtomobile a = new Avtomobile(MasName[rand.Next(0, 4)], rand.Next(100, 400), rand.Next(2, 5));
                    stack.Push(a);
                }
                else
                if (i % 1 == 0)
                {
                    Express a = new Express(MasNameOfExpress[rand.Next(0, 4)], rand.Next(1, 10), rand.Next(100, 200), rand.Next(50, 2000));
                    stack.Push(a);
                }
                else
                {
                    Transport a = new Transport(rand.Next(100, 400), rand.Next(2, 5));
                    stack.Push(a);
                }
            }
        }
        static void PushRandomInList(ref List<Transport> ls)
        {
            string[] MasName = { "Универсал", "Купе", "Лимузин", "Микроавтобус", "Кабиролет" };
            string[] MasNameOfExpress = { "Красная стрела", "Полярная стрела", "Восток", "Арктика", "Белоруссия" };
            int n = 0;
            Console.WriteLine("Сколько элементов добавить?");

            n = Input.IntCheckConsole();

            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0)
                {
                    Rain a = new Rain(rand.Next(1, 10), rand.Next(100, 200), rand.Next(50, 2000));
                    ls.Add(a);
                }
                else
                if (i % 2 == 0)
                {
                    Avtomobile a = new Avtomobile(MasName[rand.Next(0, 4)], rand.Next(100, 400), rand.Next(2, 5));
                    ls.Add(a);
                }
                else
                if (i % 1 == 0)
                {
                    Express a = new Express(MasNameOfExpress[rand.Next(0, 4)], rand.Next(1, 10), rand.Next(100, 200), rand.Next(50, 2000));
                    ls.Add(a);
                }
                else
                {
                    Transport a = new Transport(rand.Next(100, 400), rand.Next(2, 5));
                    ls.Add(a);
                }
            }
        }
        static void Main(string[] args)
        {
            bool flag = false;
            // stack
            Stack stack = new Stack();
            // list
            List<Transport> ls = new List<Transport>();
            //testcollection
            TestCollection vs = new TestCollection();

            while (!flag)
            {
                try
                {
                    Menu(mainMenu);
                    int choise = Input.IntCheckConsole();

                    switch (choise)
                    {
                        case 1:
                            PushRandomInStack(ref stack);
                            ShowStack(stack);
                            break;
                        case 2:
                            ShowStack(stack);
                            break;
                        case 3:
                            stack.Pop();
                            ShowStack(stack);
                            break;
                        case 4:
                            Transport[] Transports = new Transport[stack.Count];
                            stack.CopyTo(Transports, 0);
                            Array.Sort(Transports);
                            while (stack.Count != 0)
                            {
                                stack.Pop();
                            }
                            for (int i = 0; i < Transports.Length; i++)
                            {
                                stack.Push(Transports[i]);
                            }
                            ShowStack(stack);
                            break;
                        case 5:
                            int index = Input.IntCheckConsole();
                            int k = 0;
                            foreach (var i in stack)
                            {
                                if (k == index - 1)
                                {
                                    Console.WriteLine(i);
                                }
                                k++;
                            }
                            break;
                        case 6:
                            RequestStack(stack);
                            break;
                        case 7:
                            PushRandomInList(ref ls);
                            ShowList(ls);
                            break;
                        case 8:
                            ShowList(ls);
                            break;
                        case 9:
                            Console.WriteLine("Удалить элемент по ключу: введите номер элемента: ");
                            index = Input.IntCheckConsole();
                            ls.RemoveAt(index - 1);
                            ShowGreen("Элемент удален");
                            ShowList(ls);
                            break;
                        case 10:
                            ls.Sort();
                            ShowList(ls);
                            break;
                        case 11:
                            Console.WriteLine("Найти элемент по ключу: введите скорость транспорта: ");
                            index = Input.IntCheckConsole();
                            Transport tran = (ls.Find(x => x.Speed == index));
                            ShowGreen(tran.ToString());
                            break;
                        case 12:
                            RequestList(ls);
                            break;
                        case 13:
                            Console.WriteLine("Введите размер массива: ");
                            int size = Input.IntCheckConsole();
                            Console.WriteLine("Заполнить рандомно: 1 - да, 0 - нет ");
                            int ranf = Input.IntCheckConsole();
                            vs = new TestCollection(size, 1);
                            break;
                        case 14:
                            if (vs != null)
                            {
                                vs.TCollLinkListProd();
                                vs.TCollLinkListString();
                            }
                            break;
                        case 15:
                            if (vs != null)
                            {
                                vs.TCollDictProdAvtomobileKey();
                                vs.TCollDictStringAvtomobileKey();
                            }
                            break;
                        case 16:
                            if (vs != null)
                            {
                                vs.TCollDictProdAvtomobileValue();
                                vs.TCollDictStringAvtomobileValue();
                            }
                            break;
                        case 17:
                            flag = !flag;
                            break;
                        default:
                            Console.WriteLine("Неопознанное значение!");
                            break;
                    }
                    Console.WriteLine();
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }

        }
    }
}

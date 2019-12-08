using System;
using MyLib;
using System.Text;
using CheckerInputConsole;
using Lib;

namespace ConsoleApp1
{
    class Program
    {
        const string MainMENU = @"Часть 1: Однонаправленный список.
Часть 2: Двунаправленный список.
Часть 3: Дерево
Часть 4: Очередь

5. Выход из программы.";
        const string Part1MENU = @"1. Создать список.
2. Вставить элемент по номеру.
3. Удалить элемент по номеру.
4. Просмотреть список.
6. Удалить все элементы.
7. Показать количество созданных элементов.

8. Выход из раздела.";
        const string Part2MENU = @"1. Создать список.
2. Вставить элемент по номеру.
3. Удалить элемент по номеру.
4. Просмотреть список.
6. Удалить все элементы.
7. Показать количество созданных элементов.

8. Выход из раздела.";
        const string Part3MENU = @"1. Создать дерево через capacity.
2. Создать дерево через массив.
3. Добавить элемент.
4. Просмотреть дерево.
5. Найти количество элементов дерева, начинающихся с заданного символа.
6. Удалить все элементы.
7. Показать количество созданных элементов.

8. Выход из раздела.";
        const string Part4MENU = @"1. Создать очередь.
2. Добавить элементы.
3. Удалить элементы.
4. Просмотреть очередь (foreach).
5. Найти элемент по ключу.
6. Найти элемент по заданному параметру.

7. Выход из раздела.";
        static string[] name = { "Шторы", "Гитара", "Стул", "Монитор", "Стол", "Кружка", "Конфета", "Тумбочка", "Сигареты", "Струны" };
        static Random rand = new Random();

        static void ENTER()
        {
            PrintColor("Нажмите на любую кнопку..", ConsoleColor.Blue);
            Console.ReadKey();
        }
        static void PrintColor(object s, ConsoleColor c, bool text = true, ConsoleColor b = ConsoleColor.Black)
        {
            if (text)
                Console.ForegroundColor = c;
            else
            {
                Console.BackgroundColor = c;
                Console.ForegroundColor = b;
            }
            Console.WriteLine(s);
            Console.ResetColor();

        }
        static void Part1()
        {
            MyList MyList = new MyList();
            while (true)
            {
                Console.Clear();
                Console.WriteLine(Part1MENU);
                int ch = Input.IntCheckConsole();   // Пользовательский класс
                try
                {
                    switch (ch)
                    {
                        case 1:
                            #region 
                            Console.Write("Введите размер нового списка: ");
                            int size = Input.IntCheckConsole();
                            MyList = new MyList(size);
                            #endregion
                            ENTER();
                            break;
                        case 2:
                            #region
                            Console.Write("Введите номер нового элемента: ");
                            int pos = Input.IntCheckConsole();
                            int speed = rand.Next(1, 800);
                            int countMen = rand.Next(1, 1000);

                            MyList.Insert(pos, new Transport(speed, countMen));
                            #endregion
                            ENTER();
                            break;
                        case 3:
                            #region
                            Console.Write("Введите номер элемента, который вы хотите удалить: ");
                            pos = Input.IntCheckConsole();
                            MyList.RemoveAt(pos - 1);
                            #endregion
                            ENTER();
                            break;
                        case 4:
                            PrintColor("Созданные элементы:", ConsoleColor.Blue);
                            PrintColor(MyList, ConsoleColor.DarkYellow);
                            ENTER();
                            break;
                        case 6:
                            #region 
                            MyList.Clear();
                            PrintColor("Список пуст!", ConsoleColor.Blue);
                            #endregion
                            ENTER();
                            break;
                        case 7:
                            #region
                            Console.Write("Количество созданных элементов: ");
                            PrintColor(MyList.Count, ConsoleColor.Green, false);
                            #endregion
                            ENTER();
                            break;
                        default:
                            #region
                            PrintColor("Неопрознанное значение!", ConsoleColor.Red);
                            #endregion
                            ENTER();
                            break;
                    }
                }
                catch (Exception e)
                {
                    PrintColor(e.Message, ConsoleColor.Red);
                    ENTER();
                }
            }
        }
        static void Part2()
        {
            MyLinkedList MyList = new MyLinkedList();
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.Write(Part2MENU);
                int ch = Input.IntCheckConsole();
                try
                {
                    switch (ch)
                    {
                        case 1:
                            #region
                            Console.Write("Введите размер нового списка: ");
                            int size = Input.IntCheckConsole();
                            MyList = new MyLinkedList(size);
                            ENTER();
                            break;
                        #endregion
                        case 2:
                            #region
                            Console.Write("Введите номер нового элемента: ");
                            int pos = Input.IntCheckConsole();
                            int speed = rand.Next(1, 800);
                            int countMen = rand.Next(3, 1000);

                            MyList.Insert(pos, new Transport(speed, countMen));
                            #endregion
                            ENTER();
                            break;
                        case 3:
                            #region
                            Console.Write("Введите номер элемента, который вы хотите удалить: ");
                            pos = Input.IntCheckConsole();
                            MyList.RemoveAt(pos - 1);
                            #endregion
                            ENTER();
                            break;
                        case 4:
                            PrintColor("Созданные элементы:", ConsoleColor.Blue);
                            PrintColor(MyList, ConsoleColor.DarkYellow);
                            ENTER();
                            break;
                        case 6:
                            #region 
                            MyList.Clear();
                            PrintColor("Список пуст!", ConsoleColor.Blue);
                            #endregion
                            ENTER();
                            break;
                        case 7:
                            #region
                            Console.Write("Количество созданных элементов: ");
                            PrintColor(MyList.Count, ConsoleColor.Green, false);
                            #endregion
                            ENTER();
                            break;

                        case 8:
                            flag = !flag;
                            break;
                        default:
                            #region
                            PrintColor("Неопрознанное значение!", ConsoleColor.Red);
                            ENTER();
                            #endregion
                            break;

                    }
                }
                catch (Exception e)
                {
                    PrintColor(e.Message, ConsoleColor.Red);
                    ENTER();
                }
            }
        }

        static void Part3()
        {
            Tree tree = new Tree();
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine(Part3MENU);
                int ch = Input.IntCheckConsole();   // Пользовательский класс
                try
                {
                    switch (ch)
                    {
                        case 1:
                            #region 
                            PrintColor("Введите размер нового дерева: ", ConsoleColor.Blue);
                            int size = Input.IntCheckConsole();
                            tree = new Tree(size);
                            #endregion
                            ENTER();
                            break;
                        case 2:
                            #region
                            PrintColor("Введите размерность массива: ", ConsoleColor.Blue);
                            size = Input.IntCheckConsole();
                            Transport[] array = new Transport[size];
                            for (int i = 0; i < size; i++)
                            {
                                string na = Program.name[rand.Next(0, Program.name.Length - 1)];
                                int si = rand.Next(0, 50) - 25;
                                float co = rand.Next(1, 1000);
                                int sa = rand.Next(0, 99);
                                int da = rand.Next(1, 31);
                                int mo = rand.Next(1, 12);
                                int ye = rand.Next(0, 9999);
                                Transport m = new Transport(na, si, co, sa, new Date(da, mo, ye));

                                array[i] = m;
                            }

                            tree = new Tree(array);
                            #endregion
                            ENTER();
                            break;
                        case 3:
                            #region
                            string name = Program.name[rand.Next(0, Program.name.Length - 1)];
                            int s = rand.Next(0, 50) - 25;
                            float cost = rand.Next(1, 1000);
                            int sale = rand.Next(0, 99);
                            int day = rand.Next(1, 31);
                            int month = rand.Next(1, 12);
                            int year = rand.Next(0, 9999);
                            Transport obj = new Transport(name, s, cost, sale, new Date(day, month, year));

                            tree.AddElement(obj);
                            PrintColor("Новый элемент: ", ConsoleColor.Blue);
                            PrintColor(obj, ConsoleColor.Green);
                            #endregion
                            ENTER();
                            break;
                        case 4:
                            PrintColor("Дерево печатается в порядке возрастания (Первых букв в имени) сверху вниз: ",
                                ConsoleColor.Blue);
                            PrintColor(tree, ConsoleColor.Yellow);
                            ENTER();
                            break;
                        case 5:
                            #region 
                            PrintColor("Введите букву для поиска элемента дерева: ", ConsoleColor.Blue);
                            char Character = Console.ReadKey().KeyChar;
                            Console.WriteLine();
                            Transport searched = tree.SearchCharBeginName(Character);
                            if (searched == null) PrintColor("Объект не найден", ConsoleColor.Magenta);
                            else PrintColor("Найденый объект:\n" + searched, ConsoleColor.Green);
                            #endregion
                            ENTER();
                            break;
                        case 6:
                            #region 
                            tree.Clear();
                            PrintColor("Дерево было удалено!", ConsoleColor.Green);
                            #endregion
                            ENTER();
                            break;
                        case 7:
                            PrintColor("Элементов в дереве: " + tree.GetCount, ConsoleColor.Blue);
                            ENTER();
                            break;
                        case 8:
                            flag = !flag;
                            break;
                        default:
                            #region
                            PrintColor("Неопрознанное значение!", ConsoleColor.Red);
                            #endregion
                            ENTER();
                            break;
                    }
                }
                catch (Exception e)
                {
                    PrintColor(e.Message, ConsoleColor.Red);
                    ENTER();
                }
            }
        }

        //static void Part4()
        //{
        //    UQueue<int> MyList = new UQueue<int>();
        //    bool flag = true;
        //    while (flag)
        //    {
        //        Console.Clear();
        //        Console.Write(Part4MENU);
        //        int ch = Input.IntCheckConsole();
        //        try
        //        {
        //            switch (ch)
        //            {
        //                case 1:
        //                    #region 
        //                    Console.Write("Введите размер нового списка: ");
        //                    int size = Input.IntCheckConsole();
        //                    int[] arr = new int[size];
        //                    for (int i = 0; i < size; i++)
        //                    {
        //                        Console.WriteLine($"Введите значение для [{i + 1}] элемента: ");
        //                        arr[i] = Input.IntCheckConsole();
        //                    }
        //                    MyList = new UQueue<int>(arr);
        //                    #endregion
        //                    ENTER();
        //                    break;
        //                case 2:
        //                    #region
        //                    Console.Write("Введите номер нового элемента: ");
        //                    int pos = Input.IntCheckConsole();
        //                    Console.WriteLine($"Введите [{pos}] элемент: ");
        //                    int elem = Input.IntCheckConsole();
        //                    MyList.Insert(index: pos - 1, item: elem);
        //                    #endregion
        //                    ENTER();
        //                    break;
        //                case 3:
        //                    #region
        //                    Console.Write("Введите номер элемента, который вы хотите удалить: ");
        //                    pos = Input.IntCheckConsole();
        //                    MyList.RemoveAt(index: pos - 1);
        //                    #endregion
        //                    ENTER();
        //                    break;
        //                case 4:
        //                    foreach (var it in MyList)
        //                    {
        //                        PrintColor(it, ConsoleColor.DarkYellow);
        //                    }
        //                    ENTER();
        //                    break;
        //                case 5:
        //                    PrintColor("Введите индекс элемента, который хотите вывести:", ConsoleColor.Blue);
        //                    size = Input.IntCheckConsole();
        //                    PrintColor(MyList[size - 1], ConsoleColor.DarkYellow);
        //                    ENTER();
        //                    break;
        //                case 6:
        //                    #region 
        //                    PrintColor("Введите ключ поиска:", ConsoleColor.Blue);
        //                    int key = Input.IntCheckConsole();
        //                    PrintColor("Существование данного элемента: ", ConsoleColor.Blue);
        //                    PrintColor(MyList.Contains(key), ConsoleColor.Yellow);
        //                    PrintColor("Его первое вхождение: ", ConsoleColor.Blue);
        //                    PrintColor(MyList.IndexOf(key) + " - начиная с нуля.", ConsoleColor.Green);
        //                    #endregion
        //                    ENTER();
        //                    break;
        //                case 7:
        //                    flag = !flag;
        //                    break;
        //                default:
        //                    #region
        //                    PrintColor("Неопрознанное значение!", ConsoleColor.Red);
        //                    #endregion
        //                    ENTER();
        //                    break;

        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            PrintColor(e.Message, ConsoleColor.Red);
        //            ENTER();
        //        }
        //    }

        //}

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Default;
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.Write(MainMENU);
                int ch = Input.IntCheckConsole();
                switch (ch)
                {
                    case 1:
                        Part1();
                        ENTER();
                        break;
                    case 2:
                        Part2();
                        ENTER();
                        break;
                    case 3:
                        part3();
                        enter();
                        break;
                    //case 4:
                    //    Part4();
                    //    ENTER();
                    //    break;
                    case 5:
                        flag = !flag;
                        break;
                    default:
                        #region
                        PrintColor("Неопрознанное значение!", ConsoleColor.Red);
                        #endregion
                        ENTER();
                        break;

                }
            }
        }
    }
}



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
        const string MenuList = @"1. Создать список.
2. Вставить элемент по номеру.
3. Удалить элемент по номеру.
4. Просмотреть список.
5. Добавить элемент после транспорта со скоростью n.
6. Удалить все элементы.
7. Показать количество созданных элементов.

8. Выход из раздела.";
        const string MenuLinkedList = @"1. Создать список.
2. Вставить элемент по номеру.
3. Удалить элемент по номеру.
4. Просмотреть список.
5. Удалить элементы с четной скоростью.
6. Удалить все элементы.
7. Показать количество созданных элементов.

8. Выход из раздела.";
        const string MenuTree = @"1. Создать дерево через capacity.
2. Создать дерево через массив.
3. Добавить элемент.
4. Просмотреть дерево.
5. Найти количество элементов дерева, начинающихся с заданного символа.
6. Удалить все элементы.
7. Показать количество созданных элементов.

8. Выход из раздела.";
        const string MenuQueue = @"1. Создать очередь.
2. Добавить элементы.
3. Удалить элементы.
4. Просмотреть очередь (foreach).
5. Найти элемент номеру.
6. Найти элемент по ключу.

7. Выход из раздела.";
        static string[] MasName = { "Универсал", "Купе", "Лимузин", "Микроавтобус", "Кабиролет" };
        static string[] MasNameOfExpress = { "Красная стрела", "Полярная стрела", "Восток", "Арктика", "Белоруссия" };
        static Random rand = new Random();

      
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
                Console.WriteLine(MenuList);
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

                            break;
                        case 2:
                            #region
                            Console.Write("Введите номер нового элемента: ");
                            int pos = Input.IntCheckConsole();
                            int speed = rand.Next(1, 800);
                            int countMen = rand.Next(1, 1000);

                            MyList.Insert(pos, new Transport(speed, countMen));
                            #endregion

                            break;
                        case 3:
                            #region
                            Console.Write("Введите номер элемента, который вы хотите удалить: ");
                            pos = Input.IntCheckConsole();
                            MyList.RemoveAt(pos - 1);
                            #endregion

                            break;
                        case 4:
                            PrintColor("Созданные элементы:", ConsoleColor.Blue);
                            PrintColor(MyList, ConsoleColor.DarkYellow);

                            break;
                        case 5:
                            Console.Write("Введите n: ");
                            int s = Input.IntCheckConsole();
                            MyList.AddAfterEl(s);
                            PrintColor(MyList, ConsoleColor.DarkYellow);
                            break;
                        case 6:
                            #region 
                            MyList.Clear();
                            PrintColor("Список пуст!", ConsoleColor.Blue);
                            #endregion

                            break;
                        case 7:
                            #region
                            Console.Write("Количество созданных элементов: ");
                            PrintColor(MyList.Count, ConsoleColor.Green, false);
                            #endregion

                            break;
                        default:
                            #region
                            PrintColor("Неопрознанное значение!", ConsoleColor.Red);
                            #endregion
                            break;
                    }
                }
                catch (Exception e)
                {
                    PrintColor(e.Message, ConsoleColor.Red);
                }
            }
        }
        static void Part2()
        {
            MyLinkedList MyList = new MyLinkedList();
            bool flag = true;
            while (flag)
            {
                Console.Write(MenuLinkedList);
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

                            break;
                        case 3:
                            #region
                            Console.Write("Введите номер элемента, который вы хотите удалить: ");
                            pos = Input.IntCheckConsole();
                            MyList.RemoveAt(pos - 1);
                            #endregion

                            break;
                        case 4:
                            PrintColor("Созданные элементы:", ConsoleColor.Blue);
                            PrintColor(MyList, ConsoleColor.DarkYellow);

                            break;
                        case 5:
                            PrintColor("До удаления:", ConsoleColor.Blue);
                            PrintColor(MyList, ConsoleColor.DarkYellow);
                            MyList.RemoveSeveralEl();
                            PrintColor("После удаления:", ConsoleColor.Blue);
                            PrintColor(MyList, ConsoleColor.DarkYellow);
                            break;
                        case 6:
                            #region 
                            MyList.Clear();
                            PrintColor("Список пуст!", ConsoleColor.Blue);
                            #endregion

                            break;
                        case 7:
                            #region
                            Console.Write("Количество созданных элементов: ");
                            PrintColor(MyList.Count, ConsoleColor.Green, false);
                            #endregion

                            break;

                        case 8:
                            flag = !flag;
                            break;
                        default:
                            #region
                            PrintColor("Неопрознанное значение!", ConsoleColor.Red);
                            #endregion
                            break;
                    }
                }
                catch (Exception e)
                {
                    PrintColor(e.Message, ConsoleColor.Red);
                }
            }
        }

        static void Part3()
        {
            MyTree tree = new MyTree();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(MenuTree);
                int ch = Input.IntCheckConsole();
                int sp, c;
                try
                {
                    switch (ch)
                    {
                        case 1:
                            #region 
                            PrintColor("Введите размер нового дерева: ", ConsoleColor.Blue);
                            int size = Input.IntCheckConsole();
                            tree = new MyTree(size);
                            #endregion

                            break;
                        case 2:
                            #region
                            PrintColor("Введите размерность массива: ", ConsoleColor.Blue);
                            size = Input.IntCheckConsole();
                            Transport[] array = new Transport[size];
                            for (int i = 0; i < size; i++)
                            {
                                sp = rand.Next(1, 800);
                                c = rand.Next(1, 10000);
                                Transport m = new Transport(sp, c);

                                array[i] = m;
                            }

                            tree = new MyTree(array);
                            #endregion

                            break;
                        case 3:
                            #region
                            sp = rand.Next(1, 800);
                            c = rand.Next(1, 10000);
                            Transport obj = new Transport(sp, c);

                            tree.AddElement(obj);
                            PrintColor("Новый элемент: ", ConsoleColor.Blue);
                            PrintColor(obj, ConsoleColor.Green);
                            #endregion

                            break;
                        case 4:
                            PrintColor("Дерево печатается прямым обходом: ",
                                ConsoleColor.Blue);
                            PrintColor(tree, ConsoleColor.DarkYellow);

                            break;
                        case 5:
                            #region 
                            PrintColor("Введите цифру для поиска элемента дерева: ", ConsoleColor.Blue);
                            char Character = Console.ReadKey().KeyChar;
                            Console.WriteLine();
                            Transport searched = tree.SearchCharBeginName(Character);
                            if (searched == null) PrintColor("Объект не найден", ConsoleColor.Magenta);
                            else PrintColor("Найденый объект:\n" + searched, ConsoleColor.Green);
                            #endregion

                            break;
                        case 6:
                            #region 
                            tree.Clear();
                            PrintColor("Дерево было удалено!", ConsoleColor.Green);
                            #endregion

                            break;
                        case 7:
                            PrintColor("Элементов в дереве: " + tree.GetCount, ConsoleColor.Blue);

                            break;
                        case 8:
                            flag = !flag;
                            break;
                        default:
                            #region
                            PrintColor("Неопрознанное значение!", ConsoleColor.Red);
                            #endregion

                            break;
                    }
                }
                catch (Exception e)
                {
                    PrintColor(e.Message, ConsoleColor.Red);
                }
            }
        }
        static void PrintQueue(MyQueue<Transport> list)
        {
            foreach (var i in list)
            {
                PrintColor(i, ConsoleColor.DarkYellow);
            }
        }
        static void Part4()
        {
            MyQueue<Transport> list = new MyQueue<Transport>();
            bool flag = true;
            while (flag)
            {
                Console.Write(MenuQueue);
                int ch = Input.IntCheckConsole();
                try
                {
                    switch (ch)
                    {
                        case 1:
                            #region 
                            Console.Write("Введите размер нового списка: ");
                            int size = Input.IntCheckConsole();
                            Transport[] arr = new Transport[size];
                            for (int i = 0; i < size; i++)
                            {
                                if (i % 4 == 0)
                                    arr[i] = (new Transport(rand.Next(1, 800), rand.Next(1, 1000)));
                                else if (i % 3 == 0)
                                    arr[i] = (new Avtomobile(MasName[rand.Next(0, 4)], rand.Next(1, 300), rand.Next(1, 10)));
                                else if (i % 2 == 0)
                                    arr[i] = (new Rain(rand.Next(1, 100), rand.Next(1, 400), rand.Next(1, 1000)));
                                else
                                    arr[i] = (new Express(MasNameOfExpress[rand.Next(0, 4)], rand.Next(1, 100), rand.Next(1, 800), rand.Next(1, 1000)));
                            }
                            list = new MyQueue<Transport>(arr);
                            #endregion
                            
                            break;
                        case 2:
                            #region
                            Console.Write("Введите номер нового элемента: ");
                            int pos = Input.IntCheckConsole();
                            Transport k = new Transport(rand.Next(1, 800), rand.Next(1, 1000));
                            list.Insert(pos - 1, k);
                            #endregion
                            
                            break;
                        case 3:
                            #region
                            Console.Write("Введите номер элемента, который вы хотите удалить: ");
                            pos = Input.IntCheckConsole();
                            list.RemoveAt(pos - 1);
                            #endregion
                            break;
                        case 4:
                            foreach (var it in list)
                            {
                                PrintColor(it, ConsoleColor.DarkYellow);
                            }
                            
                            break;
                        case 5:
                            PrintColor("Введите индекс элемента, который хотите вывести:", ConsoleColor.Blue);
                            size = Input.IntCheckConsole();
                            PrintColor(list[size - 1], ConsoleColor.DarkYellow);
                            
                            break;
                        case 6:
                            #region 
                            PrintColor("Введите элемент для поиска", ConsoleColor.Blue);
                            PrintColor("Введите скорость:", ConsoleColor.Blue);
                            int c = Input.IntCheckConsole();
                            PrintColor("Введите количество человек: ", ConsoleColor.Blue);
                            int s = Input.IntCheckConsole();
                            k = new Transport(c, s);
                            PrintColor("Существование данного элемента: ", ConsoleColor.Blue);
                            PrintColor(list.Contains(k), ConsoleColor.Yellow);
                            PrintColor("Его первое вхождение: ", ConsoleColor.Blue);
                            PrintColor(list.IndexOf(k) + " - начиная с нуля.", ConsoleColor.Green);
                            #endregion
                            
                            break;
                        case 7:
                            flag = !flag;
                            break;
                        default:
                            #region
                            PrintColor("Неопрознанное значение!", ConsoleColor.Red);
                            #endregion
                            
                            break;

                    }
                }
                catch (Exception e)
                {
                    PrintColor(e.Message, ConsoleColor.Red);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Default;
            bool flag = true;
            while (flag)
            {
                
                Console.Write(MainMENU);
                int ch = Input.IntCheckConsole();
                switch (ch)
                {
                    case 1:
                        Part1();

                        break;
                    case 2:
                        Part2();
                        break;
                    case 3:
                        Part3();
                        break;
                    case 4:
                        Part4();
                        break;
                    case 5:
                        flag = !flag;
                        break;
                    default:
                        PrintColor("Неопрознанное значение!", ConsoleColor.Red);
                        break;
                }
            }
        }
    }
}



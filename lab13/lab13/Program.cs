using System;
using System.Collections.Generic;
using System.Text;
using MyLib;

namespace lab13
{
    delegate void AddRemoveShow(MyNewCollection act);
    delegate void ShowJournal(Journal journal);
    class Program
    {

        static string[] MasName = { "Универсал", "Купе", "Лимузин", "Микроавтобус", "Кабиролет" };
        static string[] MasNameOfExpress = { "Красная стрела", "Полярная стрела", "Восток", "Арктика", "Белоруссия" };
        const string MAINMENU = @"1. Добавить элемент в коллекцию.
2. Удалить элемент из коллекции.
3. Изменить элемент коллекции.
4. Просмотреть коллекцию.
5. Просмотреть журнал.
6. Отчистить журнал.
7. Отчистить список.

8. Выйти из программы.

Выберете из указанного списка номер: ";
        const string AddMENU = @"1. Добавить массив.
2. Добавить одиночный объект.
3. Добавить объект по умолчанию.

4. Отменить добавление.
Выберете из указанного списка номер: ";

        const string TypeMENU = @"1. Добавить объект типа Transport.
2. Добавить объект типа Rain.
3. Добавить объект типа Avtomobile.
4. Добавить объект типа Express.

5. Выйти из меню добавления.

Выберете из указанного списка номер: ";
        const string CollectionMENU = @"1. Первая коллекция.
2. Bторая коллекция.
Выберете из указанного списка номер: ";
        private const string JournalMenu = @"1. Первый журнал (add/delete, Referense 1 Collection)
2. Второй журнал (Referense 1,2 collection)
Выберете из указанного списка номер: ";
        
        static Random rand = new Random();

        static void ENTER()
        {
            Console.WriteLine("Нажмите любую клавишу..");
            Console.ReadKey();
        }

        static int CheckInt()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int k))
                {
                    return k;
                }
                else
                {
                    Console.WriteLine("Введено неизвестное значение!");
                }
            }
        }

        static void ChoiseCollectionForAct(AddRemoveShow act, MyNewCollection collect1, MyNewCollection collect2)
        {
            Console.WriteLine(CollectionMENU);
            int numCollect = CheckInt();
            if (numCollect < 1 || numCollect > 2)
            {
                throw new IndexOutOfRangeException("Выберете коллекцию 1 или 2?");
            }
            else if (numCollect == 1) act(collect1);
            else act(collect2);
        }

        static void ActionsJournal(ShowJournal show, Journal collect1, Journal collect2)
        {
            Console.WriteLine(JournalMenu);
            int numCollect = CheckInt();
            if (numCollect < 1 || numCollect > 2)
            {
                throw new IndexOutOfRangeException("Выберете коллекцию 1 или 2!");
            }
            else if (numCollect == 1) show(collect1);
            else show(collect2);
        }

        static void ShowJ(Journal journal)
        {
            Console.WriteLine(journal);
        }

        private static void ShowCollection(MyNewCollection act)
        {
            Console.WriteLine(act);
        }

        static Transport HandOrAuto<T>() where T : Transport, new()
        {
            Console.Clear();
            Console.Write(@"1. Ручной ввод
2. Параметры по умолчанию.
3. Рандомные значения.

Введите значение: ");
            int choise;
            choise = CheckInt();
            switch (choise)
            {
                case 1:
                    T cris = new T();

                    Console.WriteLine("Скорость: ");
                    int speed = CheckInt();
                    Console.WriteLine("Количество пассажиров: ");
                    int countMen = CheckInt();
                    int numberVan;
                    string nameExpress;
                    string bodyType;
                    if (cris is Rain)
                    {
                        Console.WriteLine("Количество вагонов: ");
                        numberVan = CheckInt();
                        if (cris is Express)
                        {
                            Console.WriteLine("Имя экспресса: ");
                            nameExpress = Console.ReadLine();
                            return new Express(nameExpress, numberVan, speed, countMen);
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
                        bodyType = Console.ReadLine();

                        return new Avtomobile(bodyType, speed, countMen);
                    }
                    else
                    {
                        return new Transport(speed, countMen);
                    }
                case 2:
                    return new T();
                case 3:
                    cris = new T();
                    speed = rand.Next(50, 800);
                    countMen = rand.Next(10, 1000);
                    if (cris is Rain)
                    {
                        numberVan = rand.Next(1, 100);
                        if (cris is Express)
                        {
                            nameExpress = MasNameOfExpress[rand.Next(0, 4)];
                            return new Express(nameExpress, numberVan, speed, countMen);
                        }
                        else
                            return new Rain(numberVan, speed, countMen);
                    }
                    else
                    {
                        if (cris is Avtomobile)
                        {
                            bodyType = MasName[rand.Next(0, 4)];
                            return new Avtomobile(bodyType, speed, countMen);
                        }
                        else
                        {
                            return new Transport(speed,countMen);
                        }
                    }
            }
            return new T();
        }

        static Transport AddTypeTransport(ref bool flag, string menu = TypeMENU)
        {
            Transport nwE = null;
            bool f = false;
            while (!f)
            {
                Console.Clear();
                Console.Write(menu);
                int choise = CheckInt();
                switch (choise)
                {
                    case 1:
                        nwE = HandOrAuto<Transport>();
                        f = !f;
                        break;
                    case 2:
                        nwE = HandOrAuto<Rain>();
                        f = !f;
                        break;
                    case 3:
                        nwE = HandOrAuto<Avtomobile>();
                        f = !f;
                        break;
                    case 4:
                        nwE = HandOrAuto<Express>();
                        f = !f;
                        break;
                    case 5:
                        flag = !flag;
                        f = !f;
                        break;
                    default:
                        Console.WriteLine("Неопознанное значение");
                        ENTER();
                        break;
                }
            }
            return nwE;
        }

        static void AddElemInCollection(MyNewCollection collect)
        {
            bool t = false;
            while (!t)
            {
                Console.Clear();
                Console.Write(AddMENU);
                int choise = CheckInt();
                switch (choise)
                {
                    case 1:
                        List<Transport> list = new List<Transport>();
                        int size = 0;
                        bool flag = false;
                        while (!flag)
                        {
                            list.Add(AddTypeTransport(ref flag, $"Добавить {size + 1}-й элемент\n" +
                                TypeMENU));
                            size++;
                        }
                        list.RemoveAt(size - 1);
                        size--;
                        if (size != 0)
                        {
                            Transport[] arr = new Transport[size];
                            list.CopyTo(arr, 0);
                            collect.Add(arr);
                        }
                        else
                        {
                            Console.WriteLine("Попытка добавления пустого массива!");
                        }
                        ENTER();
                        t = true;
                        break;
                    case 2:
                        Transport nwE = AddTypeTransport(ref t, $"Добавить {collect.Count} элемент\n" +
                            TypeMENU);
                        if (nwE != null)
                            collect.Add(nwE);
                        else
                        {
                            Console.WriteLine("Попытка добавления пустого элемента!");
                        }
                        t = true;
                        ENTER();
                        break;
                    case 3:
                        collect.AddDefault();
                        ENTER();
                        t = true;
                        break;
                    case 4:
                        t = true;
                        break;
                    default:
                        Console.WriteLine("Неопознанное значение..");
                        ENTER();
                        break;
                }
            }
        }

        static void RemoveInCollection(MyNewCollection collect)
        {
            Console.Write("Какой элемент нужно удалить? Введите значение: ");
            int position = CheckInt() - 1;
            collect.Remove(position);
        }

        static Transport ReferenseItem(int pos)
        {
            bool koef = true;
            return AddTypeTransport(ref koef, "Новый заменяемый объект:\n" + TypeMENU);
        }

        static void ChangeItemCollection(MyNewCollection collect)
        {
            Console.Write("Какой элемент нужно изменить? Введите значение:");
            int position = CheckInt() - 1;
            if (position >= collect.Count || position < 0)
            {
                Console.WriteLine("Введенный индекс вне границ массива!");
                return;
            }
            Transport nwEchange = ReferenseItem(position);
            collect[position] = nwEchange;
        }

        static void Clear(Journal journal)
        {
            journal.Clear();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Default;
            MyNewCollection OneCollect = new MyNewCollection();
            MyNewCollection TwoCollect = new MyNewCollection();
            Journal oneJournal = new Journal();
            Journal twoJournal = new Journal();

            // создаем возможные события для объекта типа MyNewCollection и подписываем на событие объект класса Journal

            // подписка на события первого журнала:
            // добавление\удаление и изменение элементов 1 коллекции
            OneCollect.CollectionCountChanges += new MyCollectionHandler(oneJournal.CollectionCountChanged);
            OneCollect.CollectionReferenceChanges += new MyCollectionHandler(oneJournal.CollectionReferenceChanged);

            // подписка на события второго журнала:
            // изменение элементов 1 и 2 коллекции
            OneCollect.CollectionReferenceChanges += new MyCollectionHandler(twoJournal.CollectionReferenceChanged);
            TwoCollect.CollectionReferenceChanges += new MyCollectionHandler(twoJournal.CollectionReferenceChanged);

            AddRemoveShow act;
            ShowJournal show;
            bool flag = false;
            while (!flag)
            {
                try
                {
                    Console.Clear();
                    Console.Write(MAINMENU);
                    int choise = CheckInt();
                    switch (choise)
                    {
                        case 1:
                            act = new AddRemoveShow(AddElemInCollection);
                            ChoiseCollectionForAct(act, OneCollect, TwoCollect);
                            Console.WriteLine("Элементы успешно добавлены");
                            break;
                        case 2:
                            act = new AddRemoveShow(RemoveInCollection);
                            ChoiseCollectionForAct(act, OneCollect, TwoCollect);
                            Console.WriteLine("Элементы успешно удалены");
                            break;
                        case 3:
                            act = new AddRemoveShow(ChangeItemCollection);
                            ChoiseCollectionForAct(act, OneCollect, TwoCollect);
                            Console.WriteLine("Элемент успешно изменен");
                            ENTER();
                            break;
                        case 4:
                            act = new AddRemoveShow(ShowCollection);
                            ChoiseCollectionForAct(act, OneCollect, TwoCollect);
                            ENTER();
                            break;
                        case 5:
                            show = new ShowJournal(ShowJ);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Журнал событий: ");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            ActionsJournal(show, oneJournal, twoJournal);
                            Console.ResetColor();
                            ENTER();
                            break;
                        case 6:
                            show = new ShowJournal(Clear);
                            ActionsJournal(show, oneJournal, twoJournal);
                            Console.WriteLine("Журнал отчищен!");
                            ENTER();
                            break;
                        case 7:
                            act = new AddRemoveShow(x => x.Clear());
                            ChoiseCollectionForAct(act, OneCollect, TwoCollect);
                            Console.WriteLine("Коллекция отчищена");
                            break;
                        case 8:
                            flag = !flag;
                            break;
                        default:
                            Console.WriteLine("Неопознанное значение!");
                            ENTER();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    ENTER();
                }

            }

        }
    }
}


using System;
using lab9;
namespace lab9
{
    class Program
    {
        static Random rnd = new Random();
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
        static void InputHoursMin(ref int hours, ref int min)
        {
            Console.Write("Введите часы: ");
            CheckInput(out hours, "");
            Console.Write("Введите минуты: ");
            CheckInput(out min, "");
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

        static void ScriptDemonstrationPart1()
        {
            Time time = new Time();
            ShowGreen("Объект 1 без параметров создан: " + time);

            //ShowGreen("Объект 1 6 + Time: " + (6 + time));
            //ShowGreen("Объект 1 Time + 6: " + (time + 6));

            Console.Write("Введите часы для объекта 2: ");
            CheckInput(out int hours, "");
            Console.Write("Введите минуты объекта 2: ");
            CheckInput(out int min, "");
            Time time1 = new Time(hours, min);
            ShowGreen("Объект 2 с параметрами создан: " + time1);

            Console.Write("Изменение полей класса.\nПосле изменнения будет произведено вычитание статическим методом\n Введите часы для объекта 1: ");
            CheckInput(out hours, "");
            Console.Write("Введите минуты для объекта 1: ");
            CheckInput(out min, "");
            time.Initialization(hours, min);
            ShowGreen("Объект 1: " + time);


            Console.Write("Введите часы для объекта 2: ");
            CheckInput(out hours, "");
            Console.Write("Введите минуты объекта 2: ");
            CheckInput(out min, "");
            time1.Initialization(hours, min);
            ShowGreen("Объект 2: " + time);

            Time time2 = new Time();
            time2 = Time.MinusTime(time, time1);
            Console.WriteLine("Вычитание объектов Time.\n Результат вычитания 2-го объекта из 1-го статическим методом: " + time2);

            Console.Write("Изменение полей класса.\nПосле изменнения будет произведено вычитание обычным методом");
            Console.WriteLine("Введите часы объекта 3: ");
            CheckInput(out hours, "");
            Console.Write("Введите минуты для объекта 3: ");
            CheckInput(out min, "");
            Time time3 = new Time(hours, min);

            Console.Write("Введите часы объекта 2: ");
            CheckInput(out hours, "");
            Console.Write("Введите минуты для объекта 2: ");
            CheckInput(out min, "");
            time2.Initialization(hours, min);
            Console.WriteLine();
            Console.WriteLine("Объект 3" + time3);
            Console.WriteLine("Объект 2" + time2);

            Console.WriteLine("Результат вычитания 2-го из 3-го объекта обычным методом: ");
            ShowGreen(time3.MinusTime(time2).ToString());
            Console.WriteLine("Объектов было создано: " + Time.Counter);
            //if (true)
            //{
            //    Time time4 = new Time();
            //    Console.WriteLine("Создание локального объекта. Всего объектов было создано:" + Time.Counter);
            //}

            //Console.WriteLine("После выхода из локальной области: " + Time.Counter);
            Console.Write("Вывод объекта с помощью метода. Show() ");
            time.Show();


            Console.WriteLine("Сравнение на равенство (Equals)");
            Console.WriteLine($"Объект 1: {time}");
            Console.WriteLine($"Объект 2: {time2}");
            if (Time.Equals(time, time2))
            {
                Console.WriteLine("Объекты равны");
            }
            else
            {
                Console.WriteLine("Объекты не равны");
            }

            Console.WriteLine("Хеш-код объекта time: " + time.GetHashCode());
        }
        static void ScriptDemonstrationPart2()
        {

            Console.Write("Введите часы для объекта 1: ");
            CheckInput(out int hours);
            Console.Write("Введите минуты для объекта 1: ");
            CheckInput(out int min);
            Time time = new Time(hours, min);
            ShowGreen("Объект 1: " + time);
            Console.Write("Введите часы для объекта 2: ");
            CheckInput(out hours);
            Console.Write("Введите минуты для объекта 2: ");
            CheckInput(out min);
            Time time1 = new Time(hours, min);
            ShowGreen("Объект 2: " + time1);

            Console.WriteLine("Объект 1: " + time);
            time++;
            ShowGreen("Объект 1 после инкремента: " + time);
            time--;
            ShowGreen("Объект 1 после декремента: " + time);

            Console.WriteLine("Объект 2: " + time1);
            time1++;
            ShowGreen("Объект 2 после инкремента: " + time1);

            time1--;
            ShowGreen("Объект 2 после декремента: " + time1);


            if ((bool)time1)
            {
                ShowGreen("Часы и минуты не равны нулю");
            }
            else
            {
                ShowGreen("Часы и минуты равны нулю");
            }
            Console.WriteLine();
            int k = time;
            ShowGreen("Объект 1: " + time);
            ShowGreen("Неявное преобразование в int: " + k);

            Console.WriteLine("Сравнение");
            if (time < time1)
            {
                Console.WriteLine("Объект 1 меньше, чем объект 2");
            }
            else
            {
                Console.WriteLine("Объект 1 больше, чем объект 2");
            }
        }
        static void Part2()
        {
            Time obj = new Time();
            bool flag = false;
            while (!flag)
            {
                int hours = 0, min = 0;
                Console.WriteLine(@"1. Демонстация перегрузок класса Time.
2. Создание объекта со значениями ГСЧ.
3. Создание объекта с вводом значений.
4. Показать объект.
5. Инкремент у объекта.
6. Декремент у объекта.
7. Явное перобразование (в bool).
8. Неявное перобразование (в int).
9. Сравнение объектов.

10. Выход");
                CheckInput(out int choise);
                switch (choise)
                {
                    case 1:
                        ScriptDemonstrationPart2();
                        break;
                    case 2:
                        hours = rnd.Next(0, 500);
                        min = rnd.Next(0, 500);
                        obj.Initialization(hours, min);
                        ShowGreen("Объект создан: " + obj);
                        break;
                    case 3:
                        InputHoursMin(ref hours, ref min);
                        obj.Initialization(hours, min);
                        ShowGreen("Объект создан: " + obj);
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkGreen; // устанавливаем цвет
                        obj.Show();
                        Console.ResetColor(); // сбрасываем в стандартный
                        break;
                    case 5:
                        Console.WriteLine("Инкремент ");
                        obj++;
                        ShowGreen(obj.ToString());
                        break;
                    case 6:
                        Console.WriteLine("Декремент ");
                        obj--;
                        ShowGreen(obj.ToString());
                        break;
                    case 7:
                        Console.WriteLine("Явное преобразование: " + (bool)obj);
                        break;
                    case 8:
                        int k = obj;
                        Console.WriteLine("Неявное преобразование в int: " + k);
                        break;
                    case 9:
                        Console.WriteLine("Создание нового объекта для демонстрации сравнения");
                        InputHoursMin(ref hours, ref min);
                        Time crisp = new Time(hours, min);
                        Console.WriteLine("Объект 1: " + obj);
                        Console.WriteLine("Объект 2: " + crisp);
                        if (obj < crisp)
                        {
                            ShowGreen("Объект 1 < Объект 2");
                        }
                        else
                        {
                            ShowGreen("Объект 1 > Объект 2");
                        }
                        break;
                    case 10:
                        flag = !flag;
                        break;
                    default:
                        ShowRed("Введено неопрознанное значение!");
                        break;
                }
            }
        }
        static void Part3()
        {
            TimeArraye array = new TimeArraye();
            bool flag = false;
            while (!flag)
            {
                Console.WriteLine(@"1. Создать массив без параметров.
2. Создать массив с рандомными значениями.
3. Создать массив с введенными значениями.
4. Показать массив.
5. Получить объект класса Time.
6. Получить количество созданных массивов.
7. Показать максимальное время.
8. Перезаписать значение в элементе массива
 
9. Выход");
                CheckInput(out int choise);
                switch (choise)
                {
                    case 1:
                        array = new TimeArraye();
                        ShowGreen("Массив создан");
                        break;
                    case 2:
                        Console.Write("На сколько элементов создать массив? ");
                        CheckInput(out int size);
                        array = new TimeArraye(0, size);
                        ShowGreen("Массив создан");
                        break;
                    case 3:
                        Console.Write("На сколько элементов создать массив? ");
                        CheckInput(out size);
                        array = new TimeArraye(1, size);
                        ShowGreen("Массив создан");
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkGreen; // устанавливаем цвет
                        array.Show();
                        Console.ResetColor(); // сбрасываем в стандартный
                        break;
                    case 5:
                        try
                        {
                            Console.Write("Какой номер элемента?");
                            CheckInput(out int index);
                            Console.ForegroundColor = ConsoleColor.DarkGreen; // устанавливаем цвет
                            array[index - 1].Show();
                            Console.ResetColor(); // сбрасываем в стандартный
                        }
                        catch (ArgumentOutOfRangeException e)
                        {
                            ShowRed(e.Message);
                        }
                        break;
                    case 6:
                        ShowGreen("Число созданных объектов: " + TimeArraye.Counter);
                        break;
                    case 7:
                        try
                        {
                            Console.Write("Максимальное время, зафиксированное в массиве: ");
                            array.ShowMax();
                        }
                        catch (Exception e)
                        {
                            ShowRed(e.Message);
                        }
                        break;
                    case 8:
                        try
                        {
                            Console.Write("Какой элемент перезаписать?");
                            CheckInput(out int k);
                            int khour = 0, kmin = 0;
                            InputHoursMin(ref khour, ref kmin);
                            array[k - 1].Hours = khour;
                            array[k - 1].Min = kmin;
                            Console.ForegroundColor = ConsoleColor.DarkGreen; // устанавливаем цвет
                            array.Show();
                            Console.ResetColor(); // сбрасываем в стандартный
                        }
                        catch (Exception e)
                        {
                            ShowRed(e.Message);
                        }
                        break;
                    case 9:
                        flag = !flag;
                        break;
                    default:
                        ShowRed("Введено неопрознанное значение!");
                        break;

                }
            }

        }
        static void Part1()
        {
            Time obj = new Time();
            bool ok = false;
            while (!ok)
            {
                int hours = 0;
                int min = 0;
                Console.WriteLine(@"1. Демонстация функционала класса Time (без перегруженных операторов).
2. Создать объект и заполнить с помощью ГСЧ.
3. Создать объект и заполнить вручную.
4. Показать объект.
5. Получить разность объектов статическим методом.

6. Выход");
                CheckInput(out int choise);
                switch (choise)
                {
                    case 1:
                        ScriptDemonstrationPart1();
                        break;
                    case 2:
                        hours = rnd.Next(0, 500);
                        min = rnd.Next(0, 500);
                        obj.Initialization(hours, min);
                        ShowGreen("Объект создан: " + obj);
                        break;
                    case 3:
                        InputHoursMin(ref hours, ref min);
                        obj.Initialization(hours, min);
                        ShowGreen("Объект создан: " + obj);
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkGreen; // устанавливаем цвет
                        obj.Show();
                        Console.ResetColor(); // сбрасываем в стандартный
                        break;
                    case 5:
                        Console.WriteLine("Объект 1");
                        InputHoursMin(ref hours, ref min);
                        obj.Initialization(hours, min);
                        Console.WriteLine("Объект 2");
                        InputHoursMin(ref hours, ref min);
                        Time time = new Time(hours, min);
                        obj = Time.MinusTime(obj, time);
                        ShowGreen("Результат: " + obj);
                        break;
                    case 6:
                        ok = !ok;
                        break;
                    default:
                        ShowRed("Введено неопознанное значение!");
                        break;
                }

            }
        }
        static void Main(string[] args)
        {
            bool flag = false;
            while (!flag)
            {
                Console.Clear();
                Console.WriteLine(@"1. Часть первая.
2. Часть вторая.
3. Часть третья.
4. Выход");
                CheckInput(out int choise);
                switch (choise)
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

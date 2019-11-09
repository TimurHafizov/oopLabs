using System;

namespace lab6
{
    class Program
    {
         Random rand = new Random();
        static void ShowError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
        static void ShowMsg(string msg)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
        static int ReadInt(string msg = "")
        {
            if (msg != "") Console.WriteLine(msg);
            bool ok;
            int num;
            do
            {
                ok = Int32.TryParse(Console.ReadLine(), out num);
                if (!ok) Console.WriteLine("Ошибка. Неверный ввод");
            } while (!ok);
            return num;
        }

        static int ReadRange(int max = 1000, int min = 1)
        {
            int choice;
            bool ok;
            do
            {
                ok = true;
                choice = ReadInt();
                if (choice < min)
                {
                    ok = false;
                    Console.WriteLine($"Ошибка. Число меньше минимального ({min})");
                }
                if (choice > max)
                {
                    ok = false;
                    Console.WriteLine($"Ошибка. Число больше максимального ({max})");
                }
            } while (!ok);
            return choice;
        }

        static int RandInt(int min = -50, int max = 50)
        {
            return rand.Next(min, max);
        }

        static char[] RandCharArr()
        {
            char[] arr = new char[RandInt(1, 20)];
            for (int i = 0; i < arr.Length; i++) arr[i] = RandChar();
            return arr;
        }

        static char RandChar(int min = 48, int max = 83)
        {
            return (char)rand.Next(min, max);
        }

        static char[] ReadCharArr()
        {
            return Console.ReadLine().ToCharArray();
        }

        static void Fill(ref char[][] arr)
        {
            Console.WriteLine(@"1 Заполнение с помощью ГСЧ
2 Заполнение вручную");
            int choice = ReadRange(2);
            switch (choice)
            {
                case 1:
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = RandCharArr();
                    }
                    break;
                case 2:
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine($"Введите символы {i + 1} - ой строки массива");
                        arr[i] = ReadCharArr();
                    }
                    break;
            }
        }

        static void Print(char[][] arr)
        {
            if (arr != null)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                Console.ResetColor();
            }
            else
            {
                ShowError("Строка пуста!");
            }
            
        }

        static void DeleteOneString(ref char[][] arr)
        {
            int q = 0;
            int number = -1;
            char[][] arr2;
            arr2 = new char[arr.Length - 1][];
            for (int i = 0; i < arr.Length; i++)
            {
                q = 0;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (Char.IsDigit(arr[i][j]))
                    {
                        q++;
                    }
                }
                if (q >= 3)
                {
                    number = i;
                    break;
                }
            }
            if (number == -1)
            {
                ShowError("В массиве нет строк, в которых 3 и более цифр");
            }
            else
            {
                Array.Copy(arr, 0, arr2, 0, number);
                Array.Copy(arr, number + 1, arr2, number, arr.Length - number - 1);
                arr = arr2;
                ShowMsg("Удалена первая встретившаяся строка, в которой не менее 3 цифр");
            }
        }



        static void CreateJagArr(out char[][] arr)
        {
            char[][] sub;
            Console.WriteLine("Введите количество строк");
            int rows = ReadRange();
            sub = new char[rows][];
            Fill(ref sub);
            arr = sub;
        }

        static string RandStr()
        {
            string str = "";
            switch (RandInt(0, 6))
            {
                case 0: str = "как дела? как мать? как отец!"; break;
                case 1: str = "Ты забудешь обо мне! на сиреневой луне! (с) Леонид Агутин."; break;
                case 2: str = "Погода была ясная. Прочитай книгу! Какая красивая роза!"; break;
                case 3: str = @"Так хочу тебя узнать ближе я, 
Остальное сейчас лишнее.
Я Хочу тебя узнать, почувствовать,
Что мы живы! Ещё живы!"; break;
                case 4: str = @"Так хочу тебя узнать ближе я, 
Остальное сейчас лишнее.
Я Хочу тебя узнать, почувствовать,
Что мы живы!"; break;
                case 5: str = @"А может просто потеряться, впрочем, как и миллионы. 
В мире цифрового глянца под дождями из 'Айфонов'!
В его обойме с каждым днём все больше патронов!
Я пробовал бороться вместо этого прошел пробы."; break;
                case 6: str = @"Что такое осень - это небо.
Плачущее небо под ногами!
В лужах разлетаются птицы с облаками.
Осень, я давно с тобою не был!"; break;
            }
            return str;
        }

        static void JagArr()
        {
            char[][] arr;
            CreateJagArr(out arr);
            int choice;
            do
            {
                Console.WriteLine(@"Введите:
1 — для печати массива
2 — для удаления из массива первой строки, в которой не менее 3 цифр
3 — для выхода");
                choice = ReadRange(3);
                switch (choice)
                {
                    case 1: Print(arr); break;
                    case 2: DeleteOneString(ref arr); break;
                }
            } while (choice != 3);
        }

        static void Print(string str)
        {
            if (Exist(str))
            {
                ShowMsg(str);
            }
            else
            {
                ShowError("Строка пуста!");
            }
        }

        static bool Exist(string str)
        {
            if (str != "\0")
                if (str.Length != 0) return true;
            return false;
        }

        static string DeleteExclamation(string str)
        {

            if (Exist(str))
            {
                string[] words;
                words = str.Split('.', '!', '?');
                
                int size = words.Length;

                char[] znaki = new char[size];

                int c = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '.' || str[i] == '?' || str[i] == '!')
                    {
                        znaki[c] = str[i];
                        c++;
                    }
                }
                int size2 = size;

                for(int i = 0; i < size; i++)
                {
                    words[i] += znaki[i];
                }
                
                for (int i = 0; i < size2; i++)
                {
                    if (znaki[i] == '!')
                    {
                        words = Remove(words, i);
                        znaki = Remove2(znaki, i);
                        i--;
                        size2--;
                    }
                }
                str = "";
                for (int i = 0; i < size2; i++)
                {
                    str += words[i];
                }
                Console.WriteLine("Строка после удаления восклицательных предложений:");
                Print(str);
                return str;
            }
            else
            {
                ShowError("Строка пуста");
                return "";
            }
           
        }

        static string[] Remove(string[] array, int indexToDelete)
        {
            if (array.Length == 0) return array;
            if (array.Length <= indexToDelete) return array;

            string[] output = new string[array.Length - 1];
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i == indexToDelete) continue;
                output[counter] = array[i];
                counter++;
            }

            return output;
        }
        static char[] Remove2(char[] array, int indexToDelete)
        {
            if (array.Length == 0) return array;
            if (array.Length <= indexToDelete) return array;

            char[] output = new char[array.Length - 1];
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i == indexToDelete) continue;
                output[counter] = array[i];
                counter++;
            }
            return output;
        }

        static void String()
        {
            int choice;
            Console.WriteLine(@"Введите:
1 — для ввода вручную
2 — для формирования случайно");
            choice = ReadRange(2);
            string str;
            if (choice == 1)
            {
                Console.WriteLine("Введите строку");
                str = Console.ReadLine();
            }
            else
            {
                str = RandStr();
            }
            do
            {
                Console.WriteLine(@"Введите:
1 — для вывода строки
2 — для удаления восклицательных предложений
3 — для выхода");
                choice = ReadRange(3);
                switch (choice)
                {
                    case 1: Print(str); break;
                    case 2: str = DeleteExclamation(str); break;
                }
            } while (choice != 3);
        }
        static void Main(string[] args)
        {
            ShowMsg("Лаборатоная работа №6");
            int choice;
            do
            {
                Console.WriteLine(@"Введите:
1 — для работы с массивом
2 — для работы со строкой
3 — для завершения программы");
                choice = ReadRange(3);
                switch (choice)
                {
                    case 1: JagArr(); break;
                    case 2: String(); break;
                }
            } while (choice != 3);
        }
    }
}

using System;

namespace lab1
{
    class Program
    {
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
                if (!ok) ShowError("Ошибка. Неверный ввод");
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
                    ShowError($"Ошибка. Число меньше минимально-допустимого ({min})");
                }
                if (choice > max)
                {
                    ok = false;
                    ShowError($"Ошибка. Число больше максимально-допустимого({max})");
                }
            } while (!ok);
            return choice;
        }

        static int RandInt(int min = 0, int max = 100)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }

        static void Fill(ref int[] arr, int choice = -1)
        {
            if (choice == -1)
            {
                Console.WriteLine(@"Введите 1 для заполения массива случайными числами
Введите 2 для ввода вручную");
                choice = ReadRange(2);
            }
            switch (choice)
            {
                case 1: RandFill(ref arr); break;
                case 2: UserFill(ref arr); break;
            }
        }

        static void Fill(ref int[,] arr)
        {
            int choice;
            Console.WriteLine(@"Введите 1 для заполения массива случайными числами
Введите 2 для ввода вручную");
            choice = ReadRange(2);
            switch (choice)
            {
                case 1: RandFill(ref arr); break;
                case 2: UserFill(ref arr); break;
            }
        }

        static void Fill(ref int[][] arr)
        {
            Console.WriteLine(@"Введите 1 для заполения массива случайными числами
Введите 2 для ввода вручную");
            int choice = ReadRange(2);
            switch (choice)
            {
                case 1: RandFill(ref arr); break;
                case 2: UserFill(ref arr); break;
            }
        }

        static void RandFill(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = RandInt();
        }

        static void RandFill(ref int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = RandInt();
        }

        static void RandFill(ref int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                RandFill(ref arr[i]);
        }

        static void UserFill(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = ReadInt($"Введите элемент номер {i + 1}");
        }

        static void UserFill(ref int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = ReadInt($"Введите элемент номер [{i + 1},{j + 1}]"); ;
        }

        static void UserFill(ref int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                UserFill(ref arr[i]);
        }

        static bool Exist(int[] arr)
        {
            if (arr != null)
                return arr.Length != 0;
            else return false;
        }

        static bool Exist(int[,] arr)
        {
            return arr.Length != 0;
        }

        static bool Exist(int[][] arr)
        {
            return arr.Length != 0;
        }


        static void PrintArray(int[] arr)
        {
            if (Exist(arr))
            {
                for (int i = 0; i < arr.Length; i++)
                    Console.Write(String.Format("{0,4}", arr[i]));
                Console.WriteLine();
            }
            else ShowMsg("Массив пуст");
        }

        static void PrintArray(int[,] arr)
        {
            if (Exist(arr))
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                        Console.Write(String.Format("{0,4}", arr[i, j]));
                    Console.WriteLine();
                }
            else ShowMsg("Массив пуст");
        }

        static void PrintArray(int[][] arr)
        {
            if (Exist(arr))
                for (int i = 0; i < arr.Length; i++)
                    PrintArray(arr[i]);
        }


        static void ChoiceDelete(ref int[] arr)
        {
            if (Exist(arr))
            {
                int N, K;

                Console.WriteLine("Сколько удалим?");
                N = ReadRange(arr.Length, 1);


                while (true)
                {
                    Console.WriteLine("С какого номера будем удалять?");
                    K = ReadRange(arr.Length, 1) - 1;
                    if ((K < arr.Length) && (K + 1 != 0))
                    {
                        if (((K + N) <= arr.Length))
                            //все норм
                            break;
                        else ShowError("Ошибка! При таких данных массив существовать не будет! Повторите ввод!");
                    }
                    else
                    {
                        ShowError("Ошибка! При таких данных массив существовать не будет! Повторите ввод!");
                    }
                }
                int size = arr.Length - N;
                int[] newArr = new int[size];
                DeleteEl(newArr, arr, K, N);
                arr = newArr;
                // DeleteInd(ref arr);
            }
            else
            {
                ShowError("Массив пуст");
            }
        }

        static void DeleteEl(int[] newMas, int[] mas, int K, int N)
        {
            if (newMas.Length != 0)
            {
                int count = 0;
                for (int i = 0; i < K; i++)
                {
                    newMas[count] = mas[i];
                    count++;
                }
                for (int i = K + N; i < mas.Length; i++)
                {
                    newMas[count] = mas[i];
                    count++;
                }
            }
        }

        static void UserFill2(ref int[,] arr, int n, int m)
        {
            string s;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    s = "Введите элемент номер [" + (i + 1) + "," + (3 * j + 3) + "]";
                    arr[i, j] = ReadInt(s);
                }
        }
        static void ChoiceAdd(ref int[,] arr, int sizeRow, int sizeColumn)
        {
            if (Exist(arr))
            {
                int newSizeColumn2 = sizeColumn / 2;
                int newSizeColumn = sizeColumn + sizeColumn / 2;
                int[,] newArr = CreateMatrix2(sizeRow, newSizeColumn);
                int[,] newArr2 = CreateMatrix2(sizeRow, newSizeColumn2);//массив который вводит пользователь
                if (sizeColumn >= 2)
                {
                    Console.WriteLine("Введите элементы, которые встанут на место добавленных столбцов");
                    int choice;
                    Console.WriteLine(@"Введите:
1 для заполения массива случайными числами
2 для ввода вручную
3 для ввода нулей, для наглядности");
                    choice = ReadRange(2);
                    switch (choice)
                    {
                        case 1:
                            for (int i = 0; i < sizeRow; i++)
                            {
                                for (int j = 0; j < newSizeColumn2; j++)
                                {
                                    newArr2[i, j] = RandInt();
                                }
                            }
                            break;
                        case 2: UserFill2(ref newArr2, sizeRow, newSizeColumn2); break;
                        case 3:
                            //обнуление выходного массива для наглядности
                            for (int i = 0; i < sizeRow; i++)
                            {
                                for (int j = 0; j < newSizeColumn; j++)
                                {
                                    newArr[i, j] = 0;
                                }
                            }
                            break;
                    }
                }
                else
                {
                    ShowError("Строк не хватает, чтобы были четные");
                }

                //nechet
                for (int i = 0; i < sizeRow; i++)
                {
                    for (int j = 0; j < newSizeColumn; j++)
                    {
                        if (2 * j <= sizeColumn && 3 * j < newSizeColumn)
                        {
                            newArr[i, 3 * j] = arr[i, 2 * j];
                        }
                    }
                }
                //chet
                for (int i = 0; i < sizeRow; i++)
                {
                    for (int j = 1; j < newSizeColumn; j++)
                    {
                        if (2 * j - 1 <= sizeColumn && 3 * j - 2 < newSizeColumn)
                        {
                            newArr[i, 3 * j - 2] = arr[i, 2 * j - 1];
                        }
                    }
                }
                //1243567
                for (int i = 0; i < sizeRow; i++)
                {
                    for (int j = 0; j < newSizeColumn; j++)
                    {
                        if (j <= newSizeColumn2 && 3 * j + 2 <= newSizeColumn - 1)
                        {
                            newArr[i, 3 * j + 2] = newArr2[i, j];
                        }
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                PrintArray(arr);
                Console.ResetColor();

                Console.WriteLine("После изменения:");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                PrintArray(newArr);
                Console.ResetColor();
            }
            else ShowError("Массив пуст");
        }

        static void ChoiceDelete(ref int[][] arr, int lines)
        {
            if (Exist(arr))
            {
                Console.WriteLine("После какой строки будем добавлять строки?");
                int n = ReadRange(lines, 1);
                Console.WriteLine("Сколько строк добавить? ");
                int k = ReadRange();
                int lines2 = k + lines;
                int[][] arr2 = new int[lines2][];
                CreateNewJagArray(ref arr, ref arr2, lines, lines2, n, k);
                arr = arr2;
            }
            else ShowError("Массив пуст");
        }
        static void CreateNewJagArray(ref int[][] jag, ref int[][] jag2, int lines, int lines2, int n, int k)
        {


            for (int i = 0; i < n; i++)
            {
                int colomn = jag[i].Length;
                jag2[i] = new int[colomn];
                for (int j = 0; j < colomn; j++)
                {
                    jag2[i][j] = jag[i][j];
                }
            }
            for (int i = n; i <= n + k - 1; i++)
            {
                int colomn = RandInt();
                jag2[i] = new int[colomn];
                for (int j = 0; j < colomn; j++)
                {
                    jag2[i][j] = RandInt();
                }
            }
            for (int i = n + k; i < lines2; i++)
            {
                int colomn = jag[i - k].Length;
                jag2[i] = new int[colomn];
                for (int j = 0; j < colomn; j++)
                {
                    jag2[i][j] = jag[i - k][j];
                }
            }
        }
        static int[] CreateVector(int size)
        {
            int[] arr = new int[size];
            Fill(ref arr);
            return arr;
        }
        static int[,] CreateMatrix(int sizeRow = 0, int sizeColumn = 0)
        {
            int[,] sub;
            if (sizeRow * sizeColumn == 0)
            {
                sub = new int[1, 1];
                sub[0, 0] = RandInt();
            }
            else
            {
                sub = new int[sizeRow, sizeColumn];
                Fill(ref sub);
            }
            return sub;
        }
        static int[,] CreateMatrix2(int sizeRow = 0, int sizeColumn = 0)
        {
            int[,] sub;
            if (sizeRow * sizeColumn == 0)
            {
                sub = new int[1, 1];
                sub[0, 0] = RandInt();
            }
            else
            {
                sub = new int[sizeRow, sizeColumn];
                Fill2(ref sub);
            }
            return sub;
        }
        static void Fill2(ref int[,] arr)
        {
            RandFill(ref arr);
        }
        private static void CreateJagArray(ref int[][] jag, int lines)
        {
            for (int i = 0; i < lines; i++)
            {
                int colomn = RandInt(1, 10);
                jag[i] = new int[colomn];
            }
        }
        //static void CreateJaggedArray(out int[][] arr, int choiceFill)
        //{
        //    int[][] sub;
        //    if (choiceFill != 0)
        //    {
        //        sub = new int[1][];
        //        sub[0] = new int[1];
        //        switch (choiceFill)
        //        {
        //            case 1: sub[0][0] = RandInt(); break;
        //            case 2: sub[0][0] = ReadInt("Введите число"); break;
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Введите количество строк");
        //        int rows = ReadRange();
        //        sub = new int[rows][];
        //        for (int i = 0; i < rows; i++)
        //        {
        //            Console.WriteLine($"Введите количество столбцов для строки {i + 1}");
        //            int col = ReadRange();
        //            sub[i] = new int[col];
        //        }
        //        Fill(ref sub);
        //    }
        //    arr = sub;
        //}


        static void Vector()
        {
            Console.WriteLine("Введите размерность массива");
            int size = ReadRange();
            int[] arr = CreateVector(size);
            int choice;
            do
            {
                Console.WriteLine(@"Введите:
1 — для печати массива
2 — для удаления элементов
3 — для выхода");
                choice = ReadRange(3);
                switch (choice)
                {
                    case 1: PrintArray(arr); break;
                    case 2: ChoiceDelete(ref arr); break;
                }

            } while (choice != 3);
        }

        static void Matrix()
        {
            Console.WriteLine("Введите количество строк");
            int sizeRow = ReadRange();
            Console.WriteLine("Введите количество столбцов");
            int sizeColumn = ReadRange();
            int[,] arr = CreateMatrix(sizeRow, sizeColumn);
            int choice;
            do
            {
                Console.WriteLine(@"Введите:
1 — для печати массива
2 — для добавления элементов после четных столбцов
3 — для выхода");
                choice = ReadRange(3);
                switch (choice)
                {
                    case 1: PrintArray(arr); break;
                    case 2: ChoiceAdd(ref arr, sizeRow, sizeColumn); break;
                }
            } while (choice != 3);
        }

        static void JaggedArray()
        {
            Console.WriteLine("Введите количество строк рваного массива");
            int lines = ReadRange();
            int[][] arr = new int[lines][];
            CreateJagArray(ref arr, lines);
            Fill(ref arr);
            int choice;
            do
            {
                Console.WriteLine(@"Введите 1 для печати массива
Введите 2 для добавления строк
Введите 3 для выхода");
                choice = ReadRange(3);
                switch (choice)
                {
                    case 1: PrintArray(arr); break;
                    case 2: ChoiceDelete(ref arr, lines); break;
                }
            } while (choice != 3);
        }

        static void Main(string[] args)
        {
            ShowMsg("Лаборатоная работа №5");
            int choice;
            do
            {
                Console.WriteLine(@"Введите:
1 — для работы с одномерным массивом
2 — для работы с двумерным массивом
3 — для работы с рваным массивом
4 — для завершения программы");
                choice = ReadRange(4);
                switch (choice)
                {
                    case 1: Vector(); break;
                    case 2: Matrix(); break;
                    case 3: JaggedArray(); break;
                }

            } while (choice != 4);
        }
    }
}
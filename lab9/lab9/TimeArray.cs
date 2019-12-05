using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace lab9
{


    class TimeArraye
    {
        private Time[] arr;
        private int size;
        static private Random rand = new Random();
        static private int counter;

        public Time[] Arr
        {
            get
            {
                return arr;
            }
            set
            {
                arr = value;
                size = arr.Length;
            }
        }
        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                if (value < 0)
                {
                    size = 0;
                }
                else
                {
                    size = value;
                }
                Time[] cases = new Time[size];
                if (Arr != null)
                    for (int i = 0; i < Arr.Length; i++)
                    {
                        cases[i] = Arr[i];
                    }
                Arr = cases;
            }
        }
        public static int Counter
        {
            get
            {
                return counter;
            }
        }

        public TimeArraye()
        {
            Size = 0;
            counter++;
        }
        void RandomInput()
        {
            for (int i = 0; i < Size; i++)
            {
                int hours = rand.Next(0, 500);
                int min = rand.Next(0, 500);
                Arr[i] = new Time(hours, min);
            }
        }
        void CheckInput(out int param)
        {
            param = 0;
            bool flag = false;
            while (!flag)
            {
                string c = Console.ReadLine();
                if (int.TryParse(c, out param))
                {
                    flag = !flag;
                }
                else
                {
                    Console.WriteLine("Неопознанное значение...");
                }
            }

        }
        void HandlyInput()
        {
            int hours, min;
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine("Введите " + i + "-ый элемент: ");
                Console.Write("Часы: ");
                CheckInput(out hours);
                Console.Write("Минуты: ");
                CheckInput(out min);
                Arr[i] = new Time(hours, min);
            }
        }
        public TimeArraye(int ok, int size)
        {
            this.Size = size;
            switch (ok)
            {
                case 0:
                    RandomInput();
                    break;
                case 1:
                    HandlyInput();
                    break;
                default:
                    break;
            }
            counter++;
        }
        ~TimeArraye()
        {
            counter--;
        }

        public Time this[int index]
        {
            get
            {
                if (index >= 0 && index < Size)
                    return Arr[index];
                else
                {
                    throw new ArgumentOutOfRangeException("Вышел за пределы массива");
                }
            }
            set
            {
                if (index > 0 && index < Size)
                {
                    Arr[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Вышел за пределы массива");
                }
            }
        }
        public void Show()
        {
            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"{Arr[i]}");
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void ShowMax()
        {
            Time[] time = new Time[Arr.Length];
            Arr.CopyTo(time, 0);
            Array.Sort(time);
            Console.WriteLine($"{time[time.Length - 1]}");
        }

        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < Arr.Length; i++)
            {
                output += Arr[i].ToString();
            }
            return output;
        }
        public override int GetHashCode()
        {
            int result = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                result += Arr[i].GetHashCode();
            }
            return result;
        }
        public override bool Equals(object obj)
        {
            TimeArraye array = obj as TimeArraye;
            if (this.Size == array.Size)
            {
                bool flag = false;
                for (int i = 0; i < Size && !flag; i++)
                {
                    if (!Arr[i].Equals(array[i]))
                    {
                        flag = true;
                    }
                }
                if (flag) return false;
                else return true;
            }
            else
            {
                return false;
            }
        }

    }
}
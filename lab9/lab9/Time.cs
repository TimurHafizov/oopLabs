using System;
using System.Collections.Generic;
using System.Text;

namespace lab9
{
    class Time : IComparable
    {
        int hours;
        int min;
        static int count = 0;

        public static int Counter
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
        public int Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if (value > 0)
                {
                    hours = value;
                }
                else
                {
                    hours = 0;
                }//Ограничиваем ввод часов по бизнес правилам.
            }
        }
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value < 0)
                {
                    min = value;
                }
                else
                {
                    if (value >= 60)
                    {
                        min = value;
                        Hours += min / 60;
                        min %= 60;
                    }
                    else
                    {
                        min = value;
                    }
                } //Ограничиваем ввод минут по бизнес правилам.
            }
        }
        public Time()
        {
            Hours = 0;
            Min = 0;
            Counter++;
        }//конструктор без параметров
        public Time(int h, int m)
        {
            Hours = h;
            Min = m;
            Counter++;
        }//конструктор с параметрам
        ~Time()
        {
            Counter--;
        }//деструктор
        public void Show()
        {
            Console.WriteLine("Время: " + Hours + ":" + Min);
        } // вывод объекта
        public void Initialization(int hours, int min)
        {
            Hours = hours;
            Min = min;
        } //инициализация объекта без помощи конструктора
        public Time MinusTime(Time time)
        {
            return Time.MinusTime(this, time);
        } // вычитание из объекта, вызвавшего метод, объект передеваемый в параметрах

        public static Time MinusTime(Time t1, Time t2)
        {
            int m, h;
            if (t1.Min < t2.Min)
            {
                t1.Hours--;
                m = t1.Min + 60 - t2.Min;
            }
            else
            {
                m = t1.Min - t2.Min;
            }
            if (t1.Hours < t2.Hours)
            {
                Console.WriteLine("Результат получился отрицательным. Значение обнулено!");
                h = 0;
                m = 0;
            }
            else
            {
                h = t1.Hours - t2.Hours;
            }
            Time t = new Time();
            t.Hours = h;
            t.Min = m;
            return t;
        } // статический метод вычитание из певого объекта второго


        //часть вторая
        public static Time operator ++(Time time)
        {
            time.Min++;
            return time;
        }//перегрузка инкремента
        public static Time operator --(Time time)
        {
            if ((bool)time)
            {
                time.Min--;

                if (time.Min < 0)
                {
                    time.Hours--;
                    time.Min = 59;
                }
                if (time.Hours < 0)
                {
                    Console.WriteLine("Часов меньше 0! Значение часов обнулено!");
                    time.Hours = 0;
                }
                return time;
            }
            else
            {
                Console.WriteLine("Меньше некуда");
                return time;
            }
            
        }//перегрузка декремента

        public static explicit operator bool(Time time)
        {
            if (time.Min == 0 && time.Hours == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }//существует ли что-то в объекте

        public static Time operator +(Time time, int val)
        {
            time.Min += val;
            return time;
        }
        public static Time operator +(int val, Time time)
        {
            time.Min += val;
            return time;
        }
        public static implicit operator int(Time time)
        {
            return time.Hours * 60 + time.Min;
        }//неявное приведение в инт
        public static bool operator <(Time a, Time b)
        {
            if (a.Hours * 60 + a.Min < b.Hours * 60 + b.Min)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//перегрузка оператора сравнения меньше
        public static bool operator >(Time a, Time b)
        {
            if (!(a < b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }//перегрузка оператора сравнения больше

        public int CompareTo(object obj)
        {
            if (obj is Time)
            {
                Time time = obj as Time;
                int hm1 = Hours * 60 + Min,
                    hm2 = time.Hours * 60 + time.Min;
                return hm1.CompareTo(hm2);
            }
            else
                throw new Exception();
        }//для сортировки
        public override string ToString()
        {
            return Hours + ":" + Min;
        }
        public override int GetHashCode()
        {
            return (Hours * 60 + Min).GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Time time = obj as Time;
            if (this.Hours == time.Hours)
            {
                if (Min == time.Min)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

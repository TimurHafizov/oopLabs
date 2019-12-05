using System;
using System.Collections.Generic;
using System.Text;
using lab10;

namespace lab10
{
    public class Transport : IComparable, ICloneable
    {
        private int speed;
        private int countMen;
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value < 0)
                {

                    speed = 0;
                }
                else
                {
                    speed = value;
                }
            }
        }
        public int CountMen
        {
            get
            {
                return countMen;
            }
            set
            {
                if (value < 0)
                {

                    countMen = 0;
                }
                else
                {
                    countMen = value;
                }
            }
        }
        public Transport()
        {
            this.Speed = 0;
            this.CountMen = 0;
        }
        public Transport(int s = 0, int c = 0)
        {
            this.Speed = s;
            this.CountMen = c;
        }
        public virtual void Info()
        {
            Console.WriteLine("Транспорт: " + "\n\tСкорость " + this.Speed + ";\n\tКоличество людей " + this.CountMen);
        }
        public void SoundTransport()
        {
            Console.WriteLine("Звук транспорта");
        }
        public int CompareTo(object obj)
        {
            if (obj is Transport)
            {
                Transport tran = obj as Transport;
                int o1 = Speed,
                    o2 = tran.Speed;
                return o1.CompareTo(o2);
            }
            throw new Exception();
        }//для сортировки
        public override bool Equals(object obj)
        {
            Transport tran = obj as Transport;
            if (this.Speed == tran.Speed && this.CountMen == tran.CountMen)
            {
                return true;
            }
            else
            {
                return false;
            }
        }// сравнение объектов
        public override string ToString()
        {
            return "Транспорт: " + "\n\tСкорость " + this.Speed + ";\n\tКоличество людей " + this.CountMen;
        }
        public override int GetHashCode()
        {
            return Speed.GetHashCode() + CountMen.GetHashCode();
        }
        public virtual object Clone()
        {
            return new Transport(Speed, CountMen);
        }

    }
}

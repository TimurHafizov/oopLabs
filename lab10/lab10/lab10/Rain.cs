using System;
using System.Collections.Generic;
using System.Text;

namespace lab10
{
    public class Rain : Transport, ICloneable
    {
        private int numberVan;
        public int NumberVan
        {
            get
            {
                return numberVan;
            }
            set
            {
                if (value < 1)
                {

                    numberVan = 1;
                }
                else
                {
                    numberVan = value;
                }
            }
        }
        public Rain() : base()
        {
            this.NumberVan = 0;
        }
        public Rain(int n = 0, int s = 0, int c = 0) : base(s, c)
        {
            this.NumberVan = n;
        }
        public override void Info()
        {
            Console.WriteLine("Поезд: " + "\n\tКоличество вагонов " + this.NumberVan +
               ";\n\tСкорость " + this.Speed + ";\n\tКоличество людей " + this.CountMen);
        }
        public override string ToString()
        {
            return "Поезд: " + "\n\tКоличество вагонов " + this.NumberVan +
               ";\n\tСкорость " + this.Speed + ";\n\tКоличество людей " + this.CountMen;
        }
        public void SoundRain()
        {
            Console.WriteLine("Звук поезда");
        }
        public override bool Equals(object obj)
        {
            if(!(obj is Rain))
            {
                return false;
            }
            if (!base.Equals(obj))
            {
                return false;
            }
            else
            {
                Rain rain = obj as Rain;
                if (this.NumberVan == rain.NumberVan)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }// сравнение объектов
        public override object Clone()
        {
            return new Rain(NumberVan, Speed, CountMen);
        }
        public override int GetHashCode()
        {
            return Speed.GetHashCode() + CountMen.GetHashCode() + NumberVan.GetHashCode();
        }
    }
}

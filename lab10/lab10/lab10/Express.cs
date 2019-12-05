using System;
using System.Collections.Generic;
using System.Text;

namespace lab10
{
    public class Express : Rain, ICloneable
    {
        private string nameExpress;
        public string NameExpress
        {
            get
            {
                return nameExpress;
            }
            set
            {
                if (value.Length == 0)
                {

                    nameExpress = "No name";
                }
                else
                {
                    nameExpress = value;
                }
            }
        }//экспресс отличается от поезда наличием имени поезда
        public Express() : base()
        {
            this.NameExpress = "Неизвестно";
        }
        public Express(string name = "Неизвестно", int n = 0, int s = 0, int c = 0) : base(n, s, c)
        {
            this.NameExpress = name;
        }
        public override void Info()
        {
            Console.WriteLine("Экспресс: " + "\n\tИмя поезда " + this.NameExpress + ";\n\tКоличество вагонов " + this.NumberVan +
               ";\n\tСкорость " + this.Speed + ";\n\tКоличество людей " + this.CountMen);
        }
        public void SoundExpress()
        {
            Console.WriteLine("Звук экспресса");
        }
        public new object Clone()
        {
            return new Express(NameExpress, NumberVan, Speed, CountMen);
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Express))
            {
                return false;
            }
            if (!base.Equals(obj))
            {
                return false;
            }
            else
            {
                Express rain = obj as Express;
                if (this.NameExpress == rain.NameExpress)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }// сравнение объектов
        public override int GetHashCode()
        {
            return Speed.GetHashCode() + CountMen.GetHashCode() + NumberVan.GetHashCode() + NameExpress.GetHashCode();
        }
        public override string ToString()
        {
            return "Экспресс: " + "\n\tИмя поезда " + this.NameExpress + ";\n\tКоличество вагонов " + this.NumberVan +
               ";\n\tСкорость " + this.Speed + ";\n\tКоличество людей " + this.CountMen;
        }
    }
}

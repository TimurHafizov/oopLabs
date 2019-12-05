using System;
using System.Collections.Generic;
using System.Text;

namespace lab10
{
    public class Avtomobile : Transport, ICloneable
    {
        private string bodyType;
        public string BodyType
        {
            get
            {
                return bodyType;
            }
            set
            {
                if (value.Length == 0)
                {

                    bodyType = "Не задано";
                }
                else
                {
                    bodyType = value;
                }
            }
        }
        public Avtomobile() : base()
        {
            this.BodyType = "Неизвестно";
        }
        public Avtomobile(string b = "Неизвестно", int s = 0, int c = 0) : base(s, c)
        {
            this.BodyType = b;
        }
        public override void Info()
        {
            Console.WriteLine("Автомобиль: " + "\n\tТип кузова " + this.BodyType +
                ";\n\tСкорость " + this.Speed + ";\n\tКоличество людей " + this.CountMen);
        }
        public override string ToString()
        {
            return "Автомобиль: " + "\n\tТип кузова " + this.BodyType +
                ";\n\tСкорость " + this.Speed + ";\n\tКоличество людей " + this.CountMen;
        }
        public void SoundAvto()
        {
            Console.WriteLine("Звук автомобиля");
        }
        public new object Clone()
        {
            return new Avtomobile(BodyType, Speed, CountMen);
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Avtomobile))
            {
                return false;
            }
            if (!base.Equals(obj))
            {
                return false;
            }
            else
            {
                Avtomobile rain = obj as Avtomobile;
                if (this.BodyType == rain.BodyType)
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
            return Speed.GetHashCode() + CountMen.GetHashCode() + BodyType.GetHashCode();
        }
    }
}

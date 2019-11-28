using System;
using System.Collections.Generic;
using System.Text;

namespace lab10
{
    class Avtomobile : Transport
    {
        public string BodyType { get; set; }
        public override void Info()
        {
            Console.WriteLine("Автомобиль " + "Тип кузова " + this.BodyType + 
                "Скорость " + this.Speed + "Количество людей " + this.CountMen);
        }
    }
}

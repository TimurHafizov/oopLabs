using System;
using System.Collections.Generic;
using System.Text;

namespace lab10
{
    class Rain : Transport
    {
        public int NumberVan { get; set; }
        public override void Info()
        {
            Console.WriteLine("Поезд " + "Количество вагонов " +
               "Скорость " + this.Speed + "Количество людей " + this.CountMen);
        }
    }
}

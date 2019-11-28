using System;
using System.Collections.Generic;
using System.Text;
using lab10;

namespace lab10
{
    class Transport
    {
        public int Speed { get; set; }
        public int CountMen { get; set; }
        public virtual void Info()
        {
            Console.WriteLine("Транспорт " + "Скорость " + this.Speed + "Количество людей " + this.CountMen);
        }
    }
}

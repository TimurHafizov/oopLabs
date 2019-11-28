using System;
using System.Collections.Generic;
using System.Text;

namespace lab10
{
    class Express : Rain
    {
        public string NameExpress { get; set; }//экспресс отличается от поезда наличием имени поезда
        public override void Info()
        {
            Console.WriteLine("Экспресс " + "Имя поезда " + this.NameExpress + "Количество вагонов " +
               "Скорость " + this.Speed + "Количество людей " + this.CountMen);
        }
    }
}

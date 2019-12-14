using System;
using System.Collections.Generic;
using System.Text;

namespace lab14
{
    public class Output
    {
        static public void ShowRed(string s)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed; // устанавливаем цвет
            Console.WriteLine(s);
            Console.ResetColor(); // сбрасываем в стандартный
        }
        static public void ShowGreen(string s)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen; // устанавливаем цвет
            Console.WriteLine(s);
            Console.ResetColor(); // сбрасываем в стандартный
        }
    }
}

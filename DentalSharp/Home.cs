using System;
using System.Collections.Generic;
using System.Text;

namespace DentalSharp
{
    class Home
    {
        public void Display()
        {
            Console.WriteLine("Вас приветствует стоматологическая клиника Dental# \n");
            Console.WriteLine("ВАШИ ЗУБЫ — НАША ЗАБОТА\n");
            Console.WriteLine($"Локальное время: {DateTime.Now}");
        }
    }
}

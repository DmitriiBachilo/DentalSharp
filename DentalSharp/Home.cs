using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using DentalSharp.Data;

namespace DentalSharp
{
    class Home
    {
        public void Display(Database database)
        {
            Console.WriteLine("Вас приветствует стоматологическая клиника Dental# \n");
            Console.WriteLine("ВАШИ ЗУБЫ — НАША ЗАБОТА\n");
            Console.WriteLine($"Локальное время: {DateTime.Now}");
            Console.WriteLine();
            
            int countDir = 1;
            foreach (var direct in database.Directions)
            {
                Console.WriteLine($"{countDir++} - {direct.Name}");
            }
            Console.WriteLine();
            Console.Write($"Выберите направление (используйте цифры от 1 до {database.Directions.Count}): ");

            int userInputDirections;
            int countDoc = 1;
            while (!int.TryParse(Console.ReadLine(), out userInputDirections) || userInputDirections < 1 || userInputDirections > database.Directions.Count)
            {
                Console.Write("Неверное значение выброра. Попробуйте еще раз: ");
            }
            Console.WriteLine();

            foreach (var doctorDocDir in database.FindDoctorsByDirections(database.Directions[userInputDirections-1].Id))
            {
                Console.WriteLine($"{countDoc++} - {doctorDocDir.Name}");
            }
            Console.WriteLine();
            Console.Write($"Выберите доктора (используйте цифры от 1 до {countDoc - 1}): ");

            int userInputDoctors;
            while (!int.TryParse(Console.ReadLine(), out userInputDoctors) || userInputDoctors < 1 || userInputDoctors > countDoc - 1)
            {
                Console.Write("Неверное значение выброра. Попробуйте еще раз: ");
            }
            Console.WriteLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using DentalSharp.Data;

namespace DentalSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = Data.Database.ParseData();
            //Console.WriteLine(db.Doctors.First().Directions[0].Name);

            Home home = new Home();
            home.Display(db);
        }
    }
}
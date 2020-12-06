using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEKCJA_21_Praca_Domowa
{
    class Program
    {
        private static DateTime actualDate;

        static void Main(string[] args)
        {
            string name;
            string placeOfBirth;
            
            var actualDate = DateTime.Now;
            var toDay = actualDate.Day;
            var year = actualDate.Year;

            Console.WriteLine(actualDate);
            Console.WriteLine(toDay);
            Console.WriteLine(year);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Podaj liczbę: ");
                FizzBuzz fizzBuzz = new FizzBuzz(Console.ReadLine());
            }

        }
    }
}

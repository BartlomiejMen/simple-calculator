using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        private static object calculate;

        static void Main(string[] args)
        {

            try
            {

             Console.WriteLine("Podaj pierwszą liczbę: ");


                var number1 = GetInput();

            Console.WriteLine("Jaką operacje chcesz wykonać? Możliwe operacje to: '+', '-','/','*'.");
            var action = Console.ReadLine();

            Console.WriteLine("Podaj 2 Liczbę: ");
                var number2 = GetInput();


                var result = Calculate(number1, number2, action);

           

            Console.WriteLine("Wynik twojego działenia to: " + result);
            }
            catch (Exception ex)
            {
                //Logowanie do pliku
                Console.WriteLine(ex.Message);
                
            }
            finally
            {
                Console.ReadLine();
            }
        }



        private static int GetInput()
        {
            if (!int.TryParse(Console.ReadLine(), out int input))
            
                throw new Exception("Podana wartośc jeat nieprawisłowa.");

                return input;
            
        }

        private static int Calculate(int number1, int number2, string action)
        {
            switch (action)
            {
                case "+":
                    return  number1 + number2;
                    break;

                case "-":
                    return  number1 - number2;
                    break;
                case "/":
                    return  number1 / number2;
                    break;
                case "*":
                    return  number1 * number2;
                    break;
                default:
                    throw new Exception("Wybrałeś złą operację");
            }
        }
    }
}

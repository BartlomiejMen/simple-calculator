using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Modulo
{
    class Modulo
    {
        public static string ModuloMethod()
        {
            int variable = (GetNumber() % 2);
            if (variable == 0)
            {
                return "Podana liczba jest liczbą parzystą";
            }
            else
            {
                return "Podana liczba jest liczbą nieparzystą";
            }

        }

        private static int GetNumber()
        {
            if (!int.TryParse(Console.ReadLine(), out int input))

                throw new Exception("Podana wartośc jeat nieprawidłowa.");

            return input;
        }
    }

}

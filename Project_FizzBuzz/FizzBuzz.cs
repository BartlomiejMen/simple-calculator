using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_FizzBuzz
{
    public class FizzBuzz
    {
        private int _variable;

        public FizzBuzz(string number)
        {
            _variable = GetNumber(number);
            Console.WriteLine(FizzBuzzMethod(_variable));

        }


        private string FizzBuzzMethod(int variable)
        {
            //string result = null;
            string result = FizzMethod(variable) + BuzzMethod(variable);

            if (result != "") //domyślnie miało być: if( result != null)
            {
                return result;
            }
            else
            {
                return _variable.ToString();
            }

        }


        private String FizzMethod(int variable)
        {
            int resultOfModulo3 = (variable % 3);

            if (resultOfModulo3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return null;
            }

        }

        private string BuzzMethod(int variable)
        {

            int resultOfModulo5 = (variable % 5);
            if (resultOfModulo5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return null;
            }

        }

        int GetNumber(string number)
        {
            if (!int.TryParse(number, out int input))

                throw new Exception("Podana wartośc jeat nieprawidłowa.");

            return input;
        }

    }
}

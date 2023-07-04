using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAcademy_Math_Game
{
    public class MathOperation
    {
        public string[] MathOperationArray = { "Addition", "Substraction", "Mulitplication", "Division" };


        public int Addition(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Substraction(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Mulitplication(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Division(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}

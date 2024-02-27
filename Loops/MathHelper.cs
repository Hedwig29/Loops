using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class MathHelper
    {
        //Метод сложение
        public static double Addition(double firstNumber, double secondNumber)
        {
            double roundResult = Math.Round(firstNumber + secondNumber, 12);
            return roundResult;
        }

        //Метод вычитание
        public static double Subtraction(double firstNumber, double secondNumber)
        {
            double roundResult = Math.Round(firstNumber - secondNumber, 12);
            return roundResult;
        }

        //Метод умножение
        public static double Multiplication(double firstNumber, double secondNumber)
        {
            double roundResult = Math.Round(firstNumber * secondNumber, 12);
            return roundResult;
        }

        //Метод деление
        public static double Division(double firstNumber, double secondNumber)
        {
            double roundResult = Math.Round(firstNumber / secondNumber, 12);
            return roundResult;
        }
    }
}

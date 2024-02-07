using System.ComponentModel.Design;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        { //Loops for
            var i = 0;
            for (i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("число " + i + " четное");
                }
                else
                {
                    Console.WriteLine("число " + i + " не четное");
                }
            }
            //loops while
            var count = 1; while (count <= 10)
            {
                if (count % 3 == 0)
                {
                    Console.WriteLine("число " + count + " кратно 3"); count++;
                }

                else
                {
                    Console.WriteLine("число " + count + " не кратно 3"); count++;
                }

            }
            // do while
            int guess = 0;
            do { Console.WriteLine("Попробуй угадать число");
        guess = Convert.ToInt32(Console.ReadLine());
            if (guess > 5) Console.WriteLine("Ваше число больше");
            else if (guess < 5) Console.WriteLine("Ваше число меньше");
            else  Console.WriteLine("Поздравляю,Вы угадали");  } while (guess !=5);


            // foreach
            int[] numbers = new[] { 10, 20, 30, 40, 50 };
            foreach (var Number in numbers)
            {
                if (Number < 30) Console.WriteLine(Number + "Меньше 30");
                else if (Number == 30) Console.WriteLine(Number + "Равно 30");
                else if (Number > 30) Console.WriteLine(Number + "Больше 30");



            }



        }
    }
}

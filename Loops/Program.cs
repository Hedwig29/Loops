using System.Numerics;
using System.Reflection;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //# Исключение и обработка.
            // Задача 1: Деление на ноль

            
            static int Divide()
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Введите первое число:");

                        int num1 = int.Parse(Console.ReadLine());

                       
                        Console.Write("Введите второе число:");

                        
                        int num2 = int.Parse(Console.ReadLine());

                       
                        return num1 / num2;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Невозмoжно делить на 0");

                        Console.WriteLine("Попытайтесь еще раз");

                        continue;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Для ввода доступны только цифры");

                        Console.WriteLine("Попытайтесь еще раз");

                        continue;
                    }

                }
            }

            

            Console.WriteLine( Divide());

            // Задача 2: Обработка исключения , открытие файла

            static void FileReader()
            {
                try
                {
                    File.Open("Test.txt", FileMode.Open);
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Файл не найден");
                }

            }

            // Задача 3: Обработка ошибок при парсинге чисел

            static int Converter()
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Введите число:");

                        return Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Попытайтесь снова");

                        continue;
                    }

                }

            }
            Console.WriteLine("\n#TryCatch №3\n");

            Console.WriteLine(Converter());


            //Задача 1: Расширение для строк

            string text = "“Аппетит приходит во время еды.”";

            Console.WriteLine("\n#Extension №1\n");

            text.WordCounter();

            // Задача 2: Расширение для чисел

            int number = 12345678;

            bool isEven = number.IsEven();

            Console.WriteLine("\n#Extension №2\n");

            Console.WriteLine($"{number} четное: {isEven}");

            // Задача 3: Расширение для списков

            List<string> names = new List<string>()
        {"Аглая", "Арина", "Полина", "Яна", "Владимир", "Эмма", "Стефания", "Макар", "Полина" ,"Эмма"};

            List<string> uniqNames = names.GetListOfUniqNames();

            Console.WriteLine("\n#Extension №3\n");

            foreach (var name in uniqNames)
            {
                Console.WriteLine(name);
            }

        }
        
            
    }
}


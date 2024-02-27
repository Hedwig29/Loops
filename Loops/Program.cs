using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {   //№1
            // Задача 1: Простая интерполяция
            string name = "Evan";
            int age = 25;
            string city = "London";
            Console.WriteLine($"Привет, {name}! Тебе {age} года и ты живешь в городе {city}.");

            // Задача 2: Математическая интерполяция


            float num1 = 250.50F;
            float num2 = 444.40F;

            Console.WriteLine();
            Console.WriteLine($"Сумма чисел {num1} и {num2} равна: {num1 + num2}");
            Console.WriteLine($"Разноcть чисел {num1} и {num2} равна: {num1 - num2}");
            Console.WriteLine($"Произведение чисел {num1} и {num2} равно: {num1 * num2}");
            Console.WriteLine($"Частное чисел {num1} и {num2} равна: {num1 / num2}");

            // Задача 3: Длина строки и ее интерполяция

            string favoriteQuote = "Ваше время ограничено, не тратьте его, живя чужой жизнью\r\n\r\nСтив Джобс";


            Console.WriteLine($"Длинна строки: {favoriteQuote.Length}. Строка: {favoriteQuote}");

            // Задача 4: Интерполяция для даты

            var currentDateTime = DateTime.Now;

            Console.WriteLine();
            Console.WriteLine($"Сегодня {currentDateTime:d}  {currentDateTime:t}");

            //№2
            // Задача 1: Создание статического класса

            double number1 = 88888.88888;
            double number2 = 44444.44444;


            Console.WriteLine($"Результат использования метода 'сложения' равен: {MathHelper.Addition(number1, number2)}");
            Console.WriteLine($"Результат использования метода 'разности' равен: {MathHelper.Subtraction(number1, number2)}");
            Console.WriteLine($"Результат использования метода 'произведения' равен: {MathHelper.Multiplication(number1, number2)}");
            Console.WriteLine($"Результат использования метода 'деления' равен: {MathHelper.Division(number1, number2)}");

            // Задача 2: Создание статической утилиты

            string myName = "Oleksandr";
            Console.WriteLine();
            Console.WriteLine($"Ваше имя {myName} на оборот будет:{StringUtils.ReverseString(myName)}");

            // Задача 3: Работа с константами

            Console.WriteLine();
            Console.WriteLine($"Число PI = {Constants.PI}");
            Console.WriteLine($"Максимальное количество попыток в игре равно {Constants.maxTry}");
            Console.WriteLine($"Любимый сайт всея интернета = {Constants.url}");

            // Задача 4: Счетчик вызовов метода

            Counter.Increment();
            Counter.Increment();
            Counter.Increment();
            Counter.Increment();
            Console.WriteLine();
            Console.WriteLine($" Increment был вызван {Counter.callCount} раза");

            // №3
            // Задача 1: Перегрузка метода для сложения чисел

            Console.WriteLine(Overload.Add(34453, 6723));
            Console.WriteLine(Overload.Add(4345.645F, 31231.543F));

            // Задача 2: Перегрузка метода для объединения строк

            Console.WriteLine(Overload.Concatenate("Иван ", "Иваныч! "));
            Console.WriteLine(Overload.Concatenate("Иван ", "Иваныч", "Иванов"));

            // Задача 3: Перегрузка метода с различными параметрами

            Overload.PrintInfo("Иван", 20);
            Overload.PrintInfo("Игорь", 30, " улица Сибирская,20");

            //Задача 4: Перегрузка метода с параметрами по умолчанию

            Console.WriteLine(Overload.Calculate(1000, 4500));
            Console.WriteLine(Overload.Calculate(7777, 8888));
            Console.WriteLine(Overload.Calculate(7777, 8888, '+'));
            Console.WriteLine(Overload.Calculate(7777, 8888, '-'));
            Console.WriteLine(Overload.Calculate(7777, 8888, '*'));


            // №4
            //Задание 1: Создание и использование наследования

            Car BMW = new Car();
            BMW.Year = 2020;
            BMW.ModelName = "X5";
            BMW.MaxSpeed = 300;
            BMW.NumberOfDoors= 4;

           
            Console.WriteLine($"Название модели: {BMW.ModelName}");
            Console.WriteLine($"Год выпуска: {BMW.Year}");
            Console.WriteLine($"Максимальная скорость: {BMW.MaxSpeed}");
            Console.WriteLine($"Количество дверей: {BMW.NumberOfDoors}");

            Car merc = new Car();
            merc.Year = 2015;
            merc.ModelName = "AMG";
            merc.MaxSpeed = 330;
            merc.NumberOfDoors = 4;


            Console.WriteLine($"Название модели: {merc.ModelName}");
            Console.WriteLine($"Год выпуска: {merc.Year}");
            Console.WriteLine($"Максимальная скорость: {merc.MaxSpeed}");
            Console.WriteLine($"Количество дверей: {merc.NumberOfDoors}");

            Car Volkswagen = new Car();
            Volkswagen.Year = 2008;
            Volkswagen.ModelName = "passat b6 ";
            Volkswagen.MaxSpeed = 180;
            Volkswagen.NumberOfDoors = 4;

            Console.WriteLine();
            Console.WriteLine($"Название модели: {Volkswagen.ModelName}");
            Console.WriteLine($"Год выпуска: {Volkswagen.Year}");
            Console.WriteLine($"Максимальная скорость: {Volkswagen.MaxSpeed}");
            Console.WriteLine($"Количество дверей: {Volkswagen.NumberOfDoors}");

            //Задание 2: Создание и использование наследования
            Meat pork = new Meat();
            pork.SkuCode = "pork";
            pork.ExpiryDate = DateTime.Now;
            pork.Price = 50.99;
            pork.StoredInTheFridge = true;

            Console.WriteLine();
            Console.WriteLine($"номер SKU: {pork.SkuCode}");
            Console.WriteLine($"Использовать до: {pork.ExpiryDate:D}");
            Console.WriteLine($"Цена: {pork.Price}");
            Console.WriteLine($"Нужно ли хранить в холодильнике: {pork.StoredInTheFridge}");

            Fish tilapia = new Fish();
            tilapia.SkuCode = "tilapia";
            tilapia.ExpiryDate = DateTime.Now;
            tilapia.Price = 30.50;
            tilapia.Farmed = false;

            Console.WriteLine();
            Console.WriteLine($"номер SKU: {tilapia.SkuCode}");
            Console.WriteLine($"Использовать до: {tilapia.ExpiryDate:D}");
            Console.WriteLine($"Цена: {tilapia.Price}");
            Console.WriteLine($"Выращена была на ферме: {tilapia.Farmed}");
        }
    }
}

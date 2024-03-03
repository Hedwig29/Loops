namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            // Задача 1: Интерфейс для фигур IShape

            IShape circle = new Circle();
            
            Console.WriteLine(circle.CalculateArea(5, 5, 10));


            IShape rectangle = new Rectangle();
            Console.WriteLine(rectangle.CalculateArea(10, 5, 0));

            // Задача 2: Интерфейс для звука ISound

            ISound пес = new Dog(), кот = new Cat();
            пес.MakeSound();
            кот.MakeSound();

            // Задача 3: Интерфейс для управления электроприборами IElectronicDevice

            IElectronicDevice hisense = new TV(), acer = new Laptop();
            hisense.TurnOn();
            acer.TurnOff();

            // Задача 4: Интерфейс для летающих объектов IFlyable

            IFlyable sparrow = new Bird(), jet = new Airplane();
            Console.WriteLine(sparrow.Fly());
            Console.WriteLine(jet.Fly());

        }

    }


}

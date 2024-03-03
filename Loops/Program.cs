namespace Loops
{
    internal class Program
    {
        static void Main()
        {
            FruitStore freshFruits = new FruitStore();
            string fruit = "Melon";
            freshFruits.OrderProduct(fruit, 5, "FreshCo ");
            Console.WriteLine($"Продукт годен: {freshFruits.IsProductExpried(fruit)}");
            Console.WriteLine($"Цена продукта: {freshFruits.GetProductPrice(fruit)}");
            Console.WriteLine($"Страна производитель: {freshFruits.GetProductInfo(fruit)}");

            LiquorMart liquorMarket = new LiquorMart();
            string alco = "Brandy";
            Console.WriteLine();
            liquorMarket.OrderProduct(alco, 20, "Island Rum");
            Console.WriteLine($"Продукт годен: {liquorMarket.IsProductExpried(alco)}");
            Console.WriteLine($"Цена продукта: {liquorMarket.GetProductPrice(alco)}");
            Console.WriteLine($"Страна производитель: {liquorMarket.GetProductInfo(alco)}");

            CheeseStore cheeseStore = new CheeseStore();
            string cheese = "Cheese Gauda";
            Console.WriteLine();
            cheeseStore.OrderProduct(cheese, 20, "French Cheese");
            Console.WriteLine($"Продукт годен: {cheeseStore.IsProductExpried(cheese)}");
            Console.WriteLine($"Цена продукта: {cheeseStore.GetProductPrice(cheese)}");
            Console.WriteLine($"Страна производитель: {cheeseStore.GetProductInfo(cheese)}");








        }
   

       



    }
}

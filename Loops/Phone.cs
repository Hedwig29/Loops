using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Phone
    {
        public string OperationSystem { get; set; }
        public string Color { get; set; }
        private double Price { get; set; }
        public string Brand {  get; set; }
        public int LocalTax { get; set; } = 13;
        
        public Phone()
        {
            Color = "Black";
            Price = 100.00;

        }
        public Phone(string operationsystem, string color, int price, string brand, int localTax) 
        {
            OperationSystem = operationsystem;
            Color = color;
            Price = price;
            Brand = brand;
        }
       public void PhoneBoot()
        {
            Console.WriteLine(OperationSystem);
            Console.WriteLine(Color);
            Console.WriteLine(Price);
            Console.WriteLine(Brand);
        }
       public void SetPhonePrice (double price)
        {
            Console.WriteLine("Цена на телефон установлена на " + Price);
        }
        public double GetPhonePriceWithTax ()
        { 
            double pricewithtax = Price + (Price * LocalTax / 100);
            return pricewithtax;

        
        }
       public void SetProvinceTax(string Province)
        {
            switch (Province)
            {
                case "MB": LocalTax = 13; 
                break;
                case "ON": LocalTax= 12;
                break;
                case "SK": LocalTax= 10;
                break;
                case "AB": LocalTax= 8;
                break;
                case "BC": LocalTax= 11;
                break;
            }
        }




    }
    
}

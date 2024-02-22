using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
          
            Phone phone = new Phone();

            phone.PhoneBoot();
            Console.WriteLine("Android");
            Console.WriteLine("Red");
            Console.WriteLine(800);
            Console.WriteLine("Samsung");
            phone.SetPhonePrice(1000);
            phone.GetPhonePriceWithTax();
            phone.SetProvinceTax("MB");
            Console.WriteLine("Цена телефона с налогом: " + phone.GetPhonePriceWithTax());
         
           



        }
    }
}

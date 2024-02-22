using Loops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
     public class Bootle
    {
        public int Volume { get; set; }
        public string Material { get; set; }
        public string FormFactor { get; set; }
        public void Fall()
        {
            Console.WriteLine("Бутылка упала");
        }
        public void Razlajilas()
        {
            Console.WriteLine("Бутылка разложилась");
        }
    }
    class Cup
    {
        int Volume {  set; get; }
        string Material { get; set; }
        string Colour { get; set; }
        void Break()
        {
            Console.WriteLine("Стакан разбился");
        }
        void Fillup()
        {
            Console.WriteLine("Napolnili stakan");
        }
    }
     public class Car 
    { 
        public Car( int numberofDoors)
        {
            NumberofDoors = numberofDoors;
        }
     public string CarClass { get; set; }
         public int NumberofDoors { get; set; }
       public bool ISCabriolet { get; set; }
         public void StartEngine()
        {
            Console.WriteLine("Vrum Vrum");
        }
       public void StopEngine() 
        {
            Console.WriteLine("Stop engines");
        }
        public void Drive()
        {
            Console.WriteLine("car is running");
        }
    }
   
}


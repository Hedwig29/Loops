using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal interface IElectronicDevice
    {
        public void TurnOn();
        public void TurnOff();
    }
    public class TV : IElectronicDevice
    {
        public void TurnOff()
        {
            Console.WriteLine("ТВ выключин");
        }

        public void TurnOn()
        {
            Console.WriteLine("ТВ включен");
        }
    }

    public class Laptop : IElectronicDevice
    {
        public void TurnOff()
        {
            Console.WriteLine(" Ноутбук выключается");
        }

        public void TurnOn()
        {
            Console.WriteLine("Добро ПОжаловать");
        }
    }
}

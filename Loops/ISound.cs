using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal interface ISound
    {
        public void MakeSound();
    }
    public class Dog : ISound
    {
        public void MakeSound()
        {
            Console.WriteLine("Гааав, Гааав");
        }
    }

    public class Cat : ISound
    {
        public void MakeSound()
        {
            Console.WriteLine("Мяяяу, мяяяу");
        }
    }
}

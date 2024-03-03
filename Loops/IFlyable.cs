using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal interface IFlyable
    {
        public string Fly();
    }
    public class Bird : IFlyable
    {
        public string Fly()
        {
            return "Птица летит";
        }
    }

    public class Airplane : IFlyable
    {
        public string Fly()
        {
            return "Самолет летит";
        }
    }
}

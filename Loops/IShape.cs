using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal interface IShape
    {
        public double  CalculateArea(double _long, double hight, double radius);
    }
    public class Circle : IShape
    {
        public  double CalculateArea(double _long, double hight, double radius)
        {
            return radius * radius * double.Pi;
        }
    }
    public class Rectangle : IShape
    {
        public double CalculateArea(double _long, double hight, double radius)
        {
            return _long * hight;
        }
    }
}

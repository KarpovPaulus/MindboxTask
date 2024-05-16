using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Triangle : BaseShap
    {
        public double a {  get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Triangle(string nameShape, double a, double b, double c) : base(nameShape) 
        { 
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double CalcSquare()
        {
            double p = (a + b + c) / 2;
            double square = Math.Sqrt(p * (p - a) * (p - b) * (p - a));
            return square;
        }
        public bool TriangleRectangular()
        {
            if(a > b & a > c)
            {
                if(Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
                {  return true; }
            }
            if (b > a & b > c)
            {
                if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
                { return true; }
            }
            if (c > b & c > a)
            {
                if (Math.Pow(c, 2) == Math.Pow(b, 2) + Math.Pow(a, 2))
                { return true; }
            }
            return false;
        }
    }
}

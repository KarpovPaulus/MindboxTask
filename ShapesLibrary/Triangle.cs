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

        public double SquareTriangle()
        {
            double p = (a + b + c) / 2;
            double square = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - a)), 1);
            return square;
        }
    }
}

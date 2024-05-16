using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public class Circle : BaseShap
    {
        public double RadiusCircle { get; set; }

        public Circle(string nameShape,double radiusCircle) : base(nameShape)
        {
            RadiusCircle = radiusCircle;
        }

        public override double CalcSquare()
        {
            return Math.PI * Math.Pow(RadiusCircle, 2);
        }
    }
}

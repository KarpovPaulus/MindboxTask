using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    public abstract class BaseShap
    {
        public string NameShape {  get; set; }

        public BaseShap(string nameShape)
        {
            NameShape = nameShape;
        }

        public abstract double CalcSquare();
    }
}

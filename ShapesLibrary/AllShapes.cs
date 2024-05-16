using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    internal class AllShapes
    {
        public static List<string> NameShapes = new List<string>();

        public AllShapes()
        {
            NameShapes = new List<string>()
            {
                "треугольник",
                "окружность"
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.Shapes
{
    class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            double square = Math.PI * Math.Pow(Radius, 2);
            return square;
        }
    }
}

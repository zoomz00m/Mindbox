using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.Shapes
{
    class Triangle : Shape
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }
        public override double GetArea()
        {
            double p = (A + B + C) / 2;
            double square = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return square;
        }
    }
}

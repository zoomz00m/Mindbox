using System;
using Mindbox.Shapes;

namespace Mindbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle crc = new Circle(15);
            Triangle tr = new Triangle(3, 4, 5);

            Console.WriteLine(crc.GetArea());
            //Console.WriteLine(tr.GetArea());

            Console.ReadKey();
        }
    }
}

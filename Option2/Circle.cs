using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Option2
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(string name, string color, int[] position, int radius) : base(name, color, position)
        {
            Radius = radius;
        }

        public override void GetArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            Console.WriteLine($"The area is: {area}");
        }

        public override void GetPerimeter()
        {
            double perimeter = 2 * Math.PI * Radius;
            Console.WriteLine($"The perimeter is: {perimeter} ");
        }
    }

}

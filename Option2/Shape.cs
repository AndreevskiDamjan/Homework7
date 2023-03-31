using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Option2
{
    public class Shape
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int[] Position { get; set; }

        public Shape(string name, string color, int[] position)
        {
            Name = name;
            Color = color;
            Position = position;
        }
        public virtual void GetArea()
        {
            Console.WriteLine("There is no special implementation for area...");
        }

        public virtual void GetPerimeter()
        {
            Console.WriteLine("There is no special implementation for perimeter...");
        }
            public virtual void Move (Shape shape) 
            {
                shape.Position[0] += 5;
                shape.Position[1] += 5;
            }
        }
    }

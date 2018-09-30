using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MoreClasses
{
    class Box
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Box(int h, int w)
        {
            Height = h;
            Width = w;
        }

        public static Box operator+(Box a, Box b) //přetížení operátoru - vytvoření nové funkce pro operátor
        {
            int h = a.Height + b.Height;
            int w = a.Width + b.Width;
            Box res = new Box(h, w);
            return res;
        }

        static void Main(string[] args)
        {
            Box b1 = new Box(14, 3);
            Box b2 = new Box(5, 7);
            Box b3 = b1 + b2; //přetížený operátor
        }
    }
}

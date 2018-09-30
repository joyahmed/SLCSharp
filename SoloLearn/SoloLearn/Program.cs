using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Ahoj");
            Console.WriteLine("Jak se jmenuješ?");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zdravím toho, jež se nazývá {0}.", jmeno);
            Console.WriteLine("A kolik ti je let?");
            //Convert.ToInt16,32,64 - 32 je základ
            int vek = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Aha, tobě je {0} let.", vek);
            var cislo = 7.5; //implicitní typ
            const double PI = Math.PI; //konstanta

            Console.WriteLine("\nPress any key to close");
            Console.ReadKey();
        }
    }
}

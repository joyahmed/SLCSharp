using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MoreClasses
{
    class Cat
    {
        public static int count = 0; //static určuje proměnnou určenou výhradně třídě - pro více instancí třídy existuje stále pouze jedna proměnná (je sdílena mezi všemi objekty třídy Cat)
        private readonly string name = "John"; // readonly - může být změněna pouze konstruktorem, nemusí být ihned deklarována

        public Cat(string name)
        {
            count++;
            this.name = name;
        }

        ~Cat() //destruktor
        {
            Console.WriteLine("Destructor");
        }

        static void Main(string[] args)
        {
            Cat c1 = new Cat("Mandy");
            Cat c2 = new Cat("Pista");

            Console.WriteLine(Cat.count); ////Outputs 2
        }
    }
}

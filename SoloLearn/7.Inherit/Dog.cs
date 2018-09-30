using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Inherit
{
    class Dog : Animal
    {
        public Dog()
        {
            Legs = 4;
        }

        public void Bark()
        {
            Console.Write("Woof"); 
        }
    }
}

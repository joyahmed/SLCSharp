using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MoreClasses
{ 
    class Clients
    {
        private string[] names = new string[10];

        public string this[int index] //indexer
        {
            get
            {
                return names[index];
            }
            set
            {
                names[index] = value;
            }
        }

        public static void Main()
        {
            Clients c = new Clients();
            c[0] = "Dave";
            c[1] = "Bob";

            Console.WriteLine(c[1]);
            //Outputs "Bob"  
        }
    }
}

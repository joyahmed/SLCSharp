using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects
{
    class Person
    {
        private string name; //field
        private int age = 0;

        public string Name //property, první písmeno atributu velké
        {
            get { return name; }
            set { name = value; }
        }
        
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
            }
        }

        public string Residence { get; set; } //automatické vytvoření prístupových objektů, není potřeba definovat atribut

        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Bob";
            Console.WriteLine(p.Name);
        }
    }
}

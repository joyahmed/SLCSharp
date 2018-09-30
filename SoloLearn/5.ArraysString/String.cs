using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ArraysString
{
    class String
    {
        public static void Main()
        {
            string a = "some text";
            Console.WriteLine(a.Length); //délka řetězce
            //Outputs 9

            Console.WriteLine(a.IndexOf('t')); //index prvního výskytu
            //Outputs 5

            a = a.Insert(0, "This is "); //vložení za index
            Console.WriteLine(a);
            //Outputs "This is some text"

            a = a.Replace("This is", "I am"); //výměna něčeho za něco
            Console.WriteLine(a);
            //Outputs "I am some text"

            if (a.Contains("some")) //vrací true pokud nalezne 
                Console.WriteLine("found");
            //Outputs "found"

            a = a.Remove(4); //odstraní vše za indexem
            Console.WriteLine(a);
            //Outputs "I am"

            a = a.Substring(2); //vrací určitý počet znaků za určitým indexem (pokud není určena délka, vrací vše od indexu do konce), respektive vrací vše od do
            Console.WriteLine(a);
            //Outputs "am"

        }
    }
}

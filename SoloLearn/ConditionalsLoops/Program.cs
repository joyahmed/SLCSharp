using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int mark = 100;

            if (mark > 100)
            {
                Console.WriteLine("> 100");
            } else if (mark <= 100)
            {
                Console.WriteLine("<= 100");
            }

            int num = 3;
            switch (num)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                default:
                    Console.WriteLine("The default case");
                    break;
            }

            int n = 0;
            while (++n < 6)
            {
                Console.WriteLine(n);
            }

            int x = 10;
            for (; x > 0; x -= 3)
            {
                Console.WriteLine(x);
            }

            // if ? true : false
            int age = 42;
            string msg;
            msg = (age >= 18) ? "Welcome" : "Sorry";
            Console.WriteLine(msg);

            //kalkulacka
            do
            {
                Console.Write("a = ");
                string str = Console.ReadLine();
                if (str == "exit")
                    break;

                int a = Convert.ToInt32(str);

                Console.Write("b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                int sum = a + b;
                Console.WriteLine("Result: {0}", sum);
            }
            while (true);
        }
    }
}

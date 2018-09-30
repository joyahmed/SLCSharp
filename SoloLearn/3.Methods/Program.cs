using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static double Pow(int x, int y = 2) //y = defaultní hodnota
        {
            return Math.Pow(x, y);
        }

        static void Sqr(ref int x) //referenční argument - mění se hodnota v paměti
        {
            x = x * x;
        }

        static void GetValues(out int x, out int y) //výstupní parametry  
        {
            x = 5;
            y = 42;
        }

        static List<string> ReverseList(List<string> list, out int pocet)
        {
            pocet = 0;
            var otoceny = new List<string>();
            for (int i = list.Count-1; i > -1; i--)
            {
                otoceny.Add(list.ElementAt(i));
                pocet++;
            }
            return otoceny;
        }

        static int Fact(int num) //rekurzivní metoda
        {
            if (num == 1)
            {
                return 1;
            }
            return num * Fact(num - 1);
        }

        static void DrawPyramid(int n) //kreslení pyramidy, n - počet řádků
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Pow(6));
            //Outputs 36 (6^2)

            Console.WriteLine(Pow(y: 3, x: 4)); //různé pořadí parametrů
            //Outputs 64 (4^3)

            int a = 3;
            Sqr(ref a);
            Console.WriteLine(a);
            // Outputs 9

            int o1, o2;
            GetValues(out o1, out o2); //hodnoty vstupních parametrů nemají vliv na výstup, parametry pouze určují proměnné do kterých se mají uložit výstupní hodnoty z metody
            //Now o1 equals 5, o2 equals 42

            int pocet;
            List<string> list = new List<string>(new string[]{"ahoj","jak","se", "mas"});
            list = ReverseList(list, out pocet);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list.ElementAt(i) + " ");
            }
            Console.WriteLine("\n" + pocet);
        }
    }
}

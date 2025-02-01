using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //porovnávání 10
            Console.WriteLine("zadejte číslo");
            int cislo = Convert.ToInt32(Console.ReadLine());
            if (cislo > 10)
            {
                Console.WriteLine("číslo je větší než 10");
            }
            else
            {
                Console.WriteLine("číslo je menší než 10");
            }

            //kladné, záporné
            if (cislo == 0 )
            {
                Console.WriteLine("číslo je 0");
            }
            else if (cislo < 0)
            {
                Console.WriteLine("číslo je záporné");
            }
            else
            { 
                Console.WriteLine("číslo je kladné");
            }

            //věk
            Console.WriteLine("zadejte svůj věk");
            int vek = Convert.ToInt32(Console.ReadLine());
            if (vek >= 18)
            {
                Console.WriteLine("je plnoletý ");
            }
            else
            {
                Console.WriteLine("neni plnoletý");
            }



            Console.ReadKey();
        }
    }
}

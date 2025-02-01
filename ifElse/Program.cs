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
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("введите число2");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("введите число3");
            int c = int.Parse(Console.ReadLine());
           
                
 if (a < b && a < c)
            {
                Console.WriteLine(a);
                if (b < c)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                else
                {    Console.WriteLine(c);
                Console.WriteLine(b);
                }
            }
            if ( b<a && b < c)
            {
                Console.WriteLine(b);
                if (a < c)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                }
            }
            if (c < b && c<a)
            {
                Console.WriteLine(c);
                if (b < a)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }
            }
        }
    }
}

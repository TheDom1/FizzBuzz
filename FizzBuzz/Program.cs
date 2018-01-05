using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " " + "This number is divisable by both 3 and 5!");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " " + "This number is divisable by 3.");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " " + "This is number is divisable by 5.");
                }
                else
                {
                    Console.WriteLine(i + " " + "This number is not divisable by either 3 or 5, sad.");
                   
                }
            }
            Console.ReadLine();
        }
    }
}

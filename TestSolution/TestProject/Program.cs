using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            while (x > 0)
            {
                Console.WriteLine(x--);
            }
            Console.WriteLine("Boom!!!");
            Console.Read();
        }
    }
}

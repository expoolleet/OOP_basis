using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basis
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Generator gen = new Generator(1);
            for (int i = 0; i < 10; i++)
            {
                gen.Generate();
            }

            Console.ReadKey();

        }
    }
}

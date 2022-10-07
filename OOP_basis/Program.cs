using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basis
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            Generator gen = new Generator(random.Next(1,4));
            for (int i = 0; i < 10; i++)
            {
                gen.Generate();
            }

            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1: Main(); break;
            }
        }
    }
}

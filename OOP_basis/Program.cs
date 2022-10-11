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
            
            int n = 10;
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                new Generator(random.Next(1, 4), random).Generate();
            }

            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1: Main(); break;
            }
        }
    }
}

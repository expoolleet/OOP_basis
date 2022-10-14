using System;

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

            Console.Write("1 для повтора: ");
            int x = Convert.ToInt32(Console.ReadLine());
            
            switch (x)
            {
                case 1: Main(); break;
            }
        }
    }
}

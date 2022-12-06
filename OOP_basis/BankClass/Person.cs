using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basis.BankClass
{
    class Person
    {
        string Name { get; }
        int Sum { get; }

        public Person(string name, int sum)
        {
            Name = name;
            Sum = sum;
      
        }

        public string Info()
        {
            return $"ФИО: {Name}\nСчет в банке: {Sum}\n_\n";
        }
    }
}

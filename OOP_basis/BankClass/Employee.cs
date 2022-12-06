using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basis.BankClass
{
    class Employee
    {
        string Name { get; }
        string Position { get; }
        int Salary { get; }

        public Employee(string name, string position, int salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }

        public string Info()
        {
            return $"ФИО: {Name}\nПозиция: {Position}\nЗарплата: {Salary}\n_\n";
        }
    }
}

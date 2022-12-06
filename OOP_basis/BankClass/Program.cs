using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basis.BankClass
{
    class Program
    {
        static void Main()
        {

            var person1 = new Person("Иванов Иван Иванович", 100);
            var person2 = new Person("Сергеев Сергей Сегреевич", 150);

            var employee1 = new Employee("Романов Роман Романович", "Банкир", 300);

            var bank = new Bank();

            bank.Register(person1);
            bank.Register(person2);
            bank.Register(employee1);

            bank.PrintInfo();

            Console.ReadKey();
        }
    }

}

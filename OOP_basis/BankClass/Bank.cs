using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basis.BankClass
{
    class Bank
    {

        private List<Person> personList = new List<Person>();
        private List<Employee> employeeList = new List<Employee>();

        public Bank() {}
        

        public void Register<T>(T obj)
        {
            if (obj is Person)
            {
                var person = obj as Person;

                if (!personList.Contains(person))
                {
                    personList.Add(person);
                }
                else
                {
                    Console.WriteLine("Данный пользователь уже зарегистрирован");
                }   
            }
            else if (obj is Employee)
            {
                var employee = obj as Employee;

                if (!employeeList.Contains(employee))
                {
                    employeeList.Add(employee);
                }
                else
                {
                    Console.WriteLine("Данный работник уже зарегистрирован");
                }
            }
            else
            {
                throw new ArgumentException("Только сущности Person и Employee могут быть зарегистрированы в банке");
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("\tИнформация о клиентах:\n");
            foreach (var person in personList)
            {
                Console.WriteLine(person.Info());
            }

            Console.WriteLine("\tИнформация о работниках:\n");
            foreach (var employee in employeeList)
            {
                Console.WriteLine(employee.Info());
            }
        }

    }


}

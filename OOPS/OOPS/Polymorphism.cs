using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{   
    enum role
    {
        Director, Delivery_Manager
    }
    class User
    {
        public const int age = 10;
        public string name { get; }
        public role role { get; set; }

        public User(string name)
        {
            int age = 100;
            Console.WriteLine($"Age = {age}");
            this.name = name;
        }
        public void Enter()
        {
            Console.WriteLine("1");
           
        }
    }

    class Employee: User
    {
        public Employee(string name) : base(name)
        {

        }
        public new void Enter()
        {
            Console.WriteLine("2");
            Console.WriteLine(name);
            Console.WriteLine(this.role);
        }
    }
    class Polymorphism
    {
        public void PolymorphismDemo()
        {
            Employee e1 = new Employee("John");
            e1.role = role.Director;
            e1.Enter();

            //User u1 = new User();
            //u1.Enter();
        }
    }
}

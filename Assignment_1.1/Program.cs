using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._1
{
    class Department
    {
        public void display()

        {

            Console.WriteLine("IT Department");

        }
    }

    class Employee :Department
    {
        public void disemp()
        {
            Console.WriteLine("Name : Mr.Jagrit Pandey"); Console.WriteLine("Age : 23"); Console.WriteLine("Post : Data anlayst"); Console.ReadLine();
        }
    }
    class Program
    {
private static void Main(string[] args) {
            Employee myobj = new Employee(); myobj.display();

            myobj.disemp();

        }

    }
}

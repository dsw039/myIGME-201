using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GiveRaise(emp);
        }

        struct Employee
        {
            public string sName;
            public double dSalary;
        }

        static  bool GiveRaise(Employee emp)
        {
            emp.dSalary = 30000;
            Console.WriteLine("What is your name?");
            emp.sName = Console.ReadLine();
            if (emp.sName == "Daniel")
            {
                emp.dSalary += 19999.99;
                Console.WriteLine("Congrats! You got a raise! Your new Salary is " + emp.dSalary);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

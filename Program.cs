using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentsept15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Uddhav Dahatonde", 10, 50000, 200);
            employee.Total_salary();
            employee.Net_paid();
            Console.WriteLine(employee.DisplayValue());
        }
    }
}

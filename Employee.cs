using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentsept15
{
    internal class Employee
    {
        private string name;
        private int id;
        private int basic_salary;
        public double hra, da,  pf,pa,total;
        public double net;
        public Employee(string name, int id, int basic_salary ,double pa)
        {
            this.name = name;
            this.id = id;
            this.basic_salary = basic_salary;
            this.pa = pa;
        }
        public void Total_salary()
        {
            hra = 0.4 * basic_salary;
            da = 0.2 * basic_salary;
            pf = 0.12 * basic_salary;
            total = basic_salary + hra + da;
        }
        public void Net_paid()
        {
            net = total - (pf + pa);
        }
        public string DisplayValue()
        {
            return $"Total salary of Employee is{net}";
        }
    }
}

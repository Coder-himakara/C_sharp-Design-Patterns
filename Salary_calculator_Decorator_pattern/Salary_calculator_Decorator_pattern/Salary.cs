using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_calculator_Decorator_pattern
{
    public abstract class Salary
    {
        protected Employee _employee;
        protected string description = "unkonwn salary";
        public string position = "";
        protected double salary;
        public double allowance;
        public double transport;
        public double tax;
        public double epf;

        public virtual string getDescription()
        {
            return description;
        }
        public abstract double netSalary();
        
    }
}

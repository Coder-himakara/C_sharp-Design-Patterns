using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_calculator_Decorator_pattern
{
    public class Allowance : Salary_Decorator
    {
        public Allowance(Salary _salary) { 
            this._salary = _salary;
        }

        public override string getDescription()
        {
            return this.description = _salary.getDescription() + " + Allowance";
        }
        public override double netSalary()
        {
           return this.salary=_salary.netSalary() + _salary.allowance;
        }
    }
}

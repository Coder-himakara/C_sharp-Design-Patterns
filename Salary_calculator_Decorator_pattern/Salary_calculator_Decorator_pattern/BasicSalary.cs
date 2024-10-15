using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_calculator_Decorator_pattern
{
    public class BasicSalary : Salary
    {
        public BasicSalary(Employee employee) { 
            this._employee = employee;
            this.position=this._employee.getPosition();
            this.salary =employee.getSalary();
            this.allowance=(this.salary*employee.getAllowanceRate())/100.00;
        }
        public override double netSalary()
        {
            return this.salary;
        }
        public override string getDescription()
        {
            this.description = "Employee"+_employee.getName()+"has"+this.salary;
            return this.description;
        }
        
            
    }
}

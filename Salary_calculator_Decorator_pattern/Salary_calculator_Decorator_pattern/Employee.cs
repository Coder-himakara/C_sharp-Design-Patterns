using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_calculator_Decorator_pattern
{
    public class Employee
    {
        string name="";
        string position="";
        private double basic_salary;
        bool staff_transport;
        double allowance_rate;

        List<Employee> employees =new List<Employee>();
        public Employee(string name,string position,double basic_salary,bool transport,double allowance_rate)
        {
            this.name = name;
            this.position = position;
            this.basic_salary = basic_salary;
            this.staff_transport = transport;
            this.allowance_rate = allowance_rate;

        }
        public double getSalary()
        {
            return this.basic_salary;
        }
        public double getAllowanceRate()
        {
            return this.allowance_rate;
        }
        public string getName()
        {
            return this.name;
        }
        public string getPosition()
        {
            return this.position;
        }
       
    }
}

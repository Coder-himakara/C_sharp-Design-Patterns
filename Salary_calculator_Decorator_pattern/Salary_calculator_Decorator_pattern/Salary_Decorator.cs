using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_calculator_Decorator_pattern
{
    public abstract  class Salary_Decorator: Salary
    {
        protected Salary _salary;
        
        public abstract string getDescription();
    }
}

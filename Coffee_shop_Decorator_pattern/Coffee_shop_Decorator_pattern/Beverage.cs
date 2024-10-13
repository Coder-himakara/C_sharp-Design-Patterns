using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_shop_Decorator_pattern
{
    public abstract class Beverage
    {
        protected string description="Unknown Beverage";

        public virtual string getDescription()
        {
            return this.description;
        }
        
        public abstract double cost();
    }
}

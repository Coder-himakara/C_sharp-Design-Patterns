using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_shop_Decorator_pattern
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) { 
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return this.beverage.getDescription() + ", Mocha";
        }
        public override double cost()
        {
            return this.beverage.cost() + 0.35;
        }
    }
}

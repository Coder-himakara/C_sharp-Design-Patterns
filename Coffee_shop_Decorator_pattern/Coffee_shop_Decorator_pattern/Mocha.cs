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
            string text= beverage.getDescription() + ", Mocha";
            return text;
        }
        public override double cost()
        {
            return beverage.cost() + 0.30;
        }
    }
}

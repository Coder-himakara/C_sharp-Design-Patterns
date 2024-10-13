using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_shop_Decorator_pattern
{
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage) {
            this.beverage = beverage;
        }
        public override string getDescription()
        {
           string text = beverage.getDescription() + " ,Milk";  
           return text;
        }
        public override double cost()
        {
            return beverage.cost() + 0.20;
        }
    }
}

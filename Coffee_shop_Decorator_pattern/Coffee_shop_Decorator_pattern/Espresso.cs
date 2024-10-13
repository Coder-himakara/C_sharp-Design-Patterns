using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_shop_Decorator_pattern
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            this.description = "Espresso";
        }
        public override double cost()
        {
            return 1.99;
        }
    }
}

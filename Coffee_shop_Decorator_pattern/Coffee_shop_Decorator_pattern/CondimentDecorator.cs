using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_shop_Decorator_pattern
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;

        public abstract string getDescription();
    }
}

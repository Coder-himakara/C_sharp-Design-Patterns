using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_shop_Decorator_pattern
{
    public class HouseBlend :Beverage
    {
        public HouseBlend()
        {
            description = "HosueBlend";
        }
        public override double cost()
        {
            return 3.00;
        }
    }
}

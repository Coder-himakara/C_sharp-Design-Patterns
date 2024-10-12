using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_shop_FactoryMethod
{
    public class NyPizzaStore : PizzaStore
    {
        public NyPizzaStore()
        {

        }
        public override Pizza createPizza(String item)
        {
            if (item.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            //else if (item.Equals("veggie"))
            //{
            //    return new NYStyleVeggiePizza();
            //}
            //else if (item.equals("clam"))
            //{
            //    return new NYStyleClamPizza();
            //}
            //else if (item.equals("pepperoni"))
            //{
            //    return new NYStylePepperoniPizza();
            //}
            else return null;
        }
    }
}

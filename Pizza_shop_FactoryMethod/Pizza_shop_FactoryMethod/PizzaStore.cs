using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_shop_FactoryMethod
{
    public abstract class PizzaStore
    {
        //Client code
        public Pizza makeOrder(String type)
        {
            Pizza pizza; //Reference to the product
            pizza = createPizza(type);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            return pizza;
        }

       //Factory Method
        public abstract Pizza createPizza(string type);
    }
}

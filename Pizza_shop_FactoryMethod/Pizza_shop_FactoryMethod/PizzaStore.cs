using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_shop_FactoryMethod
{
    public abstract class PizzaStore
    {
        private string text1;
        private string text2;
        private string text3;
        //Client code
        public Pizza makeOrder(String type)
        {
            Pizza pizza; //Reference to the product
            pizza = createPizza(type);
            pizza.prepare();
            text1= pizza.bake();
            text2 = pizza.cut();
            text3 = pizza.box();          
            return pizza;
        }

       //Factory Method
        public abstract Pizza createPizza(string type);

        public string getText1() { return text1; }
        public string getText2() { return text2; }
        public string getText3() { return text3; }
    }
}

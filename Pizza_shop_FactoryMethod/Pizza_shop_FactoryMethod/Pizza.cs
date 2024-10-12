using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_shop_FactoryMethod
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected ArrayList toppings = new ArrayList();
        
        void prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            foreach (String topping in toppings)
            {
               Console.WriteLine("   " + topping);
            }
        }
        void bake()
        {
          Console.WriteLine("Bake for 25 minutes at 350");
        }
        void cut()
        {
           Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        void box()
        {
           Console.WriteLine("Place pizza in official PizzaStore box");
        }
        public String getName()
        {
            return name;
        }
    }
}

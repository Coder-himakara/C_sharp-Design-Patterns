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
        
        public void prepare()
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
        public string bake()
        {
            string bake_text = "Bake for 25 minutes at 350";
            return bake_text;
         
        }
        public string cut()
        {
            string cut_text = "Cutting the pizza into diagonal slices";
            return cut_text;
            
        }
        public string box()
        {
            string box_text = "Place pizza in official PizzaStore box";
            return box_text;
           
        }
        public String getName()
        {
            return name;
        }
    }
}

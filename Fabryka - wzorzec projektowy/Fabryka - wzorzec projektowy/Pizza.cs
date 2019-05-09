using System;
using System.Collections.Generic;
using System.Text;

namespace Fabryka___wzorzec_projektowy
{
    abstract class Pizza
    {

        protected String name;
        protected String dough;
        protected String sauce;
        protected List<String> toppings = new List<string>();

        public void prepare()
        {
            Console.WriteLine("preparing" + name);
            Console.WriteLine("Tossing dugh...");
            Console.WriteLine("Adding Sauce...");
            Console.WriteLine("Adding topping");
            foreach(String topping in toppings)
            {
                Console.WriteLine(" " + topping);
            }
        }

        public virtual void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void box()
        {
            Console.WriteLine("Place pizza inf official PizzaStore box");
        }

        public String getName()
        {
            return name;
        }
    }
}

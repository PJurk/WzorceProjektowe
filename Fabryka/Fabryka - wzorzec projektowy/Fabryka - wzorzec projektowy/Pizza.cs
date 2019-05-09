using System;
using System.Collections.Generic;
using System.Text;

namespace Fabryka___wzorzec_projektowy
{
    abstract class Pizza
    {

        protected String name;

        protected Sauce sauce;
        protected Dough dough;
        protected Veggies veggies[];
        protected Cheese cheese;
        protected Pepperoni pepperoni;
        protected Clams clam;

        public abstract void prepare();

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

        public void setName(String name)
        {
            this.name = name;
        }
    }
}

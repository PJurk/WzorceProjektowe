using System;
using System.Collections.Generic;
using System.Text;

namespace Fabryka___wzorzec_projektowy
{
    class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            name = "Chicago Style Sauce And Cheese Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void cut()
        {
            Console.WriteLine("Cuttin the pizza into square slices");
        }
    }
}

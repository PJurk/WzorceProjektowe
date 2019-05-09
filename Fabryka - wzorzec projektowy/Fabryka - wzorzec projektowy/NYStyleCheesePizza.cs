using System;
using System.Collections.Generic;
using System.Text;

namespace Fabryka___wzorzec_projektowy
{
    class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name  = "NY Style Sauce And Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
}

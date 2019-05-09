using System;
using System.Collections.Generic;
using System.Text;

namespace Fabryka___wzorzec_projektowy
{
    class ClamPizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public ClamPizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing" + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            clam = ingredientFactory.createClam();
        }
    }
}

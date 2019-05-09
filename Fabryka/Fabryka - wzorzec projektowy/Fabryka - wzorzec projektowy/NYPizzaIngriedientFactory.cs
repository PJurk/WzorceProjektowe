using System;
using System.Collections.Generic;
using System.Text;

namespace Fabryka___wzorzec_projektowy
{
    class NYPizzaIngriedientFactory : PizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            return new ReggianoCheese();         
        }

        public Clams createClam()
        {
            return new FreshClams();
        }

        public Dough createDough()
        {
            return new ThinCrustDough();
        }

        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce createSauce()
        {
            return new MarinaraSauce();
        }

        public Veggies[] createVeggies()
        {
            Veggies veggies[] = { new Garlic(), new Onion(), new Mushrom(), new RedPepper() };
            return veggies;
        }
    }
}

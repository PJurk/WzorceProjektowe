using System;
using System.Collections.Generic;
using System.Text;

namespace Fabryka___wzorzec_projektowy
{
    class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(String item)
        {
            if (item.Equals("cheese"))
            {
                return new ChicagoStyleCheesePizza();
            }
            else if (item.Equals("veggie"))
            {
                return new ChicagoStyleVeegiePizza();
            }
            else if (item.Equals("clam"))
            {
                return new ChicagoStyleClamPizza();
            }
            else if (item.Equals("pepperoni"))
            {
                return new ChicagoStylePepperoniPizza();
            }
            else return null;
        }
    }
}

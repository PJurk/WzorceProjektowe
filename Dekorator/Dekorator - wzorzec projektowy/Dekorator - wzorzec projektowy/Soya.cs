using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorator___wzorzec_projektowy
{
    class Soya : CondimentDecorator
    {
        Beverage beverage;

        public Soya(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double cost()
        {
            return beverage.cost() + 1.50;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Soya";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorator___wzorzec_projektowy
{
    class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override String getDescription()
        {
            return beverage.getDescription() + ", Mocha";
        }

        public override double cost()
        {
            return beverage.cost() + .20;
        }
    }
}

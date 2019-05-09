using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorator___wzorzec_projektowy
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "HouseBlend";
        }

        public override double cost()
        {
            return 0.89;
        }
    }
}

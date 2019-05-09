using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorator___wzorzec_projektowy
{
    abstract class Beverage
    {
        protected String description = "Unknow Beverage";

        public virtual String getDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}

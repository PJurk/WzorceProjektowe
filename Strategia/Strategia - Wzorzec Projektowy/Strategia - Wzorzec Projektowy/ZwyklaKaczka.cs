using System;
using System.Collections.Generic;
using System.Text;

namespace Strategia___Wzorzec_Projektowy
{
    class ZwyklaKaczka : Kaczka
    {
        public ZwyklaKaczka(Latanie jakLatac, Kwakanie jakKwakac)
        {
            jakKwacze   = jakKwakac;
            jakLatam    = jakLatac;
        }
    }
}

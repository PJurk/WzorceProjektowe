using System;
using System.Collections.Generic;
using System.Text;

namespace Obserwator___wzorzec_projektowy
{
    interface Obserwator
    {
        void aktualizuj(float temp, float humidity, float pressure);
    }
}

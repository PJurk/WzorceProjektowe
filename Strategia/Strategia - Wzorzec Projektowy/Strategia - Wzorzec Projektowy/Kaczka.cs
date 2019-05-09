using System;
using System.Collections.Generic;
using System.Text;

namespace Strategia___Wzorzec_Projektowy
{
    abstract class Kaczka
    {
        protected Kwakanie    jakKwacze;
        protected Latanie     jakLatam;

        public void Lec()
        {
            jakLatam.Lec();
        }

        public void Kwac()
        {
            jakKwacze.Kwac();
        }

        public void UstawKwakanie(Kwakanie jakKwakac)
        {
            jakKwacze = jakKwakac;
        }

        public void UstawLatanie(Latanie jakLatac)
        {
            jakLatam = jakLatac;
        }
    }
}

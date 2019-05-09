using System;
using System.Collections.Generic;
using System.Text;

namespace Obserwator___wzorzec_projektowy
{
    interface Subject
    {
        void zarejestrujObserwatora(Obserwator o);
        void usunObserwatora(Obserwator o);
        void powiadomObserwatorow();
    }
}

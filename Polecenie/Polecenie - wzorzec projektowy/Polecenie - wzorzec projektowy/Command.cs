using System;
using System.Collections.Generic;
using System.Text;

namespace Polecenie___wzorzec_projektowy
{
    interface Command
    {
        void execute();

        String getName();
    }
}

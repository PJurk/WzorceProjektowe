using System;
using System.Collections.Generic;
using System.Text;

namespace Polecenie___wzorzec_projektowy
{
    class NoCommand : Command
    {
        public void execute()
        {
            
        }

        public string getName()
        {
            return "Empty slot";
        }
    }
}

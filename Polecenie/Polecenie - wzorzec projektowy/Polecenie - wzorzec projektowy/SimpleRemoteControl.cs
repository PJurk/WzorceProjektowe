using System;
using System.Collections.Generic;
using System.Text;

namespace Polecenie___wzorzec_projektowy
{
    class SimpleRemoteControl
    {
        Command slot;

        public void setCommand(Command command)
        {
            slot = command;
        }

        public void buttonWasPressed()
        {
            slot.execute();
        }
    }
}

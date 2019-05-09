using System;
using System.Collections.Generic;
using System.Text;

namespace Polecenie___wzorzec_projektowy
{
    class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;

        public RemoteControl()
        {
            onCommands = new Command[7];
            offCommands = new Command[7];

            Command noCommand = new NoCommand();

            for (int i=0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        public void setCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void onButtonWasPushed(int slot)
        {
            onCommands[slot].execute();
        }

        public void offButtonWasPushed(int slot)
        {
            offCommands[slot].execute();
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("\n Remote Control \n");
            for (int i=0; i < onCommands.Length; i++)
            {
                sb.Append("Slot [{0}] {1} ___ {2) \n", i, onCommands[i].getName(), offCommands[i].getName());
            }

            return sb.ToString();
        }
    }
}

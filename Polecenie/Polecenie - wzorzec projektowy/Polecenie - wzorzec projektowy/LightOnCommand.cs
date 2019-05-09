using System;
using System.Collections.Generic;
using System.Text;

namespace Polecenie___wzorzec_projektowy
{
    class LightOnCommand : Command
    {
        Light light;
        String name = "LightOn";

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.on();
        }

        public string getName()
        {
            return name;
        }
    }
}

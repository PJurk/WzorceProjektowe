using System;
using System.Collections.Generic;
using System.Text;

namespace Polecenie___wzorzec_projektowy
{
    class LightOffCommand : Command
    {
        Light light;
        String name = "LightOff";

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.off();
        }

        public string getName()
        {
            return name;
        }
    }
}

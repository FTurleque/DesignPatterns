using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Command.RemoteControl
{
    public abstract class Receiver
    {
        private int volume;
        private bool isOn;

        public void TurnOn()
        {
            isOn = true;
        }

        public void TurnOff()
        {
            isOn = false;
        }

        public void TurnUpTheVolume()
        {
            volume++;
        }

        public void TurnDownTheVolume()
        {
            volume--;
        }

    }
}

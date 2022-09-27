using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Command.RemoteControl.Commands
{
    public abstract class Command : ICommand
    {
        protected Receiver receiver;

        protected Command(Receiver _receiver)
        {
            this.receiver = _receiver;
        }

        public abstract void Cancel();

        public abstract void Execute();
    }
}

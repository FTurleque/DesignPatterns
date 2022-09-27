using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Command.CharacterMovement
{
    public abstract class Command : ICommand
    {
        protected ReceiverMice receiver;

        protected Command(ReceiverMice _receiver)
        {
            this.receiver = _receiver;
        }

        public abstract void Cancel();

        public abstract void Execute();
    }
}

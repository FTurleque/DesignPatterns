using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Command.CharacterMovement
{
    public abstract class CommandForMouse : ICommand
    {
        private ReceiverMice receiver;

        public abstract void Cancel();

        public abstract void Execute();
    }
}

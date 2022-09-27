using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Command.CharacterMovement
{
    public class Invocator
    {
        private List<ICommand> ICommand;

        public void CommandToExecute(ICommand _command)
        {
            ICommand.Add(_command);
            _command.Execute();
        }

        public void CancelLastCommand(ICommand _command)
        {
            ICommand.Remove(_command);
        }
    }
}

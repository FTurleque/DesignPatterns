namespace DesignPatterns.Class.Command.RemoteControl
{
    public class RemoteControlInvocator
    {
        private List<ICommand> commands;

        public RemoteControlInvocator()
        {
            commands = new List<ICommand>();
        }

        public void CommandToExecute(ICommand _command)
        {
            commands.Add(_command);
        }

        public void CancelLastCommand()
        {
            commands[commands.Count - 1].Cancel();
            commands.Remove(commands[commands.Count - 1]);
        }
    }
}

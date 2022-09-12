using DesignPatterns.Class.Command.CharacterMovement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Commande.CharacterMovement.Moves
{
    public class CommandGoTo : CommandForMouse
    {
        private int stepNumber;

        public CommandGoTo(int _stepNumber)
        {
            this.stepNumber = _stepNumber;
        }

        public override void Cancel()
        {
            throw new NotImplementedException();
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}

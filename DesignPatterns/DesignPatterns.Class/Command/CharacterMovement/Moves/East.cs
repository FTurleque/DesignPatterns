using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Command.CharacterMovement.Moves
{
    public class East : Command
    {
        public East(ReceiverMice _receiver) : base(_receiver)
        {
        }

        public override void Cancel()
        {
            throw new NotImplementedException();
        }

        public override void Execute()
        {
            receiver.SetNewPositionX(/*1*/);
        }
    }
}

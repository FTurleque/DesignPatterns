﻿using DesignPatterns.Class.Command.CharacterMovement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Commande.CharacterMovement.Moves
{
    public class CommandBackOff : CommandForMouse
    {
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

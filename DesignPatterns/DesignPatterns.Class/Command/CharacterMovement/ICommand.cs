﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Command.CharacterMovement
{
    public interface ICommand
    {
        public void Execute();
        public void Cancel();
    }
}

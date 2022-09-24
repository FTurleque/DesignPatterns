﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.State.StateButton.States
{
    public class Pushed : IStateButton
    {
        public IStateButton DisablePushButton(PushButton ctx)
        {
            throw new NotImplementedException();
        }

        public IStateButton DisplayPushButton(PushButton ctx)
        {
            throw new NotImplementedException();
        }

        public IStateButton EnablePushButton(PushButton ctx)
        {
            return new EnableState();
        }

        public IStateButton ErasePushButton(PushButton ctx)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Appui sur le boutton.
        /// </summary>
        /// <param name="ctx">Instance du bouton</param>
        /// <returns>Retourne l'état du boutton</returns>
        public IStateButton PressPushButton(PushButton ctx)
        {
            Console.WriteLine("The button is alredy pushed");
            return this;
        }

        /// <summary>
        /// Liberation du boutton.
        /// </summary>
        /// <param name="ctx">Instance du bouton</param>
        /// <returns>Retourne l'état du boutton</returns>
        public IStateButton ReleasePushButton(PushButton ctx)
        {
            return new Released();
        }

        public override string ToString()
        {
            return "Pushed";
        }
    }
}

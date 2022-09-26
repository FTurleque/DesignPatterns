using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.State.StateButton.States
{
    public class EnableState : IStateButton
    {
        /// <summary>
        /// Désactivation du boutton.
        /// </summary>
        /// <param name="ctx">Instance du bouton</param>
        /// <returns>Retourne l'état du boutton</returns>
        public IStateButton DisablePushButton(PushButton ctx)
        {
            return new DisableState();
        }

        /// <summary>
        /// Activation du boutton.
        /// </summary>
        /// <param name="ctx">Instance du bouton</param>
        /// <returns>Retourne l'état du boutton</returns>
        public IStateButton EnablePushButton(PushButton ctx)
        {
            Console.WriteLine("The button is already enable.");
            return this;
        }

        public IStateButton PressPushButton(PushButton ctx)
        {
            return new Pushed();
        }

        public IStateButton ReleasePushButton(PushButton ctx)
        {
            Console.WriteLine("The button is removed.");
            return this;
        }

        public override string ToString()
        {
            return "Enable";
        }
    }
}

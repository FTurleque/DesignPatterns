using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.State.StateButton.States
{
    public class DisableState : IStateButton
    {
        /// <summary>
        /// Désactivation du boutton.
        /// </summary>
        /// <param name="ctx">Instance du bouton</param>
        /// <returns>Retourne l'état du boutton</returns>
        public IStateButton DisablePushButton(PushButton ctx)
        {
            Console.WriteLine("The button is already disable.");
            return this;
        }

        /// <summary>
        /// Activation du boutton.
        /// </summary>
        /// <param name="ctx">Instance du bouton</param>
        /// <returns>Retourne l'état du boutton</returns>
        public IStateButton EnablePushButton(PushButton ctx)
        {
            return new EnableState();
        }

        /// <summary>
        /// Appui sur le boutton.
        /// </summary>
        /// <param name="ctx">Instance du bouton</param>
        /// <returns>Retourne l'état du boutton</returns>
        public IStateButton PressPushButton(PushButton ctx)
        {
            Console.WriteLine("The button is disable, you cant push it ");
            return this;
        }

        /// <summary>
        /// Libération du boutton.
        /// </summary>
        /// <param name="ctx">Instance du bouton</param>
        /// <returns>Retourne l'état du boutton</returns>
        public IStateButton ReleasePushButton(PushButton ctx)
        {
            Console.WriteLine("The button is disable, you cant release it ");
            return this;
        }

        public override string ToString()
        {
            return "Disable";
        }
    }
}

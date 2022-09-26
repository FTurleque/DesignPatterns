namespace DesignPatterns.Class.State.StateButton.States
{
    public class Pushed : IStateButton
    {
        public IStateButton DisablePushButton(PushButton ctx)
        {
            Console.WriteLine("This state is inaccessible.");
            return this;
        }

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
            return this;
        }

        /// <summary>
        /// Liberation du boutton.
        /// </summary>
        /// <param name="ctx">Instance du bouton</param>
        /// <returns>Retourne l'état du boutton</returns>
        public IStateButton ReleasePushButton(PushButton ctx)
        {
            return new EnableState();
        }

        public override string ToString()
        {
            return "Pushed";
        }
    }
}

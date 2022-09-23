using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.State.StateButton.States
{
    public class DisableState : IStateButton
    {
        public IStateButton DisablePushButton(PushButton ctx)
        {
            Console.WriteLine("The button is already disable.");
            return this;
        }

        public IStateButton DisplayPushButton(PushButton ctx)
        {
            throw new NotImplementedException();
        }

        public IStateButton EnablePushButton(PushButton ctx)
        {
            Console.WriteLine("This actions is impossible.");
            return this;
        }

        public IStateButton ErasePushButton(PushButton ctx)
        {
            throw new NotImplementedException();
        }

        public IStateButton PressPushButton(PushButton ctx)
        {
            throw new NotImplementedException();
        }

        public IStateButton ReleasePushButton(PushButton ctx)
        {
            throw new NotImplementedException();
        }
    }
}

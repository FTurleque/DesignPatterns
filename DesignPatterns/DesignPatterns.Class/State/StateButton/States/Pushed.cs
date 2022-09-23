using System;
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
            return new DisableState();
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

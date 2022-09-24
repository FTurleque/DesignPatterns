using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.State.StateButton
{
    public interface IStateButton
    {
        IStateButton DisplayPushButton(PushButton ctx);
        IStateButton PressPushButton(PushButton ctx);
        IStateButton ReleasePushButton(PushButton ctx);
        IStateButton DisablePushButton(PushButton ctx);
        IStateButton EnablePushButton(PushButton ctx);
        IStateButton ErasePushButton(PushButton ctx);
        public string ToString();
    }
}

using DesignPatterns.Class.State.StateButton.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.State.StateButton
{
    public class PushButton
    {
        private IStateButton currentStateButton;

        public PushButton()
        {
            Display();
        }

        public void Display()
        {
            currentStateButton = new EnableState();
        }

        public void Press()
        {
            throw new System.NotImplementedException();
        }

        public void Release()
        {
            throw new System.NotImplementedException();
        }

        public void Disable()
        {
            throw new System.NotImplementedException();
        }

        public void Enable()
        {
            throw new System.NotImplementedException();
        }

        public void Erase()
        {
            throw new System.NotImplementedException();
        }
    }
}

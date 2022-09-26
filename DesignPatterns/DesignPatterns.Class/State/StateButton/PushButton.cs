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
            Console.WriteLine("The button is display.");
            Console.WriteLine(currentStateButton.ToString());
        }

        public void Press()
        {
            currentStateButton = currentStateButton.PressPushButton(this);
            Console.WriteLine(currentStateButton.ToString());
            Release();
        }

        public void Release()
        {
            currentStateButton = currentStateButton.ReleasePushButton(this);
            Console.WriteLine(currentStateButton.ToString());
        }

        public void Disable()
        {
            currentStateButton = currentStateButton.DisablePushButton(this);
            Console.WriteLine(currentStateButton.ToString());
        }

        public void Enable()
        {
            currentStateButton = currentStateButton.EnablePushButton(this);
            Console.WriteLine(currentStateButton.ToString());
        }

        public void Erase()
        {
            Console.WriteLine("The button is erease.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.State.VideoStates
{
    public class Pause : IVideoState
    {
        public IVideoState PauseTheVideo(Video ctx)
        {
            Console.WriteLine("Déjà en pause.");
            return this;
        }

        public IVideoState PlayTheVideo(Video ctx)
        {
            return new Play();
        }

        public IVideoState StopTheVideo(Video ctx)
        {
            return new Stop();
        }

        public override string ToString()
        {
            return " ";
        }
    }
}

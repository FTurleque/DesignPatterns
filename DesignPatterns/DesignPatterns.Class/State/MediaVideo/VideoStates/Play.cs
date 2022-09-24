using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.State.MediaVideo.VideoStates
{
    public class Play : IVideoState
    {
        public IVideoState PauseTheVideo(Video ctx)
        {
            return new Pause();
        }

        public IVideoState PlayTheVideo(Video ctx)
        {
            Console.WriteLine("Déjà en lécture.");
            return this;
        }

        public IVideoState StopTheVideo(Video ctx)
        {
            return new Stop();
        }

        public override string ToString()
        {
            return "Lecture";
        }
    }
}

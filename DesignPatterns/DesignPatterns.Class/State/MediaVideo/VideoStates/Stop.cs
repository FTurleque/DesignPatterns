using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.State.MediaVideo.VideoStates
{
    public class Stop : IVideoState
    {
        public IVideoState PauseTheVideo(Video ctx)
        {
            Console.WriteLine("Impossible, vidéo déjà à l'arrêt.");
            return this;
        }

        public IVideoState PlayTheVideo(Video ctx)
        {
            return new Play();
        }

        public IVideoState StopTheVideo(Video ctx)
        {
            Console.WriteLine("Vidéo déjà à l'arrêt.");
            return this;
        }

        public override string ToString()
        {
            return " ";
        }
    }
}

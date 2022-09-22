using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Class.State.MediaVideo
{
    public interface IVideoState
    {
        public IVideoState StopTheVideo(Video ctx);

        public IVideoState PlayTheVideo(Video ctx);

        public IVideoState PauseTheVideo(Video ctx);

        public string ToString();
    }
}
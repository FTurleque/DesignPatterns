using DesignPatterns.Class.State.VideoStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.State.MediaVideo
{
    public class Video
    {
        private IVideoState currentStateVideo;

        public Video()
        {
            currentStateVideo = new Stop();
        }

        public void StopTheVideo()
        {
            currentStateVideo = currentStateVideo.StopTheVideo(this);
        }

        public void PlayTheVideo()
        {
            currentStateVideo = currentStateVideo.PlayTheVideo(this);
        }

        public void PauseTheVideo()
        {
            currentStateVideo = currentStateVideo.PauseTheVideo(this);
        }

        public string ToString()
        {
            return currentStateVideo.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatternsApp.src.DesignPatterns.Structural.ProxyPattern.Good.Package;

namespace DesignPatternsApp.src.DesignPatterns.Structural.ProxyPattern.Good
{
    public class YoutubeVideoProxy : Video
    {
        private string _videoId;
        private YouTubeVideo _realVideo;

        public YoutubeVideoProxy(string videoId)
        {
            _videoId = videoId;
        }

        public string GetVideoId()
        {
            return _videoId;
        }

        public void Render()
        {
            if (_realVideo == null)
            {
                _realVideo = new YouTubeVideo(_videoId);
            }
            _realVideo.Render();
        }
    }
}
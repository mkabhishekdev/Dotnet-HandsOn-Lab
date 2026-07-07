using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.ProxyPattern.Bad.Package
{
    public class YouTubeVideo : Video
    {
        private string _videoId;

        public YouTubeVideo(string videoId)
        {
            _videoId = videoId;
            Download();
        }

        private void Download()
        {
            Console.WriteLine($"Downloading video with ID: {_videoId}");
        }

        public string GetVideoId()
        {
            return _videoId;
        }

        public void Render()
        {
            Console.WriteLine($"Rendering video with ID: {_videoId}");
        }
    }
}
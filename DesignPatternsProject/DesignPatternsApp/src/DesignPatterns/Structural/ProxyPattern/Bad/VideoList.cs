using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatternsApp.src.DesignPatterns.Structural.ProxyPattern.Bad.Package;

namespace DesignPatternsApp.src.DesignPatterns.Structural.ProxyPattern.Bad
{
    public class VideoList
    {
        private Dictionary<string, Video> _videoList = new Dictionary<string, Video>();

        public void AddVideo(string videoId)
        {
            _videoList[videoId] = new YouTubeVideo(videoId);
        }

        public void WatchVideo(string videoId)
        {
            if (_videoList.ContainsKey(videoId))
            {
                _videoList[videoId].Render();
            }
            else
            {
                Console.WriteLine($"Video with ID: {videoId} not found.");
            }
        }
    }
}
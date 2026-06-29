using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.StrategyPattern.GoodExample
{
    public class VideoStorage
    {
        private ICompressor _compressor;
        private IOverlay _overlay;

        public VideoStorage(ICompressor compressor, IOverlay overlay)
        {
            _compressor = compressor;
            _overlay = overlay;
        }
        
        public void SetCompressor(ICompressor compressor)
        {
            _compressor = compressor;
        }   

        public void SetOverlay(IOverlay overlay)
        {
            _overlay = overlay;
        }

        public void Store(string filename)
        {
            _compressor.Compress();
            _overlay.Apply();

            Console.WriteLine($"Video {filename} stored successfully." + _compressor);
        }   
    }
}
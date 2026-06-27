using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.StrategyPattern
{
    public class VideoStorage
    {
        private Compressors _compressor;
        private Overlays _overlay;

        public VideoStorage(Compressors compressor, Overlays overlay = Overlays.None)
        {
            _compressor = compressor;
            _overlay = overlay;
        }
        
        public void SetCompressor(Compressors compressor)
        {
            _compressor = compressor;
        }   

        public void SetOverlay(Overlays overlay)
        {
            _overlay = overlay;
        }

        public void Store(string filename)
        {
            // compression logic
            if(_compressor == Compressors.MOV)
            {
                Console.WriteLine($"Storing {filename} as MOV with {_overlay} overlay.");
            }
            else if(_compressor == Compressors.MP4)
            {
                Console.WriteLine($"Storing {filename} as MP4 with {_overlay} overlay.");
            }
            else if(_compressor == Compressors.WEBM)
            {
                Console.WriteLine($"Storing {filename} as WEBM with {_overlay} overlay.");
            }

            // overlay logic
            if(_overlay == Overlays.BlackAndWhite)
            {
                Console.WriteLine($"Applying Black and White overlay to {filename}.");      
            }
            else if(_overlay == Overlays.Blur)
            {
                Console.WriteLine($"Applying Blur overlay to {filename}.");      
            }
            else if(_overlay == Overlays.None)
            {
                Console.WriteLine($"No overlay applied to {filename}.");      
            }

            Console.WriteLine($"Video {filename} stored successfully." + _compressor);
        }   
    }
}
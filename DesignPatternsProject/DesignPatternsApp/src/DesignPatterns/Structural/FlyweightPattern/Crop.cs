using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.FlyweightPattern
{
    public class Crop
    {
        private int _x;
        private int _y;
        
        private CropIcon _cropIcon;

        public Crop(int x, int y, CropIcon cropIcon)
        {
            _x = x;
            _y = y;
            _cropIcon = cropIcon;
        }
       
        
        public void Render()
        {
            Console.WriteLine($"Rendering {_cropIcon.GetType()} at ({_x}, {_y})");
        }
    }
}
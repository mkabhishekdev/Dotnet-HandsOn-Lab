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
        private CropType _cropType;
        
        private byte[] _icon;

        public Crop(int x, int y, CropType cropType, byte[] icon)
        {
            _x = x;
            _y = y;
            _cropType = cropType;
            _icon = icon;
        }
        
        public void Render()
        {
            Console.WriteLine($"Rendering {_cropType} at ({_x}, {_y})");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.FlyweightPattern
{
    public class CropIcon
    {
        private readonly CropType _cropType;
        private readonly byte[] _icon;

        public CropIcon(CropType cropType, byte[] icon)
        {
            _cropType = cropType;
            _icon = icon;
        }

        public CropType GetCropType()
        {
            return _cropType;
        }

        public byte[] GetIcon()
        {
            return _icon;
        }
    }
}
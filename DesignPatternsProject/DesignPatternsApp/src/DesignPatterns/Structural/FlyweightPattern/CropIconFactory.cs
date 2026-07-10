using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.FlyweightPattern
{
    public class CropIconFactory
    {
        //cache
        private Dictionary<CropType, CropIcon> _cropIcons = new Dictionary<CropType, CropIcon>();

        public CropIcon GetCropIcon(CropType cropType)
        {
            if (!_cropIcons.ContainsKey(cropType))
            {
                var icon = new CropIcon(cropType, null);
                _cropIcons.Add(cropType, icon);
            }

            return _cropIcons[cropType];
        }
    }
}
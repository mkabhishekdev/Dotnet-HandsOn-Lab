using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.FlyweightPattern
{
    public class CropService
    {
        private CropIconFactory _cropIconFactory;
        
        public CropService(CropIconFactory cropIconFactory)
        {
            _cropIconFactory = cropIconFactory;
        }

        public List<Crop> GetCrops()
        {
            List<Crop> crops = new List<Crop>();
           
            var carrot1 = new Crop(1,4,_cropIconFactory.GetCropIcon(CropType.Carrot));
            var carrot2 = new Crop(1,5,_cropIconFactory.GetCropIcon(CropType.Carrot));
            var carrot3 = new Crop(1,6,_cropIconFactory.GetCropIcon(CropType.Carrot));
            
            crops.Add(carrot1);
            crops.Add(carrot2);
            crops.Add(carrot3);
            
            return crops;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.FlyweightPattern
{
    public class CropService
    {
        public List<Crop> GetCrops()
        {
            List<Crop> crops = new List<Crop>();
           
            var carrot1 = new Crop(1,4,CropType.Carrot, null);
            var carrot2 = new Crop(1,5,CropType.Carrot, null);
            var carrot3 = new Crop(1,6,CropType.Carrot, null);
            
            crops.Add(carrot1);
            crops.Add(carrot2);
            crops.Add(carrot3);
            
            return crops;
        }
    }
}
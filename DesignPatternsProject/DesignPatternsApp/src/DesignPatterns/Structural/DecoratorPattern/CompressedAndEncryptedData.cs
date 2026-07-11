using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.DecoratorPattern
{
    public class CompressedAndEncryptedData : CloudData
    {
        public CompressedAndEncryptedData(string url) : base(url)
        {
            
        }

        public override void Save(string data)
        {
            var compressed = new CompressedData(_url).Compress(data);
            var encryptedAndCompressed = new EncryptedData(_url).Encrypt(data);
            base.Save(encryptedAndCompressed);
        }
    }
}
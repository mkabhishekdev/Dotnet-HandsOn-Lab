using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.DecoratorPattern
{
    public class EncryptedData : CloudData
    {
        public EncryptedData(string url) : base(url)
        {
        }

        public override void Save(string data)
        {
            string encryptedData = Encrypt(data);
            base.Save(encryptedData);
        }

        public string Encrypt(string data)
        {
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(data));
        }
    }
}
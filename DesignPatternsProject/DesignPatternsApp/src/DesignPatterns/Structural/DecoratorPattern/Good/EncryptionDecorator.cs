using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Structural.DecoratorPattern.Good
{
    public class EncryptionDecorator : DataDecorator
    {
        public EncryptionDecorator(IData data) : base(data)
        {
        }

        public override void Save(string data)
        {
            Console.WriteLine("Encrypting data before saving...");
            string encryptedData = Encrypt(data);
            _data.Save(encryptedData);
        }

        public string Encrypt(string data)
        {
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(data));
        }
    }
}
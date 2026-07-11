
using DesignPatternsApp.src.DesignPatterns.Structural.DecoratorPattern.Good;

var url = "https://cloudstorage.com/data";
var data = "This is some important data that needs to be saved securely.";
var compress = true;
var encrypt = true;

 IData cloudData = new CloudData(url);

 if(encrypt)
 {
     cloudData = new EncryptionDecorator(cloudData);
 }
 if(compress)
 {
     cloudData = new CompressionDecorator(cloudData);
 }
 
 cloudData.Save(data);  



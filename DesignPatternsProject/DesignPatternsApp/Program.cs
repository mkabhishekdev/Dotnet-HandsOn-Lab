
using DesignPatternsApp.src.DesignPatterns.Creational.SingletonPattern;

var settings = AppSettings.GetInstance();

settings.SetSetting("app_name", "Design Patterns App");
settings.SetSetting("app_creator", "mkabhishek");

Console.WriteLine("App creator is: "+settings.GetSetting("app_creator"));

Test.Run();


 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Creational.SingletonPattern
{
    public class AppSettings
    {
        private static AppSettings _instance;

        private AppSettings() // In Singleton pattern, the constructor is private to prevent instantiation from 
        // outside the class : IMPORTANT
        {
            
        }

        public static AppSettings GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AppSettings();
            }
            return _instance;
        }

        private Dictionary<string, object> _settings = new Dictionary<string, object>();

        public object GetSetting(string key)
        {
            if (_settings.ContainsKey(key))
            {
                return _settings[key];
            }
            return null;
        }

        public void SetSetting(string key, object value)
        {
            _settings[key] = value;
        }
    }
}
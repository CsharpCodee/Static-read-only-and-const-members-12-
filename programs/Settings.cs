using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зкфсешс13._5
{
    public class Settings
    {
        private static readonly string configFilePath;

        static Settings()
        {
            configFilePath = "C:\\C:\\Users\\Uswer\\config.txt"; 
        }

        public static void DisplayConfigFilePath()
        {
            Console.WriteLine($"Путь к файлу конфигурации: {configFilePath}");
        }
    }
}

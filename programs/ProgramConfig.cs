using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic13._2
{
    public class ProgramConfig
    {
        public const string Version = "1.0.0";
        public const string DeveloperName = "Александра";
        public static void DisplayInfo()
        {
            Console.WriteLine($"Версия программы: {Version}");
            Console.WriteLine($"Разработчик: {DeveloperName}");
        }
    }
}

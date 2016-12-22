using Microsoft.VisualStudio.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudioSettingsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var devenvPath = @"C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\devenv.exe";
            var settings = ExternalSettingsManager.CreateForApplication(devenvPath);
            Console.ReadKey();
        }
    }
}

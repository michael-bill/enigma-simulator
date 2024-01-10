using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EnigmaSimulator.Language
{
    class Localization
    {
        public static void SetLanguage(string lang)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(lang);
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(lang);
        }
    }
}

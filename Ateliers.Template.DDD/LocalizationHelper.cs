using System;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;
using System.Text;

namespace Ateliers.Template.DDD
{
    internal static class LocalizationHelper
    {
        private static ResourceManager rm = new ResourceManager("Ateliers.Template.DDD", typeof(LocalizationHelper).Assembly);

        internal static string GetString(string key)
        {
            CultureInfo culture = CultureInfo.CurrentUICulture;
            return rm.GetString(key, culture);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cicdExample
{
    public static class Helper
    {
        public static string GetDescription(int celsius)
        {
            var desc = celsius switch
            {
                var n when n >= 25 => "HOT",
                var n when n <= 10 => "COLD",
                _ => "NORMAL" // default value
            };
            return desc;
        }

        public static string GetDescriptionToLower(int celsius)
        {
            return GetDescription(celsius).ToLower();
        }
    }
}

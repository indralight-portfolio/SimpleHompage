using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homepage.Lib
{
    public class Util
    {
        public static string Convert(string str)
        {
            DateTime dt;
            bool success = DateTime.TryParseExact(str, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dt);
            if (success)
            {
                var result = dt.ToString("yyyy/MM/dd");
                return result;
            }
            return str;
        }
    }
}

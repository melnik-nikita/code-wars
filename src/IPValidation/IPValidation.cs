using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace IPValidation
{
    public class Kata
    {
        public static bool is_valid_IP(string ipAddres)
        {
            IList<string> ips = ipAddres.Split('.');

            if (ips.Count != 4) return false;

            return ips.All(ip =>
            {
                int result;

                if (ip.Length > 1 && ip.StartsWith("0"))
                {
                    return false;
                }

                if (!int.TryParse(ip, NumberStyles.None, new NumberFormatInfo(), out result))
                {
                    return false;
                }

                if (result < 0 || result > 255)
                {
                    return false;
                }

                return true;
            });
        }
    }
}
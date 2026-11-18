using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MathHelper
    {
        // N = a^k, где k целое из диапазона 0..4
        public static bool IsPower(long n, long a)
        {
            long value = 1;
            for (int k = 0; k <= 4; k++)
            {
                if (value == n) return true;
                value *= a;
            }
            return false;
        }
    }
}

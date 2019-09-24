using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSorfWF
{
    class MethodSwap
    {
        public static void start<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }
    }
}

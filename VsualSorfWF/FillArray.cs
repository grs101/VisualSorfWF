using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSorfWF
{
    class FillArray
    {
        public static void generate_rand_data_for_array (ref int [] array, int count, int min, int max)
        {
            Random random = new Random();
            array = new int[count];
            array = array.Select(x => random.Next(min, max)).ToArray();
        }
    }
}

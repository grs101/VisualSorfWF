using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSorfWF
{
    class SelectionSort
    {
        //класс сортровки выборкой
        public static void begin(ref int [] array, int i)
        {
            int min = i;
            for (int j = i + 1; j < array.Length; j++)
                if (array[j] < array[min])
                    min = j;

            if (min != i)
                MethodSwap.start(ref array[i], ref array[min]);

        }
    }
}

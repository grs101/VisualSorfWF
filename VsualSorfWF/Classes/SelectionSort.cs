using System;
using System.Windows.Forms;

namespace VisualSorfWF
{
    class SelectionSort
    {
        //класс сортровки выборкой
        public static void begin(ref int [] array, ref PictureBox pictureBox1, int minimum, int max)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                        min = j;
                }
                if (min != i)
                    MethodSwap.start(ref array[i], ref array[min]);
                if (pictureBox1 != null)
                {
                    Draw.begin(ref pictureBox1, array, minimum, max);
                }
            }
        }
    }
}

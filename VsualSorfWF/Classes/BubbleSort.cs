using System;
using System.Windows.Forms;

namespace VisualSorfWF
{
    class BubbleSort
    {
        //класс сортровки пузырьком

        public static void begin(ref int[] array, ref PictureBox pictureBox1, int minimum, int max)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min = i;
                for (int j = 1; j < array.Length - i; j++)
                    if (array[j - 1] > array[j])
                        MethodSwap.start(ref array[j - 1], ref array[j]);
                if (pictureBox1 != null)
                {
                    Draw.begin(ref pictureBox1, array, max);
                }
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace VisualSorfWF
{
    class InsertSort
    {
        public static void begin(int[] arr, ref PictureBox picbox, int min, int max)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j;
                int buf = arr[i];
                for (j = i - 1; j >= 0; j--)
                {
                    if (arr[j] < buf)
                        break;

                    MethodSwap.start(ref arr[j+1], ref arr[j]);
                    Draw.begin(ref picbox, arr, min, max);
                }
            }
        }
    }
}

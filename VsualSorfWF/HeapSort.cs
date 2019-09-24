using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualSorfWF
{
    class HeapSort
    {
        //класс пирамидальной сортировки
        static Int32 add2pyramid(Int32[] arr, Int32 i, Int32 N)
        {
            Int32 imax;
            Int32 buf;
            if ((2 * i + 2) < N)
            {
                if (arr[2 * i + 1] < arr[2 * i + 2]) imax = 2 * i + 2;
                else imax = 2 * i + 1;
            }
            else imax = 2 * i + 1;
            if (imax >= N) return i;
            if (arr[i] < arr[imax])
            {
                buf = arr[i];
                arr[i] = arr[imax];
                arr[imax] = buf;
                if (imax < N / 2) i = imax;
            }
            return i;
        }

        static void Pyramid_Sort(Int32[] arr, Int32 len, ref PictureBox picbox, int min, int max)
        {
            //step 1: building the pyramid
            for (Int32 i = len / 2 - 1; i >= 0; --i)
            {
                long prev_i = i;
                i = add2pyramid(arr, i, len);
                if (prev_i != i) ++i;
            }

            //step 2: sorting
            for (Int32 k = len - 1; k > 0; --k)
            {
                MethodSwap.start(ref arr[0], ref arr[k]);
                Draw.begin(ref picbox, arr, min, max);
                Int32 i = 0, prev_i = -1;
                while (i != prev_i)
                {
                    prev_i = i;
                    i = add2pyramid(arr, i, k);
                }
            }
        }

        public static void begin(ref int [] arr, ref PictureBox picbox, int min, int max)
        {
            //сортировка
            Pyramid_Sort(arr, arr.Length, ref picbox, min, max);

            System.Console.WriteLine("\n\nThe array after sorting:");
            foreach (Int32 x in arr)
            {
                System.Console.Write(x + " ");
            }
            System.Console.WriteLine("\n\nPress the <Enter> key");
            System.Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualSorfWF
{
    class QuickSort
    {
        //метод возвращающий индекс опорного элемента
        static int Partition(ref int[] array, ref PictureBox picbox, int minIndex, int maxIndex, int minV, int maxV)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    MethodSwap.start(ref array[pivot], ref array[i]);
                    if (picbox != null)
                    {
                        Draw.begin(ref picbox, array, maxV);
                    }
                }
            }

            pivot++;
            MethodSwap.start(ref array[pivot], ref array[maxIndex]);
            if (picbox != null)
            {
                Draw.begin(ref picbox, array, maxV);
            }
            return pivot;
        }

        //быстрая сортировка
        public static int[] begin(ref int[] array,ref PictureBox picbox, int minIndex, int maxIndex, int minV, int maxV)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(ref array,ref picbox, minIndex, maxIndex, minV, maxV);
            begin(ref array, ref picbox, minIndex, pivotIndex - 1, minV,maxV);
            begin(ref array, ref picbox, pivotIndex + 1, maxIndex, minV, maxV);

            return array;
        }
    }
}

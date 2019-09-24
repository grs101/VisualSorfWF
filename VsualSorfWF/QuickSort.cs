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
        static int Partition(int[] array, ref PictureBox picbox, int minIndex, int maxIndex, int minV, int maxV)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    MethodSwap.start(ref array[pivot], ref array[i]);
                    Draw.begin(ref picbox, array, minV, maxV);
                }
            }

            pivot++;
            MethodSwap.start(ref array[pivot], ref array[maxIndex]);
            Draw.begin(ref picbox, array, minV, maxV);
            return pivot;
        }

        //быстрая сортировка
        public static int[] begin(int[] array,ref PictureBox picbox, int minIndex, int maxIndex, int minV, int maxV)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array,ref picbox, minIndex, maxIndex, minV, maxV);
            begin(array, ref picbox, minIndex, pivotIndex - 1, minV,maxV);
            begin(array, ref picbox, pivotIndex + 1, maxIndex, minV, maxV);

            return array;
        }
    }
}

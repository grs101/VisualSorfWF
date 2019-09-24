namespace VisualSorfWF
{
    class BubbleSort
    {
        //класс сортровки пузырьком
        public static void begin(ref int[] array, int i)
        {
            int min = i;
            for (int j = 1; j < array.Length - i; j++)
                if (array[j-1] > array[j])
                    MethodSwap.start(ref array[j-1], ref array[j]);
        }
    }
}

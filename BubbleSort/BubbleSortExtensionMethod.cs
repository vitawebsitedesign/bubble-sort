namespace BubbleSort
{
    public static class BubbleSortExtensionMethod
    {
        public static void BubbleSort(this int[] arr)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    var shouldSwap = arr[i] > arr[i + 1];
                    if (shouldSwap)
                    {
                        var temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }
    }
}

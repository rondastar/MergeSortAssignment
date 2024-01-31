namespace MergeSortAssignment
{
    // Ronda Rutherford
    // Merge Sort
    // 1-30-2024
    internal class Program
    {
        static void Main(string[] args)
        {
            // HOW MERGE SORT WORKS
            // We begin with unsorted values in an array.
            // Then loop through the array splitting it in half each time.
            // until each value is in its own individual array.
            // Next, arrays are compared in sets of 2 arrays, a right one and a left one.
            // If the

            Console.WriteLine("Merge Sort Implementation in C#");
            // Array initialization and method calls will go here

            int[] array = { 12, 11, 13, 5, 6, 7 };

            Console.Write("Original Array: ");
            PrintArray(array);

            //MergeSort(array, 0, array.Length - 1);

            //Console.Write("Sorted Array: ");
            //PrintArray(array);
        }

        // MergeSort method implementation will go here
        public static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                // Find the middle point
                int middle = (left + right) / 2;

                // Sort first and second halves
                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);

                // Merge the sorted halves
                //Merge(array, left, middle, right); 
            }
        }

        // Merge method implementation will go here
        public static void Merge(int[] array, int left, int middle, int right)
        {
            // Implement the logic to merge two sorted subarrays into a single sorted array
            // Include comments explaining the merging process

            int n1 = middle - left + 1;
            int n2 = right - middle;

            // Create temporary arrays
            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            // Copy data to temp arrays leftArray[] and rightArray[]
            for (int i = 0; i < n1; i++)
                leftArray[i] = array[left + i];
            for (int j = 0; j < n2; j++)
                rightArray[j] = array[middle + 1 + j];

            int k = left;
            int x = 0, y = 0;

            // Merge the temp arrays back into array[left..right]
            while (x < n1 && y < n2)
            {
                if (leftArray[x] <= rightArray[y])
                {
                    array[k] = leftArray[x];
                    x++;
                }
                else
                {
                    array[k] = rightArray[y];
                    y++;
                }
                k++;
            }

            // Copy the remaining elements of leftArray[], if there are any
            while (x < n1)
            {
                array[k] = leftArray[x];
                x++;
                k++;
            }

            // Copy the remaining elements of rightArray[], if there are any
            while (y < n2)
            {
                array[k] = rightArray[y];
                y++;
                k++;
            }
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++) 
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine(array[array.Length - 1]);
        } // PrintArray
    }
}

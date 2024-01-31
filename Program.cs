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
            // Begin with unsorted values in an array. If there is more than one value in the array,
            // split the array in half by identifying the left and right index of the first and second half of the array.
            // Repeat this process for the left half of the array and the right half of the array,
            // until each value is in its own individual array.
            // Next, arrays are compared in sets of 2 arrays, a right one and a left one.
            // Because this is a recurvise process, the left and right arrays have already been sorted so each is in order.
            // Iterate through the left and right arrays and compare the left-most value remaining in the  array.
            // The lower value is placed in the next index in the array, until all of the elements in either the right
            // or left array have been put in the main index. Then any values remaining in one of the right or left indexes
            // Is added to the main array. This process is repeated recursively until the entire array is sorted.

            Console.WriteLine("Merge Sort Implementation in C#");
            // Array initialization and method calls will go here

            // Will's example
            int[] array = { 12, 11, 13, 5, 6, 7 };

            Console.Write("Original Example Array: ");
            PrintArray(array);

            MergeSort(array, 0, array.Length - 1);

            Console.Write("Sorted Example Array: ");
            PrintArray(array);

            // Ronda's test
            int[] array2 = { 98, 76, 3, 56, 89, 1 };

            Console.Write("Original Ronda's Array: ");
            PrintArray(array2);

            MergeSort(array2, 0, array2.Length - 1);

            Console.Write("Sorted Ronda's Array: ");
            PrintArray(array2);
        }

        // MergeSort method implementation will go here
        public static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                // Find the middle point
                int middle = (left + right) / 2;

                // Sort first and second halves
                // The first half begins at the left index and ends at the middle index
                MergeSort(array, left, middle);
                // The second half begins at the index that is one greater than the middle and ends at the right index
                MergeSort(array, middle + 1, right);

                // Recursion causes the entire array to be halved until they are the only element in their "half"

                // Merge the halves, which are sorted as they are merged
                Merge(array, left, middle, right);
            } // The if statement causes the function to only run if there is more than one element in the array
        } // MergeSort

        // Merge method implementation will go here
        public static void Merge(int[] array, int left, int middle, int right)
        {
            // Implement the logic to merge two sorted subarrays into a single sorted array
            // Include comments explaining the merging process

            // find the length of each half
            int n1 = middle - left + 1;
            int n2 = right - middle;

            // Create temporary arrays with the length corresponding to each half
            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            // Copy data to temp arrays leftArray[] and rightArray[]
            for (int i = 0; i < n1; i++)
                leftArray[i] = array[left + i];
            for (int j = 0; j < n2; j++)
                rightArray[j] = array[middle + 1 + j];

            // Left index of the array
            int k = left;

            // Left indexes of left and right arrays
            int x = 0, y = 0;

            // Merge the temp arrays back into leftArray[] and rightArray[]
            // The while loop iterates through the left array and right array
            // starting at index 0 for each, as long as neither index end has been reached
            while (x < n1 && y < n2)
            {
                // Compare the value at the left-most index of the left array to that of the
                // left-most index of the right array. Put the lower value in the next index of the
                // main array. Increment the index of the main array and the array half the lowest value 
                // came from.
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

            // When the while loop above is finished, all elements have been sorted.
            // Any elements remaining in the right or left array are added to the end of the main array.

            // Copy the remaining elements of leftArray[], if there are any
            // This happens if the end of the right array is reached first.
            while (x < n1)
            {
                array[k] = leftArray[x];
                x++;
                k++;
            }

            // Copy the remaining elements of rightArray[], if there are any
            // This happens if the end of the left array is reached first.
            while (y < n2)
            {
                array[k] = rightArray[y];
                y++;
                k++;
            }
        } // Merge

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

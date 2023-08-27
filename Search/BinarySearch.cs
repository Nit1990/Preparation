public class BinarySearch
{
    // Binary Search on Sorted Array
    public int Binary(int[] arr, int target)
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
        int targetValue = 4;

        int min = 0;
        int max = arr.Length - 1;

        // mid = min + max /2 will cause overflow error

        while (min <= max)
        {

            int mid = min + (max - min) / 2;

            if (target == arr[mid])
            {
                return mid;
            }
            else if (target > arr[mid])
            {
                min = mid + 1;
            }
            else
            {
                max = mid - 1;
            }
        }
        return default;
    }

    // Search Insert Position
    public void SearchInsert(){
        int[] nums = {1,3,5,6};
        int target = 7;

        int min = 0;
        int max = nums.Length-1;

        while(min<=max){
            int mid = min + (max-min)/2;
            if(target == nums[mid]){
                Console.WriteLine(mid);
            }
            else if(target > nums[mid]){
                min = mid + 1;
            }
            else{
                max = mid -1;
            }
        }
        Console.WriteLine(min);
    }

}


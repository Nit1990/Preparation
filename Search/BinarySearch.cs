public class BinarySearch{

int[] array = new int[] {1,2,3,4,5,6};
int targetValue = 4;

// Binary Search on Sorted Array
public BinarySearch(){
   
    int result = Binary(array,targetValue);
    Console.WriteLine(result);
}
    public int Binary(int[] arr, int target){

      int min = 0;
      int max = arr.Length - 1;

    // mid = min + max /2 will cause overflow error

    while(min <= max){

    int mid = min + (max-min) / 2;

    if(target == arr[mid])
    {
        return mid;
    }
    else if(target > arr[mid])
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
}
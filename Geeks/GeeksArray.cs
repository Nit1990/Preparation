namespace GeeksArray
{

    public class Arrays
    {

        public int[] LeadersInArray()
        {
            int[] arr = { 16, 17, 4, 3, 5, 2 };
            int N = 6;

            int j = N - 1;
            List<int> list = new List<int>();

           
            for (int i = N - 1; i >= 0; i--)
            {
                if (i == N - 1)
                {
                    list.Add(arr[i]);
                    continue;
                }
                if (arr[i] > arr[j])
                {
                    list.Add(arr[i]);
                    j = i;
                }
            }

        var arr1 = list.ToArray();
        // list.Reverse();
        Array.Reverse(arr1);
       return arr1;
        }
    }

}
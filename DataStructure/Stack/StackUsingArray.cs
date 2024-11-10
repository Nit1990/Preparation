namespace PracticeProject.DataStructure.Stack
{
    public class StackUsingArray
    {
        int[] stackArray = new int[100];
        int top = -1;

        public void push(int x)
        {
            top++;
            stackArray[top] = x;
        }

        public int pop()
        {
            int x = stackArray[top];
            top--;
            return x;
        }
        public int Size()
        {
            return top + 1;
        }

        public void Show()
        {
            int size = Size();

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(stackArray[i]);
            }
        }
    }
}

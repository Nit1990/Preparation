namespace DataStructure
{

    public class StackUsingLinkedList
    {

        // Linked List Node
        public class Node
        {
            public object data;
            public Node next;

        }

        // head - top 
        Node top;

        // Initialize top with null
        public StackUsingLinkedList()
        {
            this.top = null;

        }

        // Is Empty Stack
        public bool IsEmpty()
        {
            return top == null;
        }

        public void Push(object x)
        {
            // create a new node temp 
            Node temp = new Node();

            temp.data = x;
            // change the pointer temp.next => top, top => temp
            temp.next = top;
            top = temp;

        }

        // Check the first element
        public void Peek()
        {
            if (!IsEmpty())
            {
                Console.WriteLine(this.top.data);
            }
            else
            {
                Console.WriteLine("Stack is Empty");

            }
        }

        // Remove the top element from stack
        public object Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Underflow");
                return string.Empty;
            }

            // update the top pointer to next node
            var x = top.data;
            top = top.next;
            return x;
        }

        // Display the Stack
        public void Display()
        {
            if (!IsEmpty())
            {
                // assign top to temp node for traversing
                Node temp = top;

                while (temp != null)
                {
                    Console.WriteLine(temp.data);

                    temp = temp.next;


                }
            }

        }

        // Valid Parentheses
        public bool ValidParentheses(string s)
        {
            foreach(char c in s){
                if(c == '}')
                {
                    if(IsEmpty() || Convert.ToChar(this.Pop()) != '{')
                    return false;
                }
                else if(c == ')')
                {
                    if(IsEmpty() || Convert.ToChar(this.Pop()) != '(')
                    return false;
                }
                else if(c == ']')
                {
                    if(IsEmpty() || Convert.ToChar(this.Pop()) != '[')
                    return false;
                }
                else {
                    this.Push(c);
                }
            }
            var result = this.IsEmpty();
            return this.IsEmpty();
            

        }

    }



}
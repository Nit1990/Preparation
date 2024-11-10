namespace PracticeProject.DataStructure.LinkedList
{

    // Creating Node of a Linked List.
    public class Node
    {

        public int Data;
        public Node Next;

    }

    // Linked List class having Head , which is null
    public class SingleLinkedList
    {
        public Node head;

        // Traversing Linked List
        public void Traversing()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            Node p = head;
            while (p != null)
            {
                Console.WriteLine(p.Data);
                p = p.Next;
            }
        }

        // Add Element at front
        public void push_front(int newElement)
        {
            Node newNode = new Node(); // Allocate a new Node 
            newNode.Data = newElement; // assign data
            newNode.Next = head; // make next node of new node as Head
            head = newNode; // make new node as head

        }

        // Add Element at back
        public void push_back(int newElement)
        {
            Node newNode = new Node(); // Allocate a new Node
            newNode.Data = newElement; // assign data
            newNode.Next = null; // make next node of new node as Null because its last node

            if (head == null)
            {
                head = newNode; // if linkedList is empty then make new node as head. make the node as first node
            }
            else // traverse the LinkedList to reach end of LinkedList
            {
                Node temp = new Node();
                temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;

            }
        }

        // Reverse LinkedList
        public void reverseList()
        {
            // Initialize 3 pointers prev,curr,next
            if (head != null)
            {
                Node? prev = null; //initialize to null
                Node next = head; //initialize to head
                Node curr = head; //initialize to head



                while (curr != null)
                {
                    next = curr.Next; //a node ahead of current
                    curr.Next = prev; // reverse the link
                    prev = curr; //a node behind of current , move a node
                    curr = next; // bring curr node to same point as next , move a node
                }
                head = prev;
            }

        }

        // Floyd's cycle-finding algorithm to detect Loop in LinkedList
        public void HasLoop()
        {

            if (head == null || head.Next == null)
            {
                Console.Write("False");
            }
            Node slow = head;
            Node fast = head.Next;

            while (fast != null && fast.Next != null)
            {
                if (slow == fast)
                {
                    Console.Write("True");
                }
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            Console.WriteLine("False");
        }

        // Floyd's cycle-finding algorithm to find middle node of Linkedlist, check How to initialize fast pointer
        public void GetMiddleOfLinkedList()
        {
            if (head == null || head.Next == null)
            {
                Console.WriteLine(value: head?.Data);
            }

            Node slow = head;
            Node fast = head;

            while (fast != null && fast.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
            }

            Console.WriteLine(value: slow?.Data);
        }

        public void BubbleSortExData()
        {
            Node end;
            Node p;
            Node q;

            for (end = null; end != head.Next; end = p)
            {
                for (p = head; p.Next != end; p = p.Next)
                {
                    q = p.Next;
                    if (p.Data > q.Data)
                    {
                        (p.Data, q.Data) = (q.Data, p.Data);
                    }
                }
            }


        }

        public void MergeLinkedList(SingleLinkedList list)
        {
            Node p1 = head;
            Node p2 = list.head;
            Node startM;
        }
        public void IntersectionOfTwoLinkedList()
        {

        }
    }

}
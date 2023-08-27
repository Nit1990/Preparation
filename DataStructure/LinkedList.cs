namespace DataStructure
{

    // Creating Node of a Linked List.
    public class Node
    {

        public int _data;
        public Node _next;

    }

    // Linked List class having Head , which is null
    public class SingleLinkedList
    {
        public Node head;

        public SingleLinkedList()
        {
            head = null;
        }

        // Add Element at front
        public void push_front(int newElement)
        {
            Node newNode = new Node(); // Allocate a new Node 
            newNode._data = newElement; // assign data
            newNode._next = head; // make next node of new node as Head
            head = newNode; // make new node as head

        }

        // Add Element at back
        public void push_back(int newElement)
        {
            Node newNode = new Node(); // Allocate a new Node
            newNode._data = newElement; // assign data
            newNode._next = null; // make next node of new node as Null because its last node

            if (head == null)
            {
                head = newNode; // if linkedList is empty then make new node as head. make the node as first node
            }
            else
            {
                Node temp = new Node();
                temp = head;
                while (temp._next != null)
                    temp = temp._next;
                temp._next = newNode;

            }
        }
        public void reverseList()
        {
            // Initialize 3 pointers prev,curr,next
            if (this.head != null)
            {
                Node prev = null; //initialize to null
                Node next = this.head; //initialize to head
                Node curr = this.head; //initialize to head



                while (curr != null)
                {
                    next = curr._next; //a node ahead of current
                    curr._next = prev; // reverse the link
                    prev = curr; //a node behind of current , move a node
                    curr = next; // bring curr node to same point as next , move a node
                }
                this.head = prev;
            }

        }
    }



}
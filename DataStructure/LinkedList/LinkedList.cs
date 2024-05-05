namespace DataStructure.LinkedList
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
        public Node? head;

       
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
            else
            {
                Node temp = new Node();
                temp = head;
                while (temp.Next != null)
                    temp = temp.Next;
                temp.Next = newNode;

            }
        }
       
        // Reverse LinkedList
        public void reverseList()
        {
            // Initialize 3 pointers prev,curr,next
            if (head != null)
            {
                Node prev = null; //initialize to null
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
    }



}
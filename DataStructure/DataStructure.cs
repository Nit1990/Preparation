using PracticeProject.DataStructure.LinkedList;
using PracticeProject.DataStructure.Stack;
using PracticeProject.DataStructure.Tree;

namespace PracticeProject.DataStructure
{
    public class DataStructure
    {
        public DataStructure()
        {
            LinkedList();
            Tree();
            Stack();

        }

        public static void Stack()
        {
            // Stack using LinkedList

            // StackUsingLinkedList stack = new StackUsingLinkedList();
            // stack.ValidParentheses("{()[]");

            // Stack using Array

            // StackUsingArray stack = new StackUsingArray();
            //stack.push(7);
            //stack.push(8);
            //stack.Show();
            //stack.pop();
            //stack.Show();

        }

        public static void LinkedList()
        {
            // LinkedList

            SingleLinkedList linkedList = new SingleLinkedList();
            linkedList.push_back(5);
            linkedList.push_back(7);
            linkedList.push_back(9);
            linkedList.push_back(15);
            SingleLinkedList list2 = new SingleLinkedList();
            list2.push_back(4);
            list2.push_back(8);
            list2.push_back(10);
            list2.push_back(30);
            list2.push_back(80);
            linkedList.MergeLinkedList(list2);

            // linkedList.BubbleSortExData();
            // linkedList.reverseList();
        }

        public static void Tree()
        {

            TreeClass tree = new TreeClass();
            // tree.Insert(5);
            //tree.Insert(3);
            //tree.Insert(6);
        }
    }
}
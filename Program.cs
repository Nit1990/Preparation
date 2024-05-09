// See https://aka.ms/new-console-template for more information
using OOPS;
using Coding;
using DesignPattern;
using MediumLeetcode;
using GeeksArray;
using SOLID;
using PrintPattern;
using DataStructure.Stack;
using Sorting;
using DataStructure.Tree;

#pragma warning disable CA1050 // Declare types in namespaces
public class Program
#pragma warning restore CA1050 // Declare types in namespaces
{

    // Driver Code
    public static void Main()
    {

        // Search
        // BinarySearch obj = new BinarySearch();
        // obj.BinarySearch();
        //obj.SearchInsert();


        // OOPS

        // Derived obj = new Derived();
        // Base bcdc = new Derived();
        // bcdc.show();
        //   CompositionExample comp = new();
        //   AssociationExample asso = new();
        //AggregationExample aggre = new();

        // SOLID
        //Liskov liskov = new Liskov();


        // Coding

        GMS obj = new();
        //obj.NoOfCharacter();
       // obj.FirstNonRepetingCharbyArray();
        //obj.FirstNonRepetingCharbyDict();
        // obj.PowerOf10();
        // obj.LongestCommonSubString();
        //obj.SplitDictionary();
        // obj.ValidPalindrome();
        //obj.MaxArea();
        //obj.MaxAreaUsingWhile();
        //obj.FirstOccurence();
        //obj.IsAnagram();
        //obj.ContainsDuplicate();
        // obj.RemoveDuplicates();
        // obj.TwoSum();
        //obj.BestTimeToBuy();
        // obj.ReplaceElements();
        //obj.IsSubsequence();
        // obj.LongestCommonPrefix();
       // obj.LongestCommonPrefix();
        // obj.MoveZero();
        // obj.NumUniqueEmails();
        // obj.CanPlaceFlowers();
        //obj.LargestElementArray();
        obj.LargestElementArrayForLoop();
        //obj.SecondSmallestAndSecondLargestArray();
        // obj.IsArraySorted();
        //obj.UnionOfArray();
        // obj.AppearOnceInArray();
        //  obj.MaximumOneInArray();
        //obj.LongestSubArray();
        //obj.ReverseVowels();
        //obj.RearrangebySign();
        //obj.ReverseWords();
        obj.FrequencyOfLetter();
        // Geeks for geeks

        // Arrays obj = new Arrays();
        //obj.LeadersInArray();
        // obj.RotateArrayOnePlace();
        //obj.RotateArrayByKElementsUsingTempArray();
        //obj.RotateArrayByKElementsLeft();
        // obj.ReverseWordInString();

        // LinkedList

        // SingleLinkedList linkedList = new SingleLinkedList();
        // linkedList.push_back(10);
        // linkedList.push_back(20);
        // linkedList.push_back(30);
        // linkedList.push_back(40);
        // linkedList.reverseList();

        // Stack using LinkedList

        // StackUsingLinkedList stack = new StackUsingLinkedList();
        // stack.ValidParentheses("{()[]");

        // Stack using Array

        //StackUsingArray stack = new StackUsingArray();
        //stack.push(7);
        //stack.push(8);
        //stack.Show();
        //stack.pop();
        //stack.Show();

        // Tree
        Tree tree = new Tree();
        tree.Insert(5);
        tree.Insert(3);
        tree.Insert(6);

        // Medium Leetcode

        Medium objMedium = new Medium();
        // var result = objMedium.GroupAnagrams();
        // objMedium.TopKFrequentElements();
        // objMedium.ProductExceptSelf();
        // objMedium.TwoSumArrayIsSorted();
        // objMedium.ThreeSum();
        // objMedium.MaxSubArraySum();
        //objMedium.KadaneAlgorithm();
        //objMedium.Sort012();
        // objMedium.BuyAndSell();       
       

        //Singelton.GetInstance();
        //Singelton.GetInstance();

        // Adapter 
        // AdapterExample adapterExample = new();

        // Factory
        // FactoryExample factoryExample = new();

        // Strategy Design Pattern

        // The client code picks a concrete strategy and passes it to the
        // context. The client should be aware of the differences between
        // strategies in order to make the right choice.
        // var context = new Context();

        // Console.WriteLine("Client: Strategy is set to normal sorting.");
        // context.SetStrategy(new ConcreteStrategyA());
        // context.DoSomeBusinessLogic();

        // Console.WriteLine();

        // Console.WriteLine("Client: Strategy is set to reverse sorting.");
        // context.SetStrategy(new ConcreteStrategyB());
        // context.DoSomeBusinessLogic();

        // Pattern

        //Pattern pattern = new Pattern();
        // pattern.Pattern1();
        // pattern.Pattern2();
        //pattern.Pattern3();
        // pattern.Pattern4();
        //pattern.Pattern5();
        // pattern.Pattern6();
        // pattern.Pattern7();

        // Sorting
      //  _ = new InsertionSort();
       // _ = new QuickSort();
    }

}




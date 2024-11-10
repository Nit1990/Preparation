namespace PracticeProject.DataStructure.Tree
{
    
    public class Node
    {
        public int data;

        // Reference to Left Child
        public Node? left;

        // Reference to Right Child
        public Node? right;

        public Node(int val = 0,Node? left = null, Node? right = null)
        {
            this.data = val;

            this.left = left;

            this.right = right;
        }
    }
    public class TreeClass
    {
        public Node? root;

        public void Insert(int key)
        {
           root = InsertRecord(root, key);
        }

        private Node InsertRecord(Node? root, int key)
        {
            if(root == null)
            {
                root= new Node(key);
                return root;
            }
            if(key < root.data)
            {
                root.left = InsertRecord(root.left, key);
            }
            else if(key > root.data)
            {
                root.right = InsertRecord(root.right, key);
            }

            return root;
        }
    }
}

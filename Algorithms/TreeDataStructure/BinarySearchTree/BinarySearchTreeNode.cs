namespace Algorithms.TreeDataStructure.BinarySearchTree
{
    /// <summary>
    /// BinarySearchTreeNode provides implementation of Binary Search Tree Data Model for INTEGER type
    /// This implementation would be better with GENERIC approach
    /// </summary>
    public class BinarySearchTreeNode
    {
        //ACTUAL DATA
        public int Data;

        public BinarySearchTreeNode LeftNode;

        public BinarySearchTreeNode RightNode;

        public BinarySearchTreeNode(int data)
        {
            Data = data;
        }
    }
}
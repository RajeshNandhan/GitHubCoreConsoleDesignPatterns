namespace Algorithms.TreeDataStructure.AVLTree
{
    internal class AVLTreeNode
    {
        public int Data;

        public int Height;

        public AVLTreeNode LeftNode;

        public AVLTreeNode RightNode;

        public AVLTreeNode(int value)
        {
            Data = value;
            Height = 1;
        }
    }
}

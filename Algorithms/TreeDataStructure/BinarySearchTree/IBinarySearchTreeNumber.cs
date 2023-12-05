namespace Algorithms.TreeDataStructure.BinarySearchTree
{
    public interface IBinarySearchTreeNumber
    {
        void AddNode(int value);

        List<int> GetInOrderTraversal();

        List<int> GetPostOrderTraversal();

        List<int> GetPreOrderTraversal();

        void DeleteNode(int key);

        BinarySearchTreeNode Search(int value);
    }
}

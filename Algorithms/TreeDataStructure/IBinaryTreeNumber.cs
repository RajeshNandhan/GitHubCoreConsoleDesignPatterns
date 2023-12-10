namespace Algorithms.TreeDataStructure
{
    public interface IBinaryTreeNumber
    {
        void AddNode(int value);

        List<int> GetInOrderTraversal();

        List<int> GetPostOrderTraversal();

        List<int> GetPreOrderTraversal();

        void DeleteNode(int key);

        bool Search(int value);
    }
}

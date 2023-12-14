namespace Algorithms.TreeDataStructure.BTree
{
    public class BTreeNode
    {
        public List<int> DataCollection { get; set; }

        public List<BTreeNode> ChildNodes { get; set; }

        public BTreeNode Parent { get; set; }

        public BTreeNode()
        {
            DataCollection = new List<int>();
            ChildNodes = new List<BTreeNode>();
            Parent = null;
        }
    }
}

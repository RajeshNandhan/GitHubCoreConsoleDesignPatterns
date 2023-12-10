namespace Algorithms.TreeDataStructure.BinarySearchTree
{
    /// <summary>
    /// BinarySearchTreeRecursiveNumber basically creates and implements BinarySearchTreeNode logics through RECURSIVE way
    /// </summary>
    internal class BinarySearchTreeRecursiveNumber : IBinaryTreeNumber
    {
        private BinarySearchTreeNode rootNode;

        /// <summary>
        /// Traverse the entire tree in In-Order routine
        /// </summary>
        public List<int> GetInOrderTraversal()
        {
            return InOrderTraversal(rootNode);
        }

        private List<int> InOrderTraversal(BinarySearchTreeNode node)
        {
            List<int> traversedData = new List<int>();

            if (node != null)
            {
                traversedData.AddRange(InOrderTraversal(node.LeftNode));
                traversedData.Add(node.Data);
                traversedData.AddRange(InOrderTraversal(node.RightNode));
            }

            return traversedData;
        }

        public List<int> GetPostOrderTraversal()
        {
            List<int> result = new List<int>();
            PostOrderTraversal(rootNode, result);
            return result;
        }

        private void PostOrderTraversal(BinarySearchTreeNode node, List<int> result)
        {
            if (node != null)
            {
                PostOrderTraversal(node.LeftNode, result);
                PostOrderTraversal(node.RightNode, result);
                result.Add(node.Data);
            }
        }

        public List<int> GetPreOrderTraversal()
        {
            List<int> result = new List<int>();
            PreOrderTraversal(rootNode, result);
            return result;
        }

        private void PreOrderTraversal(BinarySearchTreeNode node, List<int> result)
        {
            if (node != null)
            {
                result.Add(node.Data);
                PreOrderTraversal(node.LeftNode, result);
                PreOrderTraversal(node.RightNode, result);
            }
        }


        /// <summary>
        /// Add method creates a new BinarySearchTreeNode and assign it to either left or right node of a Parent node
        /// This Add is a RECUSRSIVE (BinarySearchTreeNode.Add()) way of creating and assigning appropriate BinarySearchTreeNode to a Parent node
        /// </summary>
        /// <summary>
        /// Add method creates a new BinarySearchTreeNode and calls RECUSRSIVE (BinarySearchTreeNode.Add()) way of adding child node to rootNode
        /// </summary>
        /// <summary>
        /// Add method creates a new BinarySearchTreeNode and assign it to either left or right node of a Parent node
        /// This Add is a RECUSRSIVE (BinarySearchTreeNode.Add()) way of creating and assigning appropriate BinarySearchTreeNode to a Parent node
        /// </summary>
        public void AddNode(int value)
        {
            if (rootNode == null)
            {
                rootNode = new BinarySearchTreeNode(value);
            }
            else
            {
                Add(rootNode, value);
            }
        }

        private void Add(BinarySearchTreeNode currentNode, int value)
        {
            if (value < currentNode.Data)
            {
                //TREMINAL CONDITION - LAST NODE WILL ALWAYS HAVE LeftNode and RightNode as NULL
                if (currentNode.LeftNode == null)
                {
                    currentNode.LeftNode = new BinarySearchTreeNode(value);
                }
                else
                {
                    Add(currentNode.LeftNode, value);
                }
            }
            else
            {
                if (currentNode.RightNode == null)
                {
                    currentNode.RightNode = new BinarySearchTreeNode(value);
                }
                else
                {
                    Add(currentNode.RightNode, value);
                }
            }
        }

        public void DeleteNode(int key)
        {
            DeleteNode(rootNode, key);
        }

        private BinarySearchTreeNode DeleteNode(BinarySearchTreeNode root, int key)
        {
            if (root == null)
                return root;

            if (key < root.Data)
                //ONE CHILD CASE - Node that needs to be deleted has ONLY either left and right node
                //LEFT or RIGHT side node of "Current Node" will become LEFT node of the root node or parent node
                root.LeftNode = DeleteNode(root.LeftNode, key);
            else if (key > root.Data)
                //ONE CHILD CASE - Node that needs to be deleted has ONLY either left and right node
                //LEFT or RIGHT side node of "Current Node" will become RIGHT node of the root node or parent node
                root.RightNode = DeleteNode(root.RightNode, key);
            else
            {
                //When a "Current Node" has only one of the node from LEFT or RIGHT side,
                //LEFT or RIGHT side node will become LEFT or RIGHT node of the root node, by that it will REMOVE the reference of "Current Node" 
                //Additionally if "Current Node" has both LEFT or RIGHT side node as NULL, root node will take LEFT or RIGHT side as NULL node
                if (root.LeftNode == null)
                    return root.RightNode;
                else if (root.RightNode == null)
                    return root.LeftNode;

                /*START - IN ORDER Successor SHIFT*/
                //TWO CHILD CASE - Node that needs to be deleted has both left and right
                root.Data = GetMinValue(root.RightNode);

                root.RightNode = DeleteNode(root.RightNode, root.Data);
            }

            return root;
        }

        private int GetMinValue(BinarySearchTreeNode node)
        {
            int minValue = node.Data;

            while (node.LeftNode != null)
            {
                minValue = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minValue;
        }

        public bool Search(int value)
        {
            var node = Search(rootNode, value);
            return node != null;
        }

        private BinarySearchTreeNode Search(BinarySearchTreeNode node, int value)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Data == value)
            {
                return node;
            }
            else
            {
                if (value < node.Data)
                {
                    return Search(node.LeftNode, value);
                }
                else
                {
                    return Search(node.RightNode, value);
                }
            }
        }
    }
}

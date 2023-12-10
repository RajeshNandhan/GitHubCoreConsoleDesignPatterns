namespace Algorithms.TreeDataStructure.AVLTree
{
    /// <summary>
    /// Balanced Binary Search Tree for Number
    /// </summary>
    internal class AVLTreeNumber : IBinaryTreeNumber
    {
        AVLTreeNode root;

        public List<int> GetPreOrderTraversal()
        {
            List<int> result = new List<int>();

            PreOrderTraversal(root, result);

            return result;
        }

        private void PreOrderTraversal(AVLTreeNode node, List<int> result)
        {
            if (node != null)
            {
                result.Add(node.Data);
                PreOrderTraversal(node.LeftNode, result);
                PreOrderTraversal(node.RightNode, result);
            }
        }

        public List<int> GetInOrderTraversal()
        {
            return InOrderTraversal(root);
        }

        private List<int> InOrderTraversal(AVLTreeNode node)
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

            PostOrderTraversal(root, result);

            return result;
        }

        private void PostOrderTraversal(AVLTreeNode node, List<int> result)
        {
            if (node != null)
            {
                PostOrderTraversal(node.LeftNode, result);
                PostOrderTraversal(node.RightNode, result);
                result.Add(node.Data);
            }
        }

        private int GetHeight(AVLTreeNode node)
        {
            if (node == null)
                return 0;
            return node.Height;
        }

        private AVLTreeNode getSuccessor(AVLTreeNode node)
        {
            AVLTreeNode current = node;

            while (current.LeftNode != null)
                current = current.LeftNode;

            return current;
        }

        private int getBalanceFactor(AVLTreeNode node)
        {
            if (node == null)
                return 0;
            return GetHeight(node.LeftNode) - GetHeight(node.RightNode);
        }

        /// <summary>
        /// example ROTATE = {current node ~  152 <- 234}, new node {144}, {input node ~ 144 <- 152 <- 234}, {output - balance node ~ 144 <- 152 -> 234}
        /// In this case node {AAA <- 144}, {234 -> BBB} will NOT have any change
        /// IF 152 has any RIGHT node {152 -> CCC} it will become LEFT node of 234, 152 -> 234 <- CCC
        /// RECALCULATE the height and update it to node after the balance
        /// </summary>
        private AVLTreeNode RightRotate(AVLTreeNode currentNode)
        {
            AVLTreeNode currentNodeLeftNode = currentNode.LeftNode;
            AVLTreeNode backupNode = currentNodeLeftNode.RightNode;

            currentNodeLeftNode.RightNode = currentNode;
            currentNode.LeftNode = backupNode;

            currentNode.Height = Math.Max(GetHeight(currentNode.LeftNode), GetHeight(currentNode.RightNode)) + 1;
            currentNodeLeftNode.Height = Math.Max(GetHeight(currentNodeLeftNode.LeftNode), GetHeight(currentNodeLeftNode.RightNode)) + 1;

            return currentNodeLeftNode;
        }

        /// <summary>
        /// example ROTATE = {current node ~  23 -> 41}, new node {190}, {input node ~ 23 -> 41 -> 190}, {output - balance node ~ 21 <- 41 -> 190}
        /// In this case node {AAA <- 23}, {190 -> BBB} will NOT have any change
        /// IF 41 has any LEFT node { CCC <- 41} it will become RIGHT node of 23, {23 <- 41 and 23 -> CCC}
        /// RECALCULATE the height and update it to node after the balance
        /// </summary>
        private AVLTreeNode LeftRotate(AVLTreeNode node)
        {
            AVLTreeNode currentRightNode = node.RightNode;//41
            AVLTreeNode backupNode = currentRightNode.LeftNode;//null

            currentRightNode.LeftNode = node;// 21 <- 41
            node.RightNode = backupNode;

            node.Height = Math.Max(GetHeight(node.LeftNode), GetHeight(node.RightNode)) + 1;
            currentRightNode.Height = Math.Max(GetHeight(currentRightNode.LeftNode), GetHeight(currentRightNode.RightNode)) + 1;

            return currentRightNode;
        }

        public void AddNode(int value)
        {
            root = Insert(root, value);
        }

        private AVLTreeNode Insert(AVLTreeNode node, int data)
        {
            if (node == null)
                return new AVLTreeNode(data);

            //Step 1 - Create a new node and assign it to either LEFT or RIGHT node
            //NEW NODE Will be created with height 1 from "Insert" call
            if (data < node.Data)
                node.LeftNode = Insert(node.LeftNode, data);
            else if (data > node.Data)
                node.RightNode = Insert(node.RightNode, data);
            else
                return node;

            //Step 2 - Height of the NODE = Max count of nodes from LEFT or RIGHT side and +1
            //RESET the Height of CURRENT NODE to till ROOT node in a recursive
            node.Height = 1 + Math.Max(GetHeight(node.LeftNode), GetHeight(node.RightNode));

            //Step 3 - Balance factor of a NODE => COUNT of nodes from LEFT - COUNT of nodes from RIGHT
            // - Balance factor should be {-1,0,1}, otherwise rotate the node to balance it
            int balanceFactor = GetHeight(node.LeftNode) - GetHeight(node.RightNode);




            //Balance factor will be +VE number, when the LEFT SIDE has more Child node then RIGHT SIDE node
            //Example - {current node ~  152 <- 190}, ADD new node {144}, {RESULTANT CURRENT NODE ~ 144 <- 152 <- 190}, 
            //Example - { RESULTANT BALANCED CURRENT NODE ~ 144 <- 152 -> 190 }
            if (balanceFactor > 1 && data < node.LeftNode.Data)
                return RightRotate(node);

            //Balance factor will be -VE number, when the RIGHT SIDE has more child node then LEFT SIDE node
            //Example - { current node ~ 23 -> 41}, ADD new node (data) { 190 }, { RESULTANT CURRENT NODE ~ 23-> 41-> 190}
            //Example - { RESULTANT BALANCED CURRENT NODE ~ 21 < -41-> 190}
            if (balanceFactor < -1 && data > node.RightNode.Data)
                return LeftRotate(node);


            //Balance factor will be +VE number, when the LEFT SIDE has more Child node then RIGHT SIDE node
            //Example - {current node ~  145 <- 165}, ADD new node {156}, { RESULTANT CURRENT NODE ~ 145 <- 165 and 145 -> 156}
            //Example (AFter LeftRotate) - { RESULTANT CURRENT NODE ~ 145 <- 156 <- 165}
            //Example(AFter RightRotate) - { RESULTANT BALANCED CURRENT NODE ~ 145 <- 156 -> 165}
            //List<int>() { 165, 145, 156 }
            if (balanceFactor > 1 && data > node.LeftNode.Data)
            {
                node.LeftNode = LeftRotate(node.LeftNode);
                return RightRotate(node);
            }

            //Balance factor will be -VE number, when the RIGHT SIDE has more child node then LEFT SIDE node
            //Example - { current node ~ 41 -> 152}, ADD new node (data) { 44 }, { RESULTANT CURRENT NODE ~ 41 -> 152 and 44 <- 152}
            //Example (AFter RightRotate) - { RESULTANT CURRENT NODE ~ 41 -> 44 -> 152}
            //Example(AFter LeftRotate) - { RESULTANT BALANCED CURRENT NODE ~ 41 <- 44 -> 152}
            //List<int>() { 41, 152, 44 }
            if (balanceFactor < -1 && data < node.RightNode.Data)
            {
                node.RightNode = RightRotate(node.RightNode);
                return LeftRotate(node);
            }

            return node;
        }



        public void DeleteNode(int key)
        {
            Delete(root, key);
        }

        // Function to delete a node from the AVL tree
        public AVLTreeNode Delete(AVLTreeNode selectedNode, int data)
        {
            if (selectedNode == null)
                return selectedNode;

            if (data < selectedNode.Data)
                selectedNode.LeftNode = Delete(selectedNode.LeftNode, data);
            else if (data > selectedNode.Data)
                selectedNode.RightNode = Delete(selectedNode.RightNode, data);
            else
            {
                // selectedNode - Node with only one child or no child
                // selectedNode - Node that is matching to data
                if (selectedNode.LeftNode == null || selectedNode.RightNode == null)
                {
                    //In case of one child "nodeBackup" will have either LEFT node or RIGHT node
                    //In case of no child "nodeBackup" will have NULL 
                    AVLTreeNode nodeBackup = null;

                    if (selectedNode.LeftNode == null)
                        nodeBackup = selectedNode.RightNode;
                    else
                        nodeBackup = selectedNode.LeftNode;

                    selectedNode = nodeBackup;
                }
                else
                {
                    // Node with two children: Get the inorder successor
                    AVLTreeNode temp = getSuccessor(selectedNode.RightNode);

                    // Copy the inorder successor's data to this node
                    selectedNode.Data = temp.Data;

                    // Delete the inorder successor
                    selectedNode.RightNode = Delete(selectedNode.RightNode, temp.Data);
                }
            }

            // when the deleted node is leaf node and has no child to it
            if (selectedNode == null)
                return selectedNode;

            // Update height of the current node
            selectedNode.Height = 1 + Math.Max(GetHeight(selectedNode.LeftNode), GetHeight(selectedNode.RightNode));

            // Get the balance factor of this node
            int balance = getBalanceFactor(selectedNode);

            // If the node becomes unbalanced, perform rotations

            // Left Left Case
            if (balance > 1 && getBalanceFactor(selectedNode.LeftNode) >= 0)
                return RightRotate(selectedNode);

            // Left Right Case
            if (balance > 1 && getBalanceFactor(selectedNode.LeftNode) < 0)
            {
                selectedNode.LeftNode = LeftRotate(selectedNode.LeftNode);
                return RightRotate(selectedNode);
            }

            // Right Right Case
            if (balance < -1 && getBalanceFactor(selectedNode.RightNode) <= 0)
                return LeftRotate(selectedNode);

            // Right Left Case
            if (balance < -1 && getBalanceFactor(selectedNode.RightNode) > 0)
            {
                selectedNode.RightNode = RightRotate(selectedNode.RightNode);
                return LeftRotate(selectedNode);
            }

            return selectedNode;
        }



        public bool Search(int value)
        {
            var node = Search(root, value);
            return node != null;
        }

        private AVLTreeNode Search(AVLTreeNode node, int value)
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

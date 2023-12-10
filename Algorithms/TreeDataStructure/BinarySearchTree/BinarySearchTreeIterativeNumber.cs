namespace Algorithms.TreeDataStructure.BinarySearchTree
{
    /// <summary>
    /// BinarySearchTreeIterativeNumber basically creates and implements BinarySearchTreeNode logics through ITERATIVE way
    /// 
    /// Binary Tree Structure: A BST is a binary tree where each node can have at most two children: a left child and a right child.
    /// Ordering Property: For every node in the BST:
    ///    The values in the left subtree are less than the value of the node.
    ///    The values in the right subtree are greater than the value of the node.
    ///    This property holds true for all nodes in the tree.
    /// </summary>
    internal class BinarySearchTreeIterativeNumber : IBinaryTreeNumber
    {
        private BinarySearchTreeNode rootNode;

        public void DeleteNode(int value)
        {
            DeleteNode(rootNode, value);
        }

        /// <summary>
        /// DELETE - Remove a selected node reference from parent Node
        /// CASE 1 - ZERO CHILD CASE - Node that needs to be deleted has no CHILD in both left and right (NULL <- 5 -> NULL)
        /// CASE 2 - TWO CHILD CASE - Node that needs to be deleted has both left and right
        /// CASE 3 - ONE CHILD CASE - Node that needs to be deleted has ONLY either left and right node
        /// </summary>
        private void DeleteNode(BinarySearchTreeNode root, int value)
        {
            //currentNode = Node that needs to be deleted that matching the value passed
            BinarySearchTreeNode currentNode = root;

            //parentNode - Parent node of the node needs to be deleted
            BinarySearchTreeNode parentNode = root;

            do
            {
                if (currentNode.Data == value)
                {
                    //CASE 3 - ONE CHILD CASE - Node that needs to be deleted has ONLY either left and right node
                    if (currentNode.LeftNode != null && currentNode.RightNode != null)
                    {
                        /* METHOD 1 START - IN ORDER PREDECESSOR SHIFT */

                        ////Step 1 - inOrderPredecessorNode = FInd the Greatest Value in Right Sub Tree, Which will be a value of leaf node 
                        //int inOrderPredecessorNodeValue = GetMaxValue(currentNode.LeftNode);

                        ////Step 2 - Now delete inOrderPredecessorNodeValue the leaf node
                        //DeleteNode(currentNode, inOrderPredecessorNodeValue);

                        ////Step 3 - COnvert current node value with inOrderPredecessorNodeValue
                        //currentNode.Data = inOrderPredecessorNodeValue;

                        /* END - IN ORDER PREDECESSOR SHIFT */



                        /* METHOD 2 START - IN ORDER Successor SHIFT*/

                        //Step 1 - inOrderSuccessorValueNode = FInd the Smallest Value in Right Sub Tree, Which will be a value of leaf node
                        int inOrderSuccessorValue = GetMinValue(currentNode.RightNode);

                        //Step 2 - Now delete inOrderSuccessorValueNode the leaf node
                        DeleteNode(currentNode, inOrderSuccessorValue);

                        //Step 3 - COnvert current node value with inOrderSuccessorValueNode
                        currentNode.Data = inOrderSuccessorValue;

                        /* END - IN ORDER Successor SHIFT */
                    }
                    else
                    {
                        //ZERO CHILD CASE - Node that needs to be deleted has no CHILD in both left and right
                        //ONE CHILD CASE - Node that needs to be deleted has ONLY either left and right node
                        if (parentNode.LeftNode == currentNode)
                        {
                            if (currentNode.LeftNode != null)
                            {
                                // [INPUT] => PARENT NODE : {13 <- 15 -> NULL} CURRENT NODE : {7 <- 13 -> NULL)}
                                // [OUTPUT AFTER DELETE 13] => {7 <- 15 -> NULL}
                                parentNode.LeftNode = currentNode.LeftNode;
                            }
                            else
                            {
                                // [INPUT] => (14 <- 13 -> NULL) (13 <- 15 -> NULL)
                                // [OUTPUT DELETE 13] => (14 <- 15 -> NULL)
                                parentNode.LeftNode = currentNode.RightNode;
                            }
                        }
                        else
                        {
                            if (currentNode.RightNode != null)
                            {
                                // [INPUT] => (NULL <- 23 -> 28) (NULL <- 19 -> 23)
                                // [OUTPUT DELETE 23] => (NULL <- 19 -> 28)
                                parentNode.RightNode = currentNode.RightNode;
                            }
                            else
                            {
                                // [INPUT] => (21 <- 23 -> NULL) (NULL <- 19 -> 23)
                                // [OUTPUT DELETE 23] => (NULL <- 19 -> 21)
                                parentNode.RightNode = currentNode.LeftNode;
                            }
                        }
                    }

                    return;
                }
                else
                {
                    //Search for the node to be deleted 
                    //currentNode - node to be deleted 
                    //parentNode - Parent node of the node needs to be deleted
                    parentNode = currentNode;

                    if (value < currentNode.Data)
                    {
                        currentNode = currentNode.LeftNode;
                    }
                    else
                    {
                        currentNode = currentNode.RightNode;
                    }
                }
            } while (currentNode != null);
        }

        /// <summary>
        /// inOrderSuccessorValueNode = FInd the Smallest Value in Sub Tree, Which will be a value of leaf node 
        /// </summary>
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

        /// <summary>
        /// inOrderPredecessorNode = FInd the Greatest Value in Sub Tree, Which will be a value of leaf node 
        /// </summary>
        private int GetMaxValue(BinarySearchTreeNode node)
        {
            int maxValue = node.Data;

            while (node.RightNode != null)
            {
                maxValue = node.RightNode.Data;
                node = node.RightNode;
            }

            return maxValue;

        }
        /// <summary>
        /// Add method creates a new BinarySearchTreeNode through iterative approach
        /// STEP 1 - create a newNode and set it has rootNode
        /// STEP 1 RESULT => root node -> 23 (NULLL <- 23 -> NULL)
        /// 
        /// Add 45 to TREE STRUCTURE
        /// STEP 2 - create a newNode (NULLL <- 45 -> NULL) and check if newNode.Data < rootNode.Data (45 < 23)
        /// STEP 3 - Since 45 > 23 and rootNode.RightNode = NULL, SET rootNode.RightNode = newNode (NULLL <- 45 -> NULL)
        /// STEP 3 RESULT => NULL <- 23 -> (NULLL <- 45 -> NULL) 
        /// 
        /// Add 55 to TREE STRUCTURE
        /// STEP 4 - create a newNode (NULLL <- 55 -> NULL) and check if newNode.Data < rootNode.Data (55 < 23)
        /// STEP 4 - Since 55 > 23 and and rootNode.RightNode != NULL SET rootNode.RightNode as next node (currentNode)
        /// STEP 4 RESULT => currentNode = (NULLL <- 45 -> NULL) 
        /// STEP 5 - check if newNode.Data < currentNode.Data (55 < 45)
        /// STEP 5 - Since 55 > 45 and currentNode.RightNode = NULL, SET currentNode.RightNode = newNode (NULLL <- 55 -> NULL)
        /// STEP 5 RESULT => NULL <- 23 -> (NULLL <- 45 -> (NULLL <- 55 -> NULL)
        /// </summary>
        public void AddNode(int data)
        {
            BinarySearchTreeNode newNode = new BinarySearchTreeNode(data);

            //Better always copy the rootNode to new variable before the iteration
            BinarySearchTreeNode currentNode = rootNode;
            BinarySearchTreeNode backupCurrentNode;


            if (rootNode == null) //First node insertion
                rootNode = newNode;
            else
            {
                do
                {
                    backupCurrentNode = currentNode;

                    //If NEW node (newNode) data is LESS then CURRENT-NODE data, then NEW node (newNode) should go to LEFT side of the tree or sub tree (CURRENT-NODE)
                    //NEW node (newNode) will become the leaf node of the left most node as its parent node
                    //Adding (NULLL <- 41 -> NULL) to (NULLL <- 45 -> NULL) will become ((NULLL <- 41 -> NULL)  <- 45 -> NULL)
                    if (newNode.Data < currentNode.Data)
                    {
                        currentNode = currentNode.LeftNode;

                        //IF LeftNode is NULL then newNode will become LeftNode of currentNode
                        //LeftNode will be NULL when its the leaf node
                        //IF LeftNode has data, then CONTINUE to check for LeftNode's child node data as next step
                        if (currentNode == null)
                        {
                            backupCurrentNode.LeftNode = newNode;
                        }
                    }
                    //If NEW node (newNode) data is GREATER then CURRENTNODE data, then NEW node (newNode) should go to RIGHT side of the tree or sub tree (CURRENT-NODE)
                    //NEW node (newNode) will become the leaf node of the right most node as its parent node
                    //Adding (NULLL <- 55 -> NULL) to (NULLL <- 45 -> NULL) will become (NULL  <- 45 -> (NULLL <- 55 -> NULL))
                    else
                    {
                        currentNode = currentNode.RightNode;

                        if (currentNode == null)
                        {
                            backupCurrentNode.RightNode = newNode;
                        }
                    }
                } while (currentNode != null);
            }
        }

        /// <summary>
        /// "IN-ORDER TRAVERSAL" => LEFT, ROOT, RIGHT or LEFT, CURRENT, RIGHT
        /// The "in-order" in a Binary Search Tree (BST) refers to a specific way of traversing the tree
        /// The in-order traversal is particularly useful when you need to retrieve the nodes in sorted order (ascending order)
        /// 
        /// How it works - GitHubCoreConsoleDesignPatterns\BinarySearchTree.txt
        /// </summary>
        public List<int> GetInOrderTraversal()
        {
            List<int> result = new List<int>();
            if (rootNode == null)
                return result;

            Stack<BinarySearchTreeNode> stack = new Stack<BinarySearchTreeNode>();
            BinarySearchTreeNode current = rootNode;

            //WHILE start from rootNode
            //WHILE for Traversing right nodes
            while (current != null || stack.Count > 0)
            {
                //WHILE for Traversing left nodes and Add nodes to STACK
                //IF LEFT NODE IS => 1 <- 12 <- 23, STACK WILL BE => {Item 1 = 23, Item 2 = 12, Item 3 = 1}
                while (current != null)
                {
                    stack.Push(current);
                    current = current.LeftNode;
                }

                //WHEN STACK NODE IS => {Item 1 = 23, Item 2 = 12, Item 3 = 1},
                //POP() TAKES VALUE FROM TOP, SO ARRAY (result) =>  {Item 3, Item 2, Item 1} => [1,12,23]
                current = stack.Pop();
                result.Add(current.Data);

                //{NULL <- 1 -> NULL}, {1 <- 12 -> 15}, {12 <- 23 -> SOMETHING}
                //HERE 15 SHOULD COME BETWEEN 12 and 23
                //SO 15 WILL BE PUSHED AND POPED IN THE NEXT ITERATION
                //When any of the left node has RIGHT NODE, IT wll be lessthan the PARENT node of the both current left node and its right node
                current = current.RightNode;
            }

            return result;
        }

        /// <summary>
        /// "POST-ORDER TRAVERSAL" => LEFT, RIGHT, ROOT => LEFT, RIGHT, CURRENT
        /// "post-order" in a Binary Search Tree (BST) refers to a specific way of traversing the tree
        /// 
        /// How it works - GitHubCoreConsoleDesignPatterns\BinarySearchTree.txt
        /// </summary>
        public List<int> GetPostOrderTraversal()
        {
            List<int> result = new List<int>();

            if (rootNode == null)
                return result;

            Stack<BinarySearchTreeNode> stack = new Stack<BinarySearchTreeNode>();
            Stack<int> output = new Stack<int>();
            stack.Push(rootNode);

            while (stack.Count > 0)
            {
                BinarySearchTreeNode current = stack.Pop();
                output.Push(current.Data);

                if (current.LeftNode != null)
                    stack.Push(current.LeftNode);

                if (current.RightNode != null)
                    stack.Push(current.RightNode);
            }

            while (output.Count > 0)
            {
                result.Add(output.Pop());
            }

            return result;
        }

        /// <summary>
        /// "PRE-ORDER TRAVERSAL" => LEFT, RIGHT, ROOT => LEFT, RIGHT, CURRENT
        /// "pre-order" in a Binary Search Tree (BST) refers to a specific way of traversing the tree
        /// 
        /// How it works - GitHubCoreConsoleDesignPatterns\BinarySearchTree.txt
        /// </summary>
        public List<int> GetPreOrderTraversal()
        {
            List<int> result = new List<int>();
            Stack<BinarySearchTreeNode> stack = new Stack<BinarySearchTreeNode>();

            if (rootNode == null)
                return result;

            stack.Push(rootNode); /*Iteration 1 - ADD Root node to stack*/

            while (stack.Count > 0)
            {
                /*When LEFT node is null, Right Node will be set to current, so the right traversal begins */
                BinarySearchTreeNode current = stack.Pop();/*Iteration 1 - SET Root node as current, Iteration 2 - SET LEFT node as current*/

                result.Add(current.Data);/*Iteration 1 - ADD Root node value to result, Iteration 2 - ADD LEFT node value to result*/

                if (current.RightNode != null)
                    stack.Push(current.RightNode); /*Iteration 1 - ADD Right Node to stack, Iteration 2 - ADD Right Node to stack*/

                if (current.LeftNode != null)
                    stack.Push(current.LeftNode); /*Iteration 1 - ADD LEFT Node to stack, Iteration 2 - ADD LEFT Node to stack*/
            }

            return result;
        }

        /// <summary>
        /// SEARCH A VALUE IN Binary Search Tree Node
        /// Searching for a value in a Binary Search Tree (BST) involves traversing the tree based on the properties of a BST:
        /// Properties of a BST - values in the left subtree are less than the root, and values in the right subtree are greater than the root.
        /// Properties of a BST - Each node in Binary Search Tree (BST) is like a root with its DATA and a reference LEFT and RIGHT NODE
        /// </summary>
        /// <returns></returns>
        public bool Search(int data)
        {
            BinarySearchTreeNode currentNode = rootNode;

            while (currentNode != null)
            {
                //IF INPUT matched to currentNode NODE DATA, then break the loop and RETURN currentNode
                if (currentNode.Data == data)
                    return true;

                //IF INPUT is Less than DATA of the current node, it will only be there in its left node or left sub tree
                if (data < currentNode.Data)
                {
                    currentNode = currentNode.LeftNode;
                }
                else
                {
                    currentNode = currentNode.RightNode;
                }
            }

            return false;
        }
    }
}

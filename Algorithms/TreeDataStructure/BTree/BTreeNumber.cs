namespace Algorithms.TreeDataStructure.BTree
{
    public class BTreeNumber
    {
        private BTreeNode RootNode { get; set; }

        private readonly int ChildNodeMaxCount;

        private readonly int ItemsPerNodeMaxCount;

        /// <summary>
        /// ItemsPerNodeMaxCount will always be ODD number
        /// WHEN ChildNodeMaxCount = 1 => { ItemsPerNodeMaxCount = 1 } , { for 1 middle is 1 }
        /// WHEN ChildNodeMaxCount = 2 => { ItemsPerNodeMaxCount = 3 } , { for 3 middle is 2 }
        /// WHEN ChildNodeMaxCount = 3 => { ItemsPerNodeMaxCount = 5 } , { for 5 middle is 3 }
        /// WHEN ChildNodeMaxCount = 4 => { ItemsPerNodeMaxCount = 7 } , { for 7 middle is 4 }
        /// </summary>
        public BTreeNumber(int childNodeMaxCount)
        {
            ChildNodeMaxCount = childNodeMaxCount;
            ItemsPerNodeMaxCount = (2 * ChildNodeMaxCount) - 1;
        }

        public List<int> GetInOrderTraversal()
        {
            List<int> result = new List<int>();

            InOrderTraversal(RootNode, result);

            return result;
        }

        private void InOrderTraversal(BTreeNode node, List<int> result)
        {
            if (node != null)
            {
                if (node.ChildNodes.Count != 0)
                {
                    // Traverse the left child and its keys
                    // IF ROOT NODE - DataCollection = {41, 134}
                    // IF ROOT NODE - ChildNodes = {12,23,39},{43,44},{151,175,181,190}
                    // ITERATION 1 - {12,23,39} + 41 
                    // ITERATION 1 result => [12,23,39,41]
                    // ITERATION 2 = [12,23,39,41] + {43,44} + 134
                    // ITERATION 2 - result => [12,23,39,41,43,44,134]
                    for (int i = 0; i < node.DataCollection.Count; i++)
                    {
                        InOrderTraversal(node.ChildNodes[i], result);
                        result.Add(node.DataCollection[i]);
                    }

                    // Traverse the right child
                    // POST ITERATION for 2 index - [12,23,39,41,43,44,134] + last child node that is right most child
                    // POST ITERATION for 2 index - [12,23,39,41,43,44,134] + last child node that is right most child node
                    // POST ITERATION for 2 index - [12,23,39,41,43,44,134] + {151,175,181,190} 
                    // POST ITERATION for 2 result => [12,23,39,41,43,44,134,151,175,181,190]
                    InOrderTraversal(node.ChildNodes[node.DataCollection.Count], result);
                }
                else
                {
                    // WHEN node has NO ChildNodes - leaf node to result
                    for (int i = 0; i < node.DataCollection.Count; i++)
                    {
                        result.Add(node.DataCollection[i]);
                    }
                }
            }
        }

        public void Insert(int data)
        {
            if (RootNode == null)
            {
                RootNode = new BTreeNode();
            }

            BTreeNode currentNode = RootNode;

            //CASE - WHEN NUMBER OF DATA IN RootNode EXCEEDS THE LIMIT (ItemsPerNodeMaxCount)
            //STep 1 - Create a new root node (newRoot)
            //STep 2 - Add CURRENT node (currentNode) as a child node of new root node (newRoot)
            //STep 3 - SplitChild means Add middle item of currentNode to (newRoot) data collection and convert remining data into 2 child node of (newRoot)
            //Step 4 - Re-assign the new node (newRoot) as RootNode
            //Step 5 - Continue for insertion given data to RootNode or child node of RootNode
            if (currentNode.DataCollection.Count == ItemsPerNodeMaxCount)
            {
                BTreeNode newRoot = new BTreeNode();
                newRoot.ChildNodes.Add(currentNode);
                SplitChild(newRoot, 0, currentNode);
                RootNode = newRoot;
                InsertIntoNonFull(newRoot, data);
            }
            else
            {
                //CASE - WHEN NUMBER OF DATA IN RootNode NODE DataCollection IS LESSTHEN THE LIMIT (ItemsPerNodeMaxCount)
                //JUST ADD DATA to currentNode.DataCollection
                InsertIntoNonFull(currentNode, data);
            }
        }

        /// <summary>
        /// DataCollection b-tree will always be sorted order 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="inputData"></param>
        private void InsertIntoNonFull(BTreeNode node, int inputData)
        {
            if (node.ChildNodes.Count == 0)
            {
                //DataCollection b-tree will always be sorted order 
                node.DataCollection.Add(inputData);
                node.DataCollection = node.DataCollection.OrderBy(x => x).ToList();
            }
            else
            {
                //Collection is zero based index, and iteration happens in reverse order
                // node might have more than 1 item in that case it might have more than 1 child node
                int dataCollectionCurrentIndex = node.DataCollection.Count - 1;

                while (dataCollectionCurrentIndex >= 0 && inputData < node.DataCollection[dataCollectionCurrentIndex])
                {
                    dataCollectionCurrentIndex--;
                }

                dataCollectionCurrentIndex++;

                if (node.ChildNodes[dataCollectionCurrentIndex].DataCollection.Count == ItemsPerNodeMaxCount)
                {
                    SplitChild(node, dataCollectionCurrentIndex, node.ChildNodes[dataCollectionCurrentIndex]);

                    if (inputData > node.DataCollection[dataCollectionCurrentIndex])
                    {
                        dataCollectionCurrentIndex++;
                    }
                }

                InsertIntoNonFull(node.ChildNodes[dataCollectionCurrentIndex], inputData);
            }
        }

        //Step 1 - Create a NEW Node (newChildNode) and SET "parentNode" as Parent Node of newChildNode 
        //Step 2 - INSERT the NEW Node (newChildNode) as child of "parentNode" => "parentNode" will have 2 childs = {existing child, new child [EMPTY]}
        //"ChildNodeMaxCount" is always a middle position of data collection and note "ChildNodeMaxCount - 1" is always a middle position for "0" based index collection
        //Step 3 - Insert a (middle position) DATA from the existingChildNodeOfParentNode into the parent's data collection at a specific position
        //IF existingChildNodeOfParentNode.DataCollection = {11, 23, 29, 45, 56} THEN parentNode.DataCollection ={29} 
        //Step 4 - Move a subset of Data Collection from existingChildNodeOfParentNode to the newChildNode
        //IF existingChildNodeOfParentNode.DataCollection = {11, 23, 29, 45, 56} THEN newChildNode.DataCollection ={45, 56}
        //Step 5 - Remove the transferred Data Collection that is newChildNode.DataCollection ={45, 56} from the existingChildNodeOfParentNode
        //IF existingChildNodeOfParentNode.DataCollection = {11, 23, 29, 45, 56} THEN existingChildNodeOfParentNode.DataCollection ={11, 23}
        private void SplitChild(BTreeNode parentNode, int position, BTreeNode existingChildNodeOfParentNode)
        {
            // Create a new node "newChildNode"  AND  Set "parent" as the parent of the NEW NODE
            BTreeNode newChildNode = new BTreeNode();
            newChildNode.Parent = parentNode;

            // Insert the new node "newChildNode" into the parent's children list at a specific position
            parentNode.ChildNodes.Insert(position + 1, newChildNode);

            // Insert a DATA from the existingChildNodeOfParentNode into the parent's data collection at a specific position (middle position)
            parentNode.DataCollection.Insert(position, existingChildNodeOfParentNode.DataCollection[ChildNodeMaxCount - 1]);

            // Move a subset of Data Collection from existingChildNodeOfParentNode to the newChildNode
            // FROM Middle position to Last position 
            // WHEN ChildNodeMaxCount = 3 THEN EXTARCT DATA FROM 3 to 4 POSITION
            newChildNode.DataCollection.AddRange(existingChildNodeOfParentNode.DataCollection.GetRange(ChildNodeMaxCount, ChildNodeMaxCount - 1));

            // Remove the transferred Data Collection from existingChildNodeOfParentNode
            // WHEN ChildNodeMaxCount = 3 THEN the RANGE of DATA FROM 2 to 3 POSITION will be removed
            // REMAINING DATA IN THE existingChildNodeOfParentNode IS FROM 0 to 1 POSITION
            existingChildNodeOfParentNode.DataCollection.RemoveRange(ChildNodeMaxCount - 1, ChildNodeMaxCount);

            // Check if existingChildNodeOfParentNode has child nodes (is not a leaf node)
            if (existingChildNodeOfParentNode.ChildNodes.Count != 0)
            {
                // Move a subset of child nodes from existingChildNodeOfParentNode to newChildNode
                newChildNode.ChildNodes.AddRange(existingChildNodeOfParentNode.ChildNodes.GetRange(ChildNodeMaxCount, ChildNodeMaxCount));

                // Remove the transferred child nodes from existingChildNodeOfParentNode
                existingChildNodeOfParentNode.ChildNodes.RemoveRange(ChildNodeMaxCount, ChildNodeMaxCount);
            }
        }
    }
}

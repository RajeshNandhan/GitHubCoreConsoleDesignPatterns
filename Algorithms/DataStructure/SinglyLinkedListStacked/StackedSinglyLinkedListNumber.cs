using Algorithms.DataStructure.SinglyLinkedList;
using System.Text;

namespace Algorithms.DataStructure.SinglyLinkedListStacked
{
    /// <summary>
    /// Advantage of stacked linked list or fact for any linked list is, it DOESNOT have array size limited
    /// Array size NOT limited while creating or adding items to collection
    /// </summary>
    internal class StackedSinglyLinkedListNumber
    {
        /// <summary>
        /// lastNode will always have last added node and should be maintained by insert remove and reverse
        /// </summary>
        private SinglyLinkedListNode lastNode;


        /// <summary>
        ///  Create a new node and add it to the collection
        ///  Time complexity is a constatnt that is Takes O(1) time for adding a new item to collection
        /// </summary>
        public void Push(int data)
        {
            //STEP 1 - Create a new node
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
            SinglyLinkedListNode tempNode = lastNode;

            if (lastNode == null)
            {
                lastNode = newNode;
            }
            else
            {
                newNode.NextNode = tempNode;
                lastNode = newNode;
            }
        }

        public void Pop()
        {
            SinglyLinkedListNode currentNode = lastNode;
            SinglyLinkedListNode tempNode;

            if (lastNode == null)
            {
                return;
            }
            else
            {
                tempNode = currentNode.NextNode;
                lastNode = tempNode;
            }
        }

        public int GetCount()
        {
            int NodeIndex = 0;

            //MUST always copy the lastNode to new variable before the iteration
            SinglyLinkedListNode currentNode = lastNode;

            while (currentNode != null)
            {
                NodeIndex++;
                currentNode = currentNode.NextNode;
            }

            return NodeIndex;
        }

        public override string ToString()
        {
            //MUST always copy the lastNode to new variable before the iteration
            SinglyLinkedListNode currentNode = lastNode;

            StringBuilder stringBuilder = new StringBuilder();

            while (currentNode != null)
            {
                stringBuilder.Append(currentNode.Data + " , ");
                currentNode = currentNode.NextNode;
            }

            return stringBuilder.ToString();
        }
    }
}

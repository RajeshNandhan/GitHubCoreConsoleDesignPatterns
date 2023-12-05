using System.Text;

namespace Algorithms.DataStructure.SinglyLinkedList
{
    internal class SinglyLinkedListNumber
    {
        /// <summary>
        /// HeadNode will always be the starting node of collection
        /// COllection iteration should start from HeadNode
        /// </summary>
        private SinglyLinkedListNode headNode;

        /// <summary>
        /// lastNode will always have last added node and should be maintained by insert remove and reverse
        /// </summary>
        private SinglyLinkedListNode lastNode;

        /// <summary>
        ///  Create a new node and add it to the collection
        ///  Time complexity is a constatnt that is Takes O(1) time for adding a new item to collection
        /// </summary>
        public void Add(int data)
        {
            //STEP 1 - Create a new node
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);

            //when headNode == null - Keep bith headNode, lastNode both has newNode for the first node
            if (headNode == null)
            {
                headNode = newNode;
                lastNode = newNode;
            }
            else
            {
                //Update the lastNode with newly added newNode, next time add new item as its next item
                //newNode.NextNode will always and must be NULL
                lastNode.NextNode = newNode;
                lastNode = newNode;
            }
        }


        /// <summary>
        /// Inserts a new Node containing data at given index
        /// Insertion of new node takes O(1) time but finding node at insertion point takes O(n) time.
        /// Hence Takes overall O(n) time.
        /// How to Inserts a node?
        /// STEP 1 - Find the node of the given index from the collection 
        /// STEP 2 - Identify (Current node) and its (Next Node)
        /// STEP 3 - RESET nextNode of (Current node) to newNode
        /// STEP 3 - SET newNode's  next node to Next node of (Current node)
        /// example in collection [a->b b->c c->d d->e] after insertion g @ 2 position [a->b b->g g->c c->d d->e]
        /// </summary>
        public void Insert(int data, int index)
        {
            //CREATE A NODE to insert at a given position
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);

            //MUST always copy the HeadNode to new variable before the iteration
            SinglyLinkedListNode currentNode = headNode;

            if (index == 0)
            {
                //When adding newNode for zero index it should become start node so its headNode
                newNode.NextNode = currentNode;
                headNode = newNode;
            }
            else
            {
                int currentPosition = 1;

                //FIND THE CURRENT ELEMENT IN THE GIVEN "INDEX"
                while (currentPosition < index && currentNode != null)
                {
                    currentNode = currentNode.NextNode;
                    currentPosition++;
                }

                // currentNode will be NULL FOR OUT OF INDEX CASE
                if (currentNode != null)
                {
                    SinglyLinkedListNode previousNode = currentNode;
                    SinglyLinkedListNode nextNode = currentNode.NextNode;

                    previousNode.NextNode = newNode;
                    newNode.NextNode = nextNode;

                    //nextNode will be NULL IF ITEM INSERTED AFTER LAST NODE
                    //nextNode should become a new last node as its added after lassNode
                    //NEED TO REST LastNode as newNode FOR ADD LOGIC TO WORK [EDGE CASE]
                    if (nextNode == null)
                    {
                        lastNode = newNode;
                    }
                }
            }
        }

        /// <summary>
        /// How to remove a node?
        /// STEP 1 - Find the node matching in the collection (Current node) and its (Previous Node)
        /// STEP 2 - RESET nextNode of (Previous Node) to nextNode of (Current node) 
        /// example in collection [a->b b->c c->d d->e] after reset [a->b b->d d->3] ,so C is removed
        /// SO, (Current node) link is broken and become orphaned
        /// </summary>
        public void Remove(int data)
        {
            SinglyLinkedListNode currentNode = headNode;
            SinglyLinkedListNode previousNode;

            while (currentNode != null)
            {
                //ONLY WHEN FIRST ITEM TO BE REMOVED
                if (currentNode.Data == data && currentNode.Data == headNode.Data)
                {
                    currentNode = currentNode.NextNode;
                    headNode = currentNode;
                    return;
                }
                else
                {
                    previousNode = currentNode;
                    currentNode = currentNode.NextNode;

                    ///currentNode will be null for the last element
                    if (currentNode != null && currentNode.Data == data)
                    {
                        previousNode.NextNode = currentNode.NextNode;

                        //previousNode.NextNode will become NULL when currentNode.NextNode is NULL and LAST ELEMENT
                        //NEED TO REST LastNode as newNode FOR ADD LOGIC TO WORK [EDGE CASE]
                        if (previousNode.NextNode == null)
                        {
                            lastNode = previousNode;
                        }

                        return;
                    }
                }
            }
        }

        /// <summary>
        /// [a->b b->c c->d d->e e->f f->null] after reverse [f->e e->d d->c c->b b->a a->null]
        /// </summary>
        public void Reverse()
        {
            SinglyLinkedListNode currentNode;
            SinglyLinkedListNode previousNode = null;
            SinglyLinkedListNode nextNode;

            currentNode = headNode;//a
            nextNode = headNode;//a

            while (nextNode != null)//LAST NODE OF nextNode WILL BE NULL
            {
                //nextnode as BACK UP
                nextNode = nextNode.NextNode;//{b}{c}{d}{e}{f}{null}

                currentNode.NextNode = previousNode;//{null}{a}{b}{c}{d}{e}

                previousNode = currentNode;//{a}{b}{c}{d}{e}{f}

                //SWAP THE NODE
                currentNode = nextNode;//{b}{c}{d}{e}{f}{null}
            }

            headNode = previousNode;//{f}->{e}->{d}
        }

        /// <summary>
        ///  Find the first node containing given data that matches the key, Returns -1 if not found
        ///  Takes O(n) time, that is linear time complexity meaning number of iteration varies based on number of items and it is not a constatnt
        /// </summary>
        public int FindIndex(int data)
        {
            int Index = 0;

            //MUST always copy the HeadNode to new variable before the iteration
            SinglyLinkedListNode currentNode = headNode;

            while (currentNode != null)
            {
                Index++;
                if (currentNode.Data == data)
                {
                    return Index;
                }
                else
                {
                    currentNode = currentNode.NextNode;
                }
            }
            return -1;
        }

        public int GetCount()
        {
            int NodeIndex = 0;

            //MUST always copy the HeadNode to new variable before the iteration
            SinglyLinkedListNode currentNode = headNode;

            while (currentNode != null)
            {
                NodeIndex++;
                currentNode = currentNode.NextNode;
            }

            return NodeIndex;
        }

        public override string ToString()
        {
            //MUST always copy the HeadNode to new variable before the iteration
            SinglyLinkedListNode currentNode = headNode;

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

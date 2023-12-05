using System.Text;

namespace Algorithms.DataStructure.DoublyLinkedList
{
    internal class DoubleLinkedListNumber
    {
        private DoubleLinkedListNode headNode;
        private DoubleLinkedListNode lastNode;

        /// <summary>
        ///  Create a new node and add it to the collection
        ///  Time complexity is a constatnt that is Takes O(1) time for adding a new item to collection
        /// </summary>
        public void Add(int data)
        {
            //STEP 1 - Create a new node
            DoubleLinkedListNode newNode = new DoubleLinkedListNode(data);

            if (headNode == null)
            {
                headNode = newNode;
                lastNode = newNode;
            }
            else
            {
                lastNode.NextNode = newNode;
                newNode.PreviousNode = lastNode;
                lastNode = newNode;
            }
        }

        //a->b a<-b->c b<-c->d c<-d->e insert f at 3 position {b<-c->d}
        //a->b a<-b->F b<-F->c F<-c->d c<-d->e
        //todo-delete last node
        public void Insert(int data, int index)
        {
            //STEP 1 - Create a new node
            DoubleLinkedListNode newNode = new DoubleLinkedListNode(data);
            int indexCounter = 0;

            DoubleLinkedListNode currentNode = headNode;
            DoubleLinkedListNode currentPreviousNode = null;

            if (index == 0)
            {
                newNode.NextNode = currentNode;
                currentNode.PreviousNode = newNode;
                headNode = newNode;
                return;
            }
            else
            {
                while (currentNode != null && index >= indexCounter)
                {
                    if (index == indexCounter)
                    {
                        newNode.PreviousNode = currentNode.PreviousNode;
                        newNode.NextNode = currentNode;

                        currentNode.PreviousNode = newNode;
                        currentPreviousNode.NextNode = newNode;

                        return;
                    }

                    indexCounter++;
                    currentPreviousNode = currentNode;
                    currentNode = currentNode.NextNode;
                }
            }
        }

        //a->b a<-b->c b<-c->d c<-d->e d<-e remove c
        //a->b a<-b->D b<-D->e d<-e remove c
        public void Remove(int data)
        {
            DoubleLinkedListNode currentNode = headNode;
            DoubleLinkedListNode currentPreviousNode = null;
            DoubleLinkedListNode currentNextNode = null;

            while (currentNode != null)
            {
                if (currentNode.Data == data)
                {
                    //currentNode.PreviousNode will be NULL FOR FIRST NODE
                    if (currentNode.PreviousNode == null)
                    {
                        currentNextNode = currentNode.NextNode;
                        currentNextNode.PreviousNode = null;
                        currentNode.NextNode = null;
                        headNode = currentNextNode;
                    }
                    else
                    {
                        currentNextNode = currentNode.NextNode;
                        currentPreviousNode = currentNode.PreviousNode;
                        currentPreviousNode.NextNode = currentNextNode;
                        currentNextNode.PreviousNode = currentPreviousNode;
                    }

                    return;
                }

                currentNode = currentNode.NextNode;
            }
        }

        //a->b a<-b->c b<-c->d c<-d->e d<-e->f e<-f->NULL
        //step 1 : b<-a-NULL c<-b->a d<-c->b e<-d->c f<-e->d NULL<-f->e
        //step 1 : SET HEADNODE AS  NULL<-f->e now the out out => f->e->d->c->b->a->NULL
        public void Reverse()
        {
            DoubleLinkedListNode currentNode = headNode;
            DoubleLinkedListNode nextNode = null;
            bool option2 = true;

            while (currentNode != null)
            {
                nextNode = currentNode.NextNode;

                //nextNode will be NULL for the last item's next node
                //reverse e<-f to NULL<-f->e 
                //SET NULL<-f->e has head node now
                //THIS WHOE nextNode == null CAN BE TAKEN CARE BY MAINTIANING LAST NODE AS A PROBERTY FOR DoubleLinkedListNumber
                if (nextNode == null && option2)
                {
                    headNode = currentNode;
                    nextNode = currentNode.NextNode;
                    headNode.NextNode = headNode.PreviousNode;
                    headNode.PreviousNode = nextNode;
                    return;
                }
                else
                {
                    currentNode.NextNode = currentNode.PreviousNode;
                    currentNode.PreviousNode = nextNode;
                    currentNode = nextNode;
                }
            }

            //COMMENT REPLACEMENT CODE + THIS WHOE nextNode == null CAN BE TAKEN CARE BY MAINTIANING LAST NODE AS A PROBERTY FOR DoubleLinkedListNumber
            if (option2 == false)
            {
                currentNode = headNode;
                headNode = lastNode;
                lastNode = currentNode;
            }
        }

        /// <summary>
        ///  Find the first node containing given data that matches the key, Returns -1 if not found
        ///  Takes O(n) time, that is linear time complexity meaning number of iteration varies based on number of items and it is not a constatnt
        /// </summary>
        public int FindIndex(int data)
        {
            int Index = 0;

            //MUST always copy the HeadNode to new variable before the iteration
            DoubleLinkedListNode currentNode = headNode;

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
            DoubleLinkedListNode currentNode = headNode;

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
            DoubleLinkedListNode currentNode = headNode;

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

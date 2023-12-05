using Algorithms.DataStructure.SinglyLinkedList;
using System;
using System.Text;

namespace Algorithms.DataStructure.CircularSinglyLinkedList
{
    internal class CircularSinglyLinkedListNumber
    {
        private SinglyLinkedListNode lastNode;

        /// <summary>
        ///  Create a new node and add it to the collection
        ///  Time complexity is a constatnt that is Takes O(1) time for adding a new item to collection
        ///  iteration 1 (add a) - a.NextNode = a (a is the last node)(a->a)
        ///  iteration 2 (add b) - b.NextNode = a and a.NextNode = b , so order formed (a,b) with circular reference (a->b, b->a) {b->a = last node}
        ///  iteration 2 (add c) - c.NextNode = a and b.NextNode = c , so order formed (a,b,c) with circular reference (a->b, b->c, c->a) {c->a = last node}
        ///  iteration 2 (add d) - d.NextNode = a and c.NextNode = d , so order formed (a,b,c,d) with circular reference (a->b, b->c, c->d d->a) {d->a = last node}
        /// </summary>
        public void Add(int data)
        {
            //STEP 1 - Create a new node
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);

            //lastNode is NULL for the first add
            if (lastNode == null)
            {
                lastNode = newNode;
                newNode.NextNode = lastNode;
            }
            else
            {
                //since newNode will become the last node, it retains lastNode.NextNode as next node
                //lastNode.NextNode will always have the first node in it - circular reference
                newNode.NextNode = lastNode.NextNode;

                //Previously added lastNode will have newNode has is nextNode
                //data arranges like [when you add b as newnode after a = a->b] [when you add c as newnode after b = b->c]
                lastNode.NextNode = newNode;

                //newly added newNode should be the last node of the collection
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
        /// example in collection [a->b b->c c->d d->e e->a] after insertion g @ 2 position [a->b b->g g->c c->d d->e e->a]
        /// </summary>
        public void Insert(int data, int index)
        {
            //CREATE A NODE to insert at a given position
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);

            //MUST always copy the HeadNode to new variable before the iteration
            SinglyLinkedListNode currentNode = lastNode;

            if (index == 0)
            {
                newNode.NextNode = lastNode.NextNode;
                lastNode.NextNode = newNode;
            }
            else
            {
                int currentPosition = 0;

                //FIND THE CURRENT ELEMENT IN THE GIVEN "INDEX"
                do
                {
                    currentNode = currentNode.NextNode;
                    currentPosition++;
                }
                while (currentPosition < index && currentNode != lastNode);

                // currentPosition == index will make sure node inserted at right index and prevent insertion at overflow
                // if currentPosition != index means given index input is not with in existing range
                if (currentPosition == index)
                {
                    SinglyLinkedListNode nextNode = currentNode.NextNode;

                    currentNode.NextNode = newNode;
                    newNode.NextNode = nextNode;

                    //if currentNode is happens to last node of the existing collection re-assign it with newNode [one new node [newNode] added at the lastNode]
                    if (currentNode == lastNode)
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
        /// example - remove c->d from collection [a->b b->c c->d d->e e->a] after reset [a->b b->d d->e e->a],so C is removed
        /// SO, (Current node) link is broken and become orphaned
        /// </summary>
        public void Remove(int data)
        {
            //MUST always copy the HeadNode to new variable before the iteration
            SinglyLinkedListNode currentNode = lastNode;
            SinglyLinkedListNode previousNode = null;

            do
            {
                previousNode = currentNode;
                currentNode = currentNode.NextNode;

                if (currentNode.Data == data)
                {
                    previousNode.NextNode = currentNode.NextNode;

                    //RESET lastNode with previousNode of currentNode to maintain the circular reference
                    //example - remove e->a from collection[a->b b->c c->d d->e e->a] after reset[a->b b->c c->d d->a],so E last node is removed
                    if (currentNode == lastNode)
                    {
                        lastNode = previousNode;
                    }

                    return;
                }
            }
            while (currentNode != lastNode);
        }

        /// <summary>
        /// [a->b b->c c->d d->e e->f f->a] after reverse [f->e e->d d->c c->b b->a a->f]
        /// [a->b b->c c->d d->e e->f f->a] => [b->a c->b d->c e->d f->e     a->f]
        /// a,b,c,d,e,f => f,e,d,c,b,a
        /// </summary>
        public void Reverse()
        {
            SinglyLinkedListNode currentNode;
            SinglyLinkedListNode previousNode = null;
            SinglyLinkedListNode nextNode;

            currentNode = lastNode;
            previousNode = currentNode.NextNode;//FIRST NODE
            nextNode = currentNode.NextNode;//FIRST NODE

            do
            {
                nextNode = nextNode.NextNode;

                previousNode.NextNode = currentNode;

                currentNode = previousNode;

                previousNode = nextNode;
            }
            while (nextNode != lastNode);

            lastNode = previousNode.NextNode;

            previousNode.NextNode = currentNode;
        }

        /// <summary>
        ///  Find the first node containing given data that matches the key, Returns -1 if not found
        ///  Takes O(n) time, that is linear time complexity meaning number of iteration varies based on number of items and it is not a constatnt
        /// </summary>
        public int FindIndex(int data)
        {
            int Index = 0;

            SinglyLinkedListNode currentNode = lastNode;

            do
            {
                currentNode = currentNode.NextNode;

                Index++;

                if (currentNode.Data == data)
                {
                    return Index;
                }
            }
            while (currentNode != lastNode);

            return -1;
        }

        public int GetCount()
        {
            int nodeIndex = 0;

            //lastNode.NextNode will points to the first node of the collection
            //currentNode == lastNode is when one circular iteration completes
            SinglyLinkedListNode currentNode = lastNode;

            do
            {
                currentNode = currentNode.NextNode;
                nodeIndex++;
            }
            while (currentNode != lastNode);

            return nodeIndex;
        }

        public override string ToString()
        {
            //lastNode.NextNode will points to the first node of the collection
            //currentNode == lastNode is when one circular iteration completes
            SinglyLinkedListNode currentNode = lastNode;
            StringBuilder stringBuilder = new();

            do
            {
                currentNode = currentNode.NextNode;
                stringBuilder.Append(currentNode.Data + " , ");
            }
            while (currentNode != lastNode);

            return stringBuilder.ToString();
        }
    }
}

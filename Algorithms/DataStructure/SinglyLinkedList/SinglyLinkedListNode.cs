namespace Algorithms.DataStructure.SinglyLinkedList
{
    internal class SinglyLinkedListNode
    {
        //ACTUAL DATA
        public int Data;

        //NEXT NODE OF THE COLLECTION
        //ACTUAL IMPLEMENTATION SHOULD HAVE POINTER TO MEMORY and THAT WOULD REDUCE THE SIZE OF OBJECT
        //.NET C# CLASS VARIABLE ONLY REFFERNCE TO THE OBJECT
        public SinglyLinkedListNode NextNode;

        public SinglyLinkedListNode(int data)
        {
            Data = data;
        }
    }
}
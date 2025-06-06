﻿using Algorithms.DataStructure;
using Algorithms.DataStructure.CircularSinglyLinkedList;
using Algorithms.DataStructure.DoublyLinkedList;
using Algorithms.DataStructure.SinglyLinkedList;
using Algorithms.DataStructure.SinglyLinkedListStacked;
using Algorithms.Extensions;
using Algorithms.SearchAlgorithms;
using Algorithms.Sorting;
using Algorithms.TreeDataStructure;
using Algorithms.TreeDataStructure.BTree;

namespace Algorithms
{
    internal class Program
    {
        static void Main()
        {
            //DataStructureTest();
            //SearchTest();
            //SortTest();
            ExtensionsTest();
        }

        private static void SearchTest()
        {
            //LinearSearchNumbers.TestMethod();
            //BinarySearchNumbers.TestMethod();
            //BinarySearchRecursiveNumbers.TestMethod();
        }

        private static void SortTest()
        {
            //SortTesting.TestMethod();
            //MergeSortNumbers.TestMethod();
            //SelectionSortNumbers.TestMethod();
            //BubbleSortNumbers.TestMethod();
            //InsertionSortNumbers.TestMethod();
        }

        private static void DataStructureTest()
        {
            //SinglyLinkedListNumberTEST.TestMethod();
            //DoubleLinkedListNumberTEST.TestMethod();
            //CircularSinglyLinkedListNumberTEST.TestMethod();
            //StackedSinglyLinkedListNumberTEST.TestMethod();
            //BinaryTreeNumberTest.TestMethod();
            BTreeNumberTEST.TestMethod();
        }

        private static void ExtensionsTest()
        {
            //SerializationExtension.TestMethod();
            SerializationExtension2.TestMethod();
        }
    }
}
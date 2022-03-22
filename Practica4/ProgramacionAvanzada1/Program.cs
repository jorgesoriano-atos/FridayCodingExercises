using ProgramacionAvanzada1.Excercises;
using System;
using System.Collections.Generic;

namespace ProgramacionAvanzada1
{
    internal class Program
    {
        public delegate void DoList(int[] intArray);
        public delegate void SortList(List<string> wordList);
        static void Main(string[] args)
        {

            int[] intArray = new int[15] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            List<string> wordList = new List<string>() { "Amerigo", "Vespucci", "was", "an", "Italian", "merchant", "explorer", "and", "navigator", "from", "the", "Republic", "of", "Florence", "from", "whose", "name", "the", "term", "America", "is", "derived" };
            
            ListNumbers listNumbers = new ListNumbers();
            ListSorting sorting = new ListSorting();

            DoList listEvenNumbers1 = new DoList(listNumbers.ListEvens);
            DoList listEvenNumbers2 = new DoList(listNumbers.ListEvens);

            SortList sl1 = new SortList(sorting.SortAscending);
            SortList sl2 = new SortList(sorting.SortDescending);

            //1. list even numbers
            Console.WriteLine("\n\n\t ---------- 1. List Even Numbers: ----------\n");
            listEvenNumbers1(intArray);

            //2. list odd numbers
            Console.WriteLine("\n\n\t ---------- 2. List Odd Numbers: ----------\n");
            listEvenNumbers2(intArray);

            //3. Ascending Sorted List
            Console.WriteLine("\n\n\t ---------- 3. Ascending Sorted List: ----------\n");
            sl1(wordList);

            //4. Descending Sorted List
            Console.WriteLine("\n\n\t ---------- 4. Descending Sorted List: ----------\n");
            sl2(wordList);
        }
    }
}

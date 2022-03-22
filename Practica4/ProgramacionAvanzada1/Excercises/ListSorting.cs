using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionAvanzada1.Excercises
{
    internal class ListSorting
    {

        public ListSorting() { }

        public void SortAscending(List<string> wordList)
        {
            wordList.Sort();
            Console.WriteLine(String.Join(",", wordList));
        }

        public void SortDescending(List<string> wordList)
        {
            wordList.Sort();
            wordList.Reverse();
            Console.WriteLine(String.Join(",", wordList));
        }
    }
}

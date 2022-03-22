using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionAvanzada1.Excercises
{
    internal class ListNumbers
    {
        

        public ListNumbers() { }

        public void ListEvens(int[] intArray)
        {
            foreach (int i in intArray)
            {
                Console.WriteLine(i % 2 == 0 ? "" : $"{i} ");
            }
        }
        public void ListOdds(int[] intArray) 
        {
            foreach (int i in intArray)
            {
                Console.WriteLine(i % 2 == 0 ? $"{i} " : "");
            }
        }
    }
}

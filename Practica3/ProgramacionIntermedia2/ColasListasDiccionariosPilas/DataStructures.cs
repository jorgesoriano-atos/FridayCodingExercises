using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionIntermedia2.ColasListasDiccionariosPilas
{
    public static class DataStructures
    {
        public static int[] ReverseWithQueue(int[] integerArray)
        {
            int length = integerArray.Length;
            int[] reversedArray = new int[length];
            Queue<int> myQueue = new Queue<int>();

            foreach (int element in integerArray) { 
                myQueue.Enqueue(element);
            }

            for (int i = (length - 1); i >= 0; i--)
            {
                reversedArray[i] = myQueue.Dequeue();
            }
            
            return reversedArray;
        }

        public static int[] ReverseWithList(int[] integerArray)
        {
            int length = integerArray.Length;
            List<int> myList = new List<int>();

            foreach (int element in integerArray)
            {
                myList.Add(element);
            }

            myList.Reverse();

            return myList.ToArray();
        }

        public static int[] ReverseWithDictionary(int[] integerArray)
        {
            int length = integerArray.Length;
            int[] reversedArray = new int[length];
            Dictionary<int, int> myDict = new Dictionary<int, int>();

            for (int i = 0; i < length; i++)
            {
                myDict.Add(i, integerArray[i]);
            }

            foreach (var keyvalue in myDict)
            {
                reversedArray[length - 1] = keyvalue.Value;
                length--;
            }

            return reversedArray;
        }

        public static bool IsPalindrome(char[] charArray)
        {
            Stack<char> myStack = new Stack<char>();
            int length = charArray.Length;

            //Even word lenght
            if(length % 2 == 0)
            {

                for(int i = 0; i < (length / 2); i++)
                {
                    myStack.Push(charArray[i]);
                }

                for (int i = (length / 2); i < length; i++)
                {
                    if (charArray[i] != myStack.Pop())
                        return false;
                }

            } 
            //Odd word lenght
            else
            {
                
                for (int i = 0; i < (length - 1) / 2; i++)
                {
                    myStack.Push(charArray[i]);
                }

                for (int i = ((length - 1) / 2) + 1; i < length; i++)
                {
                    if (charArray[i] != myStack.Pop())
                        return false;
                }
            }
            return true;
        }
    }
}

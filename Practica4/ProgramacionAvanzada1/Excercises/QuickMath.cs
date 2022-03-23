using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionAvanzada1.Excercises
{
    internal class QuickMath
    {
        public QuickMath() { }

        public bool IsDivisibleByThree(int value) => value % 3 == 0;

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

        public double GetMax(int[] intArray) => (double)intArray.Max();

        public double GetMin(int[] intArray) => (double)intArray.Min();

        public double GetAvg(int[] intArray) => (double)intArray.Average();

        public double GetRMS(int[] intArray)
        {
            double result = 0;
            Array.ForEach(intArray, value => result += Math.Pow((double)value, 2));

            return result;
        }

    }
}

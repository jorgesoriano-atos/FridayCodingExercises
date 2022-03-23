using ProgramacionAvanzada1.Excercises;
using ProgramacionAvanzada1.Excercises.Variance;
using System;
using System.Collections.Generic;

namespace ProgramacionAvanzada1
{
    internal class Program
    {
        //Delegate Headers
        public delegate void DoList(int[] intArray);
        public delegate void SortList(List<string> wordList);
        public delegate bool DivisibleByThree(int value);
        public delegate double ArrayMath(int[] intArray);
        public delegate void TextUtils(string text);
        static void Main(string[] args)
        {
            //Variables needed
            int[] intArray = new int[15] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            List<string> wordList = new List<string>() { "Amerigo", "Vespucci", "was", "an", "Italian", "merchant", "explorer", "and", "navigator", "from", "the", "Republic", "of", "Florence", "from", "whose", "name", "the", "term", "America", "is", "derived" };
            int testInteger = 99;
            string testString = "haBiBi";

            //Objects needed
            QuickMath quickMath = new QuickMath();
            ListSorting sorting = new ListSorting();
            TextSpitter textSpitter = new TextSpitter();

            //Delegates needed
            DoList dl1 = new DoList(quickMath.ListEvens);
            DoList dl2 = new DoList(quickMath.ListEvens);

            SortList sl1 = new SortList(sorting.SortAscending);
            SortList sl2 = new SortList(sorting.SortDescending);

            DivisibleByThree qm3 = new DivisibleByThree(quickMath.IsDivisibleByThree);

            TextUtils tu1 = new TextUtils(textSpitter.SpitText);

            ArrayMath am1 = new ArrayMath(quickMath.GetMax);
            ArrayMath am2 = new ArrayMath(quickMath.GetMin);
            ArrayMath am3 = new ArrayMath(quickMath.GetAvg);
            ArrayMath am4 = new ArrayMath(quickMath.GetRMS);



            //1. list even numbers
            Console.WriteLine("\n\n\t ---------- 1. List Even Numbers: ----------\n");
            dl1(intArray);

            //2. list odd numbers
            Console.WriteLine("\n\n\t ---------- 2. List Odd Numbers: ----------\n");
            dl2(intArray);

            //3. Ascending Sorted List
            Console.WriteLine("\n\n\t ---------- 3. Ascending Sorted List: ----------\n");
            sl1(wordList);

            //4. Descending Sorted List
            Console.WriteLine("\n\n\t ---------- 4. Descending Sorted List: ----------\n");
            sl2(wordList);

            //5. Is Multiple of 3?
            Console.WriteLine("\n\n\t ---------- 5. Is Multiple of 3?: ----------\n");
            Console.WriteLine($"{testInteger} - {qm3(testInteger)}"); ;

            //6. Write Text in Console
            Console.WriteLine("\n\n\t ---------- 6. Write Text in Console: ----------\n");
            tu1(testString);

            //7. Get Maximum
            Console.WriteLine("\n\n\t ---------- 7. Get Maximum: ----------\n");
            Console.WriteLine(am1(intArray));

            //8. Get Minimum
            Console.WriteLine("\n\n\t ---------- 8. Get Minimum: ----------\n");
            Console.WriteLine(am2(intArray));

            //9. Get Average
            Console.WriteLine("\n\n\t ---------- 9. Get Average: ----------\n");
            Console.WriteLine(am3(intArray));

            //10. Get RMS
            Console.WriteLine("\n\n\t ---------- 10. Get RMS: ----------\n");
            Console.WriteLine(am4(intArray));

            //11. Variance
            Console.WriteLine("\n\n\t ---------- 11. Variance: ----------\n");

                //Covariance
            ICovariant<Worker> covariance = new Covariant<Teacher>();

                //Contravariance
            IContravariant<Student> contravariance = new Contravariant<Person>();

                //Invariance
            IInvariant<Worker> invariance = new Invariant<Worker>();

            //12. Generic Delegates
            Console.WriteLine("\n\n\t ---------- 12. Generic Delegates: ----------\n");
            Console.WriteLine("ACTION");

            Action<string> toUpperAction = s => Console.WriteLine($"{s} to upper: {s.ToUpper()}");
            toUpperAction(testString);

            Console.WriteLine("FUNC");

            Func<int, int> getSquaredFunc = x => x * x;
            getSquaredFunc(testInteger);
            Console.WriteLine($"{testInteger} squared is {getSquaredFunc(testInteger)}");

            Console.WriteLine("PREDICATE");

            Predicate<int> isNegatvePredicate = x => x < 0;
            Console.WriteLine($"Is {testInteger} negative? {isNegatvePredicate(testInteger)}");

        }
    }
}

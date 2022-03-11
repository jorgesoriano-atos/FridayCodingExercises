using ProgramacionIntermedia2.ColasListasDiccionariosPilas;
using ProgramacionIntermedia2.OperadorImplicito;
using ProgramacionIntermedia2.TiposPorValorYReferencia;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProgramacionIntermedia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
                TUPLAS

            */
            Console.WriteLine("//////////////////////////////// T U P L A S ////////////////////////////////\n\n\n");
            var TupleList1 = new List<Tuple<int, int>> {
                Tuple.Create(1, 1),
                Tuple.Create(1, 4),
                Tuple.Create(5, 21),
                Tuple.Create(14, 1),
                Tuple.Create(33, 56),
            };

            var TupleList2 = new List<(string Name, string Kind, int Replicas, bool Run)>
            {
                ("Soros", "Squishy", 2, true),
                ("Prostagma", "Eerie", 0, false),
                ("Esternos", "Whiney", 2999, true),
                ("Caecilius", "Jumpy", 10, true)
            };

            foreach (Tuple<int, int> tuple in TupleList1)
            {
                Console.WriteLine(tuple);
            }

            Console.WriteLine("\n------------------------------------------------------------------------\n");

            foreach ((string, string, int, bool) tuple in TupleList2)
            {
                Console.WriteLine(tuple);
            }

            /*

            OPERADOR IMPLICITO

            */
            Console.WriteLine("\n\n\n//////////// O P E R A D O R   I M P L I C I T O //////////////\n\n\n");
            WaterBender Katara = new WaterBender("Katara", "Female", 14, true);
            AirBender Tenzin = new AirBender("Tenzin", "Male", 51, "Oogi");

            BenderTester.DoAirBenderThings(Tenzin);
            BenderTester.DoWaterBenderThings(Katara);
            Console.WriteLine("\n");
            BenderTester.DoAirBenderThings(Katara);
            BenderTester.DoWaterBenderThings(Tenzin);

            /*
             
            TIPOS POR VALOR Y REFERENCIA

            */
            Console.WriteLine("\n\n\n///// T I P O S  P O R  V A L O R   Y  R E F E R E N C I A /////\n\n\n");

            CarClass[] CarArray1 = new CarClass[1000000];
            CarStruct[] CarArray2 = new CarStruct[1000000];

            Stopwatch sw = new Stopwatch();
            TimeSpan ts1 = new TimeSpan();
            TimeSpan ts2 = new TimeSpan();

            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                CarArray1[i] = new CarClass(20000, "blue", 4);
            }
            sw.Stop();
            ts1 = sw.Elapsed;

            sw.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                CarArray2[i] = new CarStruct(17500, "gray", 5);
            }
            sw.Stop();
            ts2 = sw.Elapsed;

            Console.WriteLine($"Tiempo de instanciacion para los objetos: {ts1.ToString()} ms" +
                $"\nTiempo de instanciacion para los structs: {ts2.ToString()} ms");

            /*

            QUEUE, LIST Y DICTIONARY

            */
            Console.WriteLine("\n\n\n///// Q U E U E,  L I S T,  D I C T I O N A R Y /////\n\n\n");

            int[] myArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            TimeSpan ts3 = new TimeSpan();
            TimeSpan ts4 = new TimeSpan();
            TimeSpan ts5 = new TimeSpan();

            sw.Restart();
            DataStructures.ReverseWithQueue(myArray);
            sw.Stop();
            ts3 = sw.Elapsed;

            sw.Restart();
            DataStructures.ReverseWithList(myArray);
            sw.Stop();
            ts4 = sw.Elapsed;

            sw.Restart();
            DataStructures.ReverseWithDictionary(myArray);
            sw.Stop();
            ts5 = sw.Elapsed;

            Console.WriteLine($"Time elapsed for:\n" +
                $"\t Queue: {ts3.ToString()}\n" +
                $"\t List: {ts4.ToString()}\n" +
                $"\t Dict: {ts5.ToString()}\n");

            /*

            STACK

            */
            Console.WriteLine("\n\n\n///////////////////////// S T A C K /////////////////////////\n\n\n");

            char[] myCharArray1 = { 'a', 'n', 'n', 'a'};
            char[] myCharArray2 = { 'a', 'n', 'a', 'n', 'a' };
            char[] myCharArray3 = { 'a', 'n', 'y', 'a' };
            char[] myCharArray4 = { 'c', 'y', 'k', 'a', 'a' };

            Console.WriteLine($"Is char array 1 palindrome? {DataStructures.IsPalindrome(myCharArray1).ToString()}" +
                $"\nIs char array 2 palindrome? {DataStructures.IsPalindrome(myCharArray2).ToString()}" +
                $"\nIs char array 3 palindrome? {DataStructures.IsPalindrome(myCharArray3).ToString()}" +
                $"\nIs char array 4 palindrome? {DataStructures.IsPalindrome(myCharArray4).ToString()}");
        }
    }
}

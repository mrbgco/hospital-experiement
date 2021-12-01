using System;
using System.Collections.Generic;
using System.Linq;

namespace hospital_experiement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simulate 10 years
            var numberOfPatients = new List<KeyValuePair<string, int>>();
            for (int i = 1; i <= 365; i++)
            {
                numberOfPatients.Add(new KeyValuePair<string, int>($"Day{i}", Poisson.GetPoisson(300)));
            }

            Print(numberOfPatients);
        }

        public static void Print(List<KeyValuePair<string, int>> list)
        {

            // get the max length of all the words so we can align
            var max = list.Max(x => x.Key.Length);

            foreach (var item in list)
            {
                // right align using PadLeft and max length
                Console.Write(item.Key.PadLeft(max));

                Console.Write(" ");


                // Write the bars
                for (var i = 0; i < item.Value; i++)
                    Console.Write("*");

                // change back
                Console.BackgroundColor = ConsoleColor.Black;

                Console.Write(" ");
                // this creates the new line
                Console.WriteLine(item.Value);
            }
        }
    }
}
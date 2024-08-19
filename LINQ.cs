using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace C__Learn
{
    public class LINQ
    {
        public static void Main(string[] args)
        {
            // Parts of a LINQ query
            // Data Source

            int[] numbers = { 24, 22, 55, 44, 90, 68 };

            // Query creation 

            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            // Query Execution

            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }

            // Immediate query execution 

            var evenNumQuery =
                from num in numbers
                where num % 2 == 0
                select num;

            int evenNumCount = evenNumQuery.Count();

            Console.WriteLine(evenNumCount);

            // For immediate execution We can force any query to execute
            // immediately using the Enumerable.ToList or Enumerable.ToArray methods.
            // Immediate execution provides reuse of query results, not query declaration.
            // The results are retrieved once, then stored for future use.

            List<int> numQuery2 =
                (from num in numbers
                    where (num % 2) == 0
                    select num).ToList();

            // or like this:
            // numQuery3 is still an int[]

            var numQuery3 =
                (from num in numbers
                 where (num % 2) == 0
                 select num).ToArray();

            // Deferred Query Execution

            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }

            int[] scores = { 56, 90, 100, 134, 23, 444 };

            IEnumerable<int> highScoresQuery =
                from score in scores
                where score > 80
                orderby score descending
                select score;

            // retrieve data and transform into a new type of object.

            IEnumerable<string> highScoresQuery2 =
                from score in scores
                where score > 80
                orderby score descending
                select $"The score is {score}";
        }
    }
}

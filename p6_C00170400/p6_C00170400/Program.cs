// Brian Hodge
// C00170400
// CMPS 358
// Project#6

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace p6_C00170400
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo wordsList1 = new FileInfo("C:\\Users\\mhhod\\source\\repos\\358Project6\\p6_C00170400\\p6_C00170400\\words1.txt"); // Excercise 1
            FileInfo wordsList2 = new FileInfo("C:\\Users\\mhhod\\source\\repos\\358Project6\\p6_C00170400\\p6_C00170400\\words2.txt");
            StreamReader readList1 = wordsList1.OpenText();
            StreamReader readList2 = wordsList2.OpenText();
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
           
            string nextLine = readList1.ReadLine();
            string nextLine2 = readList2.ReadLine();
            int count = 0;
            int count2 = 0;
            while (nextLine != null)
            {
                count++;
                list1.Add(nextLine);
                nextLine = readList1.ReadLine();
            }
            while (nextLine2 != null)
            {
                count2++;
                list2.Add(nextLine2);
                nextLine2 = readList2.ReadLine();
            }
            readList1.Close();
            readList2.Close();
            Console.WriteLine($"Number of words in list1: " + count);
            Console.WriteLine($"Number of words in list2: " + count2);
            Console.WriteLine();
            
            try                 // Exercise 2
            {
                var value =
                    from x in list2
                    where (!string.IsNullOrEmpty(x)) && (x.Contains("am"))
                    select x;
                Console.WriteLine("Result set of words containing 'am' in list2: ");    
                foreach(var e in value)
                    Console.WriteLine(e);
                Console.ReadLine();
            }
            catch(Exception)
            {
                Console.WriteLine("End of result set of words containing 'am' in list2");
                Console.WriteLine();
            }
            

            try                         // Excercise 3
            {
                var charLength =
                    from n in list1
                    where (!string.IsNullOrEmpty(n)) && (n.Length == 8) || (n.Length == 9)
                    select n;

                Console.WriteLine("Result set of words in list1 of length 8 or 9 characters");
                foreach(var s in charLength)
                    Console.WriteLine(s);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("End of result set of words in list1 of length 8 or 9 characters\n");
            }
           
/*
            try                         // Exercise 4
            {
                List<string> resultSet = new List<string>();
                
                var intermediateQueryResults =
                from x in list2
                where x.Length >= 0
                orderby x.Length
                select x;

                List<string> intermediateSet = intermediateQueryResults.ToList<string>();
                int minLength = intermediateSet.First().Length;
                int maxLength = intermediateSet.Last().Length;

                for (int i = 0; i <= list2.Count; i++)
                {
                    var temp = 
                    from n in list2
                    where (n.Length == minLength) || (n.Length == maxLength)
                    select n;

                    resultSet.Add(temp.ToString());
                }


                Console.WriteLine("Result set of shortest and longest words in list2: ");
                foreach(var s in resultSet)
                {
                    Console.WriteLine(s);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("End of result set of shortest and longest words in list2");
            }
*/
            try 
            {
                
                Console.WriteLine();
                IEnumerable<string> intermediateResult =
                    from x in list2
                    //where x.Length > 0
                    orderby x.Length
                    select x;

                Console.WriteLine("Result set sorted by length: ");
                foreach(var str in intermediateResult)
                    Console.WriteLine(str);
            
            }
            catch(Exception)
            {
                Console.WriteLine("End of result set sorted by length: ");
            }
            
        }
    }
}

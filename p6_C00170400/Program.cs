// Brian Hodge
// C00170400
// CMPS 358
// Project#6

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace p6_C00170400
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo wordsList1 = new FileInfo("words1.txt"); // Excercise 1
            FileInfo wordsList2 = new FileInfo("words2.txt");
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
                    where (x.Contains("am"))
                    orderby x
                    select x;
                Console.WriteLine("Result set of words containing 'am' in list2: ");    
                foreach(var e in value)
                    Console.Write(e + $" ");
                Console.WriteLine();
            }
            catch(Exception)
            {
                Console.WriteLine("End of result set of words containing 'am' in list2");
                Console.WriteLine();
            }
            Console.WriteLine();
            

            try                         // Excercise 3
            {
                var charLength =
                    from n in list1
                    where (!string.IsNullOrEmpty(n)) && (n.Length == 8) || (n.Length == 9)
                    orderby n
                    select n;

                Console.WriteLine("Result set of words in list1 of length 8 or 9 characters: ");
                foreach(var s in charLength)
                    Console.Write(s + $" ");
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("End of result set of words in list1 of length 8 or 9 characters\n");
            }
           

            try                         // Exercise 4
            {
                
                Console.WriteLine();
                IEnumerable<string> intermediateResult =
                    from x in list2
                    orderby x.Length
                    select x;


                IEnumerable<string> intermediateresult2 =
                    from y in list1
                    orderby y.Length
                    select y;
                
                Console.WriteLine("Shortest and longest words in list2: ");
                Console.Write(intermediateResult.First() + $" " + intermediateResult.Last() + " " + intermediateresult2.First() + " " + intermediateresult2.Last() + "\n");
            
            
            }
            catch(Exception)
            {
                Console.WriteLine("End of shortest and longest words in list 2: ");
            }

            Console.WriteLine();

            try                         // Exercise 5
            {
                IEnumerable<string> uniqueWords =
                    list1.Union(list2);
                
                
                int uniqueCount1 = 0;
                foreach(string u in uniqueWords)
                    uniqueCount1++;    
                    Console.Write($"Unique words in both lists: " + uniqueCount1 + "\n");
                    
            }
            catch(Exception)
            {
                Console.WriteLine("End of unique words in both lists");
            }

            Console.WriteLine();

            try                     // Exercise 6
            {
                IEnumerable<string> commonWords = 
                    list1.Intersect(list2);
                
                Console.WriteLine("Words common to both lists: ");
                foreach(string common in commonWords)
                    Console.Write(common + $" ");
                Console.WriteLine();
            }
            catch(Exception)
            {
                Console.WriteLine("End of words common to both lists");
            }
            
            Console.WriteLine();

            try                     // Exercise 7
            {
                IEnumerable<string> list1OnlyWords = 
                    list1.Except(list2);

                Console.WriteLine("Words appearing only in list 1: ");
                foreach(string list1Only in list1OnlyWords)
                    Console.Write(list1Only + $" ");
            }
            catch(Exception)
            {
                Console.WriteLine("End of list of words apppearing only in list 1");
            }

            Console.WriteLine();

            try                     // Exercise 8
            {
                Console.WriteLine();
                var wordsContaingY =
                    from j in list1
                    let noIorNOi = Regex.Replace(j, "[Ii]", "y")
                    where noIorNOi.Contains("y")
                    select noIorNOi;

                Console.WriteLine("Words from list1 now conataining 'y': ");
                foreach(var k in wordsContaingY)
                    Console.Write(k + $" ");
                Console.WriteLine();
            }
            catch(Exception)
            {
                Console.WriteLine("End of result set of words from list1 containing 'y' ");
            }
            
            Console.WriteLine();

            try                     // Exercise 9
            {
                var groupJoin =
                    from a in list1
                    from b in list2
                    where (a.Length == 12) && (b.Length == 12)
                    select a + " : " + b;
                    
                Console.WriteLine("Group Join of words from both lists with length of 12: ");
                foreach(var gj in groupJoin)
                    Console.WriteLine(gj);
                Console.WriteLine();
            }
            catch(Exception)
            {
                Console.WriteLine("End of result set containing all words in both lists with a length of 12");
            }

            Console.WriteLine();

            try                     // Exercise 10
            {
                var zipped = 
                    list1.Zip(list2, (x, y) =>
                    {
                        if (x.Length == 3 && y.Length == 3)
                            return (x + " : " + y);
                        else if (x.Length != 3 && y.Length != 3)
                            return null;
                        return null;
                    });

                Console.WriteLine("Zip Join of words in both lists with length of 3: ");
                foreach(var z in zipped)
                {
                    if (z != null)
                        Console.WriteLine(z);
                }
                Console.WriteLine();
            }
            catch(Exception)
            {
                Console.WriteLine("End of Zip Join of words in both lists with length of 3");
            }
        }
    }
}
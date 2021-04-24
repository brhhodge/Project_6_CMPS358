# Project6_358

CMPS 358 Spring 2021 Programming Project #6

Project Overview:
  A single C# project consisting of ten exercises, nine of which will require LINQ queries and / or extensions.
  Each exercise will be worth 20 points

Project Description
 1. Create a C# console project in Visual Studio Code and name it “p6_your-ulid”. Then,  
  (a) download the files “words1.txt” and “words2.txt” from Moodle and save them in the main directory
    of the project.
  (b) Write the code to read both files, storing each in a separate System.Collections.Generic.List<String>
    lists. For the remainder of this document, the List containing the words read from “words1.txt”
    will be referred to as “list 1” and the List containing the words read from “words2.txt” will be
    referred to as “list 2”.
  (c) Display the number of words that are now stored in both list 1 and list 2.
2.
  Use LINQ to create a result set of all words in list 2 that contain “am”, then display the words in the
  result.
3. 
  Use LINQ to create a result set of all words in list 1 that are 8 or 9 characters long, then display the
  words in the result.
4. 
  Use LINQ to create a result set containing the shortest and longest words in list 2, then display the words
  in the fifth list. (Tip: One way to accomplish this is to use intermediate LINQ results. For instance,
  use LINQ to create result set that is sorted on length. Then, find the length of the shortest word (the
  first word) and the length of the longest word (the last word). Finally, use LINQ to create a result of all
  the words that match one or the other lengths.)
5.
  Use LINQ to find all the words that are unique in both lists. I. e. create a result that contains only one
  copy of each word. Then, display the words in the result.

6. 
  Use LINQ to create a result set that contains the words common to both lists, then display the words in
  the result.
7. 
  Use LINQ to create a result set that contains the words that appear only list 1, then display the words in
  the result.
8. 
  Use LINQ to create a result set that contains all the words in list 1 that contain the letter ‘y’. The catch
  is that all letters ‘I’ or ‘i’ in list 1 have to be converted to ‘y’ before creating the previous result. (Tip:
  One way to accomplish this is to use let with Regex.Replace to find and replace all the ‘I’ and ‘i’ letters,
  then use that intermediate result with find all the words that contain ‘y’.) Then display the words in the
  result.
9. 
  Use LINQ group join to create a result set that contains all the words in both lists that have a length of
  12. (Tip: Place the where for length between the from and the join.) Then, display the result.
10. 
  Use LINQ zip to create a result set that contains a zip join of all words in both lists that have a
  length of 3. (Tip: Consider using an if-else in a lambda expression that returns the combination of the
  words or a null. The null values can be filtered out when displaying the results.) Then display the
  result.

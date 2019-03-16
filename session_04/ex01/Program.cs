using System;
using System.IO;
using System.Linq;

namespace session_04
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                using (var sr = new StreamReader("../sometext.txt"))
                {

                    string line;
                    int lineNo = 0;
                    string longestWord = "";
                    System.Console.WriteLine("Working?");
                    while ((line = sr.ReadLine()) != null)
                    {
                        lineNo++;
                        int countSpaces = line.Count(Char.IsWhiteSpace);
                        string[] lineWords = line.Split();
                        foreach (string w in lineWords)
                        {
                            if (w.Length > longestWord.Length)
                            {
                                longestWord = w;
                            }
                        }

                        int countWords = lineWords.Length;
                        System.Console.WriteLine($"There are {countSpaces} Spaces in the {lineNo} line and {countWords}");
                        System.Console.WriteLine($"The longest word in this line is : {longestWord}");
                    }

                }

            }
            catch (Exception e)
            {
                e.GetBaseException();
            }
        }
    }
}

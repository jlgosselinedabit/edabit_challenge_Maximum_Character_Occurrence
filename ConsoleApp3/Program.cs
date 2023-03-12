using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        public static string MaxOccur(string text)
        {
            text = String.Concat(text.OrderBy(ch => ch));

            int counter = 1;
            int charCount = 0;
            char c = '0';
            string finalResult = "";
            int flag = 0;
            int firstTime = 1;

            
            for (int i = 0; i < text.Length-1; i++)
            {
                if (text[i] == text[i + 1])
                {
                    counter += 1;
                    flag = 1;
                }
                else
                {
                    c = text[i];
                    string converted = Char.ToString(c);

                    if (counter > charCount)
                    {
                        charCount = counter;
                        finalResult = converted;
                    }
                    else if(counter == charCount)
                    {
                        if(firstTime == 1)
                        {
                            finalResult = converted;
                            firstTime += 1;
                        }
                        else
                        {
                            finalResult += ", ";
                            finalResult += converted;
                        }  
                    }
                    counter = 1;
                }
            }

            if(flag == 0)
            {
                return "No Repetition";
            }
            else
            {
                return finalResult;
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine(MaxOccur("system admin"));
            // returns "m, s"

            /*
            Console.WriteLine(MaxOccur("Edabit"));
            // returns "No Repetition"
            */

            /*
            Console.WriteLine(MaxOccur("Computer Science"));
            // returns 'e'
            */

            /*
            Console.WriteLine(MaxOccur("the quick brown fox jumps over the lazy dog"));
            // --->          abcdeeefghhijklmnoooopqrrsttuuvwxyz (with 8 whites spaces)
            // returns whitespace
            */

            /*
            Console.WriteLine(MaxOccur("SHdRVBAHskaBJSyHfD"));
            //expected: ABBDHHHJRSSVadfksy
            // returns H
            */


            /*
             * Given a string text. Write a function that returns the character with the highest frequency. 
             * If more than 1 character has the same highest frequency, return all those characters as a 
             * comma separated string. 
             * If there is no repetition in characters, return "No Repetition".
            */

        }
    }
}

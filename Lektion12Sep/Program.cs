using System;
using System.Linq;
using System.Collections;

namespace Lektion12sep
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            String str = "AABBCANCDE";
            String newStr = "";
            for (int i = 0; i < str.length(); i++)
            {
                if (!newStr.contains(str.charAt(i) + ""))
                    newStr = newStr + str.charAt(i);
            }
            System.out.println(newStr);
            */

            // Take Lenght of original list - Define Duplicates? - remove duplicates, compare new lenght to original lenght if equal is false Print result

            // Cannot have Duplicates in Hashset - Removes all Duplicates
            string textWithDuplicates = "aaabbcccgg";

                Console.WriteLine(textWithDuplicates.Count());
                var letters = new HashSet<char>(textWithDuplicates);
                //Console.WriteLine(letters.Count());

                foreach (char c in letters) Console.Write(c);
              
            

        }
    }
}
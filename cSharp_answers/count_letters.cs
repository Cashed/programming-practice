using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Letters
    {
      // public static void Main(string[] args)
      // {
      //   string str = "aabbabaccac";
      //
      //   Dictionary<char, int> returned = CountLetters(str);
      //
      //   foreach (KeyValuePair<char, int> kvp in returned) {
      //     Console.WriteLine("Letter = {0}, Count = {1}", kvp.Key, kvp.Value);
      //   }
      //
      // }
      public static Dictionary<char, int> CountLetters(string str) {
        Dictionary<char, int> returnObj =  new Dictionary<char, int>();

         if (str.Length == 0) {
           return returnObj;
         }

         for (int i = 0; i < str.Length; i++) {
           if (!returnObj.ContainsKey(str[i])) {
             returnObj.Add(str[i], 1);
           }
           else {
             returnObj[str[i]]++;
           }
         }
         return returnObj;
      }
    }
}

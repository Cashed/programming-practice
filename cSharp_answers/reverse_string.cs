using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class reverse
    {
      public static void Main(string[] args)
      {
        string str = "happyhappy";
        Console.WriteLine(ReverseString(str));
      }
      public static string ReverseString(string str) {
        if (str.Length == 0) {
          return str;
        }

        string reversed = "";
        for (int i = str.Length - 1; i >= 0; i--) {
          reversed += str[i];
        }

        return reversed;
      }
    }
}

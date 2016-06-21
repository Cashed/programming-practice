using System;


namespace ConsoleApplication
{
    public class UniqueString
    {
        // public static void Main(string[] args)
        // {
        //
        //   string str = "truck";
        //   string repeated = "garage";
        //
        //   Console.WriteLine(Unique(str));
        //
        //
        // }
        public static bool Unique(string str) {
          // construct array that can hold values for all chars
          bool[] uniqueChars = new bool[256];

          // check if any duplicates from length
          if (str.Length > 256) {
            return false;
          }

          // iterate through string, check if char has already been stored as present (true)
          // if so, return false, or store as 'true' in array
          for (int i = 0; i < str.Length; i++) {
            if (uniqueChars[str[i]]) {
              return false;
            }
            else {
              uniqueChars[str[i]] = true;
            }
          }
          return true;
        }
    }
}

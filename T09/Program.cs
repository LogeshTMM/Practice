// PRINT A DIAMOND
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the number of rows for a diamond do you want to see");
      int.TryParse (Console.ReadLine (), out int a);
      if (a == 0) Console.WriteLine ("Invaild Input");
      else {
         char b = '*'; char c = ' '; int[] s = { };
         for (int j = 1; j <= a; j++) { // separate a hard number from a given input
            if (j % 2 != 0) {
               s = s.Append (j).ToArray ();
            }
         }
         //Console.WriteLine (s.Length);
         int len = s.Length - 1;
         foreach (int j in s) {
            var str1 = new string (c, len); // string (c, len) len denotes how many times repeat c
            Console.Write (str1); len--;
            var str = new string (b, j);
            Console.WriteLine (str);
         }
         Array.Reverse (s);
         s = s.Skip (1).ToArray ();
         //List<int> numberList = s.ToList ();
         //numberList.RemoveAt (0);
         int len1 = 1;
         foreach (int j in s) {
            if (j != a) {
               var str1 = new string (c, len1);
               Console.Write (str1); len1++;
               var str = new string (b, j);
               Console.WriteLine (str);
            }
         }
         //foreach (int j in s) Console.Write (j);
      }
   }
}
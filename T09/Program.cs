// PRINT A DIAMOND
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the number of rows for a diamond do you want to see");
      int a = Convert.ToInt32 (Console.ReadLine ());
      char b = '*'; char c = ' '; int[] s = { };
      for (int j = 1; j <= a; j++) {
         if (j % 2 != 0) {
            s = s.Append (j).ToArray ();
         }
      }
      //Console.WriteLine (s.Length);
      int len = s.Length - 1;
      foreach (int j in s) {
         var str1 = new string (c, len);
         Console.Write (str1); len--;
         var str = new string (b, j);
         Console.WriteLine (str);
      }
      Array.Reverse (s);
      List<int> numberList = s.ToList ();
      numberList.RemoveAt (0);
      //foreach (int j in s) Console.Write (j);
      int len1 = 1;
      foreach (int j in numberList) {
         if (j != a) {
            var str1 = new string (c, len1);
            Console.Write (str1); len1++;
            var str = new string (b, j);
            Console.WriteLine (str);
         }
      }
   }
}
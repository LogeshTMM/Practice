// PRINT A DIAMOND
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the number of rows for a diamond do you want to see");
      int.TryParse (Console.ReadLine (), out int input);
      if (input == 0 || input < 5) {
         Console.WriteLine ("Invaild Input");
         return;
      } else {
         char star = '*'; char space = ' '; int[] noofstars = Array.Empty<int> ();
         for (int j = 1; j <= input; j++) {
            if (j % 2 != 0) {
               noofstars = noofstars.Append (j).ToArray ();
            }
         }
         int repeat = noofstars.Length - 1;
         foreach (int j in noofstars) {
            var space_str = new string (space, repeat);
            Console.Write (space_str); repeat--;
            var star_str = new string (star, j);
            Console.WriteLine (star_str);
         }
         Array.Reverse (noofstars); int len = 1;
         for (int i = 1; i < noofstars.Length; i++) {
            var item = noofstars[i];
            if (i != 0) {
               var space_str = new string (space, len);
               Console.Write (space_str);
               var star_str = new string (star, item);
               Console.WriteLine (star_str);
               len++;
            }
         }
      }
   }
}
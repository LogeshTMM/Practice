// TO FIND NTH TERM ARMSTRONG NUMBER
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the nth number to find the Armstrong Number");
      int.TryParse (Console.ReadLine (), out int num);
      if (num == 0) {
         Console.WriteLine ("Invalid input");
         return;
      }
      int result = 0, a, count = 0;
      List<int> lists = new (), ntermlist = new ();
      string dString;
      double sum;
      int ArmStrong (int tempNum) {
         for (int i = 0; i >= 0; i++) {
            dString = i.ToString ();
            foreach (char b in dString) {
               a = b - 48;
               sum = Math.Pow (a, dString.Length);
               lists.Add ((int)sum);
            }
            result = lists.Sum ();
            if (i == result) {
               ntermlist.Add (i);
               count++;
               if (count == num) {
                  Console.WriteLine ($"{num} th term of Armstrong Number is {i}");
                  break;
               }
            }
            lists.Clear ();
         }
         return result;
      }
      ArmStrong (num);
   }
}
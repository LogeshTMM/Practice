// TO FIND NTH TERM ARMSTRONG NUMBER
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the nth number to find the Armstrong number");
      if (!uint.TryParse (Console.ReadLine (), out uint input)) {
         Console.WriteLine ("Invalid input");
         return;
      }
      ArmStrong (input);
   }
   static int ArmStrong (uint nthTerm) {
      int count = 0, num = 0;
      while (true) {
         int result = 0;
         foreach (int a in num.ToString ()) result += (int)Math.Pow (a - 48, num.ToString ().Length);
         /* ASCII CODE FOR 1 is 49, assume that subtract a by 48 (a - 48;) to get int value 1.*/
         if (num == result) {
            count++;
            if (count == nthTerm) {
               Console.WriteLine ($"{nthTerm} th term of Armstrong number is {num}");
               break;
            }
         }
         num++;
      }
      return num;
   }
}
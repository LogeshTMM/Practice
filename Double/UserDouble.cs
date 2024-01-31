namespace Udouble;
public class UserDouble {
   public static object Parse (string input) {
      UserDouble @double = new ();
      if (@double.FormatChecker (input)) return Convert.ToDouble (input);
      return $"The input string \"{input}\" was not in a correct format.";
   }

   private bool FormatChecker (string getInput) {
      char[] allChars = { '+', '-', '.', 'e', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
      for (int i = 0; i < getInput.Length; i++) {
         if (!allChars.Contains (getInput[i])) return false;
         // Locating the operators position in the getInput string.
         if (getInput[i] == '+') mPlusIndexList.Add (i);
         else if (getInput[i] == '-') mSubIndexList.Add (i);
         else if (getInput[i] == '.') mDotIndexList.Add (i);
         else if (getInput[i] == 'e') mExpIndexList.Add (i);
         // When operators exceed their limits, the initial breaker is activated.
         if (mPlusIndexList.Count > 2 || mSubIndexList.Count > 2 || mDotIndexList.Count >= 2 || mExpIndexList.Count >= 2)
            return false;
      }
      List<bool> mVerified = new (3);
      // Evaluate the present operators in the getInput string.
      if (mPlusIndexList.Count <= 2 && mPlusIndexList.Count != 0)
         mVerified.Add (PlusSubIndicesCheck (mPlusIndexList, getInput));
      if (mSubIndexList.Count <= 2 && mSubIndexList.Count != 0)
         mVerified.Add (PlusSubIndicesCheck (mSubIndexList, getInput));
      if (mDotIndexList.Count == 1) mVerified.Add (DotIndicesCheck (getInput));
      if (mExpIndexList.Count == 1) mVerified.Add (ExponentIndicesCheck (getInput));
      // Final verification
      if (mVerified.Contains (false) || getInput == "") return false;
      return true;
   }

   // Checking for either plus (or) sub operator in both forward and backward indices if it's
   // present in the checkInput.
   private bool PlusSubIndicesCheck (List<int> ints, string checkInput) {
      bool iCondition_1 = false, iCondition_2 = false;
      char[] chars = { 'e', '.', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
      foreach (int i in ints) {
         if (i != checkInput.Length - 1) {
            if (i == 0 && chars.Contains (checkInput[i + 1])) iCondition_1 = true;
            else if (i != 0 && checkInput[i - 1] == 'e' && mNums.Contains (checkInput[i + 1]))
               iCondition_2 = true;
         }
      }
      if (iCondition_1 | iCondition_2) return true;
      return false;
   }

   // Checking for exponent operator in both forward and backward indices if it's present in the checkInput.
   private bool ExponentIndicesCheck (string checkInput) {
      int expIndex = checkInput.IndexOf ('e');
      char[] expchars = { '+', '-', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
      bool isTrue = true; int count = 0;
      foreach (char c in checkInput[(expIndex + 1)..]) {
         if (!expchars.Contains (c)) return false;
         else if (c == '+' || c == '-') count++;
         if (count >= 2) return false;
      }
      if (expIndex > 0 && mNums.Contains (checkInput[expIndex - 1])) {
         if (checkInput[expIndex + 1] == '+' || checkInput[expIndex + 1] == '-') return true;
         else if (mNums.Contains (checkInput[expIndex + 1])) return true;
      } else if (expIndex != 0 && checkInput[expIndex - 1] == '.' && isTrue) return true;
      return false;
   }

   // Checking for Dot operator in both forward and backward indices if it's present in the checkInput.
   private bool DotIndicesCheck (string checkInput) {
      int dotIndex = mDotIndexList[0];
      bool isTrue = true;
      foreach (char c in checkInput[..dotIndex]) if (!mNums.Contains (c)) isTrue = false;
      if (dotIndex != checkInput.Length - 1) {
         if (dotIndex == 0 && mNums.Contains (checkInput[dotIndex + 1])) return true;
         else if (dotIndex == 1 && (checkInput[dotIndex - 1] == '+' || checkInput[dotIndex - 1] == '-'))
            return true;
         else if (dotIndex > 1 && mNums.Contains (checkInput[dotIndex - 1]) &&
                  mNums.Contains (checkInput[dotIndex + 1])) return true;
         else if (dotIndex > 1 && checkInput[dotIndex + 1] == 'e' && isTrue) return true;
      } else if (checkInput.Length != 1 && dotIndex == checkInput.Length - 1 && isTrue) return true;
      return false;
   }

   private readonly char[] mNums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
   readonly List<int> mPlusIndexList = new (), mSubIndexList = new (), mExpIndexList = new (), mDotIndexList = new ();
}
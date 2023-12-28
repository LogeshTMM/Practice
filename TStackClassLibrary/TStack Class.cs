namespace TStack;
public class TStack<T> {

   public TStack () => mArray = Array.Empty<T> ();

   public TStack (int capacity) {
      if (capacity < 0) throw new Exception ("Cannot create a TStack with a negative size");
      else mArray = Array.Empty<T> ();
   }

   public int Capacity {
      get {
         if (mArray.Length > mCapacity) {
            int quotient = mArray.Length / 4, counter = 0;// Based on the quotient value capacity of TStack will be determined.
            while (counter != quotient) {
               mCapacity *= 2;
               counter++;
            }
            return mCapacity;
         }
         return mCapacity;
      }
   }

   public void Push (T element) {
      if (mSize == 0) {
         T[] temparr = mArray;
         int mArrayNewLen = mArray.Length + 1, mArrayOldLen = temparr.Length - 1;
         mArray = new T[mArrayNewLen];
         while (mArrayOldLen != -1)
            mArray[--mArrayNewLen] = temparr[mArrayOldLen--];
         mSize = mArrayNewLen;
      }
      mArray[--mSize] = element;
   }

   public T Peek () {
      if (mArray.Length == 0) throw new Exception ("InvalidOperationException");
      else return mArray[0];
   }

   public T Pop () {
      T[] tempArr = mArray;
      if (mArray.Length == 0) throw new Exception ("InvalidOperationException");
      mArray = new T[tempArr.Length - 1];
      int mArrayNewLen = tempArr.Length - 1, mArrayOldlen = tempArr.Length - 1;
      while (mArrayOldlen != 0)
         mArray[--mArrayNewLen] = tempArr[mArrayOldlen--];
      return tempArr[0];
   }

   public int Count {
      get => mSize = mArray.Length;
   }

   public bool IsEmpty {
      get {
         if (mArray.Length == 0) return true;
         return false;
      }
   }

   T[] mArray;
   int mSize;
   int mCapacity = 4;
}
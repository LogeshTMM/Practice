using System.Reflection.Metadata.Ecma335;

namespace TQueue;
public class TQueue<T> {

   public TQueue () => mArray = new T[4];

   public void Enqueue (T element) {
      if (mSize < 4) {
         if (mArray.Length == 0) mArray = new T[4];
         mArray[mSize++] = element;
      } else {
         Array.Resize (ref mArray, mArray.Length + 1);
         mArray[mSize++] = element;
      }
   }

   public T Dequeue () {
      if (mArray.Length == 0) throw new Exception ("InvalidOperationException");
      T front = mArray[0];
      mSize--;
      int index = 0, swapIndex = 1;
      while (index != mArray.Length - 1)
         mArray[index++] = mArray[swapIndex++];
      Array.Resize (ref mArray, mArray.Length - 1);
      return front;
   }

   public T Peek () {
      if (mArray.Length == 0) throw new Exception ("InvalidOperationException");
      else return mArray[0];
   }

   public int Count => mSize;

   public bool IsEmpty => mArray.Length == 0;

   T[] mArray;
   int mSize = 0;
}
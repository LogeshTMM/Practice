namespace TQueue;
public class TQueue<T> {
   public TQueue () => mArray = new T[4];
   public void Enqueue (T element) {
      if (initialize < 4) {
         if (initialize == 0) Array.Resize (ref mArray, 4);
         mArray[initialize++] = element; mSize++;
      } else if (fillFreeSpace >= 1) { // Use the free space in mArray to add the elements from the zeroth index.
         mArray[startFromZero++] = element; --fillFreeSpace; mSize++;
      } else if ((freeSpace + remainingArrLen) == mArray.Length) {
         T[] tempArr = new T[mArray.Length + 1]; int i = 0;
         while (forward != mArray.Length) tempArr[i++] = mArray[forward++];
         // Move the elements from nth index to last element in the mArray to zero to nth index (nth index is
         //  based on how many number of elements between nth index to last element) in tempARR.
         while (backward != temp) tempArr[i++] = mArray[backward++];
         // The elements from zeroth index to nth element in the mArray move to tempArr remaining indices.
         tempArr[i++] = element; mArray = tempArr; temp = 0; mSize++;
         initialize++; stopper = true;
      } else if (!isDequeueActive || stopper == true) {
         Array.Resize (ref mArray, mArray.Length + 1);
         mArray[initialize++] = element;
         mSize++; head = mArray[0]; temp = 0;
      }
   }
   public T Dequeue () {
      if (mSize == 0) throw new Exception ("InvalidOperationException");
      temp %= mArray.Length; head = mArray[temp++];
      mSize--; forward = temp;
      remainingArrLen = mSize; freeSpace = temp; fillFreeSpace++;
      if (mSize == 0) { initialize = 0; fillFreeSpace = 0; isDequeueActive = false; } else isDequeueActive = true;
      return head;
   }
   public T Peek () {
      if (mSize == 0) throw new Exception ("InvalidOperationException");
      else return head;
   }
   public int Count => mSize;
   public bool IsEmpty => mSize == 0;

   T[] mArray;
   T head; // Hold the first element in the mArray.
   int mSize = 0, temp = 0, initialize, startFromZero = 0, forward = 0, backward, remainingArrLen, freeSpace, fillFreeSpace;
   bool isDequeueActive, stopper;
}
namespace TQueue;
public class TQueue<T> {
   public TQueue () => mArray = new T[mCapacity];
   public void Enqueue (T element) {
      if (mHead < mArray.Length && mSize != mArray.Length) mArray[mHead] = element;
      else if (mSize == mCapacity) {
         Array.Resize (ref mArray, mCapacity *= 2);
         if (mTail > 0) {
            T[] tempArr = new T[mCapacity];
            int i = 0;
            while (i < mSize) { // Move the elements from nth index (mHead) to last element (mSize) in the
               tempArr[i++] = mArray[mHead++]; // mArray and transfer the values to zero to nth index in tempARR.
               mHead %= mArray.Length;
               if (mHead == mSize) mHead = 0;
            }
            tempArr[mHead] = element;
            mArray = tempArr; mTail = 0;
         } else mArray[mHead] = element; // If the mTail is not initialized and the array is resized.
      } else if (mHead == mArray.Length) mArray[mHead %= mArray.Length] = element; // If mSize doesn't match mCapacity and mHead matches mArray.Length, mHead starts from zero.
      mHead %= mArray.Length;
      mSize++; mHead++;
   }

   public T Dequeue () {
      if (IsEmpty) throw new Exception ("Queue empty");
      T dequeueElement = mArray[mTail];
      mTail = (mTail + 1) % mArray.Length; mSize--;
      return dequeueElement;
   }

   public T Peek () {
      if (mSize == 0) throw new Exception ("InvalidOperationException");
      else return mArray[mTail]; // After the increment operation done on the tail (Dequeue method).
      // So the tail value points to the first index value of an array(mArray).
   }

   public int Count => mSize;
   public bool IsEmpty => mSize == 0;

   T[] mArray;
   int mSize, mHead, mTail, mCapacity = 4;
   // mSize => Tells the numbers of active elements in the mArray.
   // mHead => Indicates which index in the array element to include.
   // mTail => Indicates which index in the array element is going to pop.
   // mcapacity => It is used to resize an array whenever it becomes full.
}
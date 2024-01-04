namespace TQueue;
public class TQueue<T> {
   public TQueue () => mArray = new T[mCapacity];
   public void Enqueue (T element) {
      if (mInitialize < mArray.Length) {
         mArray[mInitialize++] = element; mHead++; mSize++;
      } else if (mFillFreeSpace >= 1) {
         // Use the free space in mArray to add the elements from the zeroth index(mStartFromZero) to mFillFreeSpace -1.
         mArray[mStartFromZero++] = element; --mFillFreeSpace; mSize++; mHead++;
         if (mFillFreeSpace == 0) mStartFromZero = 0;
      } else if (!isDequeueActive) {
         Array.Resize (ref mArray, mCapacity *= 2);
         mArray[mInitialize++] = element; mHead++; mSize++;
      }

      if (mHead == mArray.Length && mTail > 0) mHead = 0;
      else if (mHead == mTail) {
         T[] tempArr = new T[mCapacity *= 2];
         int i = 0, j = 0;
         while (mHead < mArray.Length) tempArr[i++] = mArray[mHead++];
         // Move the elements from nth index (mHead) to last element in the mArray and transfer the values to zero to nth index
         // (nth index isbased on how many number of elements between nth index to last element in the mArray) in tempARR.
         while (j != mTail) tempArr[i++] = mArray[j++];
         // The elements from zeroth index to nth element (mTail - 1) in the mArray, then move to tempArr remaining indices.
         mHead = i; mTail = 0; mArray = tempArr;
      }
   }

   public T Dequeue () {
      if (mSize == 0) throw new Exception ("InvalidOperationException");
      mTail %= mArray.Length; popElement = mArray[mTail++];
      mSize--; mFillFreeSpace++;
      if (mSize == 0) {
         Array.Resize (ref mArray, mCapacity *= 2);
         mInitialize = 0; mFillFreeSpace = 0; isDequeueActive = false;
      } else isDequeueActive = true;
      return popElement;
   }

   public T Peek () {
      if (mSize == 0) throw new Exception ("InvalidOperationException");
      else return mArray[mTail];
      // After the increment operation done on the tail (Dequeue method).
      // So the tail value points to the first index value of an array(mArray).
   }
   public int Count => mSize;
   public bool IsEmpty => mSize == 0;

   T[] mArray;
   T popElement; // Hold the value of poped element in the mArray.
   int mSize, mHead, mTail, mInitialize, mStartFromZero, mFillFreeSpace, mCapacity = 4;
   // mSize => Tells the numbers of active elements in the mArray.
   // mHead => Indicates which index in the array element to include.
   // mTail => Indicates which index in the array element is going to pop.
   // mFillFreeSpace => To indicate the number of free spaces in the array.
   // mcapacity => It is used to resize an array whenever it becomes full.
   // mInitialize, mStartFromZero => temporary variables.
   bool isDequeueActive; // To know whether the dequeue method is called or not.
}
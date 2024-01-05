namespace TStack;
public class TStack<T> {

   public TStack () => mArray = new T[mCapacity];

   public void Push (T element) {
      if (mSize < mArray.Length) mArray[mSize++] = element;
      else {
         Array.Resize (ref mArray, mCapacity *= 2);
         mArray[mSize++] = element;
      }
   }

   public T Pop () {
      if (mSize == 0) throw new Exception ("InvalidOperationException");
      return mArray[--mSize];
   }

   public T Peek () {
      if (mSize == 0) throw new Exception ("InvalidOperationException");
      else return mArray[mSize - 1];
   }

   public int Count => mSize;

   public bool IsEmpty => mSize == 0;

   T[] mArray;
   int mSize, mCapacity = 4;
   // mSize => Tells the numbers of active elements in the mArray.
   // mcapacity => It is used to resize an array whenever it becomes full.
}
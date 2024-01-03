namespace TStack;
public class TStack<T> {

   public TStack () => mArray = new T[4];

   public void Push (T element) {
      if (initialize < 4) {
         if (mArray.Length == 0) Array.Resize (ref mArray, 4);
         mArray[initialize++] = element;
         mSize++;
      } else {
         Array.Resize (ref mArray, mArray.Length + 1);
         mArray[initialize++] = element;
         mSize++;
      }
   }

   public T Pop () {
      if (mSize == 0) throw new Exception ("InvalidOperationException");
      popElement = mArray[mArray.Length - 1];
      Array.Resize (ref mArray, mArray.Length - 1);
      initialize = --mSize;
      return popElement;
   }

   public T Peek () {
      if (mSize == 0) throw new Exception ("InvalidOperationException");
      else return mArray[mArray.Length - 1];
   }

   public int Count => mSize;

   public bool IsEmpty => mSize == 0;

   T[] mArray;
   T popElement;
   int mSize, initialize;
}
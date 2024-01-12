namespace MyList;
public class MyList<T> {
   public MyList () => mArray = new T[mCapacity];
   public MyList (int capacity = 4) {
      if (capacity < 0) throw new Exception ("cannot create a MyList with a negative value");
      else mArray = new T[capacity];
   }

   public T this[int index] {
      get {
         if (index < 0 || index > mArray.Length) throw new IndexOutOfRangeException ();
         //If the index value is not within range between 0 and (mArray.Length - 1) thrown an exception.
         else return mArray[index];
      }
      set {
         if (index < 0 || index > mArray.Length) throw new IndexOutOfRangeException ();
         else mArray[index] = value;
      }
   }

   public int Count => mSize;

   public int Capacity => mArray.Length;

   public void Add (T element) {
      if (mSize == mArray.Length || mArray.Length == 0) Array.Resize (ref mArray, mCapacity *= 2);
      mArray[mSize++] = element;
   }

   public bool Remove (T element) {
      if (mSize != 0) {
         for (int index = 0; index < mArray.Length; index++) {
            if (mArray[index].Equals (element)) {
               for (int j = index; j < mSize; j++) (mArray[j], mArray[j + 1]) = (mArray[j + 1], mArray[j]);
               // Swap out the element that needs to be taken out for the mSize index position.
               mSize--;
               return true;
            }
         }
      }
      return false;
   }

   public void Clear () {
      mSize = 0;
      Array.Clear (mArray);
   }

   public void Insert (int index, T element) {
      if (index < 0 || index > mArray.Length || mSize == 0)
         throw new ArgumentOutOfRangeException ("Invalid Index");
      if (mSize == mArray.Length) Array.Resize (ref mArray, mCapacity *= 2);
      for (int i = mSize; i > index; i--) mArray[i] = mArray[i - 1];
      // Move the index value up by one position to a step forward, it's starts from where the new element is going to insert.
      // The Process goes on until the index value of mSize - 1.
      mArray[index] = element; mSize++;
   }

   public void RemoveAt (int index) {
      if (index < 0 || index > mArray.Length || mSize == 0)
         throw new ArgumentOutOfRangeException ("Invalid Index");
      else {
         for (int i = index; i < mSize - 1; i++)
            (mArray[i], mArray[i + 1]) = (mArray[i + 1], mArray[i]);
         // Swap out the element that needs to be taken out for the mSize index position.
         mSize--;
      }
   }

   T[] mArray;
   int mSize, mCapacity = 4;
   // mSize => Tells the numbers of active elements in the mArray.
   // mcapacity => It is used to resize an array whenever it becomes full.
}
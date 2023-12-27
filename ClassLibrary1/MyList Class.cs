namespace MyList;
public class MyList<T> {

   public MyList () => mArray = Array.Empty<T> ();

   public MyList (int capacity) {
      if (capacity < 0) throw new Exception ("cannot create a MyList with a negative value");
      else mArray = Array.Empty<T> ();
   }

   public T this[int index] {
      get {
         if (index < 0 || index > mArray.Length - 1) throw new Exception ("IndexOutOfRangeException");
         //If the index value is not within range between 0 and (mArray.Length - 1) thrown an exception.
         else return mArray[index];
      }
   }

   public int Count {
      get => mArray.Length;
   }

   public int Capacity {
      get {
         if (mArray.Length > mCapacity) {
            int quotient = mArray.Length / 4, counter = 0;// Based on the quotient value capacity of MyList will be determined.
            while (counter != quotient) {
               mCapacity *= 2;
               counter++;
            }
            return mCapacity;
         }
         return mCapacity;
      }
   }

   public void Add (T element) => mArray = mArray.Append (element).ToArray ();

   public void Remove (T element) {
      T[] tempArr = Array.Empty<T> ();
      if (mArray.Length != 0) {
         for (int i = 0; i < mArray.Length; i++)
            if (!mArray[i].Equals (element))
               tempArr = tempArr.Append (mArray[i]).ToArray ();
         mArray = tempArr;
      } else throw new Exception ("MyList is empty");
   }

   public void Clear () => mArray = Array.Empty<T> ();

   public void Insert (int index, T element) {
      T[] tempArr = Array.Empty<T> ();
      if (index < 0 || index >= mArray.Length) throw new Exception ("IndexOutOfrangeException");
      for (int i = 0, j = index; i < mArray.Length + 1; i++) {
         if (index > i) tempArr = tempArr.Append (mArray[i]).ToArray ();
         if (i == index) tempArr = tempArr.Append (element).ToArray ();
         if (i > index && i <= mArray.Length + 1) tempArr = tempArr.Append (mArray[j++]).ToArray ();
      }
      mArray = tempArr;
   }

   public void RemoveAt (int index) {
      if (index < 0 || index >= mArray.Length) throw new Exception ("ArugumentOutOfRangeException");
      T[] tempArr = Array.Empty<T> ();
      for (int i = 0; i < mArray.Length; i++)
         if (i != index) tempArr = tempArr.Append (mArray[i]).ToArray ();
      mArray = tempArr;
   }

   T[] mArray;
   int mCapacity = 4;
}
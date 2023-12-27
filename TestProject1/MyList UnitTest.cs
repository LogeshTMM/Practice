using MyList;
namespace TestProject_T26 {
   [TestClass]
   public class MyListUnitTest {

      static readonly MyList<int> mylist = new (); // User Defined Class
      static readonly List<int> lists = new (); // Predefined Class

      // In the following four methods, mylist and lists are not initialized, except for the first method.

      [TestMethod]
      ///<summary>In this method we add the elements to the MyList<T> (user - defined class) methods like Add,Remove and Insert
      ///as well as List<T> (predefined class). Lastly, evaluate the elements in both classes. </summary>
      public void TestMethod1 () {
         int i = 0;
         while (i != 5) {
            lists.Add (i);
            mylist.Add (i++);
         }
         mylist.Remove (--i);
         lists.Remove (i);
         mylist.Insert (3, 8);
         lists.Insert (3, 8);
         for (int j = 0; j < lists.Count; j++)
            Assert.IsTrue (mylist[j] == lists[j]);
      }

      [TestMethod]
      ///<summary>In this method we insert the elements to the MyList<T> (user - defined class) in Insert method
      ///as well as List<T> (predefined class) Insert method. Lastly, evaluate the elements in both classes. </summary>
      public void TestMethod2 () {
         int i = 2, j = 10;
         while (i < mylist.Count) {
            mylist.Insert (i, j);
            lists.Insert (i, j);
            i += 2; j -= 2;
         }
         for (int k = 0; k < lists.Count; k++)
            Assert.IsTrue (lists[k] == mylist[k]);
      }

      [TestMethod]
      ///<summary>In this method we remove the elements to the MyList<T> (user - defined class) in RemoveAt method
      ///as well as List<T> (predefined class) Insert method. Lastly, evaluate the elements in both classes. </summary>
      public void TestMethod3 () {
         int i = 0;
         while (i < lists.Count) {
            lists.RemoveAt (i);
            mylist.RemoveAt (i);
            i += 2;
         }
         for (int j = 0; j < mylist.Count; j++)
            Assert.IsTrue (lists[j] == mylist[j]);
      }

      [TestMethod]
      ///<summary>In this method we count the elements in the MyList<T> (user - defined class) as well as 
      ///List<T> (predefined class). Lastly, evaluate the number of elements in both classes. </summary>
      public void TestMethod4 () => Assert.IsTrue (mylist.Count == lists.Count);

      [TestMethod]
      ///<summary>In this method we delete all the elements to the MyList<T> (user - defined class) as well as 
      ///List<T> (predefined class). Lastly, evaluate the number of elements in both classes should be zero. </summary>
      public void TestMethod5 () {
         mylist.Clear ();
         lists.Clear ();
         Assert.IsTrue (mylist.Count == lists.Count);
      }
   }
}
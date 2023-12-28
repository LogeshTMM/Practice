using TQueue;
namespace TestProject_T28 {
   [TestClass]
   public class UnitTest1 {
      static readonly TQueue<int> tqueue = new (); // User-Defined class
      static readonly Queue<int> queue = new (); // Predefined class

      // In the following TestMethod2 to TestMethod4 methods, mylist and lists are not initialized, except for the first TestMethod.

      [TestMethod]
      ///<summary>In this method we add the elements to the TQueue<T> (user - defined class) methods like Enqueue and Dequeue
      ///as well as Queue<T> (predefined class). Lastly, evaluate the elements in both classes. </summary>
      public void TestMethod1 () {
         int i = 0;
         while (i != 5) {
            tqueue.Enqueue (i);
            queue.Enqueue (i++);
         }
         while (i != 0) {
            Assert.AreEqual (tqueue.Dequeue (), queue.Dequeue ());
            i--;
         }
      }

      [TestMethod]
      ///<summary>In this method we add the elements to the TQueue<T> (user - defined class) method like Enqueue and Peek
      ///method for check the first element as well as Queue<T> (predefined class). Lastly, evaluate the peek element in
      ///both classes and also check theIsEmpty property for tqueue. </summary>
      public void TestMethod2 () {
         int i = 0;
         while (i != 6) {
            tqueue.Enqueue (i);
            queue.Enqueue (i++);
         }
         Assert.IsTrue (tqueue.Peek () == queue.Peek ());
         Assert.IsFalse (tqueue.IsEmpty);
      }

      [TestMethod]
      ///<summary>In this method we check the total number of elements in TQueue<T> (user - defined class)
      ///as well as Queue<T> (predefined class). Lastly, evaluate the number of elements in both classes. </summary>
      public void TestMethod3 () => Assert.IsTrue (tqueue.Count == queue.Count);

      [TestMethod]
      ///<summary>In this method we remove the element from TQueue<T> (user - defined class) method like Dequeue
      ///as well as Queue<T> (predefined class). Lastly, evaluate no elements in both classes. </summary>
      public void TestMethod4 () {
         while (tqueue.Count != 0) {
            tqueue.Dequeue ();
            queue.Dequeue ();
         }
         Assert.IsTrue (tqueue.IsEmpty);
      }

      [TestMethod]
      ///<summary>In this method we check an exception in the TQueue<T> (user - defined class) while using Dqueue method
      ///in an empty tstack. Lastly, evaluate whether is throws an exception or not. </summary>
      public void TestMethod5 () => Assert.ThrowsException<Exception> (() => tqueue.Dequeue ());

      [TestMethod]
      ///<summary>In this method we check an exception in the TQueue<T> (user - defined class) while using Peek method
      ///in an empty tstack. Lastly, evaluate whether is throws an exception or not. </summary>
      public void TestMethod6 () => Assert.ThrowsException<Exception> (() => tqueue.Peek ());
   }
}
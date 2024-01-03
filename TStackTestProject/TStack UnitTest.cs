using TStack;
namespace TestProject_T27 {
   [TestClass]
   public class UnitTest1 {
      static readonly TStack<int> tstack = new (); // User-Defined class
      static readonly Stack<int> stacks = new (); // Predefined class

      // In the following four methods, mylist and lists are not initialized, except for the first and second TestMethod.

      [TestMethod]
      ///<summary>In this method we add the elements to the TStack<T> (user - defined class) methods like Push and Pop
      ///as well as Stack<T> (predefined class). Lastly, evaluate the elements in both classes. </summary>
      public void TestMethod1 () {
         int i = 0;
         while (i != 5) {
            tstack.Push (i);
            stacks.Push (i++);
         }
         while (i != 0) {
            Assert.AreEqual (stacks.Pop (), tstack.Pop ());
            i--;
         }
      }

      [TestMethod]
      ///<summary>In this method we add the elements to the TStack<T> (user - defined class) methods like Push and Peekalong
      ///with property IsEmpty as well as Stack<T> (predefined class) except IsEmpty. Lastly, evaluate the elements in both
      ///classes also check the tstack is empty or not. </summary>
      public void TestMethod2 () {
         int i = 0;
         while (i != 6) {
            tstack.Push (i);
            stacks.Push (i++);
         }
         Assert.IsTrue (tstack.Peek () == stacks.Peek ());
         Assert.IsFalse (tstack.IsEmpty);
      }

      [TestMethod]
      ///<summary>In this method we evaluate the number of elements in the TStack<T> (user - defined class)
      /// as well as Stack<T> (predefined class). Lastly, evaluate the total number of elements in both classes. </summary>
      public void TestMethod3 () => Assert.IsTrue (tstack.Count == stacks.Count);

      [TestMethod]
      ///<summary>In this method we delete the elements in the TStack<T> (user - defined class)
      ///as well as Stack<T> (predefined class). Lastly, evaluate the total number of elements in both classes 
      ///also check the tstack is empty or not. </summary>
      public void TestMethod4 () {
         while (tstack.Count != 0) {
            tstack.Pop ();
            stacks.Pop ();
         }
         Assert.IsTrue (tstack.IsEmpty);
         Assert.AreEqual (tstack.Count, stacks.Count);
      
      }

      [TestMethod]
      ///<summary>In this method we check an exception in the TStack<T> (user - defined class) while using Peek method
      ///in an empty tstack. Lastly, evaluate whether is throws an exception or not. </summary>
      public void TestMethod5 () => Assert.ThrowsException<Exception> (() => tstack.Peek ());

      [TestMethod]
      ///<summary>In this method we check an exception in the TStack<T> (user - defined class) while using Pop method
      ///in an empty tstack. Lastly, evaluate whether is throws an exception or not. </summary>
      public void TestMethod6 () => Assert.ThrowsException<Exception> (() => tstack.Pop ());
   }
}
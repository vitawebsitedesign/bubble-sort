using BubbleSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BubbleSortTests
{
    [TestClass]
    public class BubbleSortUnitTests
    {
        [TestMethod]
        public void SortCorrectForNoNumbers()
        {
            var expected = new int[] { };
            var actual = new int[] { };
            actual.BubbleSort();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SortCorrectForOneNumber()
        {
            var expected = new int[] { 1 };
            var actual = new int[] { 1 };
            actual.BubbleSort();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SortCorrectForManyNumbers()
        {
            var expected = new int[] { 1, 2, 3, 6, 7, 9 };
            var actual = new int[] { 9, 1, 6, 2, 7, 3 };
            actual.BubbleSort();
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}

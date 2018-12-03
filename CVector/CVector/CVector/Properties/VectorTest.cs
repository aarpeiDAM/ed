using NUnit.Framework;
using System;
namespace CVector.Properties
{
    [TestFixture()]
    public class VectorTest
    {
        [Test()]
        public void BinarySearch()
        {
            Assert.AreEqual(-1,Vector.BinarySearch(new int[]{},33));
            Assert.AreEqual(0, Vector.BinarySearch(new int[] {12,15,16,19,20}, 12));
            Assert.AreEqual(4, Vector.BinarySearch(new int[] { 10, 25, 30, 60, 65}, 65));
            Assert.AreEqual(2, Vector.BinarySearch(new int[] { 12, 26, 45, 36, 96}, 45));
            Assert.AreEqual(3, Vector.BinarySearch(new int[] { 35, 38, 95, 99, 100}, 99));
            Assert.AreEqual(2, Vector.BinarySearch(new int[] { 12, 12, 12, 12,12}, 12));
        }
    }
}

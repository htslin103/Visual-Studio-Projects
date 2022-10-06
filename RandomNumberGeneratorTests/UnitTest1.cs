using RandomNumberGenerator.Classes;
using System.Diagnostics;

namespace RandomNumberGeneratorTests
{
    [TestClass]
    public class UnitTest1
    {
        int[] startingArray = { 1, 2, 3, 4, 5, 6 };

        [TestMethod]
        public void NewRandomArrayLengthShouldBeEqualToOriginalArrayLength()
        {
            
            var randomArray = RandNumberGenerator.CreateRandomList(startingArray);
            Assert.AreEqual(startingArray.Length, randomArray.Length);
        }

        [TestMethod]
        public void NewRandomArrayCollectionShouldHaveAllDistinctItems()
        {
            var randomArray = RandNumberGenerator.CreateRandomList(startingArray);
            var item = randomArray.Distinct().Count();
            var item2 = startingArray.Length;
            Assert.AreEqual(randomArray.Distinct().Count(), startingArray.Length);
        }
    }
}
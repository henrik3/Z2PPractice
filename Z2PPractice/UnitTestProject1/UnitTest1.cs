using Microsoft.VisualStudio.TestTools.UnitTesting;
using Z2PPractice;

namespace UnitTestProject1
{// IT IS NORMAL TO WRITE THE TEST AND THEN WRITE THE CODE
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add2ParamCorrectResult()
        {
            Assert.AreEqual(5, Math.Add(2, 3));
        }
        [TestMethod]
        public void Add3ParamCorrectResult()
        {
            Assert.AreEqual(8, Math.Add(2, 3, 3));
        }
    }
}

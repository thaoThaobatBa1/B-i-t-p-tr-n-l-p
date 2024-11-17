using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTtrenlop
{
    public class TinhhieuTest
    {
        private Tinhhieu th;
        [SetUp]
        public void Setup()
        {
            th = new Tinhhieu();
        }


        [Test]
        public void testTInhieu()
        {
            int[] expectedNumbers = { 10, 4, 6, 18 };
            int expectedDifference = -18;

            Assert.AreEqual(expectedNumbers, th.GetNumbers());
            Assert.AreEqual(expectedDifference, th.GetDifference());
        }
    }
}

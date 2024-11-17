using NUnit.Framework.Interfaces;

namespace BTtrenlop
{
    public class Tests
    {
        private findNumber sv;
        [SetUp]
        public void Setup()
        {
            sv = new findNumber();
        }

        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void TestFindNumber (List<int> input ,List<int> expected)
        {
            var result = sv.FindEvenNumber(input);
            Assert.That(result, Is.EqualTo(expected));
        }

       public static IEnumerable<TestCaseData> TestCases
        {
            get {
                yield return new TestCaseData(new List<int>() { 0, 4, 5, 6, 18, 10, 9, 21, 25, 40 } , new List<int> { 0, 4, 6, 18, 10, 40 });
            }
        }

       
    }
}
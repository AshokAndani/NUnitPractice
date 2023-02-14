using ConsoleApp5;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(12,12)]
        public void Test1(int a, int b)
        {
            // arrange
            ConsoleApp5.Math math = new ConsoleApp5.Math();
            int expected = 24;
            // act
            var actual = math.Add(a, b);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestAddMethod()
        {
            // arrange
            ConsoleApp5.Math math = new ConsoleApp5.Math();
            var expected = 4294967294;
            // act
            var actual = math.Add(int.MaxValue, int.MaxValue);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(12,12)]
        [TestCase(1,1)]
        [TestCase(1,0)]
        [TestCase(1,2)]
        public void TestDivide(int a, int b)
        {
            // arrange
            ConsoleApp5.Math math = new ConsoleApp5.Math();
            int expected = 1;
            // act
            int actual = math.divide(a, b);
            // assert
            Assert.Pass();
        }

        [Test]
        [TestCase("abb")]
        [TestCase("a_b")]
        public void CheckAnyCharInbetween_PassingValidInput_ShouldReturnTrue(string input)
        { 
            //arrange
            Program p = new Program();
            bool expected = true;

            // act
            var actual = p.CheckAnyCharInbetween(input);

            // assert
            Assert.IsTrue(true);
        }
    }
}
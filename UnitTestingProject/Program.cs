using Homework14;
using Xunit;

namespace TestProject
{
    public class UnitTest
    {
        [Fact]
        public void test1()
        {
            Coconut coconut = new Coconut();
            string result = coconut.ToString();
            Assert.NotNull(result);
        }

        [Fact]
        public void test2()
        {
            Coconut coconut = new Coconut();
            string result = coconut.ToString();
            Assert.Contains("Coconut", result);
        }
    }
}
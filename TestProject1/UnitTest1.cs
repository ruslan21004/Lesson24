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
//checked
//what is expected for the home work? For the home work it is expected to create any project with some class (there should be some methods in the class) ,
//then there should be created new project of Unit tests. In this Unit tests project the Unit testinmg must be done. But in your project the UNit test project only - no project shown which you are going to test

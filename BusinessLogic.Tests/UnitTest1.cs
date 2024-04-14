namespace BusinessLogic.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestPow()
        {
            Assert.Equal(1, MainLogic.Power(1, 1));
            Assert.Equal(1, MainLogic.Power(10, 0));
            Assert.Equal(1024, MainLogic.Power(2, 10));
        }
    }
}
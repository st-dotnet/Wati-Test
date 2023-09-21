using Wati_Test_Integer;
using Moq;
using Moq.EntityFrameworkCore;
using Wati_Test_Integer.Controllers;

namespace WatiUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mockDBContext = new Mock<IIntegerContext>();
            mockDBContext.Setup(x => x.IntegerSumEntity).ReturnsDbSet(new List<IntegerSumEntity>());
            var controller = new AddController(mockDBContext.Object);
            var request = new IntegerModel
            {
                Integer1 = 1,
                integer2 = 2
            };
            var result=controller.Post(request);
            Assert.AreEqual(3, result);
        }
    }
}
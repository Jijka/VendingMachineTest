using AutoPark;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoParkTests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void CarTest()
        {
            var moto = new  MotorCycle();
            moto.SetEngine(new Engine());
            Assert.AreEqual(50, moto.EnginePower);
        }


    }
}
using NUnit.Framework;
using ProgrammingProblemSolutions.ProgrammingProblemCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingProblemSolutions.UnitTests
{
    [TestFixture()]
    public class ParkingSystem
    {
        [TestCase()]
        public void ParkingSystemTest()
        {
            var parkingSystem = new ParkingSystemProcessor(1, 1, 0);
            Assert.IsTrue(parkingSystem.AddCar(1)); // return true because there is 1 available slot for a big car
            Assert.IsTrue(parkingSystem.AddCar(2)); // return true because there is 1 available slot for a medium car
            Assert.IsFalse(parkingSystem.AddCar(3)); // return false because there is no available slot for a small car
            Assert.IsFalse(parkingSystem.AddCar(1)); // return false because there is no available slot for a big car. It is already occupied.
        }
    }
}

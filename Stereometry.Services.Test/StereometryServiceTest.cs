using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Stereometry.Domain.Entities;
using Stereometry.Domain.Interfaces;

namespace Stereometry.Services.Test
{
    [TestClass]
    public class StereometryServiceTest
    {
        [TestMethod]
        public void IntersectionVolumeTest()
        {
            //Create objects
            var realCube = new Cube(new Point(0, 0, 0), 10);
            var mockedCube = Mock.Of<IConvexSolid>();

            //Set up
            Mock.Get(mockedCube)
                .Setup(x => x.GetIntersectionVolume(realCube))
                .Returns(2);

            //Execute and Assert
            var service = new StereometryService();
            Assert.AreEqual(2, service.GetIntersectionVolume(mockedCube, realCube));
        }

        [TestMethod]
        public void IntersectsTest()
        {
            //Create objects
            var realCube = new Cube(new Point(0, 0, 0), 10);
            var mockedCube = Mock.Of<IConvexSolid>();

            //Set up
            Mock.Get(mockedCube)
                .Setup(x => x.Intersects(realCube))
                .Returns(false);

            //Execute and Assert
            var service = new StereometryService();
            Assert.IsFalse(service.Intersects(mockedCube, realCube));
        }              
    }
}

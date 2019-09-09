using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stereometry.Domain.Entities;

namespace Stereometry.Domain.Test
{
    [TestClass]
    public class PointTest
    {
        [TestMethod]
        public void CreateTest()
        {
            var point = new Point(1, 2, 3);

            Assert.IsTrue(point.X == 1);
            Assert.IsTrue(point.Y == 2);
            Assert.IsTrue(point.Z == 3);
        }
    }
}

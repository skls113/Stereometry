using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stereometry.Domain.Entities;
using Stereometry.Domain.Exceptions;

namespace Stereometry.Domain.Test
{
    [TestClass]
    public class CubeTest
    {
        [TestMethod]
        public void IdenticalCubes_Test()
        {
            var cube1 = new Cube(new Point(0, 0, 0), 3);
            var cube2 = new Cube(new Point(0, 0, 0), 3);

            CheckAssert(cube1, cube2, 27, true);
        }

        [TestMethod]
        public void IdenticalCubesMovedOnY1_Test()
        {
            var cube1 = new Cube(new Point(0, 0, 0), 3);
            var cube2 = new Cube(new Point(0, 1, 0), 3);

            CheckAssert(cube1, cube2, 18, true);
        }

        [TestMethod]
        public void IdenticalCubesMovedOnY1Z1_Test()
        {
            var cube1 = new Cube(new Point(0, 0, 0), 3);
            var cube2 = new Cube(new Point(0, 1, 1), 3);

            CheckAssert(cube1, cube2, 12, true);
        }

        [TestMethod]
        public void IdenticalCubesMovedOnY1Z2_Test()
        {
            var cube1 = new Cube(new Point(0, 0, 0), 3);
            var cube2 = new Cube(new Point(0, 1, 2), 3);

            CheckAssert(cube1, cube2, 6, true);
        }

        [TestMethod]
        public void IdenticalCubesMovedOnY1Z3_Test()
        {
            var cube1 = new Cube(new Point(0, 0, 0), 3);
            var cube2 = new Cube(new Point(0, 1, 3), 3);

            CheckAssert(cube1, cube2, 0, true);
        }

        [TestMethod]
        public void IdenticalCubesMovedOnY1Z4_Test()
        {
            var cube1 = new Cube(new Point(0, 0, 0), 3);
            var cube2 = new Cube(new Point(0, 1, 4), 3);

            CheckAssert(cube1, cube2, 0, false);
        }

        [TestMethod]
        public void EnclosedCube_Test()
        {
            var cube1 = new Cube(new Point(0, 0, 0), 10);
            var cube2 = new Cube(new Point(3, 3, 3), 2);

            CheckAssert(cube1, cube2, 8, true);
        }

        [TestMethod, ExpectedException(typeof(InvalidCubeEdgeLength))]
        public void InvalidCubeEdgeLength_Test()
        {
            var cube1 = new Cube(new Point(0, 0, 0), 0);
        }

        #region Private Methods
        private void CheckAssert(Cube cube1, Cube cube2, double expextedIntersectionVolume, bool expectedIntersects)
        {
            Assert.AreEqual(expectedIntersects, cube1.Intersects(cube2));
            Assert.AreEqual(expectedIntersects, cube2.Intersects(cube1));
            Assert.AreEqual(expextedIntersectionVolume, cube1.GetIntersectionVolume(cube2));
            Assert.AreEqual(expextedIntersectionVolume, cube2.GetIntersectionVolume(cube1));
        }
        #endregion
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stereometry.Domain.Exceptions;
using Stereometry.Domain.Entities;

namespace Stereometry.Domain.Test
{
    [TestClass]
    public class IntervalTest
    {
        [TestMethod]
        public void Intersecting_EqualIntervals_Test()
        {
            var interval1 = new Interval(1, 4);
            var interval2 = new Interval(1, 4);

            Assert.IsTrue(interval1.Intersects(interval2));
        }

        [TestMethod]
        public void Intersecting_Contain_Test()
        {
            var interval1 = new Interval(1, 4);
            var interval2 = new Interval(2, 3);

            Assert.IsTrue(interval1.Intersects(interval2));
        }

        [TestMethod]
        public void Intersecting_Contain_EqualRightBound_Test()
        {
            var interval1 = new Interval(1, 4);
            var interval2 = new Interval(2, 4);

            Assert.IsTrue(interval1.Intersects(interval2));
        }

        [TestMethod]
        public void Intersecting_Contain_EqualLeftBound_Test()
        {
            var interval1 = new Interval(1, 4);
            var interval2 = new Interval(1, 3);

            Assert.IsTrue(interval1.Intersects(interval2));
        }

        [TestMethod]
        public void Intersecting_Right_Test()
        {
            var interval1 = new Interval(1, 4);
            var interval2 = new Interval(3, 5);

            Assert.IsTrue(interval1.Intersects(interval2));
        }

        [TestMethod]
        public void Intersecting_Left_Test()
        {
            var interval1 = new Interval(1, 4);
            var interval2 = new Interval(-1, 2);

            Assert.IsTrue(interval1.Intersects(interval2));
        }

        [TestMethod]
        public void Intersecting_RightBoundEqual_Test()
        {
            var interval1 = new Interval(1, 4);
            var interval2 = new Interval(4, 6);

            Assert.IsTrue(interval1.Intersects(interval2));
        }

        [TestMethod]
        public void Intersecting_LeftBoundEqual_Test()
        {
            var interval1 = new Interval(1, 4);
            var interval2 = new Interval(0, 1);

            Assert.IsTrue(interval1.Intersects(interval2));
        }

        [TestMethod]
        public void NoIntersecting_Left_Test()
        {
            var interval1 = new Interval(3, 4);
            var interval2 = new Interval(-1, 2);

            Assert.IsFalse(interval1.Intersects(interval2));
        }

        [TestMethod]
        public void NoIntersecting_Right_Test()
        {
            var interval1 = new Interval(1, 4);
            var interval2 = new Interval(5, 6);

            Assert.IsFalse(interval1.Intersects(interval2));
        }

        [TestMethod, ExpectedException(typeof(InvalidIntervalBoundsException))]
        public void InvalidIntervalBoundsException_Test()
        {
            var interval1 = new Interval(2, 1);
        }

        [TestMethod]
        public void IntersectionLength_IntersectionLeft()
        {
            var interval1 = new Interval(1, 4);
            var interval2 = new Interval(2, 6);

            Assert.AreEqual(2,interval1.GetIntersectionLength(interval2));
        }

        [TestMethod]
        public void IntersectionLength_IntersectionRight()
        {
            var interval1 = new Interval(1, 5);
            var interval2 = new Interval(-1, 4);

            Assert.AreEqual(3, interval1.GetIntersectionLength(interval2));
        }

        [TestMethod]
        public void IntersectionLength_IntersectionContained()
        {
            var interval1 = new Interval(1, 10);
            var interval2 = new Interval(2, 7);

            Assert.AreEqual(5, interval1.GetIntersectionLength(interval2));
        }

        [TestMethod]
        public void IntersectionLength_NoIntersection()
        {
            var interval1 = new Interval(1, 4);
            var interval2 = new Interval(5, 6);

            Assert.AreEqual(0, interval1.GetIntersectionLength(interval2));
        }

        [TestMethod]
        public void IntervalLength()
        {
            var interval = new Interval(-1, 4);
            Assert.AreEqual(5, interval.Length);
        }

        [TestMethod]
        public void IntervalLength_0()
        {
            var interval = new Interval(4, 4);
            Assert.AreEqual(0, interval.Length);
        }
    }
}

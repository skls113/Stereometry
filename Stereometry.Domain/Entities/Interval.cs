using Stereometry.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stereometry.Domain.Entities
{
    public class Interval
    {
        #region Properties
        internal double Left { get; private set; }
        internal double Right { get; private set; }
        internal double Length => Right - Left;
        #endregion

        #region Constructors
        internal Interval(double left, double right)
        {
            if (right < left)
                throw new InvalidIntervalBoundsException("Right Bound has to be greater than or equal to the Left Bound");

            Left = left;
            Right = right;
        }
        #endregion

        #region Public Methods
        internal bool Intersects(Interval interval)
        {
            return this.Right >= interval.Left && this.Left <= interval.Right;
        }

        internal Interval GetIntersection(Interval interval)
        {
            Interval intersection = null;

            if (this.Intersects(interval))
                intersection = new Interval(Math.Max(this.Left, interval.Left), Math.Min(this.Right, interval.Right));

            return intersection;
        }

        internal double GetIntersectionLength(Interval interval)
        {
            double intersectionLength = 0;
            if (this.Intersects(interval))
                intersectionLength = this.GetIntersection(interval).Length;

            return intersectionLength;
        } 
        #endregion
    }
}

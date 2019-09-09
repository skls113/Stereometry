using Stereometry.Domain.Entities;
using Stereometry.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stereometry.Domain.Abstracts
{
    public abstract class ConvexSolid : IConvexSolid
    {
        #region Properties
        public abstract Interval XAxisProjection { get; }
        public abstract Interval YAxisProjection { get; }
        public abstract Interval ZAxisProjection { get; }
        #endregion

        public abstract IIntersectionCalculator GetIntersectionCalculator();

        public virtual double GetIntersectionVolume(IConvexSolid solid)
        {
            return GetIntersectionCalculator().GetIntersectionVolume(solid);
        }

        public bool Intersects(IConvexSolid solid)
        {
            // We apply the Seperating Axis Theorem in the case of 3-dimension space
            return XAxisProjection.Intersects(solid.XAxisProjection)
                    && YAxisProjection.Intersects(solid.YAxisProjection)
                    && ZAxisProjection.Intersects(solid.ZAxisProjection);
        }
    }
}

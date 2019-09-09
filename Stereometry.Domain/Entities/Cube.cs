using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stereometry.Domain.Abstracts;
using Stereometry.Domain.Exceptions;
using Stereometry.Domain.Interfaces;
using Stereometry.Domain.IntersectionCalculators;

namespace Stereometry.Domain.Entities
{
    public class Cube : ConvexSolid
    {
        #region Properties
        public Point Center { get; private set; }
        public double EdgeLength { get; private set; }
        public override Interval XAxisProjection => new Interval(Center.X - EdgeLength / 2, Center.X + EdgeLength / 2);
        public override Interval YAxisProjection => new Interval(Center.Y - EdgeLength / 2, Center.Y + EdgeLength / 2);
        public override Interval ZAxisProjection => new Interval(Center.Z - EdgeLength / 2, Center.Z + EdgeLength / 2);
        #endregion

        #region Constructors
        public Cube(Point center, double edgeLength)
        {
            if (edgeLength <= 0)
                throw new InvalidCubeEdgeLength("Edge length has to be greater than 0");

            Center = center;
            EdgeLength = edgeLength;
        }
        #endregion

        #region Public Methods
        public override IIntersectionCalculator GetIntersectionCalculator() => new CubeIntersectionCalculator(this);
        #endregion
    }
}

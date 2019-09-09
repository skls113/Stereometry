using Stereometry.Domain.Entities;
using Stereometry.Domain.Exceptions;
using Stereometry.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stereometry.Domain.IntersectionCalculators
{
    public class CubeIntersectionCalculator : IIntersectionCalculator
    {
        #region Properties
        public Cube Cube { get; private set; }
        #endregion

        #region Constructors
        public CubeIntersectionCalculator(Cube cube)
        {
            Cube = cube;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Calculates the Volume of the intersection of Cube with another Convex Solid
        /// </summary>
        /// <param name="solid"></param>
        /// <returns></returns>
        public double GetIntersectionVolume(IConvexSolid solid)
        {
            //Extend this method to get the intersection volume of Cube with other types of Convex Solids.
            if (solid is Cube)
            {
                return GetIntersectionVolumeWithCube((Cube)solid);
            }
            else
            {             
                throw new IntersectionNotCalculatedYetException(string.Format($"The calculation of the volume of the intesection of a Cube with {solid.GetType().Name} is not implemented yet"));
            }
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Calculates the volume of the intersection of the current Cube with a given cube
        /// </summary>
        /// <returns>The intersection volume</returns>
        private double GetIntersectionVolumeWithCube(Cube cube)
        {
            double volume = 0;

            if (Cube.Intersects(cube))
            {
                volume = Cube.XAxisProjection.GetIntersection(cube.XAxisProjection).Length
                        * Cube.YAxisProjection.GetIntersection(cube.YAxisProjection).Length
                        * Cube.ZAxisProjection.GetIntersection(cube.ZAxisProjection).Length;
            }

            return volume;
        }
        #endregion
    }
}

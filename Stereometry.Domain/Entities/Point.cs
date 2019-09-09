using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stereometry.Domain.Entities
{
    public struct Point
    {        
        #region Properties
        /// <summary>
        /// The x cartesian coordinate of the point
        /// </summary>
        internal double X { get; private set; }

        /// <summary>
        /// The y cartesian coordinate of the point
        /// </summary>
        internal double Y { get; private set; }

        /// <summary>
        /// The z cartesian coordinate of the point
        /// </summary>
        internal double Z { get; private set; }
        #endregion

        #region Constructors
        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        #endregion
    }
}

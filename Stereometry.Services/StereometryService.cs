using Stereometry.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stereometry.Services
{
    public class StereometryService
    {
        public double GetIntersectionVolume(IConvexSolid solid1, IConvexSolid solid2)
        {
            return solid1.GetIntersectionVolume(solid2);            
        }

        public bool Intersects(IConvexSolid solid1, IConvexSolid solid2)
        {
            return solid1.Intersects(solid2);
        }
    }
}

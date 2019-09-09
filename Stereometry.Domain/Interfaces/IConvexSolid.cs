using Stereometry.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stereometry.Domain.Interfaces
{
    public interface IConvexSolid
    {
        Interval XAxisProjection { get; }
        Interval YAxisProjection { get; }
        Interval ZAxisProjection { get; }
        double GetIntersectionVolume(IConvexSolid solid);
        bool Intersects(IConvexSolid solid);
    }
}

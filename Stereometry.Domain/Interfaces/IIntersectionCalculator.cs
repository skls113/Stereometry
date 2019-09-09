using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stereometry.Domain.Interfaces
{
    public interface IIntersectionCalculator
    {   
        double GetIntersectionVolume(IConvexSolid solid);
    }
}

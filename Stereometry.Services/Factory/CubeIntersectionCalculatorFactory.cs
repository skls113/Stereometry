using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stereometry.Domain.Entities;
using Stereometry.Domain.Interfaces;
using Stereometry.Domain.IntersectionCalculators;

namespace Stereometry.Services.Factory
{
    public class CubeIntersectionCalculatorFactory : CalculatorFactory
    {
        public override IIntersectionCalculator GetIntersectionCalculator(IConvexSolid cube)
        {
            return new CubeIntersectionCalculator(cube as Cube);
        }
    }
}

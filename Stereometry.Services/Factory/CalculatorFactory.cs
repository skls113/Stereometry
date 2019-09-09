using Stereometry.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stereometry.Services.Factory
{
    public abstract class CalculatorFactory
    {
        public abstract IIntersectionCalculator GetIntersectionCalculator(IConvexSolid solid);
    }
}

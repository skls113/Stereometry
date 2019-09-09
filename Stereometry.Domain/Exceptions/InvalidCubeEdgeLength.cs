using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stereometry.Domain.Exceptions
{
    public class InvalidCubeEdgeLength : Exception
    {
        public InvalidCubeEdgeLength(string message)
            : base(message)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stereometry.Domain.Exceptions
{
    public class IntersectionNotCalculatedYetException : Exception
    {
        public IntersectionNotCalculatedYetException(string message)
            : base(message)
        {
        }
    }
}

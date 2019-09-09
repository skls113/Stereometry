using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stereometry.Domain.Exceptions
{
    public class InvalidIntervalBoundsException : Exception
    {
        public InvalidIntervalBoundsException(string message)
            : base(message)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Additionals.Exceptions
{
    [Serializable]
    public class InvalidHashExteption : Exception
    {
        public InvalidHashExteption(string message) : base(message)
        {
        }
    }
}

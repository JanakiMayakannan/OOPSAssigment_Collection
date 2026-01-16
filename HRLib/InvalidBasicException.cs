using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class InvalidBasicException : ApplicationException
    {
        public InvalidBasicException(string message) : base(message)
        {
        }
    }
}

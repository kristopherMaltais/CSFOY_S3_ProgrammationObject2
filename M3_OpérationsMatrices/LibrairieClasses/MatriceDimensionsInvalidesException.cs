using System;
using System.Collections.Generic;
using System.Text;

namespace LibrairieClasses
{
    
    public class MatriceDimensionsInvalidesException : InvalidOperationException
    {

        public MatriceDimensionsInvalidesException() : base() { }
       
        public MatriceDimensionsInvalidesException(string message) : base(message) { }
       
        public MatriceDimensionsInvalidesException(string message, Exception innerException) : base(message, innerException) { }
    }
}

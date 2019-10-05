using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class VAException : Exception
    {
        public VAException(string message) : base(message)
        {
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeApp.Exceptions
{
    internal class NotFoundException : Exception
    {
        public NotFoundException(string name) : base($"{name} not found")
        {
        }
        public NotFoundException() : base("Not found")
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeApp.Exceptions
{
    internal class ClassNotFoundException : NotFoundException
    {
        public ClassNotFoundException(string c) : base($"Class {c}")
        {
        }
        public ClassNotFoundException() : base("Class not found")
        {
        }
    }
}

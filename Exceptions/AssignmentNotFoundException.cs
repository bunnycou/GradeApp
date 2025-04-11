using GradeApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeApp
{
    internal class AssignmentNotFoundException : NotFoundException
    {
        public AssignmentNotFoundException(string assignment) : base($"Assignment {assignment}")
        {
        }
        public AssignmentNotFoundException() : base("Assignment not found")
        {
        }
    }
}

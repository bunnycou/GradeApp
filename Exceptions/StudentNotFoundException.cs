using GradeApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeApp
{
    internal class StudentNotFoundException : NotFoundException
    {
        public StudentNotFoundException(string student) : base($"Student {student}")
        {
        }
        public StudentNotFoundException() : base("Student not found")
        {
        }
    }
}

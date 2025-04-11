using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeApp
{
    enum AssignmentType
    {
        Homework = 0,
        Test = 1,
    }

    internal class Assignment // assignment object for Classes (not object classes but the Class Object)
    {
        public string Name { get; set; } // name of assignment
        public int MaxPoints { get; set; } // maximum points earnable
        public AssignmentType Type { get; set; } // type of assignment (homework/test)
        public Assignment(string name, int maxPoints, AssignmentType type)
        {
            Name = name;
            MaxPoints = maxPoints;
            Type = type;
        }
    }

    internal class GradedAssignment : Assignment // assignment object on students
    {
        public int PointsEarned { get; set; }

        public double getGrade(int round = 2)
        {
            return Math.Round((double)PointsEarned / MaxPoints * 100, round); // calculate grade as a percentage
        }
        public GradedAssignment(Assignment assignment, int pointsEarned = 0) : base(assignment.Name, assignment.MaxPoints, assignment.Type)
        { // default to 0 points when populating new student with assignments
            PointsEarned = pointsEarned; // create new graded assignment with points earned
        }
        [JsonConstructor]// constructor for JSON deserialization
        public GradedAssignment(string name, int maxPoints, AssignmentType type, int pointsEarned) : base(name, maxPoints, type)
        { 
            PointsEarned = pointsEarned;
        }
    }
}

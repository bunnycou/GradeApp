using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeApp
{
    internal class Student
    {
        public string Name { get; set; } // name of student
        public List<GradedAssignment> Assignments { get; set; } // list of assignments for the student

        public Student(string name)
        {
            Name = name;
            Assignments = new List<GradedAssignment>();
        }

        public Tuple<int, int> GetPoints() // get earned points and total points
        {
            int points = 0; // points earned in all assignments
            int total = 0; // total points for all assignments

            if (Assignments.Count == 0) return new Tuple<int, int>(0, 0); // if no assignments, return (0, 0)

            foreach (GradedAssignment assignment in Assignments)
            {
                points += assignment.PointsEarned; // add up all the points earned
                total += assignment.MaxPoints; // add up all the points possible
            }
            return new Tuple<int, int>(points, total); // return the earned and total possible
        }

        public void AddAssignment(Assignment assignment) // add assignment to student
        {
            Assignments.Add(new GradedAssignment(assignment)); // create new graded assignment
        }
        public void EditAssignment(string assignment, int points)
        {
            GradedAssignment a = Assignments.Find(l => l.Name == assignment); // find the assignment by name
            a.MaxPoints = points; // set the max points for the assignment
            if (a.PointsEarned > a.MaxPoints) a.PointsEarned = a.MaxPoints; // if points earned is greater than max points, set it to max points
        }
        public void GradeAssignment(string assignment, int points)
        {
            try 
            {
                GradedAssignment a = Assignments.Find(l => l.Name == assignment); // find the assignment by name
                if (points > a.MaxPoints) throw new IndexOutOfRangeException("Points cannot exceed max points"); // if points are greater than max points, throw error
                if (points < 0) throw new IndexOutOfRangeException("Points cannot be negative"); // if points are negative, throw error
                a.PointsEarned = points; // set the points earned for the assignment
            }
            catch (IndexOutOfRangeException e) // catch the error
            {
                MessageBox.Show(e.Message); // show the error message
            }

        }

        public string GetAverageString() // get the average grade for the student
        {
            Tuple<int, int> allPoints = GetPoints(); // get the points
            int points = allPoints.Item1; // points earned
            int total = allPoints.Item2; // total points possible
            double average = Math.Round((double)points / total * 100, 2); // calculate average as a percentage
            string grade = Util.AlphaGrade(average); // get letter grade
            return $"{points}/{total} ({average}%) {grade}";
        }

        public string GetAssignmentGradeString(string assignment)
        {
            GradedAssignment a = Assignments.Find(l => l.Name == assignment);
            int points = a.PointsEarned; // points earned
            int total = a.MaxPoints; // total points possible
            double average = Math.Round((double)points / total * 100, 2); // calculate average as a percentage
            string grade = Util.AlphaGrade(average); // get letter grade
            return $"{points}/{total} ({average}%) {grade}"; // return the string
        }
    }
}

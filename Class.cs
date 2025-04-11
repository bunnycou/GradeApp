using GradeApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GradeApp
{
    internal class Class
    {

        public string Name { get; set; } // identifying name of class
        public List<Student> Students { get; set; } // list of students in class
        public List<Assignment> Assignments { get; set; } // list of assignments for the class
        public Class(string className)
        {
            Name = className;
            Students = new List<Student>();
            Assignments = new List<Assignment>();
        }

        public void AddStudent(string studentName) // create new student and populate their profile with assignments
        {
            Student student = new Student(studentName);
            if (Assignments.Count != 0)
            {
                foreach (Assignment assignment in Assignments)
                {
                    student.AddAssignment(assignment); // add assignment to student
                }
            }
            Students.Add(student); // add student to class with assignments
        }

        public void AddAssignment(string name, int maxPoints, AssignmentType type) // add assignment to class
        {
            Assignment assignment = new Assignment(name, maxPoints, type); // create new assignment
            Assignments.Add(assignment); // add assignment to class
            if (Students.Count == 0) return; // if no students, return
            foreach (Student student in Students)
            {
                student.AddAssignment(assignment); // add assignment to all students
            }
        }

        public void EditAssignment(string name, string newName, int maxPoints)
        {
            Assignment assignment = Assignments.Find(l => l.Name == name); // find assignment by name
            assignment.MaxPoints = maxPoints; // set max points for assignment
            foreach (Student student in Students)
            {
                student.EditAssignment(name, maxPoints); // edit all students' assignments
            }
        }

        public void RemoveAssignment(string name)
        {
            Assignments.Remove(Assignments.Find(l => l.Name == name));
            foreach (Student student in Students)
            {
                student.Assignments.Remove(student.Assignments.Find(l => l.Name == name)); // remove assignment from all students
            }
        }

        public void GradeStudent(string student, string assignment, int points)
        {
            try
            {
                Student s = Students.Find(l => l.Name == student); // find student by name
                if (s == null) throw new StudentNotFoundException(student); // if student not found throw error
                GradedAssignment a = s.Assignments.Find(l => l.Name == assignment); // find assignment by name
                if (a == null) throw new AssignmentNotFoundException(assignment); // if assignment not found throw error
                a.PointsEarned = points; // set points earned for assignment
            }
            catch(NotFoundException e)
            {
                MessageBox.Show(e.Message); // show error message
            }
        }

        public string GetOverallAverageString()
        {
            int points = 0; // points earned in all assignments
            int total = 0; // total points for all assignments
            foreach (Student student in Students)
            {
                Tuple<int, int> studentPoints = student.GetPoints(); // get all points for student
                points += studentPoints.Item1; // add up all the points earned
                total += studentPoints.Item2; // add up all the points possible
            }
            double average = Math.Round((double)points / total * 100, 2); // calculate average as a percentage
            string grade = Util.AlphaGrade(average); // get letter grade
            return $"{points}/{total} ({average}%) {grade}";
        }

        public string GetAssignmentAverageString(string assignment)
        {
            int points = 0; // points earned in all assignments
            int total = 0; // total points for all assignments
            foreach (Student student in Students)
            {
                GradedAssignment a = student.Assignments.Find(l => l.Name == assignment); // find assignment by name
                points += a.PointsEarned; // add up all the points earned
                total += a.MaxPoints; // add up all the points possible
            }
            double average = Math.Round((double)points / total * 100, 2); // calculate average as a percentage
            string grade = Util.AlphaGrade(average); // get letter grade
            return $"{points}/{total} ({average}%) {grade}";
        }
    }
}

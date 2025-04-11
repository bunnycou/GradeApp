using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeApp
{
    internal static class Util
    {
        public static List<Class> classes = new List<Class>(); // List of Classes that contain students and assignments

        public static void SaveData()
        {
            string json = JsonConvert.SerializeObject(classes);
            File.WriteAllText("data.json", json); // This will create or overwrite the file
        }


        public static void LoadData() // reads the json file and loads the classes into the list
        {
            if (File.Exists("data.json")) // check if the file exists
            {
                string json = File.ReadAllText("data.json");
                List<Class> jsonData = JsonConvert.DeserializeObject<List<Class>>(json);
                classes = jsonData; // load the data into the classes list
            }
        }

        public static string AlphaGrade(double score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        public static void LoadSampleData() // loads sample data into the classes list
        {
            classes.Clear();

            // Chemistry Class
            Class class1 = new Class("Chemistry");
            class1.AddAssignment("Chemistry Lab 1", 100, AssignmentType.Homework);
            class1.AddAssignment("Chemistry Lab 2", 100, AssignmentType.Homework);
            class1.AddAssignment("Chemistry Exam 1", 200, AssignmentType.Test);
            class1.AddStudent("Peter Parker");
            class1.AddStudent("Flash Thompson");
            class1.AddStudent("Gwen Stacy");
            class1.GradeStudent("Peter Parker", "Chemistry Lab 1", 100);
            class1.GradeStudent("Peter Parker", "Chemistry Lab 2", 100);
            class1.GradeStudent("Peter Parker", "Chemistry Exam 1", 200);
            class1.GradeStudent("Flash Thompson", "Chemistry Lab 1", 50);
            class1.GradeStudent("Flash Thompson", "Chemistry Lab 2", 50);
            class1.GradeStudent("Flash Thompson", "Chemistry Exam 1", 100);
            class1.GradeStudent("Gwen Stacy", "Chemistry Lab 1", 90);
            class1.GradeStudent("Gwen Stacy", "Chemistry Lab 2", 75);
            class1.GradeStudent("Gwen Stacy", "Chemistry Exam 1", 167);
            classes.Add(class1);

            // Mechatronics Class
            Class class2 = new Class("Mechatronics");
            class2.AddAssignment("Electronics Lab 1", 100, AssignmentType.Homework);
            class2.AddAssignment("Electronics Lab 2", 100, AssignmentType.Homework);
            class2.AddAssignment("Electronics Exam 1", 200, AssignmentType.Test);
            class2.AddStudent("Bruce Wayne");
            class2.AddStudent("Lucius Fox");
            class2.AddStudent("Barbara Gordon");
            class2.GradeStudent("Bruce Wayne", "Electronics Lab 1", 100);
            class2.GradeStudent("Bruce Wayne", "Electronics Lab 2", 100);
            class2.GradeStudent("Bruce Wayne", "Electronics Exam 1", 200);
            class2.GradeStudent("Lucius Fox", "Electronics Lab 1", 50);
            class2.GradeStudent("Lucius Fox", "Electronics Lab 2", 50);
            class2.GradeStudent("Lucius Fox", "Electronics Exam 1", 100);
            class2.GradeStudent("Barbara Gordon", "Electronics Lab 1", 90);
            class2.GradeStudent("Barbara Gordon", "Electronics Lab 2", 75);
            class2.GradeStudent("Barbara Gordon", "Electronics Exam 1", 167);
            classes.Add(class2);
        }
    }
}

using GradeApp.Exceptions;
using GradeApp.Forms;
using System;
using System.Windows.Forms;

namespace GradeApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Util.LoadData(); // load data from json file if it exists

            InitializeComponent();

            FreshForm(); // intialize the form to default state
        }

        private void FreshForm() // reset form to default state, does not clear data
        {
            // Disable everything
            // class parts
            ResetClass();
            // student parts
            ResetStudent();
            // homework parts
            ResetHomework();
            // test parts
            ResetTest();
        }

        private void ResetClass()
        {
            btnClassEdit.Enabled = false;
            btnClassDelete.Enabled = false;
            btnClassCreate.Enabled = true; // THIS BUTTON IS ALWAYS ON
            cbClasses.Enabled = true; // This should always be 
            cbClasses.Items.Clear(); // clear the class combo box
            cbClasses.Text = "";
            cbClasses.SelectedIndex = -1; // clear selection
            lblClassName.Text = "Class: None";
            lblClassStudentCount.Text = "Students: 0";
            lblClassAssignmentCount.Text = "Homework: 0 | Tests: 0";
            lblClassAverages.Text = "Class Average: 0/0 (0%) F";
            
            foreach (Class c in Util.classes) // populate the class combo box with the names of the classes
            {
                cbClasses.Items.Add(c.Name);
            }

            Util.SaveData();
        }
        private void ResetStudent()
        {
            btnStudentEdit.Enabled = false;
            btnStudentDelete.Enabled = false;
            btnStudentCreate.Enabled = false;
            cbStudents.Enabled = false;
            cbStudents.Items.Clear();
            cbStudents.Text = "";
            cbStudents.SelectedIndex = -1;
            lblStudentName.Text = "Student: None";
            lblStudentAverage.Text = "Average: 0/0 (0%) F";
            if (cbClasses.SelectedIndex != -1)
            {
                Class c = Util.classes.Find(l => l.Name == cbClasses.Text);
                btnStudentCreate.Enabled = true;
                cbStudents.Enabled = true;
                foreach (Student s in c.Students)
                {
                    cbStudents.Items.Add(s.Name);
                }
            }

            Util.SaveData();
        }
        private void ResetHomework()
        {
            btnHomeworkEdit.Enabled = false;
            btnHomeworkDelete.Enabled = false;
            btnHomeworkCreate.Enabled = false;
            btnHomeworkGrade.Enabled = false;
            cbHomework.Enabled = false;
            cbHomework.Items.Clear();
            cbHomework.Text = "";
            cbHomework.SelectedIndex = -1;
            lblHomeworkName.Text = "Homework: None";
            lblHomeworkAverage.Text = "Class Average: 0/0 (0%) F";
            lblHomeworkStudent.Text = "Student's Grade: 0/0 (0%) F";
            if (cbClasses.SelectedIndex != -1)
            {
                Class c = Util.classes.Find(l => l.Name == cbClasses.Text);
                btnHomeworkCreate.Enabled = true;
                cbHomework.Enabled = true;
                foreach (Assignment a in c.Assignments.FindAll(l => l.Type == AssignmentType.Homework))
                {
                    cbHomework.Items.Add(a.Name);
                }
            }

            Util.SaveData();
        }
        private void ResetTest()
        {
            btnTestEdit.Enabled = false;
            btnTestDelete.Enabled = false;
            btnTestCreate.Enabled = false;
            btnTestGrade.Enabled = false;
            cbTests.Enabled = false;
            cbTests.Items.Clear();
            cbTests.Text = "";
            cbTests.SelectedIndex = -1;
            lblTestName.Text = "Test: None";
            lblTestAverage.Text = "Class Average: 0/0 (0%) F";
            lblTestStudent.Text = "Student's Grade: 0/0 (0%) F";
            if (cbClasses.SelectedIndex != -1)
            {
                Class c = Util.classes.Find(l => l.Name == cbClasses.Text);
                btnTestCreate.Enabled = true;
                cbTests.Enabled = true;
                foreach (Assignment a in c.Assignments.FindAll(l => l.Type == AssignmentType.Test))
                {
                    cbTests.Items.Add(a.Name);
                }
            }

            Util.SaveData();
        }

        private void tsmiLoadSampleData_Click(object sender, EventArgs e)
        {
            Util.LoadSampleData(); // load sample data into the classes list
            FreshForm();
            Util.SaveData(); // save the loaded sample data to json file
        }

        private void tsmiEraseData_Click(object sender, EventArgs e)
        {
            Util.classes.Clear(); // clear the classes list
            FreshForm();
            Util.SaveData(); // save the cleared classes list to json file
        }

        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // If a class is selected, enable the edit and delete buttons and fill the other fields
                if (cbClasses.SelectedIndex == -1) return;
                Class c = Util.classes.Find(l => l.Name == cbClasses.Text);
                if (c == null) throw new ClassNotFoundException(cbClasses.Text);
                btnClassEdit.Enabled = true;
                btnClassDelete.Enabled = true;
                // fill fields
                lblClassName.Text = "Class: " + c.Name;
                lblClassStudentCount.Text = "Students: " + c.Students.Count;
                lblClassAssignmentCount.Text = "Homework: " + c.Assignments.FindAll(l => l.Type == AssignmentType.Homework).Count + " | Tests: " + c.Assignments.FindAll(l => l.Type == AssignmentType.Test).Count;
                lblClassAverages.Text = "Class Average: " + c.GetOverallAverageString();

                // Enable student create button and populate student combo box with the names of the students, clear any selection
                ResetStudent();

                // Enable homework create button and populate homework combo box with assigments, clear any selection
                ResetHomework();

                // Enable test create button and populate test combo box with tests, clear any selection
                ResetTest();
            }
            catch (NotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Enable edit and delete if a student is selected and update the displayed data
                if (cbStudents.SelectedIndex == -1) return;
                Class c = Util.classes.Find(l => l.Name == cbClasses.Text);
                if (c == null) throw new ClassNotFoundException(cbClasses.Text);
                Student s = c.Students.Find(l => l.Name == cbStudents.Text);
                if (s == null) throw new StudentNotFoundException(cbStudents.Text);
                btnStudentEdit.Enabled = true;
                btnStudentDelete.Enabled = true;
                CheckGradeButtons();
                // Update the displayed data
                lblStudentName.Text = "Student: " + s.Name;
                lblStudentAverage.Text = "Average: " + s.GetAverageString();
                CheckGradeDisplay();
            }
            catch (NotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbHomework_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Enable edit and delete if an assignment is selected and update the displayed data
                if (cbHomework.SelectedIndex == -1) return;
                Class c = Util.classes.Find(l => l.Name == cbClasses.Text);
                if (c == null) throw new ClassNotFoundException(cbClasses.Text);
                Assignment a = c.Assignments.Find(l => l.Name == cbHomework.Text);
                if (a == null) throw new AssignmentNotFoundException(cbHomework.Text);
                btnHomeworkEdit.Enabled = true;
                btnHomeworkDelete.Enabled = true;
                CheckGradeButtons();
                // Update displayed data
                lblHomeworkName.Text = "Homework: " + a.Name;
                lblHomeworkAverage.Text = "Class Average: " + c.GetAssignmentAverageString(a.Name);
                CheckGradeDisplay();
            }
            catch (NotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Enable edit and delete if an assignment is selected and update the displayed data
                if (cbTests.SelectedIndex == -1) return;
                Class c = Util.classes.Find(l => l.Name == cbClasses.Text);
                if (c == null) throw new ClassNotFoundException(cbClasses.Text);
                Assignment a = c.Assignments.Find(l => l.Name == cbTests.Text);
                if (a == null) throw new AssignmentNotFoundException(cbTests.Text);
                btnTestEdit.Enabled = true;
                btnTestDelete.Enabled = true;
                CheckGradeButtons();
                // Update displayed data
                lblTestName.Text = "Test: " + a.Name;
                lblTestAverage.Text = "Class Average: " + c.GetAssignmentAverageString(a.Name);
                CheckGradeDisplay();
            }
            catch (NotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckGradeButtons()
        {
            try
            {
                // Check if a student is selected and enable the grade buttons
                if (cbStudents.SelectedIndex == -1) return;
                Class c = Util.classes.Find(l => l.Name == cbClasses.Text);
                if (c == null) throw new ClassNotFoundException(cbClasses.Text);
                Student s = c.Students.Find(l => l.Name == cbStudents.Text);
                if (s == null) throw new StudentNotFoundException(cbStudents.Text);
                Assignment hw = c.Assignments.Find(l => l.Name == cbHomework.Text);
                if (hw != null) btnHomeworkGrade.Enabled = true;
                Assignment test = c.Assignments.Find(l => l.Name == cbTests.Text);
                if (test != null) btnTestGrade.Enabled = true;
            }
            catch (NotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckGradeDisplay()
        {
            try
            {
                // Check if a student is selected and display scores as needed
                if (cbStudents.SelectedIndex == -1) return;
                Class c = Util.classes.Find(l => l.Name == cbClasses.Text);
                if (c == null) throw new ClassNotFoundException(cbClasses.Text);
                Student s = c.Students.Find(l => l.Name == cbStudents.Text);
                if (s == null) throw new StudentNotFoundException(cbStudents.Text);
                Assignment hw = c.Assignments.Find(l => l.Name == cbHomework.Text);
                if (hw != null) lblHomeworkStudent.Text = s.Name + "'s Grade: " + s.GetAssignmentGradeString(hw.Name);
                Assignment test = c.Assignments.Find(l => l.Name == cbTests.Text);
                if (test != null) lblTestStudent.Text = s.Name + "'s Grade: " + s.GetAssignmentGradeString(test.Name);

            }
            catch (NotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClassCreate_Click(object sender, EventArgs e)
        {
            CreateEdit createEdit = new CreateEdit("Class");
            createEdit.Show();
            Enabled = false;
            while (createEdit.Visible) Application.DoEvents(); // wait for the create/edit form to close
            Enabled = true;
            Activate(); // activate otherwise it minimizes or hides
            if (createEdit.NewName != "") Util.classes.Add(new Class(createEdit.NewName));

            FreshForm();
        }

        private void btnClassEdit_Click(object sender, EventArgs e)
        {
            CreateEdit createEdit = new CreateEdit("Class", cbClasses.Text);
            createEdit.Show();
            Enabled = false;
            while (createEdit.Visible) Application.DoEvents(); // wait for the create/edit form to close
            Enabled = true;
            Activate(); // activate otherwise it minimizes or hides
            if (createEdit.NewName != "") Util.classes.Find(l => l.Name == cbClasses.Text).Name = createEdit.NewName;

            FreshForm();
        }

        private void btnClassDelete_Click(object sender, EventArgs e)
        {
            Util.classes.Remove(Util.classes.Find(l => l.Name == cbClasses.Text));

            FreshForm();
        }

        private void btnStudentCreate_Click(object sender, EventArgs e)
        {
            CreateEdit createEdit = new CreateEdit("Student");
            createEdit.Show();
            Enabled = false;
            while (createEdit.Visible) Application.DoEvents(); // wait for the create/edit form to close
            Enabled = true;
            Activate(); // activate otherwise it minimizes or hides
            if (createEdit.NewName != "") Util.classes.Find(l => l.Name == cbClasses.Text).Students.Add(new Student(createEdit.NewName));

            ResetStudent();
            ResetHomework();
            ResetTest();
        }

        private void btnStudentEdit_Click(object sender, EventArgs e)
        {
            CreateEdit createEdit = new CreateEdit("Student", cbStudents.Text);
            createEdit.Show();
            Enabled = false;
            while (createEdit.Visible) Application.DoEvents(); // wait for the create/edit form to close
            Enabled = true;
            Activate(); // activate otherwise it minimizes or hides
            if (createEdit.NewName != "") Util.classes.Find(l => l.Name == cbClasses.Text).Students.Find(l => l.Name == cbStudents.Text).Name = createEdit.NewName;

            ResetStudent();
            ResetHomework();
            ResetTest();
        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            Class c = Util.classes.Find(l => l.Name == cbClasses.Text);
            c.Students.Remove(c.Students.Find(l => l.Name == cbStudents.Text));
            
            ResetStudent();
            ResetHomework();
            ResetTest();
        }

        private void btnHomeworkCreate_Click(object sender, EventArgs e)
        {
            CreateEditAssignment createEditAssignment = new CreateEditAssignment("Homework");
            createEditAssignment.Show();
            Enabled = false;
            while (createEditAssignment.Visible) Application.DoEvents(); // wait for the create/edit form to close
            Enabled = true;
            Activate(); // activate otherwise it minimizes or hides
            if (createEditAssignment.NewName != "")
            {
                Class c = Util.classes.Find(l => l.Name == cbClasses.Text);
                c.AddAssignment(createEditAssignment.NewName, createEditAssignment.NewMaxPoints, AssignmentType.Homework); // add assignment to class   
            }
            
            ResetHomework();
            ResetStudent();
        }

        private void btnHomeworkEdit_Click(object sender, EventArgs e)
        {
            Class c = Util.classes.Find(l => l.Name == cbClasses.Text);
            CreateEditAssignment createEditAssignment = new CreateEditAssignment("Homework", cbHomework.Text, c.Assignments.Find(l => l.Name == cbHomework.Text).MaxPoints);
            createEditAssignment.Show();
            Enabled = false;
            while (createEditAssignment.Visible) Application.DoEvents(); // wait for the create/edit form to close
            Enabled = true;
            Activate(); // activate otherwise it minimizes or hides
            if (createEditAssignment.NewName != "") c.EditAssignment(cbHomework.Text, createEditAssignment.NewName, createEditAssignment.NewMaxPoints); // edit assignment in class

            ResetHomework();
            ResetStudent();
        }

        private void btnHomeworkDelete_Click(object sender, EventArgs e)
        {
            Class c = Util.classes.Find(l => l.Name == cbClasses.Text);
            c.RemoveAssignment(cbHomework.Text); // remove assignment from class

            ResetHomework();
            ResetStudent();
        }

        private void btnTestCreate_Click(object sender, EventArgs e)
        {
            CreateEditAssignment createEditAssignment = new CreateEditAssignment("Test");
            createEditAssignment.Show();
            Enabled = false;
            while (createEditAssignment.Visible) Application.DoEvents(); // wait for the create/edit form to close
            Enabled = true;
            Activate(); // activate otherwise it minimizes or hides
            if (createEditAssignment.NewName != "")
            {
                Class c = Util.classes.Find(l => l.Name == cbClasses.Text);
                c.AddAssignment(createEditAssignment.NewName, createEditAssignment.NewMaxPoints, AssignmentType.Test); // add assignment to class   
            }

            ResetTest();
            ResetStudent();
        }

        private void btnTestEdit_Click(object sender, EventArgs e)
        {
            Class c = Util.classes.Find(l => l.Name == cbClasses.Text);
            CreateEditAssignment createEditAssignment = new CreateEditAssignment("Test", cbTests.Text, c.Assignments.Find(l => l.Name == cbTests.Text).MaxPoints);
            createEditAssignment.Show();
            Enabled = false;
            while (createEditAssignment.Visible) Application.DoEvents(); // wait for the create/edit form to close
            Enabled = true;
            Activate(); // activate otherwise it minimizes or hides
            if (createEditAssignment.NewName != "") c.EditAssignment(cbTests.Text, createEditAssignment.NewName, createEditAssignment.NewMaxPoints); // edit assignment in class

            ResetTest();
            ResetStudent();
        }

        private void btnTestDelete_Click(object sender, EventArgs e)
        {
            Class c = Util.classes.Find(l => l.Name == cbClasses.Text);
            c.RemoveAssignment(cbTests.Text); // remove assignment from class

            ResetTest();
            ResetStudent();
        }

        private void btnHomeworkGrade_Click(object sender, EventArgs e)
        {
            Class c = Util.classes.Find(l => l.Name == cbClasses.Text);
            Student s = c.Students.Find(l => l.Name == cbStudents.Text);
            GradedAssignment a = s.Assignments.Find(l => l.Name == cbHomework.Text);
            Grade grade = new Grade(a.Name, s.Name, a.PointsEarned, a.MaxPoints);
            grade.Show();
            Enabled = false;
            while (grade.Visible) Application.DoEvents(); // wait for the grade form to close
            Enabled = true;
            Activate(); // activate otherwise it minimizes or hides
            if (grade.points != -1) c.GradeStudent(s.Name, a.Name, grade.points); // if points are not -1, set the points earned for the assignment

            ResetHomework();
            ResetStudent();
        }

        private void btnTestGrade_Click(object sender, EventArgs e)
        {
            Class c = Util.classes.Find(l => l.Name == cbClasses.Text);
            Student s = c.Students.Find(l => l.Name == cbStudents.Text);
            GradedAssignment a = s.Assignments.Find(l => l.Name == cbTests.Text);
            Grade grade = new Grade(a.Name, s.Name, a.PointsEarned, a.MaxPoints);
            grade.Show();
            Enabled = false;
            while (grade.Visible) Application.DoEvents(); // wait for the grade form to close
            Enabled = true;
            Activate(); // activate otherwise it minimizes or hides
            if (grade.points != -1) c.GradeStudent(s.Name, a.Name, grade.points); // if points are not -1, set the points earned for the assignment

            ResetTest();
            ResetStudent();
        }
    }
}

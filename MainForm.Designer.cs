namespace GradeApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsddbDebug = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiLoadSampleData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEraseData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAbout = new System.Windows.Forms.ToolStripButton();
            this.cbClasses = new System.Windows.Forms.ComboBox();
            this.gbClass = new System.Windows.Forms.GroupBox();
            this.lblClassAverages = new System.Windows.Forms.Label();
            this.lblClassAssignmentCount = new System.Windows.Forms.Label();
            this.lblClassStudentCount = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.btnClassCreate = new System.Windows.Forms.Button();
            this.btnClassDelete = new System.Windows.Forms.Button();
            this.btnClassEdit = new System.Windows.Forms.Button();
            this.gbStudents = new System.Windows.Forms.GroupBox();
            this.btnStudentCreate = new System.Windows.Forms.Button();
            this.lblStudentAverage = new System.Windows.Forms.Label();
            this.btnStudentDelete = new System.Windows.Forms.Button();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.btnStudentEdit = new System.Windows.Forms.Button();
            this.cbStudents = new System.Windows.Forms.ComboBox();
            this.gbHomework = new System.Windows.Forms.GroupBox();
            this.btnHomeworkGrade = new System.Windows.Forms.Button();
            this.lblHomeworkStudent = new System.Windows.Forms.Label();
            this.btnHomeworkCreate = new System.Windows.Forms.Button();
            this.lblHomeworkAverage = new System.Windows.Forms.Label();
            this.btnHomeworkDelete = new System.Windows.Forms.Button();
            this.lblHomeworkName = new System.Windows.Forms.Label();
            this.btnHomeworkEdit = new System.Windows.Forms.Button();
            this.cbHomework = new System.Windows.Forms.ComboBox();
            this.gbTests = new System.Windows.Forms.GroupBox();
            this.btnTestGrade = new System.Windows.Forms.Button();
            this.lblTestStudent = new System.Windows.Forms.Label();
            this.btnTestCreate = new System.Windows.Forms.Button();
            this.lblTestAverage = new System.Windows.Forms.Label();
            this.btnTestDelete = new System.Windows.Forms.Button();
            this.lblTestName = new System.Windows.Forms.Label();
            this.btnTestEdit = new System.Windows.Forms.Button();
            this.cbTests = new System.Windows.Forms.ComboBox();
            this.tsMain.SuspendLayout();
            this.gbClass.SuspendLayout();
            this.gbStudents.SuspendLayout();
            this.gbHomework.SuspendLayout();
            this.gbTests.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbDebug,
            this.tsbAbout});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(634, 25);
            this.tsMain.TabIndex = 0;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsddbDebug
            // 
            this.tsddbDebug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbDebug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLoadSampleData,
            this.tsmiEraseData});
            this.tsddbDebug.Image = ((System.Drawing.Image)(resources.GetObject("tsddbDebug.Image")));
            this.tsddbDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbDebug.Name = "tsddbDebug";
            this.tsddbDebug.Size = new System.Drawing.Size(44, 22);
            this.tsddbDebug.Text = "Data";
            // 
            // tsmiLoadSampleData
            // 
            this.tsmiLoadSampleData.Name = "tsmiLoadSampleData";
            this.tsmiLoadSampleData.Size = new System.Drawing.Size(180, 22);
            this.tsmiLoadSampleData.Text = "Load Sample Data";
            this.tsmiLoadSampleData.Click += new System.EventHandler(this.tsmiLoadSampleData_Click);
            // 
            // tsmiEraseData
            // 
            this.tsmiEraseData.Name = "tsmiEraseData";
            this.tsmiEraseData.Size = new System.Drawing.Size(180, 22);
            this.tsmiEraseData.Text = "Erase Data";
            this.tsmiEraseData.Click += new System.EventHandler(this.tsmiEraseData_Click);
            // 
            // tsbAbout
            // 
            this.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsbAbout.Image")));
            this.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbout.Name = "tsbAbout";
            this.tsbAbout.Size = new System.Drawing.Size(44, 22);
            this.tsbAbout.Text = "About";
            // 
            // cbClasses
            // 
            this.cbClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasses.FormattingEnabled = true;
            this.cbClasses.Location = new System.Drawing.Point(6, 19);
            this.cbClasses.Name = "cbClasses";
            this.cbClasses.Size = new System.Drawing.Size(121, 21);
            this.cbClasses.TabIndex = 1;
            this.cbClasses.SelectedIndexChanged += new System.EventHandler(this.cbClasses_SelectedIndexChanged);
            // 
            // gbClass
            // 
            this.gbClass.Controls.Add(this.lblClassAverages);
            this.gbClass.Controls.Add(this.lblClassAssignmentCount);
            this.gbClass.Controls.Add(this.lblClassStudentCount);
            this.gbClass.Controls.Add(this.lblClassName);
            this.gbClass.Controls.Add(this.btnClassCreate);
            this.gbClass.Controls.Add(this.btnClassDelete);
            this.gbClass.Controls.Add(this.btnClassEdit);
            this.gbClass.Controls.Add(this.cbClasses);
            this.gbClass.Location = new System.Drawing.Point(12, 28);
            this.gbClass.Name = "gbClass";
            this.gbClass.Size = new System.Drawing.Size(300, 137);
            this.gbClass.TabIndex = 3;
            this.gbClass.TabStop = false;
            this.gbClass.Text = "Class";
            // 
            // lblClassAverages
            // 
            this.lblClassAverages.AutoSize = true;
            this.lblClassAverages.Location = new System.Drawing.Point(6, 110);
            this.lblClassAverages.Name = "lblClassAverages";
            this.lblClassAverages.Size = new System.Drawing.Size(138, 13);
            this.lblClassAverages.TabIndex = 8;
            this.lblClassAverages.Text = "Overall Average: 0/0 (0%) F";
            // 
            // lblClassAssignmentCount
            // 
            this.lblClassAssignmentCount.AutoSize = true;
            this.lblClassAssignmentCount.Location = new System.Drawing.Point(6, 90);
            this.lblClassAssignmentCount.Name = "lblClassAssignmentCount";
            this.lblClassAssignmentCount.Size = new System.Drawing.Size(114, 13);
            this.lblClassAssignmentCount.TabIndex = 7;
            this.lblClassAssignmentCount.Text = "Homework: 0 | Test:  0";
            // 
            // lblClassStudentCount
            // 
            this.lblClassStudentCount.AutoSize = true;
            this.lblClassStudentCount.Location = new System.Drawing.Point(6, 70);
            this.lblClassStudentCount.Name = "lblClassStudentCount";
            this.lblClassStudentCount.Size = new System.Drawing.Size(61, 13);
            this.lblClassStudentCount.TabIndex = 6;
            this.lblClassStudentCount.Text = "Students: 0";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(6, 50);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(64, 13);
            this.lblClassName.TabIndex = 5;
            this.lblClassName.Text = "Class: None";
            // 
            // btnClassCreate
            // 
            this.btnClassCreate.Enabled = false;
            this.btnClassCreate.Location = new System.Drawing.Point(246, 16);
            this.btnClassCreate.Name = "btnClassCreate";
            this.btnClassCreate.Size = new System.Drawing.Size(50, 23);
            this.btnClassCreate.TabIndex = 4;
            this.btnClassCreate.Text = "Create";
            this.btnClassCreate.UseVisualStyleBackColor = true;
            this.btnClassCreate.Click += new System.EventHandler(this.btnClassCreate_Click);
            // 
            // btnClassDelete
            // 
            this.btnClassDelete.Enabled = false;
            this.btnClassDelete.Location = new System.Drawing.Point(190, 16);
            this.btnClassDelete.Name = "btnClassDelete";
            this.btnClassDelete.Size = new System.Drawing.Size(50, 23);
            this.btnClassDelete.TabIndex = 3;
            this.btnClassDelete.Text = "Delete";
            this.btnClassDelete.UseVisualStyleBackColor = true;
            this.btnClassDelete.Click += new System.EventHandler(this.btnClassDelete_Click);
            // 
            // btnClassEdit
            // 
            this.btnClassEdit.Enabled = false;
            this.btnClassEdit.Location = new System.Drawing.Point(134, 16);
            this.btnClassEdit.Name = "btnClassEdit";
            this.btnClassEdit.Size = new System.Drawing.Size(50, 23);
            this.btnClassEdit.TabIndex = 2;
            this.btnClassEdit.Text = "Edit";
            this.btnClassEdit.UseVisualStyleBackColor = true;
            this.btnClassEdit.Click += new System.EventHandler(this.btnClassEdit_Click);
            // 
            // gbStudents
            // 
            this.gbStudents.Controls.Add(this.btnStudentCreate);
            this.gbStudents.Controls.Add(this.lblStudentAverage);
            this.gbStudents.Controls.Add(this.btnStudentDelete);
            this.gbStudents.Controls.Add(this.lblStudentName);
            this.gbStudents.Controls.Add(this.btnStudentEdit);
            this.gbStudents.Controls.Add(this.cbStudents);
            this.gbStudents.Location = new System.Drawing.Point(12, 171);
            this.gbStudents.Name = "gbStudents";
            this.gbStudents.Size = new System.Drawing.Size(300, 103);
            this.gbStudents.TabIndex = 4;
            this.gbStudents.TabStop = false;
            this.gbStudents.Text = "Students";
            // 
            // btnStudentCreate
            // 
            this.btnStudentCreate.Enabled = false;
            this.btnStudentCreate.Location = new System.Drawing.Point(246, 16);
            this.btnStudentCreate.Name = "btnStudentCreate";
            this.btnStudentCreate.Size = new System.Drawing.Size(50, 23);
            this.btnStudentCreate.TabIndex = 4;
            this.btnStudentCreate.Text = "Create";
            this.btnStudentCreate.UseVisualStyleBackColor = true;
            this.btnStudentCreate.Click += new System.EventHandler(this.btnStudentCreate_Click);
            // 
            // lblStudentAverage
            // 
            this.lblStudentAverage.AutoSize = true;
            this.lblStudentAverage.Location = new System.Drawing.Point(6, 70);
            this.lblStudentAverage.Name = "lblStudentAverage";
            this.lblStudentAverage.Size = new System.Drawing.Size(102, 13);
            this.lblStudentAverage.TabIndex = 10;
            this.lblStudentAverage.Text = "Average: 0/0 (0%) F";
            // 
            // btnStudentDelete
            // 
            this.btnStudentDelete.Enabled = false;
            this.btnStudentDelete.Location = new System.Drawing.Point(190, 16);
            this.btnStudentDelete.Name = "btnStudentDelete";
            this.btnStudentDelete.Size = new System.Drawing.Size(50, 23);
            this.btnStudentDelete.TabIndex = 3;
            this.btnStudentDelete.Text = "Delete";
            this.btnStudentDelete.UseVisualStyleBackColor = true;
            this.btnStudentDelete.Click += new System.EventHandler(this.btnStudentDelete_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(6, 50);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(76, 13);
            this.lblStudentName.TabIndex = 9;
            this.lblStudentName.Text = "Student: None";
            // 
            // btnStudentEdit
            // 
            this.btnStudentEdit.Enabled = false;
            this.btnStudentEdit.Location = new System.Drawing.Point(134, 16);
            this.btnStudentEdit.Name = "btnStudentEdit";
            this.btnStudentEdit.Size = new System.Drawing.Size(50, 23);
            this.btnStudentEdit.TabIndex = 2;
            this.btnStudentEdit.Text = "Edit";
            this.btnStudentEdit.UseVisualStyleBackColor = true;
            this.btnStudentEdit.Click += new System.EventHandler(this.btnStudentEdit_Click);
            // 
            // cbStudents
            // 
            this.cbStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudents.Enabled = false;
            this.cbStudents.FormattingEnabled = true;
            this.cbStudents.Location = new System.Drawing.Point(6, 19);
            this.cbStudents.Name = "cbStudents";
            this.cbStudents.Size = new System.Drawing.Size(121, 21);
            this.cbStudents.TabIndex = 1;
            this.cbStudents.SelectedIndexChanged += new System.EventHandler(this.cbStudents_SelectedIndexChanged);
            // 
            // gbHomework
            // 
            this.gbHomework.Controls.Add(this.btnHomeworkGrade);
            this.gbHomework.Controls.Add(this.lblHomeworkStudent);
            this.gbHomework.Controls.Add(this.btnHomeworkCreate);
            this.gbHomework.Controls.Add(this.lblHomeworkAverage);
            this.gbHomework.Controls.Add(this.btnHomeworkDelete);
            this.gbHomework.Controls.Add(this.lblHomeworkName);
            this.gbHomework.Controls.Add(this.btnHomeworkEdit);
            this.gbHomework.Controls.Add(this.cbHomework);
            this.gbHomework.Location = new System.Drawing.Point(318, 28);
            this.gbHomework.Name = "gbHomework";
            this.gbHomework.Size = new System.Drawing.Size(300, 120);
            this.gbHomework.TabIndex = 5;
            this.gbHomework.TabStop = false;
            this.gbHomework.Text = "Homework";
            // 
            // btnHomeworkGrade
            // 
            this.btnHomeworkGrade.Enabled = false;
            this.btnHomeworkGrade.Location = new System.Drawing.Point(246, 45);
            this.btnHomeworkGrade.Name = "btnHomeworkGrade";
            this.btnHomeworkGrade.Size = new System.Drawing.Size(50, 23);
            this.btnHomeworkGrade.TabIndex = 12;
            this.btnHomeworkGrade.Text = "Grade";
            this.btnHomeworkGrade.UseVisualStyleBackColor = true;
            this.btnHomeworkGrade.Click += new System.EventHandler(this.btnHomeworkGrade_Click);
            // 
            // lblHomeworkStudent
            // 
            this.lblHomeworkStudent.AutoSize = true;
            this.lblHomeworkStudent.Location = new System.Drawing.Point(6, 90);
            this.lblHomeworkStudent.Name = "lblHomeworkStudent";
            this.lblHomeworkStudent.Size = new System.Drawing.Size(138, 13);
            this.lblHomeworkStudent.TabIndex = 11;
            this.lblHomeworkStudent.Text = "Student\'s Grade: 0/0 (0%) F";
            // 
            // btnHomeworkCreate
            // 
            this.btnHomeworkCreate.Enabled = false;
            this.btnHomeworkCreate.Location = new System.Drawing.Point(246, 16);
            this.btnHomeworkCreate.Name = "btnHomeworkCreate";
            this.btnHomeworkCreate.Size = new System.Drawing.Size(50, 23);
            this.btnHomeworkCreate.TabIndex = 4;
            this.btnHomeworkCreate.Text = "Create";
            this.btnHomeworkCreate.UseVisualStyleBackColor = true;
            this.btnHomeworkCreate.Click += new System.EventHandler(this.btnHomeworkCreate_Click);
            // 
            // lblHomeworkAverage
            // 
            this.lblHomeworkAverage.AutoSize = true;
            this.lblHomeworkAverage.Location = new System.Drawing.Point(6, 70);
            this.lblHomeworkAverage.Name = "lblHomeworkAverage";
            this.lblHomeworkAverage.Size = new System.Drawing.Size(102, 13);
            this.lblHomeworkAverage.TabIndex = 10;
            this.lblHomeworkAverage.Text = "Average: 0/0 (0%) F";
            // 
            // btnHomeworkDelete
            // 
            this.btnHomeworkDelete.Enabled = false;
            this.btnHomeworkDelete.Location = new System.Drawing.Point(190, 16);
            this.btnHomeworkDelete.Name = "btnHomeworkDelete";
            this.btnHomeworkDelete.Size = new System.Drawing.Size(50, 23);
            this.btnHomeworkDelete.TabIndex = 3;
            this.btnHomeworkDelete.Text = "Delete";
            this.btnHomeworkDelete.UseVisualStyleBackColor = true;
            this.btnHomeworkDelete.Click += new System.EventHandler(this.btnHomeworkDelete_Click);
            // 
            // lblHomeworkName
            // 
            this.lblHomeworkName.AutoSize = true;
            this.lblHomeworkName.Location = new System.Drawing.Point(6, 50);
            this.lblHomeworkName.Name = "lblHomeworkName";
            this.lblHomeworkName.Size = new System.Drawing.Size(90, 13);
            this.lblHomeworkName.TabIndex = 9;
            this.lblHomeworkName.Text = "Homework: None";
            // 
            // btnHomeworkEdit
            // 
            this.btnHomeworkEdit.Enabled = false;
            this.btnHomeworkEdit.Location = new System.Drawing.Point(134, 16);
            this.btnHomeworkEdit.Name = "btnHomeworkEdit";
            this.btnHomeworkEdit.Size = new System.Drawing.Size(50, 23);
            this.btnHomeworkEdit.TabIndex = 2;
            this.btnHomeworkEdit.Text = "Edit";
            this.btnHomeworkEdit.UseVisualStyleBackColor = true;
            this.btnHomeworkEdit.Click += new System.EventHandler(this.btnHomeworkEdit_Click);
            // 
            // cbHomework
            // 
            this.cbHomework.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHomework.Enabled = false;
            this.cbHomework.FormattingEnabled = true;
            this.cbHomework.Location = new System.Drawing.Point(6, 19);
            this.cbHomework.Name = "cbHomework";
            this.cbHomework.Size = new System.Drawing.Size(121, 21);
            this.cbHomework.TabIndex = 1;
            this.cbHomework.SelectedIndexChanged += new System.EventHandler(this.cbHomework_SelectedIndexChanged);
            // 
            // gbTests
            // 
            this.gbTests.Controls.Add(this.btnTestGrade);
            this.gbTests.Controls.Add(this.lblTestStudent);
            this.gbTests.Controls.Add(this.btnTestCreate);
            this.gbTests.Controls.Add(this.lblTestAverage);
            this.gbTests.Controls.Add(this.btnTestDelete);
            this.gbTests.Controls.Add(this.lblTestName);
            this.gbTests.Controls.Add(this.btnTestEdit);
            this.gbTests.Controls.Add(this.cbTests);
            this.gbTests.Location = new System.Drawing.Point(318, 154);
            this.gbTests.Name = "gbTests";
            this.gbTests.Size = new System.Drawing.Size(300, 120);
            this.gbTests.TabIndex = 6;
            this.gbTests.TabStop = false;
            this.gbTests.Text = "Tests";
            // 
            // btnTestGrade
            // 
            this.btnTestGrade.Enabled = false;
            this.btnTestGrade.Location = new System.Drawing.Point(246, 45);
            this.btnTestGrade.Name = "btnTestGrade";
            this.btnTestGrade.Size = new System.Drawing.Size(50, 23);
            this.btnTestGrade.TabIndex = 13;
            this.btnTestGrade.Text = "Grade";
            this.btnTestGrade.UseVisualStyleBackColor = true;
            this.btnTestGrade.Click += new System.EventHandler(this.btnTestGrade_Click);
            // 
            // lblTestStudent
            // 
            this.lblTestStudent.AutoSize = true;
            this.lblTestStudent.Location = new System.Drawing.Point(6, 90);
            this.lblTestStudent.Name = "lblTestStudent";
            this.lblTestStudent.Size = new System.Drawing.Size(138, 13);
            this.lblTestStudent.TabIndex = 14;
            this.lblTestStudent.Text = "Student\'s Grade: 0/0 (0%) F";
            // 
            // btnTestCreate
            // 
            this.btnTestCreate.Enabled = false;
            this.btnTestCreate.Location = new System.Drawing.Point(246, 16);
            this.btnTestCreate.Name = "btnTestCreate";
            this.btnTestCreate.Size = new System.Drawing.Size(50, 23);
            this.btnTestCreate.TabIndex = 4;
            this.btnTestCreate.Text = "Create";
            this.btnTestCreate.UseVisualStyleBackColor = true;
            this.btnTestCreate.Click += new System.EventHandler(this.btnTestCreate_Click);
            // 
            // lblTestAverage
            // 
            this.lblTestAverage.AutoSize = true;
            this.lblTestAverage.Location = new System.Drawing.Point(6, 70);
            this.lblTestAverage.Name = "lblTestAverage";
            this.lblTestAverage.Size = new System.Drawing.Size(102, 13);
            this.lblTestAverage.TabIndex = 13;
            this.lblTestAverage.Text = "Average: 0/0 (0%) F";
            // 
            // btnTestDelete
            // 
            this.btnTestDelete.Enabled = false;
            this.btnTestDelete.Location = new System.Drawing.Point(190, 16);
            this.btnTestDelete.Name = "btnTestDelete";
            this.btnTestDelete.Size = new System.Drawing.Size(50, 23);
            this.btnTestDelete.TabIndex = 3;
            this.btnTestDelete.Text = "Delete";
            this.btnTestDelete.UseVisualStyleBackColor = true;
            this.btnTestDelete.Click += new System.EventHandler(this.btnTestDelete_Click);
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.Location = new System.Drawing.Point(6, 50);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(60, 13);
            this.lblTestName.TabIndex = 12;
            this.lblTestName.Text = "Test: None";
            // 
            // btnTestEdit
            // 
            this.btnTestEdit.Enabled = false;
            this.btnTestEdit.Location = new System.Drawing.Point(134, 16);
            this.btnTestEdit.Name = "btnTestEdit";
            this.btnTestEdit.Size = new System.Drawing.Size(50, 23);
            this.btnTestEdit.TabIndex = 2;
            this.btnTestEdit.Text = "Edit";
            this.btnTestEdit.UseVisualStyleBackColor = true;
            this.btnTestEdit.Click += new System.EventHandler(this.btnTestEdit_Click);
            // 
            // cbTests
            // 
            this.cbTests.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTests.Enabled = false;
            this.cbTests.FormattingEnabled = true;
            this.cbTests.Location = new System.Drawing.Point(6, 19);
            this.cbTests.Name = "cbTests";
            this.cbTests.Size = new System.Drawing.Size(121, 21);
            this.cbTests.TabIndex = 1;
            this.cbTests.SelectedIndexChanged += new System.EventHandler(this.cbTests_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 291);
            this.Controls.Add(this.gbTests);
            this.Controls.Add(this.gbHomework);
            this.Controls.Add(this.gbStudents);
            this.Controls.Add(this.gbClass);
            this.Controls.Add(this.tsMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "GradeApp";
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.gbClass.ResumeLayout(false);
            this.gbClass.PerformLayout();
            this.gbStudents.ResumeLayout(false);
            this.gbStudents.PerformLayout();
            this.gbHomework.ResumeLayout(false);
            this.gbHomework.PerformLayout();
            this.gbTests.ResumeLayout(false);
            this.gbTests.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripDropDownButton tsddbDebug;
        private System.Windows.Forms.ComboBox cbClasses;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadSampleData;
        private System.Windows.Forms.ToolStripMenuItem tsmiEraseData;
        private System.Windows.Forms.ToolStripButton tsbAbout;
        private System.Windows.Forms.GroupBox gbClass;
        private System.Windows.Forms.Button btnClassCreate;
        private System.Windows.Forms.Button btnClassDelete;
        private System.Windows.Forms.Button btnClassEdit;
        private System.Windows.Forms.GroupBox gbStudents;
        private System.Windows.Forms.Button btnStudentCreate;
        private System.Windows.Forms.Button btnStudentDelete;
        private System.Windows.Forms.Button btnStudentEdit;
        private System.Windows.Forms.ComboBox cbStudents;
        private System.Windows.Forms.GroupBox gbHomework;
        private System.Windows.Forms.Button btnHomeworkCreate;
        private System.Windows.Forms.Button btnHomeworkDelete;
        private System.Windows.Forms.Button btnHomeworkEdit;
        private System.Windows.Forms.ComboBox cbHomework;
        private System.Windows.Forms.GroupBox gbTests;
        private System.Windows.Forms.Button btnTestCreate;
        private System.Windows.Forms.Button btnTestDelete;
        private System.Windows.Forms.Button btnTestEdit;
        private System.Windows.Forms.ComboBox cbTests;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblClassAverages;
        private System.Windows.Forms.Label lblClassAssignmentCount;
        private System.Windows.Forms.Label lblClassStudentCount;
        private System.Windows.Forms.Label lblStudentAverage;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblHomeworkStudent;
        private System.Windows.Forms.Label lblHomeworkAverage;
        private System.Windows.Forms.Label lblHomeworkName;
        private System.Windows.Forms.Label lblTestStudent;
        private System.Windows.Forms.Label lblTestAverage;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.Button btnHomeworkGrade;
        private System.Windows.Forms.Button btnTestGrade;
    }
}


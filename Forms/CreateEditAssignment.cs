using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeApp.Forms
{
    public partial class CreateEditAssignment : Form
    {
        public string NewName { get; set; } // new name of the object being created/edited
        public int NewMaxPoints { get; set; } // new max points of the object being created/edited
        public CreateEditAssignment(string type)
        {
            InitializeComponent();
            Text = "Creating " + type;
        }
        public CreateEditAssignment(string type, string name, int maxPoints)
        {
            InitializeComponent();
            Text = "Editing " + type + ": " + name;
            txtName.Text = name;
            numMaxPoints.Value = maxPoints;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            NewName = txtName.Text; // get the name from the text box
            NewMaxPoints = (int)numMaxPoints.Value; // get the max points from the numeric up down
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NewName = "";
            NewMaxPoints = 0;
            Close();
        }
    }
}

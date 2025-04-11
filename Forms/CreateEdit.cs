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
    public partial class CreateEdit : Form
    {
        public string NewName { get; set; } // new name of the object being created/edited
        public CreateEdit(string type)
        {
            InitializeComponent();
            Text = "Creating " + type;
        }

        public CreateEdit(string type, string name)
        {
            InitializeComponent();
            Text = "Editing " + type + ": " + name;
            txtName.Text = name;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            NewName = txtName.Text; // get the name from the text box
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NewName = "";
            Close();
        }
    }
}

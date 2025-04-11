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
    public partial class Grade : Form
    {
        public int points { get; set; }
        public Grade(string assignment, string student, int points, int maxpoints)
        {
            InitializeComponent();
            Text = "Grading " + assignment + " for " + student;
            lblOldScore.Text = "Old Score: " + points;
            lblMax.Text = "Max Points: " + maxpoints;
            numScore.Maximum = maxpoints;
            numScore.Value = points;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            points = (int)numScore.Value;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            points = -1;
            Close();
        }
    }
}

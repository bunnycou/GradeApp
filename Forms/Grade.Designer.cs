namespace GradeApp.Forms
{
    partial class Grade
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
            this.lblScore = new System.Windows.Forms.Label();
            this.numScore = new System.Windows.Forms.NumericUpDown();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblOldScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(13, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(60, 13);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "New Score";
            // 
            // numScore
            // 
            this.numScore.Location = new System.Drawing.Point(16, 29);
            this.numScore.Name = "numScore";
            this.numScore.Size = new System.Drawing.Size(73, 20);
            this.numScore.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(13, 85);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(107, 85);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(111, 36);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(71, 13);
            this.lblMax.TabIndex = 4;
            this.lblMax.Text = "Max Points: 0";
            // 
            // lblOldScore
            // 
            this.lblOldScore.AutoSize = true;
            this.lblOldScore.Location = new System.Drawing.Point(116, 13);
            this.lblOldScore.Name = "lblOldScore";
            this.lblOldScore.Size = new System.Drawing.Size(66, 13);
            this.lblOldScore.TabIndex = 5;
            this.lblOldScore.Text = "Old Score: 0";
            // 
            // Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 130);
            this.ControlBox = false;
            this.Controls.Add(this.lblOldScore);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.numScore);
            this.Controls.Add(this.lblScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Grade";
            this.Text = "Grade";
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.NumericUpDown numScore;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblOldScore;
    }
}
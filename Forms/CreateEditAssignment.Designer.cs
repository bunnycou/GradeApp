namespace GradeApp.Forms
{
    partial class CreateEditAssignment
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.numMaxPoints = new System.Windows.Forms.NumericUpDown();
            this.lblNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(140, 117);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(12, 117);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 4;
            // 
            // numMaxPoints
            // 
            this.numMaxPoints.Location = new System.Drawing.Point(15, 68);
            this.numMaxPoints.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numMaxPoints.Name = "numMaxPoints";
            this.numMaxPoints.Size = new System.Drawing.Size(72, 20);
            this.numMaxPoints.TabIndex = 8;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(15, 52);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(59, 13);
            this.lblNumber.TabIndex = 9;
            this.lblNumber.Text = "Max Points";
            // 
            // CreateEditAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 161);
            this.ControlBox = false;
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.numMaxPoints);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateEditAssignment";
            this.Text = "CreateEditAssignment";
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numMaxPoints;
        private System.Windows.Forms.Label lblNumber;
    }
}
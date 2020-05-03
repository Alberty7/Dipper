namespace TimeTable
{
    partial class AddLessonForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.FatherName = new System.Windows.Forms.TextBox();
			this.FirstName = new System.Windows.Forms.TextBox();
			this.LastName = new System.Windows.Forms.TextBox();
			this.OK = new System.Windows.Forms.Button();
			this.SubjectName = new System.Windows.Forms.TextBox();
			this.AcademicHours = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.AcademicHours)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.FatherName);
			this.groupBox1.Controls.Add(this.FirstName);
			this.groupBox1.Controls.Add(this.LastName);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(142, 137);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Преподаватель";
			// 
			// FatherName
			// 
			this.FatherName.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.FatherName.Location = new System.Drawing.Point(18, 83);
			this.FatherName.Name = "FatherName";
			this.FatherName.Size = new System.Drawing.Size(100, 20);
			this.FatherName.TabIndex = 2;
			this.FatherName.Enter += new System.EventHandler(this.FatherName_Enter);
			this.FatherName.Leave += new System.EventHandler(this.FatherName_Leave);
			// 
			// FirstName
			// 
			this.FirstName.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.FirstName.Location = new System.Drawing.Point(18, 57);
			this.FirstName.Name = "FirstName";
			this.FirstName.Size = new System.Drawing.Size(100, 20);
			this.FirstName.TabIndex = 1;
			this.FirstName.Enter += new System.EventHandler(this.FirstName_Enter);
			this.FirstName.Leave += new System.EventHandler(this.FirstName_Leave);
			// 
			// LastName
			// 
			this.LastName.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.LastName.Location = new System.Drawing.Point(18, 31);
			this.LastName.Name = "LastName";
			this.LastName.Size = new System.Drawing.Size(100, 20);
			this.LastName.TabIndex = 0;
			this.LastName.Enter += new System.EventHandler(this.LastName_Enter);
			this.LastName.Leave += new System.EventHandler(this.LastName_Leave);
			// 
			// OK
			// 
			this.OK.Location = new System.Drawing.Point(182, 126);
			this.OK.Name = "OK";
			this.OK.Size = new System.Drawing.Size(75, 23);
			this.OK.TabIndex = 6;
			this.OK.Text = "Принять";
			this.OK.UseVisualStyleBackColor = true;
			this.OK.Click += new System.EventHandler(this.OK_Click);
			// 
			// SubjectName
			// 
			this.SubjectName.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.SubjectName.Location = new System.Drawing.Point(171, 43);
			this.SubjectName.Name = "SubjectName";
			this.SubjectName.Size = new System.Drawing.Size(100, 20);
			this.SubjectName.TabIndex = 7;
			this.SubjectName.Enter += new System.EventHandler(this.SubjectName_Enter);
			this.SubjectName.Leave += new System.EventHandler(this.SubjectName_Leave);
			// 
			// AcademicHours
			// 
			this.AcademicHours.Location = new System.Drawing.Point(171, 95);
			this.AcademicHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.AcademicHours.Name = "AcademicHours";
			this.AcademicHours.Size = new System.Drawing.Size(100, 20);
			this.AcademicHours.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(168, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(174, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Предусмотрено часов в семестр";
			// 
			// AddLessonForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(365, 182);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AcademicHours);
			this.Controls.Add(this.SubjectName);
			this.Controls.Add(this.OK);
			this.Controls.Add(this.groupBox1);
			this.Name = "AddLessonForm";
			this.Text = "AddLessonForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.AcademicHours)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FatherName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox SubjectName;
		private System.Windows.Forms.NumericUpDown AcademicHours;
		private System.Windows.Forms.Label label1;
	}
}
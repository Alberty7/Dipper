namespace TimeTable
{
    partial class SortingDialog
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
			this.isTeacherSorting = new System.Windows.Forms.CheckBox();
			this.isSubjectSorting = new System.Windows.Forms.CheckBox();
			this.isGroupSorting = new System.Windows.Forms.CheckBox();
			this.isCourseSorting = new System.Windows.Forms.CheckBox();
			this.isTimeSorting = new System.Windows.Forms.CheckBox();
			this.isDayOfWeekSotrting = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBoxDay = new System.Windows.Forms.GroupBox();
			this.DayWeek = new System.Windows.Forms.ListBox();
			this.groupBoxTeacher = new System.Windows.Forms.GroupBox();
			this.Teacher = new System.Windows.Forms.ListBox();
			this.groupBoxGroup = new System.Windows.Forms.GroupBox();
			this.Subject = new System.Windows.Forms.ListBox();
			this.groupBoxSubject = new System.Windows.Forms.GroupBox();
			this.Groupe = new System.Windows.Forms.ListBox();
			this.Time = new System.Windows.Forms.GroupBox();
			this.End = new System.Windows.Forms.ComboBox();
			this.Start = new System.Windows.Forms.ComboBox();
			this.groupBoxCourse = new System.Windows.Forms.GroupBox();
			this.Course = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBoxDay.SuspendLayout();
			this.groupBoxTeacher.SuspendLayout();
			this.groupBoxGroup.SuspendLayout();
			this.groupBoxSubject.SuspendLayout();
			this.Time.SuspendLayout();
			this.groupBoxCourse.SuspendLayout();
			this.SuspendLayout();
			// 
			// isTeacherSorting
			// 
			this.isTeacherSorting.Appearance = System.Windows.Forms.Appearance.Button;
			this.isTeacherSorting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.isTeacherSorting.Location = new System.Drawing.Point(712, 186);
			this.isTeacherSorting.Name = "isTeacherSorting";
			this.isTeacherSorting.Size = new System.Drawing.Size(179, 23);
			this.isTeacherSorting.TabIndex = 0;
			this.isTeacherSorting.Text = "Сортировать по преподавателю";
			this.isTeacherSorting.UseVisualStyleBackColor = true;
			this.isTeacherSorting.CheckedChanged += new System.EventHandler(this.isTeacherSorting_CheckedChanged);
			// 
			// isSubjectSorting
			// 
			this.isSubjectSorting.Appearance = System.Windows.Forms.Appearance.Button;
			this.isSubjectSorting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.isSubjectSorting.Location = new System.Drawing.Point(362, 186);
			this.isSubjectSorting.Name = "isSubjectSorting";
			this.isSubjectSorting.Size = new System.Drawing.Size(179, 23);
			this.isSubjectSorting.TabIndex = 1;
			this.isSubjectSorting.Text = "Сортировать по предмету";
			this.isSubjectSorting.UseVisualStyleBackColor = true;
			this.isSubjectSorting.CheckedChanged += new System.EventHandler(this.isSubjectSorting_CheckedChanged);
			// 
			// isGroupSorting
			// 
			this.isGroupSorting.Appearance = System.Windows.Forms.Appearance.Button;
			this.isGroupSorting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.isGroupSorting.Location = new System.Drawing.Point(362, 12);
			this.isGroupSorting.Name = "isGroupSorting";
			this.isGroupSorting.Size = new System.Drawing.Size(179, 23);
			this.isGroupSorting.TabIndex = 2;
			this.isGroupSorting.Text = "Сортировать по группе";
			this.isGroupSorting.UseVisualStyleBackColor = true;
			this.isGroupSorting.CheckedChanged += new System.EventHandler(this.isGroupSorting_CheckedChanged);
			// 
			// isCourseSorting
			// 
			this.isCourseSorting.Appearance = System.Windows.Forms.Appearance.Button;
			this.isCourseSorting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.isCourseSorting.Location = new System.Drawing.Point(12, 12);
			this.isCourseSorting.Name = "isCourseSorting";
			this.isCourseSorting.Size = new System.Drawing.Size(179, 23);
			this.isCourseSorting.TabIndex = 3;
			this.isCourseSorting.Text = "Сортировать по курсу";
			this.isCourseSorting.UseVisualStyleBackColor = true;
			this.isCourseSorting.CheckedChanged += new System.EventHandler(this.isCourseSorting_CheckedChanged);
			// 
			// isTimeSorting
			// 
			this.isTimeSorting.Appearance = System.Windows.Forms.Appearance.Button;
			this.isTimeSorting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.isTimeSorting.Location = new System.Drawing.Point(12, 186);
			this.isTimeSorting.Name = "isTimeSorting";
			this.isTimeSorting.Size = new System.Drawing.Size(179, 23);
			this.isTimeSorting.TabIndex = 4;
			this.isTimeSorting.Text = "Сортировать по времени";
			this.isTimeSorting.UseVisualStyleBackColor = true;
			this.isTimeSorting.CheckedChanged += new System.EventHandler(this.isTimeSorting_CheckedChanged);
			// 
			// isDayOfWeekSotrting
			// 
			this.isDayOfWeekSotrting.Appearance = System.Windows.Forms.Appearance.Button;
			this.isDayOfWeekSotrting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.isDayOfWeekSotrting.Location = new System.Drawing.Point(712, 12);
			this.isDayOfWeekSotrting.Name = "isDayOfWeekSotrting";
			this.isDayOfWeekSotrting.Size = new System.Drawing.Size(179, 23);
			this.isDayOfWeekSotrting.TabIndex = 5;
			this.isDayOfWeekSotrting.Text = "Сортировать по дню недели";
			this.isDayOfWeekSotrting.UseVisualStyleBackColor = true;
			this.isDayOfWeekSotrting.CheckedChanged += new System.EventHandler(this.isDayOfWeekSotrting_CheckedChanged);
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Location = new System.Drawing.Point(974, 360);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Сортировать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBoxDay
			// 
			this.groupBoxDay.Controls.Add(this.DayWeek);
			this.groupBoxDay.Location = new System.Drawing.Point(712, 41);
			this.groupBoxDay.Name = "groupBoxDay";
			this.groupBoxDay.Size = new System.Drawing.Size(344, 139);
			this.groupBoxDay.TabIndex = 7;
			this.groupBoxDay.TabStop = false;
			// 
			// DayWeek
			// 
			this.DayWeek.FormattingEnabled = true;
			this.DayWeek.Location = new System.Drawing.Point(6, 12);
			this.DayWeek.Name = "DayWeek";
			this.DayWeek.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.DayWeek.Size = new System.Drawing.Size(330, 121);
			this.DayWeek.TabIndex = 3;
			// 
			// groupBoxTeacher
			// 
			this.groupBoxTeacher.Controls.Add(this.Teacher);
			this.groupBoxTeacher.Location = new System.Drawing.Point(712, 215);
			this.groupBoxTeacher.Name = "groupBoxTeacher";
			this.groupBoxTeacher.Size = new System.Drawing.Size(344, 139);
			this.groupBoxTeacher.TabIndex = 8;
			this.groupBoxTeacher.TabStop = false;
			// 
			// Teacher
			// 
			this.Teacher.FormattingEnabled = true;
			this.Teacher.Location = new System.Drawing.Point(6, 12);
			this.Teacher.Name = "Teacher";
			this.Teacher.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.Teacher.Size = new System.Drawing.Size(330, 121);
			this.Teacher.TabIndex = 3;
			// 
			// groupBoxGroup
			// 
			this.groupBoxGroup.Controls.Add(this.Subject);
			this.groupBoxGroup.Location = new System.Drawing.Point(362, 215);
			this.groupBoxGroup.Name = "groupBoxGroup";
			this.groupBoxGroup.Size = new System.Drawing.Size(344, 139);
			this.groupBoxGroup.TabIndex = 10;
			this.groupBoxGroup.TabStop = false;
			// 
			// Subject
			// 
			this.Subject.FormattingEnabled = true;
			this.Subject.Location = new System.Drawing.Point(6, 12);
			this.Subject.Name = "Subject";
			this.Subject.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.Subject.Size = new System.Drawing.Size(330, 121);
			this.Subject.TabIndex = 2;
			// 
			// groupBoxSubject
			// 
			this.groupBoxSubject.Controls.Add(this.Groupe);
			this.groupBoxSubject.Location = new System.Drawing.Point(362, 41);
			this.groupBoxSubject.Name = "groupBoxSubject";
			this.groupBoxSubject.Size = new System.Drawing.Size(344, 139);
			this.groupBoxSubject.TabIndex = 9;
			this.groupBoxSubject.TabStop = false;
			// 
			// Groupe
			// 
			this.Groupe.FormattingEnabled = true;
			this.Groupe.Location = new System.Drawing.Point(6, 12);
			this.Groupe.Name = "Groupe";
			this.Groupe.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.Groupe.Size = new System.Drawing.Size(330, 121);
			this.Groupe.TabIndex = 2;
			// 
			// Time
			// 
			this.Time.Controls.Add(this.End);
			this.Time.Controls.Add(this.Start);
			this.Time.Location = new System.Drawing.Point(12, 215);
			this.Time.Name = "Time";
			this.Time.Size = new System.Drawing.Size(344, 139);
			this.Time.TabIndex = 12;
			this.Time.TabStop = false;
			// 
			// End
			// 
			this.End.DisplayMember = "EndLessonHour";
			this.End.FormattingEnabled = true;
			this.End.Location = new System.Drawing.Point(176, 19);
			this.End.Name = "End";
			this.End.Size = new System.Drawing.Size(162, 21);
			this.End.TabIndex = 9;
			this.End.ValueMember = "EndLessonHour";
			// 
			// Start
			// 
			this.Start.DisplayMember = "StartLessonHour";
			this.Start.FormattingEnabled = true;
			this.Start.Location = new System.Drawing.Point(8, 19);
			this.Start.Name = "Start";
			this.Start.Size = new System.Drawing.Size(162, 21);
			this.Start.TabIndex = 7;
			this.Start.ValueMember = "StartLessonHour";
			// 
			// groupBoxCourse
			// 
			this.groupBoxCourse.Controls.Add(this.Course);
			this.groupBoxCourse.Location = new System.Drawing.Point(12, 41);
			this.groupBoxCourse.Name = "groupBoxCourse";
			this.groupBoxCourse.Size = new System.Drawing.Size(344, 139);
			this.groupBoxCourse.TabIndex = 11;
			this.groupBoxCourse.TabStop = false;
			// 
			// Course
			// 
			this.Course.FormattingEnabled = true;
			this.Course.Location = new System.Drawing.Point(8, 12);
			this.Course.Name = "Course";
			this.Course.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.Course.Size = new System.Drawing.Size(330, 121);
			this.Course.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.Location = new System.Drawing.Point(886, 360);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(82, 23);
			this.button2.TabIndex = 13;
			this.button2.Text = "Отмена";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// SortingDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1066, 391);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.Time);
			this.Controls.Add(this.groupBoxGroup);
			this.Controls.Add(this.groupBoxCourse);
			this.Controls.Add(this.groupBoxTeacher);
			this.Controls.Add(this.groupBoxSubject);
			this.Controls.Add(this.groupBoxDay);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.isDayOfWeekSotrting);
			this.Controls.Add(this.isTimeSorting);
			this.Controls.Add(this.isCourseSorting);
			this.Controls.Add(this.isGroupSorting);
			this.Controls.Add(this.isSubjectSorting);
			this.Controls.Add(this.isTeacherSorting);
			this.Name = "SortingDialog";
			this.Text = "SortingDialog";
			this.Load += new System.EventHandler(this.SortingDialog_Load);
			this.groupBoxDay.ResumeLayout(false);
			this.groupBoxTeacher.ResumeLayout(false);
			this.groupBoxGroup.ResumeLayout(false);
			this.groupBoxSubject.ResumeLayout(false);
			this.Time.ResumeLayout(false);
			this.groupBoxCourse.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox isTeacherSorting;
        private System.Windows.Forms.CheckBox isSubjectSorting;
        private System.Windows.Forms.CheckBox isGroupSorting;
        private System.Windows.Forms.CheckBox isCourseSorting;
        private System.Windows.Forms.CheckBox isTimeSorting;
        private System.Windows.Forms.CheckBox isDayOfWeekSotrting;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBoxDay;
		private System.Windows.Forms.GroupBox groupBoxTeacher;
		private System.Windows.Forms.GroupBox groupBoxGroup;
		private System.Windows.Forms.GroupBox groupBoxSubject;
		private System.Windows.Forms.GroupBox Time;
		private System.Windows.Forms.GroupBox groupBoxCourse;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ListBox Course;
		private System.Windows.Forms.ListBox DayWeek;
		private System.Windows.Forms.ListBox Teacher;
		private System.Windows.Forms.ListBox Subject;
		private System.Windows.Forms.ListBox Groupe;
		private System.Windows.Forms.ComboBox End;
		private System.Windows.Forms.ComboBox Start;
	}
}
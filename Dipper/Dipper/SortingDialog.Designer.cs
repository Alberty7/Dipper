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
			this.components = new System.ComponentModel.Container();
			this.isTeacherSorting = new System.Windows.Forms.CheckBox();
			this.isSubjectSorting = new System.Windows.Forms.CheckBox();
			this.isGroupSorting = new System.Windows.Forms.CheckBox();
			this.isCourseSorting = new System.Windows.Forms.CheckBox();
			this.isTimeSorting = new System.Windows.Forms.CheckBox();
			this.isDayOfWeekSotrting = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBoxDay = new System.Windows.Forms.GroupBox();
			this.DayWeek = new System.Windows.Forms.ComboBox();
			this.comboBox10 = new System.Windows.Forms.ComboBox();
			this.comboBox5 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.groupBoxTeacher = new System.Windows.Forms.GroupBox();
			this.Teacher = new System.Windows.Forms.ComboBox();
			this.comboBox6 = new System.Windows.Forms.ComboBox();
			this.groupBoxGroup = new System.Windows.Forms.GroupBox();
			this.Subject = new System.Windows.Forms.ComboBox();
			this.groupBoxSubject = new System.Windows.Forms.GroupBox();
			this.Groupe = new System.Windows.Forms.ComboBox();
			this.comboBox8 = new System.Windows.Forms.ComboBox();
			this.comboBox7 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.Time = new System.Windows.Forms.GroupBox();
			this.comboBox15 = new System.Windows.Forms.ComboBox();
			this.comboBox16 = new System.Windows.Forms.ComboBox();
			this.comboBox14 = new System.Windows.Forms.ComboBox();
			this.comboBox13 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBoxCourse = new System.Windows.Forms.GroupBox();
			this.Course = new System.Windows.Forms.ComboBox();
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
			this.groupBoxDay.Controls.Add(this.comboBox10);
			this.groupBoxDay.Controls.Add(this.comboBox5);
			this.groupBoxDay.Controls.Add(this.comboBox3);
			this.groupBoxDay.Location = new System.Drawing.Point(712, 41);
			this.groupBoxDay.Name = "groupBoxDay";
			this.groupBoxDay.Size = new System.Drawing.Size(344, 139);
			this.groupBoxDay.TabIndex = 7;
			this.groupBoxDay.TabStop = false;
			// 
			// DayWeek
			// 
			this.DayWeek.DisplayMember = "Day";
			this.DayWeek.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DayWeek.FormattingEnabled = true;
			this.DayWeek.Location = new System.Drawing.Point(3, 16);
			this.DayWeek.Name = "DayWeek";
			this.DayWeek.Size = new System.Drawing.Size(338, 21);
			this.DayWeek.TabIndex = 5;
			this.DayWeek.ValueMember = "Day";
			// 
			// comboBox10
			// 
			this.comboBox10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox10.FormattingEnabled = true;
			this.comboBox10.Location = new System.Drawing.Point(3, 16);
			this.comboBox10.Name = "comboBox10";
			this.comboBox10.Size = new System.Drawing.Size(338, 21);
			this.comboBox10.TabIndex = 4;
			this.comboBox10.ValueMember = "NameLesson";
			// 
			// comboBox5
			// 
			this.comboBox5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox5.FormattingEnabled = true;
			this.comboBox5.Location = new System.Drawing.Point(3, 16);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Size = new System.Drawing.Size(338, 21);
			this.comboBox5.TabIndex = 3;
			this.comboBox5.ValueMember = "NameLesson";
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(6, 16);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(332, 21);
			this.comboBox3.TabIndex = 1;
			// 
			// groupBoxTeacher
			// 
			this.groupBoxTeacher.Controls.Add(this.Teacher);
			this.groupBoxTeacher.Controls.Add(this.comboBox6);
			this.groupBoxTeacher.Location = new System.Drawing.Point(712, 215);
			this.groupBoxTeacher.Name = "groupBoxTeacher";
			this.groupBoxTeacher.Size = new System.Drawing.Size(344, 139);
			this.groupBoxTeacher.TabIndex = 8;
			this.groupBoxTeacher.TabStop = false;
			// 
			// Teacher
			// 
			this.Teacher.DisplayMember = "Teacher";
			this.Teacher.FormattingEnabled = true;
			this.Teacher.Location = new System.Drawing.Point(6, 19);
			this.Teacher.Name = "Teacher";
			this.Teacher.Size = new System.Drawing.Size(332, 21);
			this.Teacher.TabIndex = 2;
			this.Teacher.ValueMember = "Teacher";
			// 
			// comboBox6
			// 
			this.comboBox6.FormattingEnabled = true;
			this.comboBox6.Location = new System.Drawing.Point(6, 19);
			this.comboBox6.Name = "comboBox6";
			this.comboBox6.Size = new System.Drawing.Size(332, 21);
			this.comboBox6.TabIndex = 4;
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
			this.Subject.DisplayMember = "NameLesson";
			this.Subject.FormattingEnabled = true;
			this.Subject.Location = new System.Drawing.Point(6, 19);
			this.Subject.Name = "Subject";
			this.Subject.Size = new System.Drawing.Size(332, 21);
			this.Subject.TabIndex = 5;
			this.Subject.ValueMember = "NameLesson";
			// 
			// groupBoxSubject
			// 
			this.groupBoxSubject.Controls.Add(this.Groupe);
			this.groupBoxSubject.Controls.Add(this.comboBox8);
			this.groupBoxSubject.Controls.Add(this.comboBox7);
			this.groupBoxSubject.Controls.Add(this.comboBox1);
			this.groupBoxSubject.Location = new System.Drawing.Point(362, 41);
			this.groupBoxSubject.Name = "groupBoxSubject";
			this.groupBoxSubject.Size = new System.Drawing.Size(344, 139);
			this.groupBoxSubject.TabIndex = 9;
			this.groupBoxSubject.TabStop = false;
			// 
			// Groupe
			// 
			this.Groupe.DisplayMember = "GroupName";
			this.Groupe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Groupe.FormattingEnabled = true;
			this.Groupe.Location = new System.Drawing.Point(3, 16);
			this.Groupe.Name = "Groupe";
			this.Groupe.Size = new System.Drawing.Size(338, 21);
			this.Groupe.TabIndex = 3;
			this.Groupe.ValueMember = "GroupName";
			// 
			// comboBox8
			// 
			this.comboBox8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox8.FormattingEnabled = true;
			this.comboBox8.Location = new System.Drawing.Point(3, 16);
			this.comboBox8.Name = "comboBox8";
			this.comboBox8.Size = new System.Drawing.Size(338, 21);
			this.comboBox8.TabIndex = 2;
			this.comboBox8.ValueMember = "NameLesson";
			// 
			// comboBox7
			// 
			this.comboBox7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox7.FormattingEnabled = true;
			this.comboBox7.Location = new System.Drawing.Point(3, 16);
			this.comboBox7.Name = "comboBox7";
			this.comboBox7.Size = new System.Drawing.Size(338, 21);
			this.comboBox7.TabIndex = 1;
			this.comboBox7.ValueMember = "NameLesson";
			// 
			// comboBox1
			// 
			this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(3, 16);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(338, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.ValueMember = "NameLesson";
			// 
			// Time
			// 
			this.Time.Controls.Add(this.comboBox15);
			this.Time.Controls.Add(this.comboBox16);
			this.Time.Controls.Add(this.comboBox14);
			this.Time.Controls.Add(this.comboBox13);
			this.Time.Controls.Add(this.label1);
			this.Time.Controls.Add(this.label2);
			this.Time.Location = new System.Drawing.Point(12, 215);
			this.Time.Name = "Time";
			this.Time.Size = new System.Drawing.Size(344, 139);
			this.Time.TabIndex = 12;
			this.Time.TabStop = false;
			// 
			// comboBox15
			// 
			this.comboBox15.DisplayMember = "EndLessonHour";
			this.comboBox15.FormattingEnabled = true;
			this.comboBox15.Location = new System.Drawing.Point(7, 59);
			this.comboBox15.Name = "comboBox15";
			this.comboBox15.Size = new System.Drawing.Size(162, 21);
			this.comboBox15.TabIndex = 9;
			this.comboBox15.ValueMember = "EndLessonHour";
			// 
			// comboBox16
			// 
			this.comboBox16.DisplayMember = "EndLessonMinut";
			this.comboBox16.FormattingEnabled = true;
			this.comboBox16.Location = new System.Drawing.Point(175, 59);
			this.comboBox16.Name = "comboBox16";
			this.comboBox16.Size = new System.Drawing.Size(162, 21);
			this.comboBox16.TabIndex = 8;
			this.comboBox16.ValueMember = "EndLessonMinut";
			// 
			// comboBox14
			// 
			this.comboBox14.DisplayMember = "StartLessonHour";
			this.comboBox14.FormattingEnabled = true;
			this.comboBox14.Location = new System.Drawing.Point(8, 19);
			this.comboBox14.Name = "comboBox14";
			this.comboBox14.Size = new System.Drawing.Size(162, 21);
			this.comboBox14.TabIndex = 7;
			this.comboBox14.ValueMember = "StartLessonHour";
			// 
			// comboBox13
			// 
			this.comboBox13.DisplayMember = "StartLessonMinut";
			this.comboBox13.FormattingEnabled = true;
			this.comboBox13.Location = new System.Drawing.Point(176, 19);
			this.comboBox13.Name = "comboBox13";
			this.comboBox13.Size = new System.Drawing.Size(162, 21);
			this.comboBox13.TabIndex = 6;
			this.comboBox13.ValueMember = "StartLessonMinut";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(168, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(11, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = ":";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(167, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(11, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = ":";
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
			this.Course.DisplayMember = "Курс";
			this.Course.FormattingEnabled = true;
			this.Course.Location = new System.Drawing.Point(6, 16);
			this.Course.Name = "Course";
			this.Course.Size = new System.Drawing.Size(332, 21);
			this.Course.TabIndex = 0;
			this.Course.ValueMember = "Курс";
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
			this.groupBoxDay.ResumeLayout(false);
			this.groupBoxTeacher.ResumeLayout(false);
			this.groupBoxGroup.ResumeLayout(false);
			this.groupBoxSubject.ResumeLayout(false);
			this.Time.ResumeLayout(false);
			this.Time.PerformLayout();
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
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox Course;
		private System.Windows.Forms.ComboBox DayWeek;
		private System.Windows.Forms.ComboBox comboBox10;
		private System.Windows.Forms.ComboBox comboBox5;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox Teacher;
		private System.Windows.Forms.ComboBox comboBox6;
		private System.Windows.Forms.ComboBox Subject;
		private System.Windows.Forms.ComboBox Groupe;
		private System.Windows.Forms.ComboBox comboBox8;
		private System.Windows.Forms.ComboBox comboBox7;
		private System.Windows.Forms.ComboBox comboBox13;
		private System.Windows.Forms.ComboBox comboBox15;
		private System.Windows.Forms.ComboBox comboBox16;
		private System.Windows.Forms.ComboBox comboBox14;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}
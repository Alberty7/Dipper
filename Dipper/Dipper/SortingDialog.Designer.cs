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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBoxDay = new System.Windows.Forms.GroupBox();
			this.groupBoxTeacher = new System.Windows.Forms.GroupBox();
			this.groupBoxGroup = new System.Windows.Forms.GroupBox();
			this.groupBoxSubject = new System.Windows.Forms.GroupBox();
			this.groupBoxTime = new System.Windows.Forms.GroupBox();
			this.groupBoxCourse = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dipperDBDataSet = new TimeTable.DipperDBDataSet();
			this.lessonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lessonsTableAdapter = new TimeTable.DipperDBDataSetTableAdapters.LessonsTableAdapter();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.yearsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.yearsTableAdapter = new TimeTable.DipperDBDataSetTableAdapters.YearsTableAdapter();
			this.groupBoxSubject.SuspendLayout();
			this.groupBoxCourse.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dipperDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.yearsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox1.Location = new System.Drawing.Point(712, 186);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(179, 23);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Сортировать по преподавателю";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox2.Location = new System.Drawing.Point(362, 12);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(179, 23);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Сортировать по предмету";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox3.Location = new System.Drawing.Point(362, 186);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(179, 23);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "Сортировать по группе";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox4
			// 
			this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox4.Location = new System.Drawing.Point(12, 12);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(179, 23);
			this.checkBox4.TabIndex = 3;
			this.checkBox4.Text = "Сортировать по курсу";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// checkBox5
			// 
			this.checkBox5.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox5.Location = new System.Drawing.Point(12, 186);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(179, 23);
			this.checkBox5.TabIndex = 4;
			this.checkBox5.Text = "Сортировать по времени";
			this.checkBox5.UseVisualStyleBackColor = true;
			// 
			// checkBox6
			// 
			this.checkBox6.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkBox6.Location = new System.Drawing.Point(712, 12);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(179, 23);
			this.checkBox6.TabIndex = 5;
			this.checkBox6.Text = "Сортировать по дню недели";
			this.checkBox6.UseVisualStyleBackColor = true;
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
			// 
			// groupBoxDay
			// 
			this.groupBoxDay.Location = new System.Drawing.Point(712, 41);
			this.groupBoxDay.Name = "groupBoxDay";
			this.groupBoxDay.Size = new System.Drawing.Size(344, 139);
			this.groupBoxDay.TabIndex = 7;
			this.groupBoxDay.TabStop = false;
			// 
			// groupBoxTeacher
			// 
			this.groupBoxTeacher.Location = new System.Drawing.Point(712, 215);
			this.groupBoxTeacher.Name = "groupBoxTeacher";
			this.groupBoxTeacher.Size = new System.Drawing.Size(344, 139);
			this.groupBoxTeacher.TabIndex = 8;
			this.groupBoxTeacher.TabStop = false;
			this.groupBoxTeacher.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// groupBoxGroup
			// 
			this.groupBoxGroup.Location = new System.Drawing.Point(362, 215);
			this.groupBoxGroup.Name = "groupBoxGroup";
			this.groupBoxGroup.Size = new System.Drawing.Size(344, 139);
			this.groupBoxGroup.TabIndex = 10;
			this.groupBoxGroup.TabStop = false;
			// 
			// groupBoxSubject
			// 
			this.groupBoxSubject.Controls.Add(this.comboBox1);
			this.groupBoxSubject.Location = new System.Drawing.Point(362, 41);
			this.groupBoxSubject.Name = "groupBoxSubject";
			this.groupBoxSubject.Size = new System.Drawing.Size(344, 139);
			this.groupBoxSubject.TabIndex = 9;
			this.groupBoxSubject.TabStop = false;
			// 
			// groupBoxTime
			// 
			this.groupBoxTime.Location = new System.Drawing.Point(12, 215);
			this.groupBoxTime.Name = "groupBoxTime";
			this.groupBoxTime.Size = new System.Drawing.Size(344, 139);
			this.groupBoxTime.TabIndex = 12;
			this.groupBoxTime.TabStop = false;
			// 
			// groupBoxCourse
			// 
			this.groupBoxCourse.Controls.Add(this.comboBox2);
			this.groupBoxCourse.Location = new System.Drawing.Point(12, 41);
			this.groupBoxCourse.Name = "groupBoxCourse";
			this.groupBoxCourse.Size = new System.Drawing.Size(344, 139);
			this.groupBoxCourse.TabIndex = 11;
			this.groupBoxCourse.TabStop = false;
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
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.lessonsBindingSource;
			this.comboBox1.DisplayMember = "NameLesson";
			this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(3, 16);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(338, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.ValueMember = "NameLesson";
			// 
			// dipperDBDataSet
			// 
			this.dipperDBDataSet.DataSetName = "DipperDBDataSet";
			this.dipperDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// lessonsBindingSource
			// 
			this.lessonsBindingSource.DataMember = "Lessons";
			this.lessonsBindingSource.DataSource = this.dipperDBDataSet;
			// 
			// lessonsTableAdapter
			// 
			this.lessonsTableAdapter.ClearBeforeFill = true;
			// 
			// comboBox2
			// 
			this.comboBox2.DataSource = this.yearsBindingSource;
			this.comboBox2.DisplayMember = "Код";
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(25, 28);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 0;
			// 
			// yearsBindingSource
			// 
			this.yearsBindingSource.DataMember = "Years";
			this.yearsBindingSource.DataSource = this.dipperDBDataSet;
			// 
			// yearsTableAdapter
			// 
			this.yearsTableAdapter.ClearBeforeFill = true;
			// 
			// SortingDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1066, 391);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBoxTime);
			this.Controls.Add(this.groupBoxGroup);
			this.Controls.Add(this.groupBoxCourse);
			this.Controls.Add(this.groupBoxTeacher);
			this.Controls.Add(this.groupBoxSubject);
			this.Controls.Add(this.groupBoxDay);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.checkBox6);
			this.Controls.Add(this.checkBox5);
			this.Controls.Add(this.checkBox4);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Name = "SortingDialog";
			this.Text = "SortingDialog";
			this.Load += new System.EventHandler(this.SortingDialog_Load);
			this.groupBoxSubject.ResumeLayout(false);
			this.groupBoxCourse.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dipperDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.yearsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBoxDay;
		private System.Windows.Forms.GroupBox groupBoxTeacher;
		private System.Windows.Forms.GroupBox groupBoxGroup;
		private System.Windows.Forms.GroupBox groupBoxSubject;
		private System.Windows.Forms.GroupBox groupBoxTime;
		private System.Windows.Forms.GroupBox groupBoxCourse;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox comboBox1;
		private DipperDBDataSet dipperDBDataSet;
		private System.Windows.Forms.BindingSource lessonsBindingSource;
		private DipperDBDataSetTableAdapters.LessonsTableAdapter lessonsTableAdapter;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.BindingSource yearsBindingSource;
		private DipperDBDataSetTableAdapters.YearsTableAdapter yearsTableAdapter;
	}
}
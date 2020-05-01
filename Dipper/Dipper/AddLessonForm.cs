using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable
{
    public partial class AddLessonForm : Form
    {
        public string[] FIO { get; private set; } = new string[3];
        public string SubjectNameString { get; private set; } = "";
        public int Hourse { get; private set; } = 0;
        public AddLessonForm()
        {
            InitializeComponent();
        }

        private void FirstName_Leave(object sender, EventArgs e) {
            if(FirstName.Text.Length == 0) {
                FirstName.Text = "Фамилия";
                FirstName.ForeColor = SystemColors.GrayText;
            }
        }

        private void FirstName_Enter(object sender, EventArgs e) {
            if(FirstName.Text == "Фамилия") {
                FirstName.Text = "";
                FirstName.ForeColor = SystemColors.WindowText;
            }
        }
        private void LastName_Leave(object sender, EventArgs e) {
            if(LastName.Text.Length == 0) {
                LastName.Text = "Имя";
                LastName.ForeColor = SystemColors.GrayText;
            }
        }

        private void LastName_Enter(object sender, EventArgs e) {
            if(LastName.Text == "Имя") {
                LastName.Text = "";
                LastName.ForeColor = SystemColors.WindowText;
            }
        }
        private void FatherName_Leave(object sender, EventArgs e) {
            if(FatherName.Text.Length == 0) {
                FatherName.Text = "Отчество";
                FatherName.ForeColor = SystemColors.GrayText;
            }
        }

        private void FatherName_Enter(object sender, EventArgs e) {
            if(FatherName.Text == "Отчество") {
                FatherName.Text = "";
                FatherName.ForeColor = SystemColors.WindowText;
            }
        }
        private void SubjectName_Leave(object sender, EventArgs e) {
            if(SubjectName.Text.Length == 0) {
                SubjectName.Text = "Предмет";
                SubjectName.ForeColor = SystemColors.GrayText;
            }
        }

        private void SubjectName_Enter(object sender, EventArgs e) {
            if(SubjectName.Text == "Предмет") {
                SubjectName.Text = "";
                SubjectName.ForeColor = SystemColors.WindowText;
            }
        }

        private void OK_Click(object sender, EventArgs e) {
            FIO[0] = LastName.Text;
            FIO[1] = FirstName.Text;
            FIO[2] = FatherName.Text;
            SubjectNameString = SubjectName.Text;
            Hourse = (int)AcademicHours.Value; 
            DialogResult = DialogResult.OK;
            Hide();
        }
    }

}

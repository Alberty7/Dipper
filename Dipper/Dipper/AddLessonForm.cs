using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dipper
{
    public partial class AddLessonForm : Form
    {
        public string[] FIO { get; private set; } = new string[3];
        public string subjectName { get; private set; } = "";
        public int Hourse { get; private set; } = 0;
        public AddLessonForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"(Фамилия)");
            if(regex.IsMatch(LastName.Text) && LastName.Text.Length != "Фамилия".Length){
                LastName.Text = regex.Replace(LastName.Text, "");
                LastName.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
            }
            else if(LastName.Text.Length == 0) {
                LastName.ForeColor = Color.FromKnownColor(KnownColor.WindowFrame);
                LastName.Text = "Фамилия";
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"(Имя)");
            if(regex.IsMatch(FirstName.Text) && FirstName.Text.Length != "Имя".Length) {
                FirstName.Text = regex.Replace(FirstName.Text, "");
                FirstName.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
            }
            else if(FirstName.Text.Length == 0) {
                FirstName.ForeColor = Color.FromKnownColor(KnownColor.WindowFrame);
                FirstName.Text = "Имя";
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"(Отчество)");
            if(regex.IsMatch(FatherName.Text) && FatherName.Text.Length != "Отчество".Length) {
                FatherName.Text = regex.Replace(FatherName.Text, "");
                FatherName.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
            }
            else if(FatherName.Text.Length == 0) {
                FatherName.ForeColor = Color.FromKnownColor(KnownColor.WindowFrame);
                FatherName.Text = "Отчество";
            }
        }
        private void SubjectName_TextChanged(object sender, EventArgs e) {
            Regex regex = new Regex(@"(Предмет)");
            if(regex.IsMatch(SubjectName.Text) && SubjectName.Text.Length != "Предмет".Length) {
                SubjectName.Text = regex.Replace(SubjectName.Text, "");
                SubjectName.ForeColor = Color.FromKnownColor(KnownColor.WindowText);
            }
            else if(SubjectName.Text.Length == 0) {
                SubjectName.ForeColor = Color.FromKnownColor(KnownColor.WindowFrame);
                SubjectName.Text = "Предмет";
            }
        }

        private void OK_Click(object sender, EventArgs e) {
            FIO[0] = LastName.Text;
            FIO[1] = FirstName.Text;
            FIO[3] = FatherName.Text;
            subjectName = SubjectName.Text;
            Hourse = (int)AcademicHours.Value; 
            DialogResult = DialogResult.OK;
            Hide();
        }
    }
}

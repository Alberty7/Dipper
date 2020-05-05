using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable
{
    public partial class SortingDialog : Form
    {
        public SortingDialog()
        {
            InitializeComponent();
        }

        private void isCourseSorting_CheckedChanged(object sender, EventArgs e) => Course.Enabled = isCourseSorting.Checked;

        private void isGroupSorting_CheckedChanged(object sender, EventArgs e) => Groupe.Enabled = isGroupSorting.Checked;

        private void isDayOfWeekSotrting_CheckedChanged(object sender, EventArgs e) => DayWeek.Enabled = isDayOfWeekSotrting.Checked;

        private void isTimeSorting_CheckedChanged(object sender, EventArgs e) => Time.Enabled = isTimeSorting.Checked;

        private void isSubjectSorting_CheckedChanged(object sender, EventArgs e) => Subject.Enabled = isSubjectSorting.Checked;

        private void isTeacherSorting_CheckedChanged(object sender, EventArgs e) => Teacher.Enabled = isTeacherSorting.Checked;

        private void button2_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e) {

        }
    }
}

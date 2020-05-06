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
    enum SortingFilters {
        None = 0,
        Course = 1,
        Group = 2,
        Days = 4,
        Time = 8,
        Subject = 16,
        Teacher = 32,
        All = 63
    }
    public partial class SortingDialog : Form
    {
        Dipper main;
        SortingArgs filter = new SortingArgs();
        public SortingDialog()
        {
            InitializeComponent();
        }

        private void IsCourseSorting_CheckedChanged(object sender, EventArgs e) {
            Course.Enabled = isCourseSorting.Checked;
           filter.args ^= SortingFilters.Course;
        }

        private void IsGroupSorting_CheckedChanged(object sender, EventArgs e) {
            Groupe.Enabled = isGroupSorting.Checked;
            filter.args ^= SortingFilters.Group;
        }

        private void IsDayOfWeekSotrting_CheckedChanged(object sender, EventArgs e) {
            DayWeek.Enabled = isDayOfWeekSotrting.Checked;
            filter.args ^= SortingFilters.Days;
        }

        private void IsTimeSorting_CheckedChanged(object sender, EventArgs e) {
            Time.Enabled = isTimeSorting.Checked;
            filter.args ^= SortingFilters.Time;
        }

        private void IsSubjectSorting_CheckedChanged(object sender, EventArgs e) {
            Subject.Enabled = isSubjectSorting.Checked;
            filter.args ^= SortingFilters.Subject;
        }

        private void IsTeacherSorting_CheckedChanged(object sender, EventArgs e) {
            Teacher.Enabled = isTeacherSorting.Checked;
            filter.args ^= SortingFilters.Teacher;
        }

        private void button2_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e) {
            if(filter.args != SortingFilters.None) {
                if(isCourseSorting.Checked && Course.Enabled) {
                    filter.crs.AddRange(Course.SelectedItems.Cast<string>());
                }
                if(isGroupSorting.Checked && Groupe.Enabled) {
                    filter.grp.AddRange(Groupe.SelectedItems.Cast<string>());
                }
                if(isDayOfWeekSotrting.Checked && DayWeek.Enabled) {
                    filter.day.AddRange(DayWeek.SelectedItems.Cast<string>());
                }
                if(isTimeSorting.Checked && Time.Enabled) {
                    filter.time = ((DateTime)Start.SelectedItem, (DateTime)End.SelectedItem);
                }
                if(isSubjectSorting.Checked && Subject.Enabled) {
                    filter.sbj.AddRange(Subject.SelectedItems.Cast<Subject>());
                }
                if(isTeacherSorting.Checked && Teacher.Enabled) {
                    filter.tch.AddRange(Teacher.SelectedItems.Cast<string>());
                }

                var item = (DataGridView)main.Tables.SelectedTab.Controls[0];

                JsonDataBase.Sort(filter, ref item);
                DialogResult = DialogResult.OK;
            }
            else {
                button2_Click(sender, e);
            }
        }

        private void SortingDialog_Load(object sender, EventArgs e) {
            main = this.Owner as Dipper;
            Course.DataSource = JsonDataBase.Courses.Keys.ToList();            
            Groupe.DataSource = JsonDataBase.Groups.Keys.ToList();
            DayWeek.DataSource = JsonDataBase.Week.Keys.ToList();
            List<DateTime> list1 = new List<DateTime>();
            List<DateTime> list2 = new List<DateTime>();
            foreach(var item in JsonDataBase.Week["Понедельник"]) {
                list1.Add(item.Item1);
                list2.Add(item.Item2);
            }
            Start.DataSource = list1;
            Start.FormattingEnabled = true;
            Start.FormatString = "HH:mm";
            End.DataSource = list2;
            End.FormattingEnabled = true;
            End.FormatString = "HH:mm";
            Subject.DataSource = JsonDataBase.PullOfSublect.ToList();
            Teacher.DataSource = JsonDataBase.Teachers.Keys.ToList();
        }
    }
    class SortingArgs {
        public SortingFilters args = SortingFilters.All;

        public List<string> crs = new List<string>();
        public List<string> grp = new List<string>();
        public List<string> day = new List<string>();
        public (DateTime, DateTime) time;
        public List<Subject> sbj = new List<Subject>();
        public List<string> tch = new List<string>();
    }
}

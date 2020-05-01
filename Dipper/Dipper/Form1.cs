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
	public partial class Dipper : Form
	{
		private bool Logined = false;
		private HashSet<Subject> PullOfSublect { get; set; }
		public Dipper()
		{
			InitializeComponent();
			PullOfSublect = new HashSet<Subject>();
		}

		private void Enter_Click(object sender, EventArgs e)
		{
			using (Password dialog = new Password())
			{
				dialog.Owner = this;
				if (dialog.ShowDialog() == DialogResult.OK) 
				{
					Enter.Hide();
					Logined = true;
				}
			}
		}


		private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void Sort_Click(object sender, EventArgs e)
		{

		}

		private void AddLesson_Click(object sender, EventArgs e)
		{
			using (AddLessonForm dialog = new AddLessonForm())
			{
				dialog.Owner = this;
				if(dialog.ShowDialog() == DialogResult.OK) {
					string teacher = $"{dialog.FIO[0]} {dialog.FIO[1]} {dialog.FIO[2]}";
					Subject temp = new Subject(dialog.SubjectNameString, teacher, dialog.Hourse);
					PullOfSublect.Add(temp);
				}
			}
		}

		private void Dipper_Load(object sender, EventArgs e) {
			// TODO: данная строка кода позволяет загрузить данные в таблицу "dipperDBDataSet.Lessons". При необходимости она может быть перемещена или удалена.
			this.lessonsTableAdapter.Fill(this.dipperDBDataSet.Lessons);

		}

		private void Search_Click(object sender, EventArgs e) {

		}
	}
}

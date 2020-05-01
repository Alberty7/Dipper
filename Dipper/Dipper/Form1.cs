using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dipper
{

	public partial class Dipper : Form
	{
		private bool Logined = false;
		private HashSet<Subject> PullOfSublect { get; set; }
		public Dipper()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void Enter_Click(object sender, EventArgs e)
		{
			using (Password dialog = new Password())
			{
				dialog.Owner = this;
				dialog.ShowDialog();
				if (dialog.isSuccsessful) 
				{
					Enter.Hide();
					Logined = dialog.isSuccsessful;
					MessageBox.Show("Вход выполнен успешно!");
				}

				else if (dialog.notInPasswords)
				{

					MessageBox.Show("Ошибка, неверный пароль!");
				}
			}
		}


		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
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
					PullOfSublect.Add(new Subject(dialog.subjectName, teacher, dialog.Hourse));
					Pull.
				}

			}
		}
	}
}

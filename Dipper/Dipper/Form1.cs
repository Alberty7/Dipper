using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

using System.Drawing;

namespace TimeTable {
	public partial class Dipper : Form {
		private bool Logined = false;

		public Dipper() {
			InitializeComponent();

			JsonDataBase.LoadTemplate(ref dataGridView1);

			Pull.DataSource = JsonDataBase.PullOfSublect.ToList();
		}

		private void Enter_Click(object sender, EventArgs e) {
			using(Password dialog = new Password()) {
				dialog.Owner = this;
				if(dialog.ShowDialog() == DialogResult.OK) {
					Enter.Hide();
					Logined = true;
				}
			}
		}


		private void ВыходToolStripMenuItem_Click(object sender, EventArgs e) {
			JsonDataBase.Save();

			Environment.Exit(0);
		}

		private void Sort_Click(object sender, EventArgs e) {
			SortingDialog dialog = new SortingDialog {
				Owner = this
			};
			dialog.ShowDialog();
		}

		private void AddLesson_Click(object sender, EventArgs e) {
			if(Logined) {
				using(AddLessonForm dialog = new AddLessonForm()) {
					dialog.Owner = this;
					if(dialog.ShowDialog() == DialogResult.OK) {
						string teacher = $"{dialog.FIO[0]} {dialog.FIO[1].FirstCharToUpper()[0]}.{dialog.FIO[2].FirstCharToUpper()[0]}";
						Subject temp = new Subject(dialog.SubjectNameString, teacher);
						JsonDataBase.PullOfSublect.Add(temp);
					}
				}
			}
			else {
				MessageBox.Show("Только авторизованные пользователи имеют право добавлять предметы", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}



		private void dataGridView1_DragDrop(object sender, DragEventArgs e) {
			if(Logined) { 
			Point clientPoint = dataGridView1.PointToClient(new Point(e.X, e.Y));
			var hit = dataGridView1.HitTest(clientPoint.X, clientPoint.Y);

			if((hit.ColumnIndex > -1) && (hit.RowIndex > -1)) {
				dataGridView1.CurrentCell = dataGridView1[hit.ColumnIndex, hit.RowIndex];
				dataGridView1.CurrentCell.Value = new Lesson(e.Data.GetData(DataFormats.Serializable, true) as Subject,
												JsonDataBase.Week[dataGridView1[0, hit.RowIndex].Value.ToString()][Convert.ToInt32(dataGridView1[1, hit.RowIndex].Value)].Item1,
												JsonDataBase.Week[dataGridView1[0, hit.RowIndex].Value.ToString()][Convert.ToInt32(dataGridView1[1, hit.RowIndex].Value)].Item2,
												 dataGridView1[hit.ColumnIndex, 0].Value.ToString(),
												 Convert.ToInt32(dataGridView1.Columns[hit.ColumnIndex].HeaderText));
			}
			}
			else {
				MessageBox.Show("Только авторизованные пользователи имеют право добавлять пары", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void Pull_MouseDown(object sender, MouseEventArgs e) {
			if(Logined)
				Pull.DoDragDrop(Pull.SelectedItem, DragDropEffects.Scroll | DragDropEffects.Move | DragDropEffects.Copy);
		}

		private void dataGridView1_DragEnter(object sender, DragEventArgs e) {
			if(Logined)
				if(e.Data.GetDataPresent(DataFormats.Serializable)) {
					e.Effect = DragDropEffects.Move | DragDropEffects.Copy | DragDropEffects.Scroll;
				}
				else {
					e.Effect = DragDropEffects.None;
				}
		}

		private void Open_Click(object sender, EventArgs e) {
			openFileDialog1.Filter = "XLS files (*.xls, *.xlt)|*.xls;*.xlt|XLSX files (*.xlsx, *.xlsm, *.xltx, *.xltm)|*.xlsx;*.xlsm;*.xltx;*.xltm|ODS files (*.ods, *.ots)|*.ods;*.ots|CSV files (*.csv, *.tsv)|*.csv;*.tsv|HTML files (*.html, *.htm)|*.html;*.htm";
			openFileDialog1.FilterIndex = 2;

			if(openFileDialog1.ShowDialog() == DialogResult.OK) {
				TabPage temp = new TabPage(openFileDialog1.FileName);
				Tables.TabPages.Add(temp);
				DataGridView dvg = new DataGridView() { Dock = DockStyle.Fill };
				temp.Controls.Add(dvg);
				JsonDataBase.LoadTemplate(ref dvg, openFileDialog1.FileName);
			}
		}
	}
	public static class StringExtensions {
		public static string FirstCharToUpper(this string input) {
			switch(input) {
				case null:
					throw new ArgumentNullException(nameof(input));
				case "":
					throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
				default:
					return input.First().ToString().ToUpper() + input.Substring(1);
			}
		}
	}
}

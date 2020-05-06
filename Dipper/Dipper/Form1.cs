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

			for(int i = 1; i<=4; i++) {
				TabPage temp = new TabPage($"Курс {i}.xlsx");
				Tables.TabPages.Add(temp);
				DataGridView dvg = new DataGridView() { Dock = DockStyle.Fill };
				dvg.AllowDrop = true;
				dvg.DragDrop += new DragEventHandler(this.dataGridView1_DragDrop);
				dvg.DragEnter += new DragEventHandler(this.dataGridView1_DragEnter);
				temp.Controls.Add(dvg);
				JsonDataBase.LoadTemplate(ref dvg, $@"..\Template{i}.xlsx");
			}

			//JsonDataBase.LoadTemplate(ref dataGridView1);

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
			for(int i = 0; i < Tables.TabPages.Count; i++) {
				saveFileDialog1.Filter = "XLS files (*.xls, *.xlt)|*.xls;*.xlt|XLSX files (*.xlsx, *.xlsm, *.xltx, *.xltm)|*.xlsx;*.xlsm;*.xltx;*.xltm|ODS files (*.ods, *.ots)|*.ods;*.ots|CSV files (*.csv, *.tsv)|*.csv;*.tsv|HTML files (*.html, *.htm)|*.html;*.htm";
				saveFileDialog1.FilterIndex = 2;

				if(saveFileDialog1.ShowDialog() == DialogResult.OK) {
					var item = (DataGridView)Tables.TabPages[i].Controls[0];
					JsonDataBase.SaveTemplate(ref item, saveFileDialog1.FileName);
				}
			}


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
				var dgv = (DataGridView)Tables.SelectedTab.Controls[0];
				Point clientPoint = dgv.PointToClient(new Point(e.X, e.Y));
				var hit = dgv.HitTest(clientPoint.X, clientPoint.Y);

				if((hit.ColumnIndex > -1) && (hit.RowIndex > -1)) {
					DialogResult var = DialogResult.Yes;
					Subject item = e.Data.GetData(DataFormats.Serializable, true) as Subject;
					for(int g = 0; g < 4; g++) {
						var DVG = (DataGridView)Tables.TabPages[g].Controls[0];
						for(int i = 2; i < DVG.ColumnCount; i++) {
							if((DVG[i, hit.RowIndex].Value != null) && (item.Teacher == ((Subject)DVG[i, hit.RowIndex].Value).Teacher)) {
								var = MessageBox.Show($"{item.Teacher} уже ведет {((Subject)DVG[i, hit.RowIndex].Value).LessonName} у {DVG.Columns[i].HeaderText} - {DVG[i, 0].Value} в это время.\n Продолжить в любом случае?", "Ошибка составления расписания", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
								if(var == DialogResult.No) {
									break;
								}
							}
						}
					}

					try {
						if(var == DialogResult.Yes) {
							dgv.CurrentCell = dgv[hit.ColumnIndex, hit.RowIndex];
							dgv.CurrentCell.Value = new Lesson(item,
															JsonDataBase.Week[dgv[0, hit.RowIndex].Value.ToString()][Convert.ToInt32(dgv[1, hit.RowIndex].Value)].Item1,
															JsonDataBase.Week[dgv[0, hit.RowIndex].Value.ToString()][Convert.ToInt32(dgv[1, hit.RowIndex].Value)].Item2,
															 dgv[hit.ColumnIndex, 0].Value.ToString(),
															 Convert.ToInt32(dgv.Columns[hit.ColumnIndex].HeaderText));
						}
					}
					catch(Exception A) {

					}
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

		private void открытьToolStripMenuItem_Click(object sender, EventArgs e) => Open_Click(sender, e);

		private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e) {
			for(int i = 1; i <= 4; i++) {
				var item = (DataGridView)Tables.TabPages[i].Controls[0];
				JsonDataBase.SaveTemplate(ref item, $@"..\Template{i}.xlsx");
			}
			for(int i = 5; i < Tables.TabPages.Count; i++) {
				var item = (DataGridView)Tables.TabPages[i].Controls[0];
				JsonDataBase.SaveTemplate(ref item, Tables.TabPages[i].Text);
			}

			JsonDataBase.Save();
		}

		private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e) {
			JsonDataBase.Save();
			saveFileDialog1.Filter = "XLS files (*.xls, *.xlt)|*.xls;*.xlt|XLSX files (*.xlsx, *.xlsm, *.xltx, *.xltm)|*.xlsx;*.xlsm;*.xltx;*.xltm|ODS files (*.ods, *.ots)|*.ods;*.ots|CSV files (*.csv, *.tsv)|*.csv;*.tsv|HTML files (*.html, *.htm)|*.html;*.htm";
			saveFileDialog1.FilterIndex = 2;

			if(saveFileDialog1.ShowDialog() == DialogResult.OK) {
				var item = (DataGridView)Tables.SelectedTab.Controls[0];
				JsonDataBase.SaveTemplate(ref item, saveFileDialog1.FileName);
			}
		}

		private void создатьToolStripMenuItem_Click(object sender, EventArgs e) {
			TabPage temp = new TabPage($"New Table {Tables.TabPages.Count + 1}");
			Tables.TabPages.Add(temp);
			DataGridView dvg = new DataGridView() { Dock = DockStyle.Fill };
			temp.Controls.Add(dvg);
			JsonDataBase.LoadTemplate(ref dvg);
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

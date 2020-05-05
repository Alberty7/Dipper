﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TimeTable {
	public partial class Dipper : Form {
		private bool Logined = false;
		private static string pathToSubjects = @"..\subjects.json";
		private static string pathToTeachers = @"..\teachers.json";
		private static string pathToDayWeek = @"..\daysweek.json";
		private static string pathToCourses = @"..\courses.json";
		private static string pathToGroups = @"..\groups.json";
		private static string pathToTimeTable = @"..\timetable.json";

		private HashSet<Subject> PullOfSublect { get; set; }
		private LinkedList<Lesson> TimeTable { get; set; }
		private Dictionary<string, string[]> Teachers { get; set; }
		private Dictionary<string, (DateTime, DateTime)[]> Week { get; set; }
		private Dictionary<string, string[]> Courses { get; set; }
		private Dictionary<string, string[]> Groups { get; set; }

		public Dipper() {
			InitializeComponent();
			PullOfSublect = new HashSet<Subject>();
			Teachers = new Dictionary<string, string[]>();
			Week = new Dictionary<string, (DateTime, DateTime)[]>();
			Courses = new Dictionary<string, string[]>();
			Groups = new Dictionary<string, string[]>();
			TimeTable = new LinkedList<Lesson>();


			PullOfSublect = JsonConvert.DeserializeObject<HashSet<Subject>>(File.ReadAllText(pathToSubjects));
			//Teachers = JsonConvert.DeserializeObject<Dictionary<string, string[]>>(File.ReadAllText(pathToTeachers));
			//Week = JsonConvert.DeserializeObject<Dictionary<string, (DateTime, DateTime)[]>>(File.ReadAllText(pathToDayWeek));
			//Courses = JsonConvert.DeserializeObject<Dictionary<string, string[]>>(File.ReadAllText(pathToCourses));
			//Groups = JsonConvert.DeserializeObject<Dictionary<string, string[]>>(File.ReadAllText(pathToGroups));
			//TimeTable = JsonConvert.DeserializeObject<LinkedList<Lesson>>(File.ReadAllText(pathToTimeTable));

			Pull.DataSource = PullOfSublect.ToList();
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
			File.WriteAllText(pathToTimeTable, JsonConvert.SerializeObject(TimeTable));
			File.WriteAllText(pathToGroups, JsonConvert.SerializeObject(Groups));
			File.WriteAllText(pathToCourses, JsonConvert.SerializeObject(Courses));
			File.WriteAllText(pathToTeachers, JsonConvert.SerializeObject(Teachers));
			File.WriteAllText(pathToSubjects, JsonConvert.SerializeObject(PullOfSublect));
			File.WriteAllText(pathToDayWeek, JsonConvert.SerializeObject(Week));

			Environment.Exit(0);
		}

		private void Sort_Click(object sender, EventArgs e) {
			SortingDialog dialog = new SortingDialog();
			dialog.ShowDialog();
		}

		private void AddLesson_Click(object sender, EventArgs e) {
			using(AddLessonForm dialog = new AddLessonForm()) {
				dialog.Owner = this;
				if(dialog.ShowDialog() == DialogResult.OK) {
					string teacher = $"{dialog.FIO[0]} {dialog.FIO[1]} {dialog.FIO[2]}";
					Subject temp = new Subject(dialog.SubjectNameString, teacher, dialog.Hourse);
					PullOfSublect.Add(temp);
				}
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;
using System.Windows.Forms;

namespace TimeTable {
	static class JsonDataBase {
		private static string pathToPasswords = @"..\passwords.json";
		private static string pathToSubjects = @"..\subjects.json";
		private static string pathToTeachers = @"..\teachers.json";
		private static string pathToDayWeek = @"..\daysweek.json";
		private static string pathToCourses = @"..\courses.json";
		private static string pathToGroups = @"..\groups.json";
		private static string pathToTable = @"..\Template.xlsx";

		public static HashSet<Subject> PullOfSublect { get; set; } = JsonConvert.DeserializeObject<HashSet<Subject>>(File.ReadAllText(pathToSubjects));
		public static Dictionary<string, string[]> Teachers { get; set; } = JsonConvert.DeserializeObject<Dictionary<string, string[]>>(File.ReadAllText(pathToTeachers));
		public static Dictionary<string, (DateTime, DateTime)[]> Week { get; set; } = JsonConvert.DeserializeObject<Dictionary<string, (DateTime, DateTime)[]>>(File.ReadAllText(pathToDayWeek));
		public static Dictionary<string, string[]> Courses { get; set; } = JsonConvert.DeserializeObject<Dictionary<string, string[]>>(File.ReadAllText(pathToCourses));
		public static Dictionary<string, string[]> Groups { get; set; } = JsonConvert.DeserializeObject<Dictionary<string, string[]>>(File.ReadAllText(pathToGroups));
		public static Dictionary<string, string> Passwords { get; set; } = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(pathToPasswords));
		public static void LoadTemplate(ref DataGridView dataGridView, string path = @"..\Template.xlsx") {
			ExcelFile workbook = ExcelFile.Load(path);

			DataGridViewConverter.ExportToDataGridView(workbook.Worksheets.ActiveWorksheet, dataGridView, new ExportToDataGridViewOptions() { ColumnHeaders = true });
		}

		public static void SaveTemplate(ref DataGridView dataGridView) {
			ExcelFile workbook = new ExcelFile();
			ExcelWorksheet worksheet = workbook.Worksheets.Add("Sheet1");

			DataGridViewConverter.ImportFromDataGridView(worksheet, dataGridView, new ImportFromDataGridViewOptions() { ColumnHeaders = true });

			workbook.Save(pathToTable);
		}

		public static void Save() {
			File.WriteAllText(pathToGroups, JsonConvert.SerializeObject(Groups));
			File.WriteAllText(pathToCourses, JsonConvert.SerializeObject(Courses));
			File.WriteAllText(pathToTeachers, JsonConvert.SerializeObject(Teachers));
			File.WriteAllText(pathToSubjects, JsonConvert.SerializeObject(PullOfSublect));
			File.WriteAllText(pathToDayWeek, JsonConvert.SerializeObject(Week));
		}

		public static void Sort() {

		}
	}
}

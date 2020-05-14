using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TimeTable
{
    static class JsonDataBase
    {
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
        public static void LoadTemplate(ref DataGridView dataGridView, string path = @"..\Template.xlsx")
        {
            ExcelFile workbook = ExcelFile.Load(path);

            DataGridViewConverter.ExportToDataGridView(workbook.Worksheets.ActiveWorksheet, dataGridView, new ExportToDataGridViewOptions() { ColumnHeaders = true });
        }

        public static void SaveTemplate(ref DataGridView dataGridView, string path = @"..\Template.xlsx")
        {
            ExcelFile workbook = new ExcelFile();
            ExcelWorksheet worksheet = workbook.Worksheets.Add("Sheet1");

            DataGridViewConverter.ImportFromDataGridView(worksheet, dataGridView, new ImportFromDataGridViewOptions() { ColumnHeaders = true });

            workbook.Save(path);
        }

        public static void Save()
        {
            File.WriteAllText(pathToGroups, JsonConvert.SerializeObject(Groups));
            File.WriteAllText(pathToCourses, JsonConvert.SerializeObject(Courses));
            File.WriteAllText(pathToTeachers, JsonConvert.SerializeObject(Teachers));
            File.WriteAllText(pathToSubjects, JsonConvert.SerializeObject(PullOfSublect));
        }

        public static void Sort(SortingArgs args, ref DataGridView view)
        {
            List<(int, int)> cells1 = null;
            List<(int, int)> cells2 = null;
            List<(int, int)> cells3 = null;
            List<(int, int)> cells4 = null;
            List<(int, int)> cells5 = null;
            List<(int, int)> cells6 = null;
            List<(int, int)> result = new List<(int, int)>();

            for (int i = 2; i < view.ColumnCount; i++)
            {
                for (int j = 1; j < view.RowCount; j++)
                {
                    view.Rows[j].Cells[i].Style.BackColor = Color.White;
                    result.Add((i, j));
                }
            }

            if ((args.args ^ SortingFilters.Course) < args.args)
            {
                cells1 = new List<(int, int)>();
                args.args ^= SortingFilters.Course;
                foreach (string item in args.crs)
                {
                    for (int i = 2; i < view.ColumnCount; i++)
                    {
                        if (view.Columns[i].HeaderText == item)
                        {
                            for (int j = 1; j < view.RowCount; j++)
                            {
                                cells1.Add((i, j));
                            }
                        }
                    }
                }
                result = result.Intersect(cells1).ToList();
            }
            if ((args.args ^ SortingFilters.Group) < args.args)
            {
                cells2 = new List<(int, int)>();
                args.args ^= SortingFilters.Group;
                foreach (string item in args.grp)
                {
                    for (int i = 2; i < view.ColumnCount; i++)
                    {
                        if (view[i, 0].Value.ToString() == item)
                        {
                            for (int j = 1; j < view.RowCount; j++)
                            {
                                cells2.Add((i, j));
                            }
                        }
                    }
                }
                result = result.Intersect(cells2).ToList();
            }
            if ((args.args ^ SortingFilters.Days) < args.args)
            {
                cells3 = new List<(int, int)>();
                args.args ^= SortingFilters.Days;
                foreach (string item in args.day)
                {
                    for (int j = 1; j < view.RowCount; j++)
                    {
                        if (view[0, j].Value.ToString() == item)
                        {
                            for (int i = 2; i < view.ColumnCount; i++)
                            {
                                cells3.Add((i, j));
                            }
                        }
                    }
                }
                result = result.Intersect(cells3).ToList();
            }
            if ((args.args ^ SortingFilters.Time) < args.args)
            {
                cells4 = new List<(int, int)>();
                args.args ^= SortingFilters.Time;
                for (int j = 1; j < view.RowCount; j++)
                {
                    if (Week["Понедельник"][(int)view[1, j].Value].Item1 >= args.time.Item1 && Week["Понедельник"][(int)view[1, j].Value].Item2 <= args.time.Item2)
                    {
                        for (int i = 2; i < view.ColumnCount; i++)
                        {
                            cells4.Add((i, j));
                        }
                    }
                }
                result = result.Intersect(cells4).ToList();
            }
            if ((args.args ^ SortingFilters.Subject) < args.args)
            {
                cells5 = new List<(int, int)>();
                args.args ^= SortingFilters.Subject;
                foreach (Subject item in args.sbj)
                {
                    for (int i = 2; i < view.ColumnCount; i++)
                    {
                        for (int j = 1; j < view.RowCount; j++)
                        {
                            if (view[i, j] != null && (Subject)view[i, j].Value == item)
                            {
                                cells5.Add((i, j));
                            }
                        }
                    }
                }
                result = result.Intersect(cells5).ToList();
            }
            if ((args.args ^ SortingFilters.Teacher) < args.args)
            {
                cells6 = new List<(int, int)>();
                args.args ^= SortingFilters.Teacher;
                foreach (string item in args.tch)
                {
                    for (int i = 2; i < view.ColumnCount; i++)
                    {
                        for (int j = 1; j < view.RowCount; j++)
                        {
                            if (view[i, j].Value != null && ((Subject)view[i, j].Value).Teacher == item)
                            {
                                cells6.Add((i, j));
                            }
                        }
                    }
                }
                result = result.Intersect(cells6).ToList();
            }
            foreach ((int, int) item in result)
            {
                view.Rows[item.Item2].Cells[item.Item1].Style.BackColor = Color.Aquamarine;
            }
        }
    }
}

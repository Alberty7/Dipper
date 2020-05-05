using System;
using System.Windows.Forms;
using GemBox.Spreadsheet;

namespace TimeTable {
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dipper());
        }
    }
}

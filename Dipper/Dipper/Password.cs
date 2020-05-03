using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace TimeTable
{
    public partial class Password : Form
    {
        private static string path = @"..\passwords.json";
        private Dictionary<string, string> passwords;
        public Password()
        {
            Dipper main = this.Owner as Dipper;
            InitializeComponent();
            textBox1.PasswordChar = '*';
            passwords = new Dictionary<string, string>();

            passwords = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(path));
        }
        private void textBox1_TextChanged(object sender, EventArgs e) => (button1.Enabled, label2.Text) = new Regex(@"\W\s*").IsMatch(textBox1.Text) ? (false, "Пароль содержит недопустимые символы") : (true, "");

        private void button1_Click(object sender, EventArgs e)
        { 
            if(!passwords.ContainsKey(textBox1.Text)) {
                DialogResult = DialogResult.None;
                MessageBox.Show("Неверный пароль");
            }
            else {
                DialogResult = DialogResult.OK;
                MessageBox.Show($"Добро пожаловть, {passwords[textBox1.Text]}");
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

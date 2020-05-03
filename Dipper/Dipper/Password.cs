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

namespace TimeTable
{
    public partial class Password : Form
    {
        public Password()
        {
            Dipper main = this.Owner as Dipper;
            InitializeComponent();
            textBox1.PasswordChar = '*';
        } 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (button1.Enabled, label2.Text) = new Regex(@"\W\s*").IsMatch(textBox1.Text) ? (false, "Пароль содержит недопустимые символы") : (true, "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DipperDBDataSet.PasswordsRow find = passwordsTableAdapter1.GetData().FindByPassword(textBox1.Text);
            if(find == null) {
                DialogResult = DialogResult.None;
                MessageBox.Show("Неверный пароль");
            }
            else {
                DialogResult = DialogResult.OK;
                MessageBox.Show($"Добро пожаловть, {find.Teacher}");
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

using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
        private void textBox1_TextChanged(object sender, EventArgs e) => (button1.Enabled, label2.Text) = new Regex(@"\W\s*").IsMatch(textBox1.Text) ? (false, "Пароль содержит недопустимые символы") : (true, "");

        private void button1_Click(object sender, EventArgs e)
        {
            if (!JsonDataBase.Passwords.ContainsKey(textBox1.Text))
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Неверный пароль");
            }
            else
            {
                DialogResult = DialogResult.OK;
                MessageBox.Show($"Добро пожаловть, {JsonDataBase.Passwords[textBox1.Text]}");
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

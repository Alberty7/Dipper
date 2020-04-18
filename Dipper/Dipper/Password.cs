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

namespace Dipper
{
    public partial class Password : Form
    {
        public bool notInPasswords = false;
        private List<string> passwords;
        public List<string> Passwords { get => passwords; }
        public bool isSuccsessful = false;
        public Password()
        {
            Dipper main = this.Owner as Dipper;
            InitializeComponent();
            InitializePasswords();
        }

        private void InitializePasswords()
        {
            passwords = new List<string>();
            StreamReader streamReader = new StreamReader("./passwords.txt");
            for (string item = "admin"; !streamReader.EndOfStream; item = streamReader.ReadLine())
            {
                passwords.Add(item);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string NotAllowed = @" ,.(){ }[] /\| !@#$%^&*+=";
            bool contains = false;
            foreach (char item in textBox1.Text)
            {
                contains = NotAllowed.Contains(item);
            }
            if (contains == true)
            {
                button1.Enabled = false;
                label2.Text = "Пароль содержит недопустимые символы";
            }
            else
            {
                button1.Enabled = true;
                label2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string psw in Passwords)
            {
                if (textBox1.Text == psw)
                {
                    isSuccsessful = true;
                    notInPasswords = false;
                }
                else
                {
                    notInPasswords = true;
                }
            }            
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Close();
        }
    }
}

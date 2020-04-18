using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dipper
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            char[] NotAllowed = @" ,.(){ }[] /\| !@#$%^&*+=".ToCharArray();

            if (textBox1.Text.Contains( (NotAllowed)) { }

            if (!value.Contains(@" ,.(){}[]/\|!@#$%^&*+=".ToCharArray()))
            {
                foreach (string item in Passwords)
                {
                    if (value == item)
                    {
                        password = value;
                        break;
                    }
                    password = null;

                }
                if (string.IsNullOrEmpty(password))
                {
                    throw new ArgumentException("Такого пароля не существует!");
                }
            }

            else
            {
                throw new ArgumentException("Пароль содержит недопустимые символы!\n(пробел,.(){}[]/\\|!@#$%^&*+= )");
            }

        }
    }
}

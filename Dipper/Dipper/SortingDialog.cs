using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable
{
    public partial class SortingDialog : Form
    {
        public SortingDialog()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e) {

        }

        private void SortingDialog_Load(object sender, EventArgs e) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dipperDBDataSet.Years". При необходимости она может быть перемещена или удалена.
            this.yearsTableAdapter.Fill(this.dipperDBDataSet.Years);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dipperDBDataSet.Lessons". При необходимости она может быть перемещена или удалена.
            this.lessonsTableAdapter.Fill(this.dipperDBDataSet.Lessons);

        }
    }
}

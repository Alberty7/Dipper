﻿using System;
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

	public partial class Dipper : Form
	{
		private bool Logined = false;
		public Dipper()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void Enter_Click(object sender, EventArgs e)
		{
			using (Password dialog = new Password())
			{
				dialog.Owner = this;
				dialog.ShowDialog();
				Logined = dialog.isSuccsessful;
			}
		}

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void Sort_Click(object sender, EventArgs e)
		{

		}
	}
}

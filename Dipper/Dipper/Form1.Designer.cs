using System.ComponentModel;

namespace TimeTable
{
    partial class Dipper
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.Menu = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Enter = new System.Windows.Forms.Button();
			this.ToolBar = new System.Windows.Forms.ToolStrip();
			this.Create = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.Open = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.Sort = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.AddLesson = new System.Windows.Forms.ToolStripButton();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.Pull = new System.Windows.Forms.ListBox();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.Tables = new System.Windows.Forms.TabControl();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.Menu.SuspendLayout();
			this.ToolBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Menu
			// 
			this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
			this.Menu.Location = new System.Drawing.Point(0, 0);
			this.Menu.Name = "Menu";
			this.Menu.Size = new System.Drawing.Size(1109, 24);
			this.Menu.TabIndex = 0;
			this.Menu.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.toolStripSeparator1,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// создатьToolStripMenuItem
			// 
			this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
			this.создатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.создатьToolStripMenuItem.Text = "Создать";
			this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
			// 
			// открытьToolStripMenuItem
			// 
			this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
			this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.открытьToolStripMenuItem.Text = "Открыть";
			this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// сохранитьToolStripMenuItem
			// 
			this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
			this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.сохранитьToolStripMenuItem.Text = "Сохранить";
			this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
			// 
			// сохранитьКакToolStripMenuItem
			// 
			this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
			this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
			this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
			// 
			// Enter
			// 
			this.Enter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Enter.Location = new System.Drawing.Point(1030, 1);
			this.Enter.Name = "Enter";
			this.Enter.Size = new System.Drawing.Size(75, 23);
			this.Enter.TabIndex = 1;
			this.Enter.Text = "Вход";
			this.Enter.UseVisualStyleBackColor = true;
			this.Enter.Click += new System.EventHandler(this.Enter_Click);
			// 
			// ToolBar
			// 
			this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create,
            this.toolStripSeparator4,
            this.Open,
            this.toolStripSeparator3,
            this.Sort,
            this.toolStripSeparator5,
            this.AddLesson});
			this.ToolBar.Location = new System.Drawing.Point(0, 24);
			this.ToolBar.Name = "ToolBar";
			this.ToolBar.Size = new System.Drawing.Size(1109, 25);
			this.ToolBar.TabIndex = 2;
			this.ToolBar.Text = "toolStrip1";
			// 
			// Create
			// 
			this.Create.BackgroundImage = global::TimeTable.Properties.Resources._create_new_folder_90671;
			this.Create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Create.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Create.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Create.Name = "Create";
			this.Create.Size = new System.Drawing.Size(23, 22);
			this.Create.Text = "Создать";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// Open
			// 
			this.Open.BackgroundImage = global::TimeTable.Properties.Resources.folder_black_open_shape_icon_icons_com_56988;
			this.Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Open.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Open.Name = "Open";
			this.Open.Size = new System.Drawing.Size(23, 22);
			this.Open.Text = "Открыть";
			this.Open.Click += new System.EventHandler(this.Open_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// Sort
			// 
			this.Sort.BackgroundImage = global::TimeTable.Properties.Resources.filter_filters_funnel_list_navigation_sort_sorting_icon_123212;
			this.Sort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Sort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Sort.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Sort.Name = "Sort";
			this.Sort.Size = new System.Drawing.Size(23, 22);
			this.Sort.Text = "Сортировка";
			this.Sort.Click += new System.EventHandler(this.Sort_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// AddLesson
			// 
			this.AddLesson.BackgroundImage = global::TimeTable.Properties.Resources.add_circle_create_expand_new_plus_icon_123218;
			this.AddLesson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.AddLesson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.AddLesson.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.AddLesson.Name = "AddLesson";
			this.AddLesson.Size = new System.Drawing.Size(23, 22);
			this.AddLesson.Text = "Добавить предмет";
			this.AddLesson.Click += new System.EventHandler(this.AddLesson_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 49);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.Pull);
			this.splitContainer1.Panel1.Controls.Add(this.treeView1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.Tables);
			this.splitContainer1.Size = new System.Drawing.Size(1109, 580);
			this.splitContainer1.SplitterDistance = 248;
			this.splitContainer1.TabIndex = 5;
			// 
			// Pull
			// 
			this.Pull.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Pull.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Pull.FormattingEnabled = true;
			this.Pull.ItemHeight = 16;
			this.Pull.Location = new System.Drawing.Point(0, 0);
			this.Pull.Name = "Pull";
			this.Pull.Size = new System.Drawing.Size(248, 580);
			this.Pull.TabIndex = 1;
			this.Pull.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pull_MouseDown);
			// 
			// treeView1
			// 
			this.treeView1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.treeView1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.Location = new System.Drawing.Point(0, 0);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(248, 580);
			this.treeView1.TabIndex = 0;
			// 
			// Tables
			// 
			this.Tables.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Tables.HotTrack = true;
			this.Tables.Location = new System.Drawing.Point(0, 0);
			this.Tables.Name = "Tables";
			this.Tables.SelectedIndex = 0;
			this.Tables.Size = new System.Drawing.Size(857, 580);
			this.Tables.TabIndex = 3;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Dipper
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1109, 629);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.ToolBar);
			this.Controls.Add(this.Enter);
			this.Controls.Add(this.Menu);
			this.DoubleBuffered = true;
			this.Name = "Dipper";
			this.Text = "TimeTable";
			this.Menu.ResumeLayout(false);
			this.Menu.PerformLayout();
			this.ToolBar.ResumeLayout(false);
			this.ToolBar.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        new private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        new private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton Create;
        private System.Windows.Forms.ToolStripButton Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Sort;
        private System.Windows.Forms.ToolStripButton AddLesson;
		private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ListBox Pull;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		//public System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		public System.Windows.Forms.TabControl Tables;
	}
}


namespace Лаба_5
{
    partial class TableManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычислитьСреднийБаллToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelFlooded = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeStat = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеДанныхСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_table = new System.Windows.Forms.DataGridView();
            this.FIO_Stud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exam_Grades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scholarship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеToolStripMenuItem,
            this.ChangeStat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStudent,
            this.удалитьСтудентаToolStripMenuItem,
            this.вычислитьСреднийБаллToolStripMenuItem,
            this.DelFlooded});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(78, 26);
            this.данныеToolStripMenuItem.Text = "Данные";
            // 
            // AddStudent
            // 
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(389, 26);
            this.AddStudent.Text = "Добавить студента";
            this.AddStudent.Click += new System.EventHandler(this.добавитьСтудентаToolStripMenuItem_Click);
            // 
            // удалитьСтудентаToolStripMenuItem
            // 
            this.удалитьСтудентаToolStripMenuItem.Name = "удалитьСтудентаToolStripMenuItem";
            this.удалитьСтудентаToolStripMenuItem.Size = new System.Drawing.Size(389, 26);
            this.удалитьСтудентаToolStripMenuItem.Text = "Удалить студента";
            this.удалитьСтудентаToolStripMenuItem.Click += new System.EventHandler(this.удалитьСтудентаToolStripMenuItem_Click);
            // 
            // вычислитьСреднийБаллToolStripMenuItem
            // 
            this.вычислитьСреднийБаллToolStripMenuItem.Name = "вычислитьСреднийБаллToolStripMenuItem";
            this.вычислитьСреднийБаллToolStripMenuItem.Size = new System.Drawing.Size(389, 26);
            this.вычислитьСреднийБаллToolStripMenuItem.Text = "Средний балл и количество задолжностей";
            this.вычислитьСреднийБаллToolStripMenuItem.Click += new System.EventHandler(this.вычислитьСреднийБаллToolStripMenuItem_Click_1);
            // 
            // DelFlooded
            // 
            this.DelFlooded.Name = "DelFlooded";
            this.DelFlooded.Size = new System.Drawing.Size(389, 26);
            this.DelFlooded.Text = "Отчислить должников";
            this.DelFlooded.Click += new System.EventHandler(this.DelFlooded_Click_1);
            // 
            // ChangeStat
            // 
            this.ChangeStat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактированиеДанныхСтудентаToolStripMenuItem});
            this.ChangeStat.Name = "ChangeStat";
            this.ChangeStat.Size = new System.Drawing.Size(107, 26);
            this.ChangeStat.Text = "Изменение ";
            // 
            // редактированиеДанныхСтудентаToolStripMenuItem
            // 
            this.редактированиеДанныхСтудентаToolStripMenuItem.Name = "редактированиеДанныхСтудентаToolStripMenuItem";
            this.редактированиеДанныхСтудентаToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.редактированиеДанныхСтудентаToolStripMenuItem.Text = "Редактирование данных студента";
            // 
            // dataGridView_table
            // 
            this.dataGridView_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO_Stud,
            this.Exam_Grades,
            this.Activity,
            this.Scholarship});
            this.dataGridView_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_table.Location = new System.Drawing.Point(0, 30);
            this.dataGridView_table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_table.Name = "dataGridView_table";
            this.dataGridView_table.RowHeadersWidth = 51;
            this.dataGridView_table.RowTemplate.Height = 24;
            this.dataGridView_table.Size = new System.Drawing.Size(800, 420);
            this.dataGridView_table.TabIndex = 1;
            // 
            // FIO_Stud
            // 
            this.FIO_Stud.HeaderText = "Группа";
            this.FIO_Stud.MinimumWidth = 6;
            this.FIO_Stud.Name = "FIO_Stud";
            this.FIO_Stud.Width = 140;
            // 
            // Exam_Grades
            // 
            this.Exam_Grades.HeaderText = "Фамилия";
            this.Exam_Grades.MinimumWidth = 6;
            this.Exam_Grades.Name = "Exam_Grades";
            this.Exam_Grades.Width = 140;
            // 
            // Activity
            // 
            this.Activity.HeaderText = "Результаты экзаменов";
            this.Activity.MinimumWidth = 6;
            this.Activity.Name = "Activity";
            this.Activity.Width = 140;
            // 
            // Scholarship
            // 
            this.Scholarship.HeaderText = "Результаты зачётов";
            this.Scholarship.MinimumWidth = 6;
            this.Scholarship.Name = "Scholarship";
            this.Scholarship.Width = 140;
            // 
            // TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_table);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "TableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableManager";
            this.Activated += new System.EventHandler(this.TableManager_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddStudent;
        private System.Windows.Forms.ToolStripMenuItem ChangeStat;
        private System.Windows.Forms.DataGridView dataGridView_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO_Stud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exam_Grades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scholarship;
        private System.Windows.Forms.ToolStripMenuItem удалитьСтудентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вычислитьСреднийБаллToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelFlooded;
        private System.Windows.Forms.ToolStripMenuItem редактированиеДанныхСтудентаToolStripMenuItem;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_5
{
    public partial class TableManager : Form
    {
        public static List<Student> table_of_students = new List<Student>();
        public static List<Student> dolzhniki = new List<Student>();
        public TableManager()
        {
            InitializeComponent();
            Student student = new Student("20-КБ-ПР1", "Козловская", "44445", "ЗЗЗЗЗ");
            table_of_students.Add(student);
            student = new Student("20-КБ-ПР2", "Филимонов", "55555", "ЗЗЗЗЗ");
            table_of_students.Add(student);
            student = new Student("20-КБ-ПР1", "Гаршин", "44555", "ЗЗЗЗЗ");
            table_of_students.Add(student);
            student = new Student("20-КБ-ПР1", "Тальянская", "55555", "ЗЗЗЗЗ");
            table_of_students.Add(student);
            student = new Student("20-КБ-ПР3", "Торосян", "33223", "ННЗЗН");
            table_of_students.Add(student);
            student = new Student("20-КБ-ПР3", "Байталенко", "23323", "ННЗЗЗ");
            table_of_students.Add(student);
        }


        private void добавитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudents add = new AddStudents();
            add.Show();
        }

        private void SingleFromListToGrid()
        {
            foreach (Student item in table_of_students)
                dataGridView_table.Rows.Add(item.group, item.fio, item.exam_grade, item.zachyot);
            
        }

        private void AllFromListToGrid()
        {
            foreach (Student item in Data.list_of_stud)
                dataGridView_table.Rows.Add(item.group, item.fio, item.exam_grade, item.zachyot);
        }

        private void CalcScholar_Click(object sender, EventArgs e)
        {
            foreach (Student student in Data.list_of_stud)
            dataGridView_table.Rows.Clear();
            AllFromListToGrid();
        }

        private void ChangeActivity_Click(object sender, EventArgs e)
        {
            dataGridView_table.Rows.Clear();
            AllFromListToGrid();
        }

        private void сохранитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            
            for (int i = 0; i < dataGridView_table.Rows.Count; i++)
                for (int j = 0; j < dataGridView_table.ColumnCount; j++)
                    ExcelApp.Cells[i + 1, j + 1] = dataGridView_table.Rows[i].Cells[j].Value;
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void редактированиеДанныхСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
        }

        private void TableManager_Activated(object sender, EventArgs e)
        {
            dataGridView_table.Rows.Clear();
            foreach (Student item in table_of_students)
                dataGridView_table.Rows.Add(item.group, item.fio, item.exam_grade, item.zachyot);
        }

        private void удалитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
        }

        private void вычислитьСреднийБаллToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Average_Form average = new Average_Form();
            average.Show();
        }

        private void DelFlooded_Click_1(object sender, EventArgs e)
        {
            foreach (Student item in table_of_students)
            {
                if (item.dolg_e + item.dolg_z >= 3)
                    dolzhniki.Add(item);
            }
            foreach (Student item in dolzhniki)
            {
                table_of_students.Remove(item);
            }

        }
    }
}

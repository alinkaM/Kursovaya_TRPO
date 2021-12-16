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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button_enter_in_login_Click(object sender, EventArgs e)
        {
            Student student = new Student("", "", "", "");
            if (Group_Box.Text != "" && textBox_stud_fio.Text != "")
            {
                foreach (var item in TableManager.table_of_students)
                    if (item.group == Group_Box.Text && item.fio == textBox_stud_fio.Text)
                        student = item;

                TableManager.table_of_students.Remove(student);
                this.Close();
            }
            else
                MessageBox.Show("Для изменения данных студента необходимо заполнить два первых поля, исзменить можно только последних два поля");

        }
    }
}

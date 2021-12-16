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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void Load_Form(object sender, EventArgs e)
        {
            MessageBox.Show("Заполняйте только те поля, которые нужно изменить (результаты экзаменов или зачётов, или и то, и другое");
        }

        private void button_enter_in_login_Click(object sender, EventArgs e)
        {
            int index = 0;
            Student student = new Student("", "", "", "");
            if (Group_Box.Text != "" && textBox_stud_fio.Text != "")
            {
                int i = 0;
                foreach (var item in TableManager.table_of_students)
                {
                    i++;
                    if (item.group == Group_Box.Text && item.fio == textBox_stud_fio.Text)
                    {
                        index = i;
                        if (textBox_exams.Text != "")
                        {
                            student.exam_grade = textBox_exams.Text;
                        }
                        if (textBox_Offset_Zachyot.Text != "")
                        {
                            student.zachyot = textBox_Offset_Zachyot.Text;
                        }
                    }
                }

                if (student.exam_grade != "")
                    TableManager.table_of_students[index - 1].exam_grade = student.exam_grade;

                if (student.zachyot != "")
                    TableManager.table_of_students[index - 1].zachyot = student.zachyot;

                this.Close();
            }
            else
                MessageBox.Show("Для изменения данных студента необходимо заполнить два первых поля, исзменить можно только последних два поля");
             
        }
    }
}

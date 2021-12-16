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
    public partial class AddStudents : Form
    {
        public AddStudents()
        {
            InitializeComponent();
        }

        private void button_enter_in_login_Click(object sender, EventArgs e)
        {
            bool check = true;
            int num;
            if (Group_Box.Text != "" && textBox_stud_fio.Text != "" && textBox_exams.Text != "" && textBox_Offset_Zachyot.Text != "")
            {
                if (check == Int32.TryParse(textBox_exams.Text, out num))
                {
                    Student student = new Student(Group_Box.Text, textBox_stud_fio.Text, textBox_exams.Text, textBox_Offset_Zachyot.Text);
                    TableManager.table_of_students.Add(student);
                    this.Close();
                }
                else
                    MessageBox.Show("Поле 'Результаты экзаменов' заполнено неправильно");
            }
            else
                MessageBox.Show("Вы не заполнили кокое-то из полей");
            
        }

        
    }
}

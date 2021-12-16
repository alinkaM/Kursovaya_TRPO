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
    public partial class Average_Form : Form
    {
        public Average_Form()
        {
            InitializeComponent();
        }

        private void button_enter_in_login_Click(object sender, EventArgs e)
        {
            double average = 0;
            if (Group_Box.Text != "")
            {
                GridResult.Rows.Clear();
                int i = 0;
                foreach (Student item in TableManager.table_of_students)
                    if (item.group == Group_Box.Text)
                    {
                        i++;
                        average += item.Average();
                        GridResult.Rows.Add(item.fio, item.Average(), item.dolg_e + item.dolg_z);
                    }
                Label_Result.Text = $"{average/i:f1}";
            }
            else
                MessageBox.Show("Вы не заполнили поле 'Номер группы'");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

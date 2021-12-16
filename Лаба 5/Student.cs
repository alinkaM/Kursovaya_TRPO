using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_5
{
    public class Student
    {
        public string group;
        public string fio;
        public string exam_grade;
        public string zachyot;
        public int dolg_e = 0;
        public int dolg_z = 0;

        public Student(string group, string fio, string exam_grade, string zachyot)
        {
            this.group = group;
            this.fio = fio;
            this.exam_grade = exam_grade;
            this.zachyot = zachyot;
            for (int i = 0; i < 5; i++)
            {
                if (exam_grade[i].ToString() == "2" || exam_grade[i].ToString() == "1")
                    dolg_e++;

                if (zachyot[i].ToString() == "Н")
                    dolg_z++;
            }
        }

        public double Average()
        {
            double average = 0;
            int t = 0;
            char[] ch = this.exam_grade.ToCharArray();
            for (int i = 0; i < 5; i++)
            {
                t += Convert.ToInt32(ch[i].ToString()) ;
            }
            if (t % 5 < 3)
                average = t / 5;
            else
                average = t / 5 + 1;
            return average;
        }
    }
}
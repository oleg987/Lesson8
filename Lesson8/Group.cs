using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Group
    {
        private Student[] students;

        public string Title { get; set; }
        //public double Average { get; set; }

        public Group()
        {
            students = new Student[0];
        }

        public Group(string title)
        {
            Title = title;
        }

        public void AddStudent(Student student)
        {
            if (student != null)
            {
                if (students == null)
                {
                    students = new Student[0];
                }
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;

                student.AddToGroup(this);
                //AverageMark();
            }
        }

        public double AverageMark()
        {
            double result = 0;

            if (students != null && students.Length > 0)
            {
                foreach (Student student in students)
                {
                    result += student.AverageMark();
                }

                result /= students.Length;
            }

            return Math.Round(result, 2);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(Title);

            if (students != null && students.Length > 0)
            {
                foreach (Student student in students)
                {
                    builder.AppendLine(student.Name);
                }
            }
            else
            {
                builder.AppendLine("Group has no students");
            }

            //string result = $"{Title}\n";

            //if (students != null && students.Length > 0)
            //{
            //    foreach (Student student in students)
            //    {
            //        result += student.Name + "\n";
            //    }
            //}
            //else
            //{
            //    result += "Group has no students\n";
            //}

            return builder.ToString();
        }
    }
}

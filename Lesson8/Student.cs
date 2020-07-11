using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Student
    {
        private Mark[] marks;
        private Group group;
        public string Name { get; set; }
        public string GroupTitle { get => group.Title ?? "No group"; }

        public Student(string name)
        {
            Name = name;
            marks = new Mark[0];
        }

        public void AddMark(Mark mark)
        {
            if (mark != null)
            {
                if (marks == null)
                {
                    marks = new Mark[0];
                }

                Array.Resize(ref marks, marks.Length + 1);
                marks[marks.Length - 1] = mark;
            }
        }

        public double AverageMark()
        {
            double result = 0;

            if (marks != null && marks.Length > 0)
            {
                foreach (Mark mark in marks)
                {
                    result += mark.Value;
                }

                result /= marks.Length;
            }

            return result;
        }

        public void AddToGroup(Group group)
        {
            this.group = group;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}

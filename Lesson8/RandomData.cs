using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    static class RandomData
    {        
        private static Random r = new Random();

        public static Mark[] GetMarks(int count)
        {
            Mark[] marks = new Mark[count];
            
            for (int i = 0; i < count; i++)
            {
                marks[i] = new Mark(r.Next(4), r.Next(101));
            }

            return marks;
        }

        public static Student[] GetStudents(int count, bool withMarks = true)
        {
            Student[] students = new Student[count];
            
            string[] firstNames = { "John", "Mike", "Fred", "Alice", "Ann", "Kate" };
            string[] lastNames = { "Connor", "Doe", "Smit", "Dias" };

            for (int i = 0; i < count; i++)
            {
                students[i] = new Student(firstNames[r.Next(firstNames.Length)] + " " + lastNames[r.Next(lastNames.Length)]);

                if (withMarks)
                {
                    int marksCount = r.Next(1, 16);

                    Mark[] marks = GetMarks(marksCount);

                    foreach (Mark mark in marks)
                    {
                        students[i].AddMark(mark);
                    }
                }
            }

            return students;
        }

        public static Group[] GetGroups(int count, bool withStudents = true)
        {
            Group[] groups = new Group[count];
            
            for (int i = 0; i < count; i++)
            {
                groups[i] = new Group($"Group #{i}");

                if (withStudents)
                {
                    int studentsCount = r.Next(1, 10);

                    Student[] students = GetStudents(studentsCount);

                    foreach (Student student in students)
                    {
                        groups[i].AddStudent(student);
                    }
                }
            }

            return groups;
        }        
    }

}

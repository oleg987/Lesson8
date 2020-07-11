using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {
        static void Main()
        {
            Group[] groups = RandomData.GetGroups(2);

            Console.WriteLine(groups[0].AverageMark());
            Console.WriteLine(groups[1].AverageMark());

            Student s = new Student("S");
            
        }
    }
}

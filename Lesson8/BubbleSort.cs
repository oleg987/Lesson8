using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    static class BubbleSort
    {
        public static void SortASC(Mark[] sortArr)
        {
            for (int i = 0; i < sortArr.Length; i++)
            {
                for (int j = 0; j < sortArr.Length; j++)
                {
                    if (sortArr[i].Value > sortArr[j].Value)
                    {
                        Mark temp = sortArr[i];
                        sortArr[i] = sortArr[j];
                        sortArr[j] = temp;
                    }
                }
            }
        }
    }
}

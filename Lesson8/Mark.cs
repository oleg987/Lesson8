using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public enum Subjects
    {
        Phisics,
        Chemistry,
        Math,
        Programming
    }
    class Mark
    {
        private int value;

        public Subjects Subject { get; set; }
        public int Value { get => value; set => this.value = (value >= 0 && value <= 100) ? value : throw new ArgumentOutOfRangeException("Mark  is out of range"); }

        public Mark(int subject, int value)
        {
            Subject = (Subjects)subject;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Subject} - {Value}";
        }
    }
}

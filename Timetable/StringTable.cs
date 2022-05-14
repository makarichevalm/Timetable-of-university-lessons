using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable
{
    public class StringTable
    {
        public string Teacher{ get; set; }
        public string Lesson { get; set; }
        public string TypeLesson { get; set; }
        public string Group { get; set; }
        public string Time { get; set; }
        public StringTable(string teacher, string lesson, string type, string group, string time)
        {
            Teacher = teacher;
            Lesson = lesson;
            TypeLesson = type;
            Group = group;
            Time = time;
        }

    }
}

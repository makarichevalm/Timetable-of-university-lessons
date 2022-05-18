using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable
{
    public class StringTable
    {
        public string Teacher { get; set; }// ФИО преподавателя
        public string Lesson { get; set; }// Название предмета
        public string TypeLesson { get; set; }//Тип занятия
        public string Group { get; set; }//Учебная группа
        public string Day{get; set;}// День недели
        public string Time { get; set; }//Время проведения
        public StringTable(string teacher, string lesson, string type, string group, string day, string time)
        {
            Teacher = teacher;
            Lesson = lesson;
            TypeLesson = type;
            Group = group;
            Day = day;
            Time = time;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable
{
    public partial class Form3 : Form
    {
        
        public Form3(StringTable str)//StringTable str
        {
            InitializeComponent();
            teacher.Text = str.Teacher;
            lesson.Text = str.Lesson;
            typeLesson.Text = str.TypeLesson;
            group.Text = str.Group;
            time.Text = str.Time;
            string day = str.Day;
            if (day == "Пн")
                radioButton1.Checked = true;
            if (day == "Вт")
                radioButton2.Checked = true;
            if (day == "Ср")
                radioButton3.Checked = true;
            if (day == "Чт")
                radioButton4.Checked = true;
            if (day == "Пт")
                radioButton5.Checked = true;
            if (day == "Сб")
                radioButton6.Checked = true;
        }
        private bool IsEmpty()
        {
            textTeacher.Text = "";
            textLesson.Text = "";
            textType.Text = "";
            textGroup.Text = "";
            textDay.Text = "";
            textTime.Text = "";
            bool flag = false;
            if (typeLesson.SelectedIndex == -1)
            {
                textType.Text = "Заполните поле <Тип занятия>";
                textType.ForeColor = Color.Red;
                flag = true;
            }
            if (time.SelectedIndex == -1)
            {
                textTime.Text = "Заполните поле <Время проведения>";
                textTime.ForeColor = Color.Red;
                flag = true;
            }
            if (string.IsNullOrEmpty(group.Text))
            {
                textGroup.Text = "Заполните поле <Группа>";
                textGroup.ForeColor = Color.Red;
                flag = true;
            }
            if (string.IsNullOrEmpty(lesson.Text))
            {
                textLesson.Text = "Заполните поле <Название предмета>";
                textLesson.ForeColor = Color.Red;
                flag = true;
            }
            if (string.IsNullOrEmpty(teacher.Text))
            {
                textTeacher.Text = "Заполните поле <Преподаватель>";
                textTeacher.ForeColor = Color.Red;
                flag = true;
            }
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked && !radioButton5.Checked && !radioButton6.Checked)
            {
                textDay.Text = "Заполните поле <День недели>";
                textDay.ForeColor = Color.Red;
                flag = true;
            }
            return flag;
        }
        private bool IsChecked()
        {
            textTeacher.Text = "";
            textLesson.Text = "";
            textType.Text = "";
            textGroup.Text = "";
            textTime.Text = "";
            bool flag = false;
            Regex regTeacher = new Regex(@"^[А-ЯЁ]+[а-яё]+ ([А-ЯЁ]+[а-яё]* [А-ЯЁ]+[а-яё]*$|[А-ЯЁ][.] [А-ЯЁ][.]$|[А-ЯЁ][.][А-ЯЁ][.])");
            Regex regGroup = new Regex(@"^\d{2}([А-ЯЁ]{2}|[а-яё]{2})\d$");
            if (!regTeacher.IsMatch(teacher.Text))
            {
                textTeacher.Text = "Примеры ввода: Лутов Иван Олегович, Лутов И. О., Лутов И.О.";
                textTeacher.ForeColor = Color.Red;
                flag = true;
            }
            if (!regGroup.IsMatch(group.Text))
            {
                textGroup.Text = "Примеры ввода: 20ВТ2, 41кр6";
                textGroup.ForeColor = Color.Red;
                flag = true;
            }
            return flag;
        }
        private void buttonReset3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOk3_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
                return;
            else if (IsChecked())
                return;
            else
            {

                string teacherBox = teacher.Text;
                string lessonBox = lesson.Text;
                string typeBox = typeLesson.Text;
                string groupBox = group.Text;
                string dayBox = "";
                string timeBox = time.Text;
                if (radioButton1.Checked)
                    dayBox = radioButton1.Text;
                if (radioButton2.Checked)
                    dayBox = radioButton2.Text;
                if (radioButton3.Checked)
                    dayBox = radioButton3.Text;
                if (radioButton4.Checked)
                    dayBox = radioButton4.Text;
                if (radioButton5.Checked)
                    dayBox = radioButton5.Text;
                if (radioButton6.Checked)
                    dayBox = radioButton6.Text;
                StringTable mainStr = new StringTable(teacherBox, lessonBox, typeBox, groupBox, dayBox, timeBox);
                Form1.mainStr = mainStr;
            }
            Close();
        }
    }
}

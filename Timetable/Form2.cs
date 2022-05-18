using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Timetable
{
    public partial class Form2 : Form
    {
        public static string TeacherBox = "";
        public static string LessonBox = "";
        public static string TypeBox = "";
        public static string GroupBox = "";
        public static string DayBox = "";
        public static string TimeBox = "";
        
        public Form2()
        {
            InitializeComponent();
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
            if (!radio1.Checked && !radio2.Checked && !radio3.Checked && !radio4.Checked && !radio5.Checked && !radio6.Checked)
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
        private void buttonReset2_Click(object sender, EventArgs e)
        {
            TeacherBox = "";
            LessonBox = "";
            TypeBox = "";
            GroupBox = "";
            TimeBox = "";
            Close();
        }
        private void buttonOk2_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
                return;
            else if (IsChecked())
                return;
            else
            {
                TeacherBox = teacher.Text;
                LessonBox = lesson.Text;
                TypeBox = typeLesson.Text;
                GroupBox = group.Text;
                TimeBox = time.Text;
                if (radio1.Checked)
                    DayBox = radio1.Text;
                if (radio2.Checked)
                    DayBox = radio2.Text;
                if (radio3.Checked)
                    DayBox = radio3.Text;
                if (radio4.Checked)
                    DayBox = radio4.Text;
                if (radio5.Checked)
                    DayBox = radio5.Text;
                if (radio6.Checked)
                    DayBox = radio6.Text;
                Close();
            }   
        }
    }
}

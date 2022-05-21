using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Timetable
{
    public partial class Form1 : Form
    {
        const string FILE = "TimetableData.json";
        List<StringTable> stroke = new List<StringTable>();//список объектов, которые будут лежать в Json
        public static StringTable mainStr;
        int rownumb = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Form2 FormAdd = new Form2();
            FormAdd.ShowDialog();
            string teacherBox = Form2.TeacherBox;
            string lessonBox = Form2.LessonBox;
            string typeBox = Form2.TypeBox;
            string groupBox = Form2.GroupBox;
            string dayBox = Form2.DayBox;
            string timeBox = Form2.TimeBox;
            StringTable newStr = new StringTable(teacherBox, lessonBox, typeBox, groupBox, dayBox, timeBox);
            if (!string.IsNullOrEmpty(teacherBox) && !string.IsNullOrEmpty(lessonBox) && !string.IsNullOrEmpty(typeBox)
            && !string.IsNullOrEmpty(groupBox) && !string.IsNullOrEmpty(timeBox))
            {
                if (!stroke.Contains(newStr))
                {
                    //занят преподаватель
                    foreach (var str in stroke)
                    {
                        if (str.Teacher == teacherBox && str.Day == dayBox && str.Time == timeBox)
                        {
                            MessageBox.Show($"У преподавателя {str.Teacher} уже есть {str.TypeLesson} " +
                                 $"по предмету '{str.Lesson}'у группы {str.Group} в {str.Day}" +
                                 $" в {str.Time}.", "Добавление записи", 0, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    // занята группа
                    foreach (var str in stroke)
                    {
                        if (str.Group == groupBox && str.Day == dayBox && str.Time == timeBox)
                        {
                            MessageBox.Show($"У группы {str.Group} уже есть {str.TypeLesson} " +
                                $"по предмету '{str.Lesson}' преподавателя {str.Teacher} в {str.Day}" +
                                $" в {str.Time}.", "Добавление записи", 0, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    stroke.Add(newStr);
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[rownumb].Cells[0].Value = (Convert.ToString(teacherBox));
                    dataGridView1.Rows[rownumb].Cells[1].Value = (Convert.ToString(lessonBox));
                    dataGridView1.Rows[rownumb].Cells[2].Value = (Convert.ToString(typeBox));
                    dataGridView1.Rows[rownumb].Cells[3].Value = (Convert.ToString(groupBox));
                    dataGridView1.Rows[rownumb].Cells[4].Value = (Convert.ToString(dayBox));
                    dataGridView1.Rows[rownumb].Cells[5].Value = (Convert.ToString(timeBox));
                    rownumb++;
                }
                else
                {
                    MessageBox.Show($"Эта строка в таблице уже есть", "Добавление записи", 0, MessageBoxIcon.Information);
                    return;
                }
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (!File.Exists(FILE))
            {
                FileStream f = File.Create(FILE);
                f.Close();
            }
            using (StreamWriter file = new StreamWriter(FILE, false))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, stroke);
            }
            MessageBox.Show("Изменения сохранены!", "Сохранение", 0, MessageBoxIcon.Information);
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            Int32 selectCount =
        dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (selectCount > 0)
            {
                string teacher = dataGridView1.SelectedCells[0].Value.ToString();
                string lesson = dataGridView1.SelectedCells[1].Value.ToString();
                string typeLesson = dataGridView1.SelectedCells[2].Value.ToString();
                string group = dataGridView1.SelectedCells[3].Value.ToString();
                string day = dataGridView1.SelectedCells[4].Value.ToString();
                string time = dataGridView1.SelectedCells[5].Value.ToString();
                foreach (var str in stroke)
                {
                    if (teacher == str.Teacher && lesson == str.Lesson && typeLesson == str.TypeLesson
                        && group == str.Group && day == str.Day && time == str.Time)
                    {
                        stroke.Remove(str);
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                        rownumb--;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Данных не существует!", "Удаление",0, MessageBoxIcon.Information);
                return;
            }
        }
        private void Change_Click(object sender, EventArgs e)
        {
            Int32 selectCount =
        dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (selectCount > 0)
            {
                string teacher = dataGridView1.SelectedCells[0].Value.ToString();
                string lesson = dataGridView1.SelectedCells[1].Value.ToString();
                string typeLesson = dataGridView1.SelectedCells[2].Value.ToString();
                string group = dataGridView1.SelectedCells[3].Value.ToString();
                string day = dataGridView1.SelectedCells[4].Value.ToString();
                string time = dataGridView1.SelectedCells[5].Value.ToString();
                foreach (var str in stroke)
                {
                    if (teacher == str.Teacher && lesson == str.Lesson && typeLesson == str.TypeLesson
                        && group == str.Group && day == str.Day && time == str.Time)
                    {
                        mainStr = str;
                        Form3 FormChange = new Form3(str, stroke);
                        FormChange.ShowDialog();
                        str.Teacher = mainStr.Teacher;
                        str.Lesson = mainStr.Lesson;
                        str.TypeLesson = mainStr.TypeLesson;
                        str.Group = mainStr.Group;
                        str.Day = mainStr.Day;
                        str.Time = mainStr.Time;
                        dataGridView1.SelectedCells[0].Value = str.Teacher;
                        dataGridView1.SelectedCells[1].Value = str.Lesson;
                        dataGridView1.SelectedCells[2].Value = str.TypeLesson;
                        dataGridView1.SelectedCells[3].Value = str.Group;
                        dataGridView1.SelectedCells[4].Value = str.Day;
                        dataGridView1.SelectedCells[5].Value = str.Time;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show($"Данных не существует! {Environment.NewLine} Добавьте записи.", "Редактирование", 0, MessageBoxIcon.Information);
                return;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Form FormInfo = new FormInfo();
            FormInfo.ShowDialog();
            if (File.Exists(FILE))
            {
                var obj = JsonConvert.DeserializeObject<List<StringTable>>(File.ReadAllText(FILE));
                if (obj != null)
                    foreach (var str in obj)
                    {
                        stroke.Add(new StringTable(str.Teacher, str.Lesson, str.TypeLesson, str.Group, str.Day, str.Time));
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[rownumb].Cells[0].Value = str.Teacher;
                        dataGridView1.Rows[rownumb].Cells[1].Value = str.Lesson;
                        dataGridView1.Rows[rownumb].Cells[2].Value = str.TypeLesson;
                        dataGridView1.Rows[rownumb].Cells[3].Value = str.Group;
                        dataGridView1.Rows[rownumb].Cells[4].Value = str.Day;
                        dataGridView1.Rows[rownumb].Cells[5].Value = str.Time;
                        rownumb++;
                    }
            }
        }
        private void ButtonDeleteAll_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count != 0)
            {
                stroke.Clear();
                dataGridView1.Rows.Clear();
                rownumb = 0;
            }
            else
            {
                MessageBox.Show("Все данные удалены!", "Очистить всё", 0, MessageBoxIcon.Information);
            }
            File.Delete(FILE);
        }
        private void ButtonFiltr_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            if (string.IsNullOrEmpty(textFiltr.Text))
            {
                label4.Text = "Заполните поле";
                label4.ForeColor = Color.Maroon;
                return;
            }
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Выберите критерий фильтрации!", "Фильтрация", 0, MessageBoxIcon.Exclamation);
                return;
            }
            string filtrText = textFiltr.Text;
            dataGridView1.Rows.Clear();
            rownumb = 0;
            if (radioButton1.Checked)
                FilteringByTeacher(filtrText);
            else if (radioButton2.Checked)
                FilteringByTime(filtrText);
            else
                FilteringByGroup(filtrText);
        }
        private void FilteringByTeacher(string textFiltr)
        {
            bool fl = false;
            foreach (var str in stroke)
            {
                if(str.Teacher == textFiltr)
                {
                    fl = true;
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[rownumb].Cells[0].Value = str.Teacher;
                    dataGridView1.Rows[rownumb].Cells[1].Value = str.Lesson;
                    dataGridView1.Rows[rownumb].Cells[2].Value = str.TypeLesson;
                    dataGridView1.Rows[rownumb].Cells[3].Value = str.Group;
                    dataGridView1.Rows[rownumb].Cells[4].Value = str.Day;
                    dataGridView1.Rows[rownumb].Cells[5].Value = str.Time;
                    rownumb++;
                }
            }
            if (fl == false)
                MessageBox.Show($"Данные о занятости преподавателя {textFiltr} не найдены!", "Фильтрация", 0, MessageBoxIcon.Information) ;
        }
        private void FilteringByTime(string textFiltr)
        {
            bool fl = false;
            foreach (var str in stroke)
            {
                if (str.Time == textFiltr)
                {
                    fl = true;
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[rownumb].Cells[0].Value = str.Teacher;
                    dataGridView1.Rows[rownumb].Cells[1].Value = str.Lesson;
                    dataGridView1.Rows[rownumb].Cells[2].Value = str.TypeLesson;
                    dataGridView1.Rows[rownumb].Cells[3].Value = str.Group;
                    dataGridView1.Rows[rownumb].Cells[4].Value = str.Day;
                    dataGridView1.Rows[rownumb].Cells[5].Value = str.Time;
                    rownumb++;
                }
            }
            if (fl == false)
                MessageBox.Show($"В расписании время {textFiltr} не занято!", "Фильтрация", 0, MessageBoxIcon.Information);
        }
        private void FilteringByGroup(string textFiltr)
        {
            bool fl = false;
            foreach (var str in stroke)
            {
                if (str.Group == textFiltr)
                {
                    fl = true;
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[rownumb].Cells[0].Value = str.Teacher;
                    dataGridView1.Rows[rownumb].Cells[1].Value = str.Lesson;
                    dataGridView1.Rows[rownumb].Cells[2].Value = str.TypeLesson;
                    dataGridView1.Rows[rownumb].Cells[3].Value = str.Group;
                    dataGridView1.Rows[rownumb].Cells[4].Value = str.Day;
                    dataGridView1.Rows[rownumb].Cells[5].Value = str.Time;
                    rownumb++;
                }
            }
            if (fl == false)
                MessageBox.Show($"Данные о занятости группы {textFiltr} не найдены!", "Фильтрация", 0, MessageBoxIcon.Information) ;
        }
        private void ButtonFiltrOff_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textFiltr.Text))
            {
                MessageBox.Show($"Фильтрация не применена!", "Фильтрация", 0, MessageBoxIcon.Information);
                return;
            }
            textFiltr.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            dataGridView1.Rows.Clear();
            rownumb = 0;
            foreach (var str in stroke)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[rownumb].Cells[0].Value = str.Teacher;
                dataGridView1.Rows[rownumb].Cells[1].Value = str.Lesson;
                dataGridView1.Rows[rownumb].Cells[2].Value = str.TypeLesson;
                dataGridView1.Rows[rownumb].Cells[3].Value = str.Group;
                dataGridView1.Rows[rownumb].Cells[4].Value = str.Day;
                dataGridView1.Rows[rownumb].Cells[5].Value = str.Time;
                rownumb++;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Сохранить изменения?", "Сохранение", 
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                Save_Click(sender, e);
            }
            if(result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}

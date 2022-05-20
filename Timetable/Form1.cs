using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if(!string.IsNullOrEmpty(teacherBox) && !string.IsNullOrEmpty(lessonBox) && !string.IsNullOrEmpty(typeBox) 
                && !string.IsNullOrEmpty(groupBox) && !string.IsNullOrEmpty(timeBox)) { 
                stroke.Add(new StringTable(teacherBox, lessonBox, typeBox, groupBox, dayBox, timeBox));
                dataGridView1.Rows.Add();
                dataGridView1.Rows[rownumb].Cells[0].Value = (Convert.ToString(teacherBox));
                dataGridView1.Rows[rownumb].Cells[1].Value = (Convert.ToString(lessonBox));
                dataGridView1.Rows[rownumb].Cells[2].Value = (Convert.ToString(typeBox));
                dataGridView1.Rows[rownumb].Cells[3].Value = (Convert.ToString(groupBox));
                dataGridView1.Rows[rownumb].Cells[4].Value = (Convert.ToString(dayBox));
                dataGridView1.Rows[rownumb].Cells[5].Value = (Convert.ToString(timeBox));
                rownumb++;
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
                        Form3 FormChange = new Form3(str);
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
                MessageBox.Show("Выберите данные для редактирования!", "Редактирование", 0, MessageBoxIcon.Exclamation);
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
        private void ButtonFind_Click(object sender, EventArgs e)
        {
        }
    }
}

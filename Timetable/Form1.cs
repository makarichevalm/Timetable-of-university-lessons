﻿using Newtonsoft.Json;
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
        private List<StringTable> stroke = new List<StringTable>();//список объектов, которые будут лежать в Json
        int rownumb = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Автор: студент группы 20ВП1 Макаричева Е.М.{Environment.NewLine}Вариант 15{Environment.NewLine}Тема: Расписание занятий в университете", "Информация");
           // string path = @"D:\2 курс\2 ООП (C#)\курсовая\Timetable-of-university-lessons\Timetable\timetableData.json";
            //FileInfo fileInfo = new FileInfo(path);
            //if (fileInfo.Exists)
                //label2.Text = $"Имя файла: {fileInfo.Name}";
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
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
            //int rowNumber = dgv.Rows.Add();
            //FormAdd.Group = 
            
                //--label2.Text = teacherBox+ "\n" + lessonBox + "\n" + typeBox + "\n" + groupBox + "\n" + timeBox;
                //string text = "hello world";
                /*using (FileStream fstream = new FileStream(@"D:\2 курс\2 ООП (C#)\курсовая\Timetable-of-university-lessons\Timetable\timetableData.txt", FileMode.OpenOrCreate))
                {
                    byte[] input = Encoding.Default.GetBytes(text);
                    fstream.Write(input, 0, input.Length);
                    //label2.Text = "Файл создан";
                }*/

                //fstream.Close();
                
            //for (int i = 0; i < stroke.Count; i++)
            //{
            /*foreach (var str in stroke)
            {
                label2.Text+= str.Teacher + "--" + str.Lesson + "--" + str.TypeLesson + "--" + str.Group + "--" + str.Time;
            }*/
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
            /*File.WriteAllText("timetableData.json", JsonConvert.SerializeObject(
        stroke.Select(str => new { url = hash }),
        Formatting.Indented));
            File.WriteAllText("timetableData.json", stroke, Formatting.Indented);*/
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
                //label2.Text = teacher + "--" + lesson + "--" + typeLesson + "--" + group + "--" + time; //Convert.ToString(selectCount);
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
                MessageBox.Show("Выберите данные для удаления!");
                return;
            }
            label2.Text = "";
                foreach (var str in stroke)
                {
                    label2.Text += str.Teacher + "--" + str.Lesson + "--" + str.TypeLesson + "--" + str.Group + "--" + str.Day + "--" + str.Time + "\n";
                }
            }

        private void Change_Click(object sender, EventArgs e)
        {
            /*Int32 selectCount =
        dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (selectCount > 0)
            {
                string teacher = dataGridView1.SelectedCells[0].Value.ToString();
                string lesson = dataGridView1.SelectedCells[1].Value.ToString();
                string typeLesson = dataGridView1.SelectedCells[2].Value.ToString();
                string group = dataGridView1.SelectedCells[3].Value.ToString();
                string day = dataGridView1.SelectedCells[4].Value.ToString();
                string time = dataGridView1.SelectedCells[5].Value.ToString();
                //label2.Text = teacher + "--" + lesson + "--" + typeLesson + "--" + group + "--" + time; //Convert.ToString(selectCount);
                foreach (var str in stroke)
                {
                    if (teacher == str.Teacher && lesson == str.Lesson && typeLesson == str.TypeLesson
                        && group == str.Group && day == str.Day && time == str.Time)
                    {
                        Form3 FormChange = new Form3(str);
                        FormChange.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите данные для удаления!");
                return;
            }
        */
            Form3 FormChange = new Form3();
            FormChange.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form FormInfo = new FormInfo();
            FormInfo.ShowDialog();
        }
    }
}

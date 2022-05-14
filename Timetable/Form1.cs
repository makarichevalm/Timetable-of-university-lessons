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
        public Form1()
        {
            InitializeComponent();
            
            

            }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Тема:Расписание занятий в университете/n"+"Автор: студент группы 20ВП1 Макаричева Е.М./n");
            MessageBox.Show($"Автор: студент группы 20ВП1 Макаричева Е.М.{Environment.NewLine}Вариант 15{Environment.NewLine}Тема: Расписание занятий в университете", "Информация");
           // string path = @"D:\2 курс\2 ООП (C#)\курсовая\Timetable-of-university-lessons\Timetable\timetableData.json";
            //FileInfo fileInfo = new FileInfo(path);
            //if (fileInfo.Exists)
                //label2.Text = $"Имя файла: {fileInfo.Name}";
        }

        /*private void buttonPrint_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            //Button b = (Button)sender;
            //Button Add = new Button();

            Print.Visible = true;
            //this.Controls.Add(Add);
        }*/

        /*private void buttonDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            Delete.Location = new Point(431, 322);
            Delete.Visible = true;
            Print.Visible = false;
        }*/

        private void buttonChange_Click(object sender, EventArgs e)
        {
            Form3 FormChange = new Form3();
            FormChange.ShowDialog();
            
            //в первой форме список для получения значений из 2, во второй сделать публичными поля
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 FormAdd = new Form2();
            FormAdd.ShowDialog();
            string teacherBox = Form2.TeacherBox;
            string lessonBox = Form2.LessonBox;
            string typeBox = Form2.TypeBox;
            string groupBox = Form2.GroupBox;
            string timeBox = Form2.TimeBox;
            //int rowNumber = dgv.Rows.Add();
            //FormAdd.Group = 
            label2.Text = teacherBox+ "\n" + lessonBox + "\n" + typeBox + "\n" + groupBox + "\n" + timeBox;
            //string text = "hello world";
            /*using (FileStream fstream = new FileStream(@"D:\2 курс\2 ООП (C#)\курсовая\Timetable-of-university-lessons\Timetable\timetableData.txt", FileMode.OpenOrCreate))
            {
                byte[] input = Encoding.Default.GetBytes(text);
                fstream.Write(input, 0, input.Length);
                //label2.Text = "Файл создан";
            }*/
                
            //fstream.Close();
            //stroke.Add(new StringTable(teacherBox, LessonBox, TypeBox, GroupBox, TimeBox));
            /*foreach (var str in stroke)
                {
                label2.Text += str;
                
                }*/
        }
        private void Save_Click(object sender, EventArgs e)
        {
        }
    }
}

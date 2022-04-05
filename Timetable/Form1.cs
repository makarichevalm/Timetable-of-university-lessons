using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Тема:Расписание занятий в университете/n"+"Автор: студент группы 20ВП1 Макаричева Е.М./n");
            MessageBox.Show($"Автор: студент группы 20ВП1 Макаричева Е.М.{Environment.NewLine}Вариант 15{Environment.NewLine}Тема: Расписание занятий в университете", "Информация");
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
            Form3 newForm = new Form3();
            newForm.Show();
            //Form2 newForm = new Form2();
            // newForm.Show();
            //dataGridView1.Visible = false;
            //Print.Visible = false;
            //Delete.Visible = false;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            //dataGridView1.Visible = false;
            //Print.Visible = false;
            //Delete.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //dataGridView1.Visible = false;
            //Print.Visible = false;
            //Delete.Visible = false;
            Form2 newForm = new Form2();
            newForm.Show();
        }
    }
}

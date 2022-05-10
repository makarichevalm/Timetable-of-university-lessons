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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private bool isEmpty()
        {
            bool flag = false;
            if (typeLesson.SelectedIndex == -1)
            {
                textType.Text = "Заполните поле";
                textType.ForeColor = Color.Red;
                flag = true;
            }
            return flag;
                


        }
        private void buttonReset2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOk2_Click(object sender, EventArgs e)
        {
            if (isEmpty())
                return;
            else
                Close();
        }
    }
}

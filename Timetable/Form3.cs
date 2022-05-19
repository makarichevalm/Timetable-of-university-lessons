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
    public partial class Form3 : Form
    {
        
        public Form3()//StringTable str
        {
            InitializeComponent();
            /*teacher.Text = str.Teacher;
            lesson.Text = str.Lesson;
            typeLesson.Text = str.TypeLesson;
            group.Text = str.Group;
            time.Text = str.Time;*/
            //radiobutton.Text -> checked;
    }

        private void buttonReset3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOk3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

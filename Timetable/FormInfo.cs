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
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            progressBar1.Maximum = 10;//10 sek
            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if(progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Enabled = false;
                this.Close();
            }
        }
    }
}

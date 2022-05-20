
namespace Timetable
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonReset2 = new System.Windows.Forms.Button();
            this.buttonOk2 = new System.Windows.Forms.Button();
            this.teacher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.group = new System.Windows.Forms.TextBox();
            this.lesson = new System.Windows.Forms.TextBox();
            this.typeLesson = new System.Windows.Forms.ComboBox();
            this.time = new System.Windows.Forms.ComboBox();
            this.textType = new System.Windows.Forms.Label();
            this.textTeacher = new System.Windows.Forms.Label();
            this.textTime = new System.Windows.Forms.Label();
            this.textGroup = new System.Windows.Forms.Label();
            this.textLesson = new System.Windows.Forms.Label();
            this.TextAdd = new System.Windows.Forms.Label();
            this.textDay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReset2
            // 
            this.buttonReset2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset2.Location = new System.Drawing.Point(273, 528);
            this.buttonReset2.Name = "buttonReset2";
            this.buttonReset2.Size = new System.Drawing.Size(88, 36);
            this.buttonReset2.TabIndex = 0;
            this.buttonReset2.Text = "Отмена";
            this.buttonReset2.UseVisualStyleBackColor = false;
            this.buttonReset2.Click += new System.EventHandler(this.buttonReset2_Click);
            // 
            // buttonOk2
            // 
            this.buttonOk2.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOk2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk2.Location = new System.Drawing.Point(398, 528);
            this.buttonOk2.Name = "buttonOk2";
            this.buttonOk2.Size = new System.Drawing.Size(88, 36);
            this.buttonOk2.TabIndex = 1;
            this.buttonOk2.Text = "Ок";
            this.buttonOk2.UseVisualStyleBackColor = false;
            this.buttonOk2.Click += new System.EventHandler(this.buttonOk2_Click);
            // 
            // teacher
            // 
            this.teacher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teacher.Location = new System.Drawing.Point(203, 75);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(283, 26);
            this.teacher.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Преподаватель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название предмета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тип занятия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Группа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Время проведения";
            // 
            // group
            // 
            this.group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.group.Location = new System.Drawing.Point(203, 280);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(283, 26);
            this.group.TabIndex = 9;
            // 
            // lesson
            // 
            this.lesson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lesson.Location = new System.Drawing.Point(203, 144);
            this.lesson.Name = "lesson";
            this.lesson.Size = new System.Drawing.Size(283, 26);
            this.lesson.TabIndex = 11;
            // 
            // typeLesson
            // 
            this.typeLesson.BackColor = System.Drawing.SystemColors.Window;
            this.typeLesson.Cursor = System.Windows.Forms.Cursors.Default;
            this.typeLesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeLesson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.typeLesson.FormattingEnabled = true;
            this.typeLesson.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.typeLesson.Items.AddRange(new object[] {
            "практика",
            "лекция"});
            this.typeLesson.Location = new System.Drawing.Point(203, 210);
            this.typeLesson.MaxDropDownItems = 2;
            this.typeLesson.Name = "typeLesson";
            this.typeLesson.Size = new System.Drawing.Size(283, 28);
            this.typeLesson.TabIndex = 12;
            // 
            // time
            // 
            this.time.DropDownHeight = 57;
            this.time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.time.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.time.FormattingEnabled = true;
            this.time.IntegralHeight = false;
            this.time.Items.AddRange(new object[] {
            "8:00",
            "9:50",
            "11:40",
            "13:45",
            "15:35",
            "17:25",
            "19:15"});
            this.time.Location = new System.Drawing.Point(203, 346);
            this.time.MaxDropDownItems = 2;
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(283, 28);
            this.time.TabIndex = 13;
            // 
            // textType
            // 
            this.textType.AutoSize = true;
            this.textType.Location = new System.Drawing.Point(12, 249);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(0, 20);
            this.textType.TabIndex = 14;
            // 
            // textTeacher
            // 
            this.textTeacher.AutoSize = true;
            this.textTeacher.Location = new System.Drawing.Point(12, 113);
            this.textTeacher.Name = "textTeacher";
            this.textTeacher.Size = new System.Drawing.Size(0, 20);
            this.textTeacher.TabIndex = 15;
            // 
            // textTime
            // 
            this.textTime.AutoSize = true;
            this.textTime.Location = new System.Drawing.Point(12, 384);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(0, 20);
            this.textTime.TabIndex = 16;
            // 
            // textGroup
            // 
            this.textGroup.AutoSize = true;
            this.textGroup.Location = new System.Drawing.Point(12, 317);
            this.textGroup.Name = "textGroup";
            this.textGroup.Size = new System.Drawing.Size(0, 20);
            this.textGroup.TabIndex = 17;
            // 
            // textLesson
            // 
            this.textLesson.AutoSize = true;
            this.textLesson.Location = new System.Drawing.Point(12, 179);
            this.textLesson.Name = "textLesson";
            this.textLesson.Size = new System.Drawing.Size(0, 20);
            this.textLesson.TabIndex = 18;
            // 
            // TextAdd
            // 
            this.TextAdd.AutoSize = true;
            this.TextAdd.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextAdd.Location = new System.Drawing.Point(154, 19);
            this.TextAdd.Name = "TextAdd";
            this.TextAdd.Size = new System.Drawing.Size(207, 29);
            this.TextAdd.TabIndex = 19;
            this.TextAdd.Text = "Добавление записи";
            // 
            // textDay
            // 
            this.textDay.AutoSize = true;
            this.textDay.Location = new System.Drawing.Point(12, 509);
            this.textDay.Name = "textDay";
            this.textDay.Size = new System.Drawing.Size(0, 20);
            this.textDay.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "День недели";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton6);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(203, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 95);
            this.panel1.TabIndex = 23;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(157, 64);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(54, 24);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Сб";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(157, 34);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(55, 24);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Пт";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(157, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(55, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Чт";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(22, 64);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(54, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ср";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(22, 34);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Вт";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Пн";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 576);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textDay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextAdd);
            this.Controls.Add(this.textLesson);
            this.Controls.Add(this.textGroup);
            this.Controls.Add(this.textTime);
            this.Controls.Add(this.textTeacher);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.time);
            this.Controls.Add(this.typeLesson);
            this.Controls.Add(this.lesson);
            this.Controls.Add(this.group);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.buttonOk2);
            this.Controls.Add(this.buttonReset2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Добавление записи";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReset2;
        private System.Windows.Forms.Button buttonOk2;
        public System.Windows.Forms.TextBox teacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox group;
        public System.Windows.Forms.TextBox lesson;
        public System.Windows.Forms.ComboBox typeLesson;
        public System.Windows.Forms.ComboBox time;
        private System.Windows.Forms.Label textType;
        private System.Windows.Forms.Label textTeacher;
        private System.Windows.Forms.Label textTime;
        private System.Windows.Forms.Label textGroup;
        private System.Windows.Forms.Label textLesson;
        private System.Windows.Forms.Label TextAdd;
        private System.Windows.Forms.Label textDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}
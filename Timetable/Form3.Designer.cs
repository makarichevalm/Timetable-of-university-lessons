
namespace Timetable
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.buttonOk3 = new System.Windows.Forms.Button();
            this.buttonReset3 = new System.Windows.Forms.Button();
            this.TextChange = new System.Windows.Forms.Label();
            this.textLesson = new System.Windows.Forms.Label();
            this.textGroup = new System.Windows.Forms.Label();
            this.textTime = new System.Windows.Forms.Label();
            this.textTeacher = new System.Windows.Forms.Label();
            this.textType = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.ComboBox();
            this.typeLesson = new System.Windows.Forms.ComboBox();
            this.lesson = new System.Windows.Forms.TextBox();
            this.group = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teacher = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOk3
            // 
            this.buttonOk3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk3.Location = new System.Drawing.Point(408, 411);
            this.buttonOk3.Name = "buttonOk3";
            this.buttonOk3.Size = new System.Drawing.Size(88, 36);
            this.buttonOk3.TabIndex = 13;
            this.buttonOk3.Text = "Ок";
            this.buttonOk3.UseVisualStyleBackColor = false;
            this.buttonOk3.Click += new System.EventHandler(this.buttonOk3_Click);
            // 
            // buttonReset3
            // 
            this.buttonReset3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset3.Location = new System.Drawing.Point(294, 411);
            this.buttonReset3.Name = "buttonReset3";
            this.buttonReset3.Size = new System.Drawing.Size(88, 36);
            this.buttonReset3.TabIndex = 12;
            this.buttonReset3.Text = "Отмена";
            this.buttonReset3.UseVisualStyleBackColor = false;
            this.buttonReset3.Click += new System.EventHandler(this.buttonReset3_Click);
            // 
            // TextChange
            // 
            this.TextChange.AutoSize = true;
            this.TextChange.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextChange.Location = new System.Drawing.Point(148, 19);
            this.TextChange.Name = "TextChange";
            this.TextChange.Size = new System.Drawing.Size(196, 29);
            this.TextChange.TabIndex = 24;
            this.TextChange.Text = "Изменение записи";
            // 
            // textLesson
            // 
            this.textLesson.AutoSize = true;
            this.textLesson.Location = new System.Drawing.Point(219, 172);
            this.textLesson.Name = "textLesson";
            this.textLesson.Size = new System.Drawing.Size(0, 20);
            this.textLesson.TabIndex = 39;
            // 
            // textGroup
            // 
            this.textGroup.AutoSize = true;
            this.textGroup.Location = new System.Drawing.Point(215, 310);
            this.textGroup.Name = "textGroup";
            this.textGroup.Size = new System.Drawing.Size(0, 20);
            this.textGroup.TabIndex = 38;
            // 
            // textTime
            // 
            this.textTime.AutoSize = true;
            this.textTime.Location = new System.Drawing.Point(215, 378);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(0, 20);
            this.textTime.TabIndex = 37;
            // 
            // textTeacher
            // 
            this.textTeacher.AutoSize = true;
            this.textTeacher.Location = new System.Drawing.Point(215, 106);
            this.textTeacher.Name = "textTeacher";
            this.textTeacher.Size = new System.Drawing.Size(0, 20);
            this.textTeacher.TabIndex = 36;
            // 
            // textType
            // 
            this.textType.AutoSize = true;
            this.textType.Location = new System.Drawing.Point(211, 242);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(0, 20);
            this.textType.TabIndex = 35;
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
            this.time.Location = new System.Drawing.Point(219, 343);
            this.time.MaxDropDownItems = 2;
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(283, 28);
            this.time.TabIndex = 34;
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
            this.typeLesson.Location = new System.Drawing.Point(215, 203);
            this.typeLesson.MaxDropDownItems = 2;
            this.typeLesson.Name = "typeLesson";
            this.typeLesson.Size = new System.Drawing.Size(283, 28);
            this.typeLesson.TabIndex = 33;
            // 
            // lesson
            // 
            this.lesson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lesson.Location = new System.Drawing.Point(215, 137);
            this.lesson.Name = "lesson";
            this.lesson.Size = new System.Drawing.Size(283, 26);
            this.lesson.TabIndex = 32;
            // 
            // group
            // 
            this.group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.group.Location = new System.Drawing.Point(215, 273);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(283, 26);
            this.group.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(33, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Время проведения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(33, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Группа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Тип занятия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Название предмета";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Преподаватель";
            // 
            // teacher
            // 
            this.teacher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teacher.Location = new System.Drawing.Point(215, 68);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(283, 26);
            this.teacher.TabIndex = 25;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 466);
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
            this.Controls.Add(this.TextChange);
            this.Controls.Add(this.buttonOk3);
            this.Controls.Add(this.buttonReset3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Изменение записи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOk3;
        private System.Windows.Forms.Button buttonReset3;
        private System.Windows.Forms.Label TextChange;
        private System.Windows.Forms.Label textLesson;
        private System.Windows.Forms.Label textGroup;
        private System.Windows.Forms.Label textTime;
        private System.Windows.Forms.Label textTeacher;
        private System.Windows.Forms.Label textType;
        private System.Windows.Forms.ComboBox time;
        private System.Windows.Forms.ComboBox typeLesson;
        private System.Windows.Forms.TextBox lesson;
        private System.Windows.Forms.TextBox group;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teacher;
    }
}
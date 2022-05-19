
namespace Timetable
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.textFind = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textFiltr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFiltr = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleLesson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeLesson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonFind = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.Phone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(175)))), ((int)(((byte)(230)))));
            this.panelMenu.Controls.Add(this.buttonFind);
            this.panelMenu.Controls.Add(this.textFind);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.textFiltr);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.buttonFiltr);
            this.panelMenu.Controls.Add(this.buttonAdd);
            this.panelMenu.Controls.Add(this.buttonStart);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(277, 557);
            this.panelMenu.TabIndex = 0;
            // 
            // textFind
            // 
            this.textFind.Location = new System.Drawing.Point(34, 432);
            this.textFind.Name = "textFind";
            this.textFind.Size = new System.Drawing.Size(205, 37);
            this.textFind.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.label4.Location = new System.Drawing.Point(34, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(34, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 105);
            this.panel1.TabIndex = 6;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.radioButton3.Location = new System.Drawing.Point(14, 71);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(105, 31);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Группа";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.radioButton2.Location = new System.Drawing.Point(14, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 31);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Время";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.radioButton1.Location = new System.Drawing.Point(14, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(179, 31);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Преподаватель";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textFiltr
            // 
            this.textFiltr.Location = new System.Drawing.Point(34, 143);
            this.textFiltr.Name = "textFiltr";
            this.textFiltr.Size = new System.Drawing.Size(205, 37);
            this.textFiltr.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Критерии фильтрации:";
            // 
            // buttonFiltr
            // 
            this.buttonFiltr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiltr.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltr.Location = new System.Drawing.Point(34, 376);
            this.buttonFiltr.Name = "buttonFiltr";
            this.buttonFiltr.Size = new System.Drawing.Size(205, 43);
            this.buttonFiltr.TabIndex = 3;
            this.buttonFiltr.Text = "Фильтровать";
            this.buttonFiltr.UseVisualStyleBackColor = true;
            this.buttonFiltr.Click += new System.EventHandler(this.ButtonFind_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(34, 89);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(205, 43);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить запись";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.AllowDrop = true;
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(114)))), ((int)(((byte)(210)))));
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Palatino Linotype", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(34, 13);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(205, 69);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Информация об авторе";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.White;
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(277, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(940, 54);
            this.panelTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Расписание занятий в университете";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Phone
            // 
            this.Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.Phone.Controls.Add(this.label2);
            this.Phone.Controls.Add(this.Change);
            this.Phone.Controls.Add(this.Save);
            this.Phone.Controls.Add(this.Delete);
            this.Phone.Controls.Add(this.dataGridView1);
            this.Phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Phone.Location = new System.Drawing.Point(277, 54);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(940, 503);
            this.Phone.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 5;
            // 
            // Change
            // 
            this.Change.Font = new System.Drawing.Font("MV Boli", 10F);
            this.Change.Location = new System.Drawing.Point(713, 315);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(108, 50);
            this.Change.TabIndex = 4;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("MV Boli", 10F);
            this.Save.Location = new System.Drawing.Point(422, 315);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(108, 50);
            this.Save.TabIndex = 3;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("MV Boli", 10F);
            this.Delete.Location = new System.Drawing.Point(147, 315);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(108, 50);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Teacher,
            this.TitleLesson,
            this.TypeLesson,
            this.Group,
            this.Day,
            this.Time});
            this.dataGridView1.Location = new System.Drawing.Point(33, 52);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(876, 182);
            this.dataGridView1.TabIndex = 0;
            // 
            // Teacher
            // 
            this.Teacher.HeaderText = "Преподаватель";
            this.Teacher.MinimumWidth = 8;
            this.Teacher.Name = "Teacher";
            this.Teacher.ReadOnly = true;
            this.Teacher.Width = 150;
            // 
            // TitleLesson
            // 
            this.TitleLesson.HeaderText = "Название предмета";
            this.TitleLesson.MinimumWidth = 8;
            this.TitleLesson.Name = "TitleLesson";
            this.TitleLesson.ReadOnly = true;
            this.TitleLesson.Width = 170;
            // 
            // TypeLesson
            // 
            this.TypeLesson.HeaderText = "Тип занятия";
            this.TypeLesson.MinimumWidth = 8;
            this.TypeLesson.Name = "TypeLesson";
            this.TypeLesson.ReadOnly = true;
            this.TypeLesson.Width = 120;
            // 
            // Group
            // 
            this.Group.HeaderText = "Группа";
            this.Group.MinimumWidth = 8;
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            this.Group.Width = 110;
            // 
            // Day
            // 
            this.Day.HeaderText = "День недели";
            this.Day.MinimumWidth = 8;
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            this.Day.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Day.Width = 130;
            // 
            // Time
            // 
            this.Time.HeaderText = "Время проведения";
            this.Time.MinimumWidth = 8;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 130;
            // 
            // buttonFind
            // 
            this.buttonFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFind.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFind.Location = new System.Drawing.Point(34, 488);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(205, 43);
            this.buttonFind.TabIndex = 16;
            this.buttonFind.Text = "Поиск";
            this.buttonFind.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 557);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.Phone.ResumeLayout(false);
            this.Phone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Panel Phone;
        private System.Windows.Forms.Button buttonFiltr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textFiltr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleLesson;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeLesson;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.TextBox textFind;
        private System.Windows.Forms.Button buttonFind;
    }
}



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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonOk3 = new System.Windows.Forms.Button();
            this.buttonReset3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(213, 81);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(283, 26);
            this.textBox5.TabIndex = 23;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(213, 130);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(283, 26);
            this.textBox4.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(213, 186);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(283, 26);
            this.textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(213, 236);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(283, 26);
            this.textBox2.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Время проведения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Группа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Тип занятия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Название предмета";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Преподаватель";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 26);
            this.textBox1.TabIndex = 14;
            // 
            // buttonOk3
            // 
            this.buttonOk3.Location = new System.Drawing.Point(408, 309);
            this.buttonOk3.Name = "buttonOk3";
            this.buttonOk3.Size = new System.Drawing.Size(88, 36);
            this.buttonOk3.TabIndex = 13;
            this.buttonOk3.Text = "Ок";
            this.buttonOk3.UseVisualStyleBackColor = true;
            this.buttonOk3.Click += new System.EventHandler(this.buttonOk3_Click);
            // 
            // buttonReset3
            // 
            this.buttonReset3.Location = new System.Drawing.Point(290, 309);
            this.buttonReset3.Name = "buttonReset3";
            this.buttonReset3.Size = new System.Drawing.Size(88, 36);
            this.buttonReset3.TabIndex = 12;
            this.buttonReset3.Text = "Отмена";
            this.buttonReset3.UseVisualStyleBackColor = true;
            this.buttonReset3.Click += new System.EventHandler(this.buttonReset3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 372);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonOk3);
            this.Controls.Add(this.buttonReset3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Изменение записи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonOk3;
        private System.Windows.Forms.Button buttonReset3;
    }
}
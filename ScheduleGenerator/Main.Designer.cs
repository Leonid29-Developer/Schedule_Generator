namespace ScheduleGenerator
{
    partial class Main
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
            this.CLB_Audiences = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CLB_Audiences
            // 
            this.CLB_Audiences.FormattingEnabled = true;
            this.CLB_Audiences.Location = new System.Drawing.Point(49, 70);
            this.CLB_Audiences.Name = "CLB_Audiences";
            this.CLB_Audiences.Size = new System.Drawing.Size(156, 199);
            this.CLB_Audiences.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Аудитории";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(500, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(254, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 199);
            this.label2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить предмет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(497, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Предмет";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(497, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Часов";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(500, 199);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 20);
            this.textBox3.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(500, 138);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(143, 24);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Практическая или нет";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(251, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Предметы";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(49, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Создать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(49, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Открыть";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 415);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CLB_Audiences);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CLB_Audiences;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}


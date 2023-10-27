﻿namespace ScheduleGenerator
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
            this.TB_NameSubject = new System.Windows.Forms.TextBox();
            this.ListSubject = new System.Windows.Forms.Label();
            this.AddSubject_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_NumberHours = new System.Windows.Forms.TextBox();
            this.PracticeNoted = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateSchedule_Button = new System.Windows.Forms.Button();
            this.OpenExcel_Button = new System.Windows.Forms.Button();
            this.Border1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CLB_Audiences
            // 
            this.CLB_Audiences.CheckOnClick = true;
            this.CLB_Audiences.FormattingEnabled = true;
            this.CLB_Audiences.Location = new System.Drawing.Point(37, 70);
            this.CLB_Audiences.Name = "CLB_Audiences";
            this.CLB_Audiences.Size = new System.Drawing.Size(168, 199);
            this.CLB_Audiences.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Аудитории";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_NameSubject
            // 
            this.TB_NameSubject.Location = new System.Drawing.Point(503, 83);
            this.TB_NameSubject.Name = "TB_NameSubject";
            this.TB_NameSubject.Size = new System.Drawing.Size(143, 20);
            this.TB_NameSubject.TabIndex = 2;
            // 
            // ListSubject
            // 
            this.ListSubject.BackColor = System.Drawing.Color.White;
            this.ListSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListSubject.Location = new System.Drawing.Point(254, 70);
            this.ListSubject.Name = "ListSubject";
            this.ListSubject.Size = new System.Drawing.Size(193, 199);
            this.ListSubject.TabIndex = 4;
            // 
            // AddSubject_Button
            // 
            this.AddSubject_Button.Location = new System.Drawing.Point(503, 222);
            this.AddSubject_Button.Name = "AddSubject_Button";
            this.AddSubject_Button.Size = new System.Drawing.Size(143, 23);
            this.AddSubject_Button.TabIndex = 5;
            this.AddSubject_Button.Text = "Добавить предмет";
            this.AddSubject_Button.UseVisualStyleBackColor = true;
            this.AddSubject_Button.Click += new System.EventHandler(this.AddSubject_Button_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(500, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Предмет";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(500, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Количество часов";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_NumberHours
            // 
            this.TB_NumberHours.Location = new System.Drawing.Point(503, 182);
            this.TB_NumberHours.Name = "TB_NumberHours";
            this.TB_NumberHours.Size = new System.Drawing.Size(143, 20);
            this.TB_NumberHours.TabIndex = 8;
            // 
            // PracticeNoted
            // 
            this.PracticeNoted.Location = new System.Drawing.Point(503, 121);
            this.PracticeNoted.Name = "PracticeNoted";
            this.PracticeNoted.Size = new System.Drawing.Size(143, 24);
            this.PracticeNoted.TabIndex = 11;
            this.PracticeNoted.Text = "Практическая или нет";
            this.PracticeNoted.UseVisualStyleBackColor = true;
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
            // CreateSchedule_Button
            // 
            this.CreateSchedule_Button.Location = new System.Drawing.Point(37, 287);
            this.CreateSchedule_Button.Name = "CreateSchedule_Button";
            this.CreateSchedule_Button.Size = new System.Drawing.Size(168, 23);
            this.CreateSchedule_Button.TabIndex = 14;
            this.CreateSchedule_Button.Text = "Сгенерировать расписание";
            this.CreateSchedule_Button.UseVisualStyleBackColor = true;
            this.CreateSchedule_Button.Click += new System.EventHandler(this.CreateSchedule_Button_Click);
            // 
            // OpenExcel_Button
            // 
            this.OpenExcel_Button.Location = new System.Drawing.Point(254, 287);
            this.OpenExcel_Button.Name = "OpenExcel_Button";
            this.OpenExcel_Button.Size = new System.Drawing.Size(193, 23);
            this.OpenExcel_Button.TabIndex = 15;
            this.OpenExcel_Button.Text = "Открыть расписание в Excel";
            this.OpenExcel_Button.UseVisualStyleBackColor = true;
            this.OpenExcel_Button.Click += new System.EventHandler(this.OpenExcel_Button_Click);
            // 
            // Border1
            // 
            this.Border1.BackColor = System.Drawing.Color.Transparent;
            this.Border1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Border1.Location = new System.Drawing.Point(487, 44);
            this.Border1.Name = "Border1";
            this.Border1.Size = new System.Drawing.Size(175, 225);
            this.Border1.TabIndex = 16;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 361);
            this.Controls.Add(this.OpenExcel_Button);
            this.Controls.Add(this.CreateSchedule_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PracticeNoted);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_NumberHours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddSubject_Button);
            this.Controls.Add(this.ListSubject);
            this.Controls.Add(this.TB_NameSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CLB_Audiences);
            this.Controls.Add(this.Border1);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CLB_Audiences;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_NameSubject;
        private System.Windows.Forms.Label ListSubject;
        private System.Windows.Forms.Button AddSubject_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_NumberHours;
        private System.Windows.Forms.CheckBox PracticeNoted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreateSchedule_Button;
        private System.Windows.Forms.Button OpenExcel_Button;
        private System.Windows.Forms.Label Border1;
    }
}


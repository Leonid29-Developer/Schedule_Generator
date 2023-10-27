using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Xml;

namespace ScheduleGenerator
{
    public partial class Main : Form
    {
        public Main() => InitializeComponent();

        // Строка подключения
        public static string ConnectString = "Data Source=PC-LEONID29\\SQLEXPRESS;Integrated Security=True";

        List<string> Audiences = new List<string>(); List<string[]> Subject = new List<string[]>();

        private void Main_Load(object sender, EventArgs e)
        {
            Audiences.Clear();

            //Загрузка данных
            using (SqlConnection SQL_Connection = new SqlConnection(ConnectString))
            {
                SQL_Connection.Open();
                string Request = $"EXEC [ScheduleGenerator].[dbo].[Audiences_ALL]"; // SQL-запрос
                SqlCommand Command = new SqlCommand(Request, SQL_Connection); SqlDataReader Reader = Command.ExecuteReader();
                while (Reader.Read()) Audiences.Add((string)Reader.GetValue(0));
                SQL_Connection.Close();
            }

            CLB_Audiences.Items.Clear(); foreach (string Audience in Audiences)
            {
                if (Audience[0] == 'L') CLB_Audiences.Items.Add("Лекционная - " + Audience.Remove(0, 1));
                if (Audience[0] == 'S') CLB_Audiences.Items.Add("Потоковая - " + Audience.Remove(0, 1));
                if (Audience[0] == 'P') CLB_Audiences.Items.Add("Практическая - " + Audience.Remove(0, 1));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] D = new string[] { textBox1.Text, checkBox1.Checked.ToString(), textBox3.Text }; Subject.Add(D);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = ""; foreach (string[] D in Subject)
            {
                label2.Text += $"{D[0]} - ";
                if (D[1] == "True") label2.Text += "Практика"; else label2.Text += "Лекция";
                label2.Text += $" {D[2]}\n";
            }
        }

        private string Week(DateTime Date)
        {
            string DayWeek = "";

            switch (Date.DayOfWeek)
            {
                case DayOfWeek.Monday: DayWeek = "ПН"; break;
                case DayOfWeek.Tuesday: DayWeek = "ВТ"; break;
                case DayOfWeek.Wednesday: DayWeek = "СР"; break;
                case DayOfWeek.Thursday: DayWeek = "ЧТ"; break;
                case DayOfWeek.Friday: DayWeek = "ПТ"; break;
                case DayOfWeek.Saturday: DayWeek = "СБ"; break;
            }

            return DayWeek;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Создание и заполнение Excel файла
            {
                //Объявляем приложение Excel
                Excel.Application APP = new Excel.Application { Visible = true, SheetsInNewWorkbook = 1 };
                //Добавить Книгу
                Workbook Book = APP.Workbooks.Add(); APP.DisplayAlerts = false;
                //Добавить Лист
                Worksheet Sheet = (Worksheet)APP.Worksheets.get_Item(1); Sheet.Name = "Расписание";

                //Границы
                for (int i = 0; i < 6; i++) { Range Ranges = Sheet.get_Range("A" + (2 + 9 * i), "C" + (9 + 9 * i)); Ranges.Borders.Color = ColorTranslator.ToOle(Color.Black); }

                //Заполнение ячеек данным
                Range Range = Sheet.get_Range("A1", "A3"); Range.Cells[1, 1] = "День"; Range.Cells[1, 2] = "Пара"; Range.Cells[1, 3] = "Наименование";
                { Range = Sheet.get_Range("A1", "C1"); Range.Borders.Color = ColorTranslator.ToOle(Color.Black); Range.VerticalAlignment = XlVAlign.xlVAlignCenter; Range.HorizontalAlignment = XlHAlign.xlHAlignCenter; }

                for (int i = 0; i < 6; i++) { Range Ranges = Sheet.get_Range("A" + (2 + 9 * i), "A" + (5 + 9 * i)); Ranges.Merge(); Border Border = Ranges.Borders[XlBordersIndex.xlEdgeBottom]; Border.LineStyle = XlLineStyle.xlLineStyleNone; }
                for (int i = 0; i < 6; i++) { Range Ranges = Sheet.get_Range("A" + (6 + 9 * i), "A" + (9 + 9 * i)); Ranges.Merge(); Ranges.VerticalAlignment = XlVAlign.xlVAlignTop; Ranges.HorizontalAlignment = XlHAlign.xlHAlignCenter; }
                DateTime Date = new DateTime(2023, 10, 23); for (int i = 0; i < 6; i++)
                { Range Ranges = Sheet.get_Range("A" + (2 + 9 * i), "A" + (9 + 9 * i)); Ranges.Cells[1, 1] = $"{Date.AddDays(i).Day}.{Date.AddDays(i).Month}.{Date.AddDays(i).Year}"; Ranges.Cells[5, 1] = $"{Week(Date.AddDays(i))}"; }

                for (int i = 0; i < 6; i++)
                { Range Ranges = Sheet.get_Range("B" + (2 + 9 * i), "B" + (9 + 9 * i)); Ranges.VerticalAlignment = XlVAlign.xlVAlignBottom; Ranges.HorizontalAlignment = XlHAlign.xlHAlignCenter; for (int j = 1; j < 9; j++) Ranges.Cells[j, 1] = j; }

                for (int i = 0; i < 6; i++)
                {
                    Range Ranges = Sheet.get_Range("C" + (2 + 9 * i), "C" + (9 + 9 * i)); Ranges.VerticalAlignment = XlVAlign.xlVAlignBottom; Ranges.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    for (int j = 1; j < 9; j++) Ranges.Cells[j, 1] = j;
                }

                //Авторазмер ячеек
                Range = Sheet.get_Range("A1", "C54"); Range.EntireColumn.AutoFit();

                //Сохраняем документ Excel
                APP.Application.ActiveWorkbook.SaveAs("MyFile.xlsx"); APP.Quit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        { FileInfo fi = new FileInfo(@"C:\Users\leoni\Documents\MyFile.xlsx"); if (fi.Exists) System.Diagnostics.Process.Start(@"C:\Users\leoni\Documents\MyFile.xlsx"); }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH3_CH4CMP.Models;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;



namespace ZH3_CH4CMP
{
    public partial class UserControl3 : UserControl
    {
        context context = new context();
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;
        public UserControl3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;
                CreateTable();
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                xlWB.Close();
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }

        void CreateTable() 
        {
            string[] fejlecek = new string[] {"Car_id","Name","Car make","Car date"};

            xlSheet.Cells[1, 1] = fejlecek[0];
            xlSheet.Cells[1, 2] = fejlecek[1];
            xlSheet.Cells[1, 3] = fejlecek[2];
            xlSheet.Cells[1, 4] = fejlecek[3];

            var adatok = context.CarData.ToList();
            object[,] tomb = new object[adatok.Count(), fejlecek.Count()];

            for (int i = 0; i < adatok.Count(); i++)
            {
                tomb[i, 0] = adatok[i].CarId;
                tomb[i, 1] = adatok[i].Name;
                tomb[i, 2] = adatok[i].CarMake;
                tomb[i, 3] = adatok[i].CarDate;
            }
            int sorszam = tomb.GetLength(0);
            int oszlopszam = tomb.GetLength(1);

            Excel.Range adatRange = xlSheet.get_Range("A2", Type.Missing).get_Resize(sorszam, oszlopszam);
            adatRange.Value2 = tomb;

            Excel.Range fejlecRange = xlSheet.get_Range("A1", Type.Missing).get_Resize(1, 4);
            fejlecRange.Font.Bold = true;
         }
    }
}

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

namespace ZH3_CH4CMP
{
    public partial class UserControl1 : UserControl
    {
        context context = new context();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            listBox_name.DisplayMember = "Name";
            listBox_id.DisplayMember = "CarId";
            Megjelenites();
            
        }

        private void Megjelenites()
        {
            listBox_name.DataSource = (from x in context.CarData
                                       select x).ToList();
            listBox_name.DisplayMember = "Name";
            carDataBindingSource.DataSource = context.CarData.ToList();
        }

        private void textBox_szures_TextChanged(object sender, EventArgs e)
        {
            Szures();
        }

        private void Szures()
        {
            listBox_name.DataSource = (from x in context.CarData
                                       where x.Name.Contains(textBox_szures.Text)
                                       select x).ToList();
            listBox_name.DisplayMember = "Name";
        }

        private void listBox_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hozzarendeles();
        }

        private void Hozzarendeles()
        {
            var selectedName = (CarData)listBox_name.SelectedItem;
            listBox_id.DataSource = (from x in context.CarData
                                     where x.CarId == selectedName.CarId
                                     select x.CarId).ToList();
            listBox_id.DisplayMember = "CarId";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            dataForm form2 = new dataForm();
            if (form2.ShowDialog()==DialogResult.OK)
            {
                MessageBox.Show("Sikeres hozzaadas");
            }
            else
            {
                MessageBox.Show("Sikertelen hozzaadas");
            }
            Megjelenites();
        }
    }
}

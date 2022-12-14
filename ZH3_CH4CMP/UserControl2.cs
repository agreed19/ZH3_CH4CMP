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
    public partial class UserControl2 : UserControl
    {
        context context = new context();
        public UserControl2()
        {
            InitializeComponent();
        }

        private void textBox_szures_TextChanged(object sender, EventArgs e)
        {
            Szures();
        }

        private void listBox_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            listBox_name.DisplayMember = "Name";
            Megjelenites();
        }

        private void Megjelenites()
        {
            listBox_name.DataSource = (from x in context.CarData
                                       select x).ToList();
            listBox_name.DisplayMember = "Name";
            
        }

        private void Szures()
        {
            listBox_name.DataSource = (from x in context.CarData
                                       where x.Name.Contains(textBox_szures.Text)
                                       select x).ToList();
            listBox_name.DisplayMember = "Name";
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan kitorli?","",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                var tobeDeleted = (CarData)listBox_name.SelectedItem;

                context.Remove(tobeDeleted);
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Sikeres torles");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Sikertelen");
            }
            Megjelenites();
        }
    }
}

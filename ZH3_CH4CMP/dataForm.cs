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
using System.Text.RegularExpressions;

namespace ZH3_CH4CMP
{
    public partial class dataForm : Form
    {
        context context = new context();
        public dataForm()
        {
            InitializeComponent();
        }

        private void textBox_name_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox_name,"");
            button_add.Visible = true;
        }

        private void textBox_name_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Regex regex = new Regex("[a-zA-Z]");
                if (!regex.IsMatch(textBox_name.Text))
                {
                    e.Cancel = true;
                    MessageBox.Show("A nev nem kezdodhet szammal es nem lehet ures");
                    button_add.Visible = false;
                    errorProvider1.SetError(textBox_name, "Csak betuk lehetnek es nem lehet ures");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_make_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox_make, "");
            button_add.Visible = true;
        }

        private void textBox_make_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmpty(textBox_make.Text))
            {
                errorProvider1.SetError(textBox_make, "Nem lehet üres");
                button_add.Visible = false;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                if (MessageBox.Show("Biztos hozzaadja?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CarData ujato = new CarData();
                    ujato.Name = textBox_name.Text;
                    ujato.CarDate = dateTimePicker1.Value;
                    ujato.CarId = textBox_id.Text;
                    ujato.CarMake = textBox_make.Text;

                    context.Add(ujato);
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private bool CheckEmpty(string szo)
        {
            return !string.IsNullOrEmpty(szo);
        }
    }
}

namespace ZH3_CH4CMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 uc1 = new UserControl1();
            panel1.Controls.Add(uc1);
            //panel1.Dock = DockStyle.Fill;
            uc1.Dock = DockStyle.Fill;
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl2 uc2 = new UserControl2();
            panel1.Controls.Add(uc2);
            //panel1.Dock = DockStyle.Fill;
            uc2.Dock = DockStyle.Fill;
        }

        private void button_excel_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 uc3 = new UserControl3();
            panel1.Controls.Add(uc3);
            //panel1.Dock = DockStyle.Fill;
            uc3.Dock = DockStyle.Fill;
        }

        private void button_source_Click(object sender, EventArgs e)
        {
            sourceForm f3 = new sourceForm();
            f3.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bizotsan ki akar lepni?","",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
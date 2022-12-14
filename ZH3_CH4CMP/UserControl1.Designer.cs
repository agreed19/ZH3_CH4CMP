namespace ZH3_CH4CMP
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_szures = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.carDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_make = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.listBox_name = new System.Windows.Forms.ListBox();
            this.listBox_id = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carMakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_szures
            // 
            this.textBox_szures.Location = new System.Drawing.Point(13, 18);
            this.textBox_szures.Name = "textBox_szures";
            this.textBox_szures.Size = new System.Drawing.Size(185, 23);
            this.textBox_szures.TabIndex = 0;
            this.textBox_szures.TextChanged += new System.EventHandler(this.textBox_szures_TextChanged);
            // 
            // textBox_id
            // 
            this.textBox_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carDataBindingSource, "CarId", true));
            this.textBox_id.Enabled = false;
            this.textBox_id.Location = new System.Drawing.Point(60, 128);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(127, 23);
            this.textBox_id.TabIndex = 1;
            // 
            // carDataBindingSource
            // 
            this.carDataBindingSource.DataSource = typeof(ZH3_CH4CMP.Models.CarData);
            // 
            // textBox_make
            // 
            this.textBox_make.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carDataBindingSource, "CarMake", true));
            this.textBox_make.Enabled = false;
            this.textBox_make.Location = new System.Drawing.Point(75, 90);
            this.textBox_make.Name = "textBox_make";
            this.textBox_make.Size = new System.Drawing.Size(100, 23);
            this.textBox_make.TabIndex = 2;
            // 
            // textBox_name
            // 
            this.textBox_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carDataBindingSource, "Name", true));
            this.textBox_name.Enabled = false;
            this.textBox_name.Location = new System.Drawing.Point(75, 46);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 23);
            this.textBox_name.TabIndex = 3;
            // 
            // listBox_name
            // 
            this.listBox_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_name.FormattingEnabled = true;
            this.listBox_name.ItemHeight = 15;
            this.listBox_name.Location = new System.Drawing.Point(13, 47);
            this.listBox_name.Name = "listBox_name";
            this.listBox_name.Size = new System.Drawing.Size(185, 589);
            this.listBox_name.TabIndex = 4;
            this.listBox_name.SelectedIndexChanged += new System.EventHandler(this.listBox_name_SelectedIndexChanged);
            // 
            // listBox_id
            // 
            this.listBox_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_id.FormattingEnabled = true;
            this.listBox_id.ItemHeight = 15;
            this.listBox_id.Location = new System.Drawing.Point(204, 47);
            this.listBox_id.Name = "listBox_id";
            this.listBox_id.Size = new System.Drawing.Size(134, 589);
            this.listBox_id.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.carMakeDataGridViewTextBoxColumn,
            this.carDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(344, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(655, 589);
            this.dataGridView1.TabIndex = 6;
            // 
            // carIdDataGridViewTextBoxColumn
            // 
            this.carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
            this.carIdDataGridViewTextBoxColumn.HeaderText = "CarId";
            this.carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
            this.carIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carMakeDataGridViewTextBoxColumn
            // 
            this.carMakeDataGridViewTextBoxColumn.DataPropertyName = "CarMake";
            this.carMakeDataGridViewTextBoxColumn.HeaderText = "CarMake";
            this.carMakeDataGridViewTextBoxColumn.Name = "carMakeDataGridViewTextBoxColumn";
            this.carMakeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carDateDataGridViewTextBoxColumn
            // 
            this.carDateDataGridViewTextBoxColumn.DataPropertyName = "CarDate";
            this.carDateDataGridViewTextBoxColumn.HeaderText = "CarDate";
            this.carDateDataGridViewTextBoxColumn.Name = "carDateDataGridViewTextBoxColumn";
            this.carDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_make);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Location = new System.Drawing.Point(1005, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 278);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(88, 199);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 56);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carDataBindingSource, "CarDate", true));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 170);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "VIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Make";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox_id);
            this.Controls.Add(this.listBox_name);
            this.Controls.Add(this.textBox_szures);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1249, 644);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_szures;
        private TextBox textBox_id;
        private TextBox textBox_make;
        private TextBox textBox_name;
        private ListBox listBox_name;
        private ListBox listBox_id;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carMakeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carDateDataGridViewTextBoxColumn;
        private BindingSource carDataBindingSource;
        private Button button_add;
    }
}

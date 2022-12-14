namespace ZH3_CH4CMP
{
    partial class UserControl2
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
            this.listBox_name = new System.Windows.Forms.ListBox();
            this.textBox_szures = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_name
            // 
            this.listBox_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_name.FormattingEnabled = true;
            this.listBox_name.ItemHeight = 15;
            this.listBox_name.Location = new System.Drawing.Point(3, 39);
            this.listBox_name.Name = "listBox_name";
            this.listBox_name.Size = new System.Drawing.Size(208, 589);
            this.listBox_name.TabIndex = 6;
            this.listBox_name.SelectedIndexChanged += new System.EventHandler(this.listBox_name_SelectedIndexChanged);
            // 
            // textBox_szures
            // 
            this.textBox_szures.Location = new System.Drawing.Point(3, 10);
            this.textBox_szures.Name = "textBox_szures";
            this.textBox_szures.Size = new System.Drawing.Size(208, 23);
            this.textBox_szures.TabIndex = 5;
            this.textBox_szures.TextChanged += new System.EventHandler(this.textBox_szures_TextChanged);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(323, 97);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(242, 187);
            this.button_delete.TabIndex = 7;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.listBox_name);
            this.Controls.Add(this.textBox_szures);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1166, 677);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox_name;
        private TextBox textBox_szures;
        private Button button_delete;
    }
}

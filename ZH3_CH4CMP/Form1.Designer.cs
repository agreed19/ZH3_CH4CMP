namespace ZH3_CH4CMP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_add = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_excel = new System.Windows.Forms.Button();
            this.button_source = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(117, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 620);
            this.panel1.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(12, 29);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(82, 71);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(12, 106);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(82, 71);
            this.button_remove.TabIndex = 2;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_excel
            // 
            this.button_excel.Location = new System.Drawing.Point(12, 183);
            this.button_excel.Name = "button_excel";
            this.button_excel.Size = new System.Drawing.Size(82, 71);
            this.button_excel.TabIndex = 3;
            this.button_excel.Text = "Excel";
            this.button_excel.UseVisualStyleBackColor = true;
            this.button_excel.Click += new System.EventHandler(this.button_excel_Click);
            // 
            // button_source
            // 
            this.button_source.Location = new System.Drawing.Point(12, 260);
            this.button_source.Name = "button_source";
            this.button_source.Size = new System.Drawing.Size(82, 71);
            this.button_source.TabIndex = 4;
            this.button_source.Text = "Source";
            this.button_source.UseVisualStyleBackColor = true;
            this.button_source.Click += new System.EventHandler(this.button_source_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 622);
            this.Controls.Add(this.button_excel);
            this.Controls.Add(this.button_source);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button_add;
        private Button button_remove;
        private Button button_excel;
        private Button button_source;
    }
}
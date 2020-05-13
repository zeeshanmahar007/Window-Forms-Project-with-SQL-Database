namespace WindowsFormsApp1
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.name_box = new System.Windows.Forms.TextBox();
            this.section_box = new System.Windows.Forms.TextBox();
            this.roll_box = new System.Windows.Forms.TextBox();
            this.dob_box = new System.Windows.Forms.TextBox();
            this.class_box = new System.Windows.Forms.TextBox();
            this.cnic_box = new System.Windows.Forms.TextBox();
            this.address_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(177, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(216, 17);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(123, 20);
            this.name_box.TabIndex = 1;
            // 
            // section_box
            // 
            this.section_box.Location = new System.Drawing.Point(216, 173);
            this.section_box.Name = "section_box";
            this.section_box.Size = new System.Drawing.Size(123, 20);
            this.section_box.TabIndex = 2;
            // 
            // roll_box
            // 
            this.roll_box.Location = new System.Drawing.Point(216, 218);
            this.roll_box.Name = "roll_box";
            this.roll_box.Size = new System.Drawing.Size(123, 20);
            this.roll_box.TabIndex = 3;
            // 
            // dob_box
            // 
            this.dob_box.Location = new System.Drawing.Point(216, 258);
            this.dob_box.Name = "dob_box";
            this.dob_box.Size = new System.Drawing.Size(123, 20);
            this.dob_box.TabIndex = 4;
            // 
            // class_box
            // 
            this.class_box.Location = new System.Drawing.Point(216, 138);
            this.class_box.Name = "class_box";
            this.class_box.Size = new System.Drawing.Size(123, 20);
            this.class_box.TabIndex = 5;
            // 
            // cnic_box
            // 
            this.cnic_box.Location = new System.Drawing.Point(216, 95);
            this.cnic_box.Name = "cnic_box";
            this.cnic_box.Size = new System.Drawing.Size(123, 20);
            this.cnic_box.TabIndex = 6;
            this.cnic_box.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // address_box
            // 
            this.address_box.Location = new System.Drawing.Point(216, 56);
            this.address_box.Name = "address_box";
            this.address_box.Size = new System.Drawing.Size(123, 20);
            this.address_box.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date Of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Roll No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Section/Semester";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Class";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(140, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "CNIC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(140, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Name";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.library_home;
            this.ClientSize = new System.Drawing.Size(570, 412);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.address_box);
            this.Controls.Add(this.cnic_box);
            this.Controls.Add(this.class_box);
            this.Controls.Add(this.dob_box);
            this.Controls.Add(this.roll_box);
            this.Controls.Add(this.section_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox section_box;
        private System.Windows.Forms.TextBox roll_box;
        private System.Windows.Forms.TextBox dob_box;
        private System.Windows.Forms.TextBox class_box;
        private System.Windows.Forms.TextBox cnic_box;
        private System.Windows.Forms.TextBox address_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
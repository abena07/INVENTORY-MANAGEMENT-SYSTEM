using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Mgt_Sys
{
    internal class CreateUser: UserControl
    {
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private Button Add;
        private Label label6;
        private ComboBox comboBox1;
        private TextBox textBox1;

        public CreateUser()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 49);
            this.textBox1.MaximumSize = new System.Drawing.Size(180, 40);
            this.textBox1.MinimumSize = new System.Drawing.Size(180, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 40);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 141);
            this.textBox2.MaximumSize = new System.Drawing.Size(180, 40);
            this.textBox2.MinimumSize = new System.Drawing.Size(180, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 40);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Firstname";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date Of Birth";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 237);
            this.dateTimePicker1.MaximumSize = new System.Drawing.Size(180, 40);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(180, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 40);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(82, 334);
            this.textBox3.MaximumSize = new System.Drawing.Size(180, 40);
            this.textBox3.MinimumSize = new System.Drawing.Size(180, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 40);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(82, 429);
            this.textBox4.MaximumSize = new System.Drawing.Size(180, 40);
            this.textBox4.MinimumSize = new System.Drawing.Size(180, 40);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 40);
            this.textBox4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Usename";
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.SlateBlue;
            this.Add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add.Location = new System.Drawing.Point(148, 573);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(112, 42);
            this.Add.TabIndex = 11;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Role";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Attendant"});
            this.comboBox1.Location = new System.Drawing.Point(82, 527);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 33);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Text = "Attendant";
            // 
            // CreateUser
            // 
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CreateUser";
            this.Size = new System.Drawing.Size(534, 673);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

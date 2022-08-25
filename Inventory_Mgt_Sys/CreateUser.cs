using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Mgt_Sys
{
    internal class CreateUser: UserControl
    {
        private TextBox lastName;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dob;
        private TextBox userName;
        private TextBox password;
        private Label label4;
        private Label label5;
        private Button Add;
        private Label label6;
        private ComboBox role;
        private Label label7;
        private ComboBox gender;
        private TextBox firstName;

        public CreateUser()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(84, 49);
            this.firstName.MaximumSize = new System.Drawing.Size(180, 40);
            this.firstName.MinimumSize = new System.Drawing.Size(180, 40);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(180, 40);
            this.firstName.TabIndex = 0;
            this.firstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(84, 131);
            this.lastName.MaximumSize = new System.Drawing.Size(180, 40);
            this.lastName.MinimumSize = new System.Drawing.Size(180, 40);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(180, 40);
            this.lastName.TabIndex = 1;
            this.lastName.TextChanged += new System.EventHandler(this.lastName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Firstname";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lastname";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date Of Birth";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dob
            // 
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob.Location = new System.Drawing.Point(82, 216);
            this.dob.MaximumSize = new System.Drawing.Size(180, 40);
            this.dob.MinimumSize = new System.Drawing.Size(180, 40);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(180, 40);
            this.dob.TabIndex = 6;
            this.dob.ValueChanged += new System.EventHandler(this.dob_ValueChanged);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(82, 303);
            this.userName.MaximumSize = new System.Drawing.Size(180, 40);
            this.userName.MinimumSize = new System.Drawing.Size(180, 40);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(180, 40);
            this.userName.TabIndex = 7;
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(82, 397);
            this.password.MaximumSize = new System.Drawing.Size(180, 40);
            this.password.MinimumSize = new System.Drawing.Size(180, 40);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(180, 40);
            this.password.TabIndex = 8;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Usename";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.SlateBlue;
            this.Add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add.Location = new System.Drawing.Point(152, 613);
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
            this.label6.Location = new System.Drawing.Point(84, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Role";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // role
            // 
            this.role.FormattingEnabled = true;
            this.role.Items.AddRange(new object[] {
            "Admin",
            "Attendant"});
            this.role.Location = new System.Drawing.Point(82, 563);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(182, 33);
            this.role.TabIndex = 13;
            this.role.Text = "Attendant";
            this.role.SelectedIndexChanged += new System.EventHandler(this.role_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Gender";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(84, 483);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(182, 33);
            this.gender.TabIndex = 16;
            this.gender.SelectedIndexChanged += new System.EventHandler(this.gender_SelectedIndexChanged);
            // 
            // CreateUser
            // 
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.role);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
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
            string fname = this.firstName.Text;
            string lname = this.lastName.Text;
            string pswd = this.password.Text;
            string role = this.role.Text;
            string uname = this.userName.Text;
            string gender = this.gender.Text;
            string dob = this.dob.Text;
            User user = new User(fname,lname, dob, role,pswd,uname,gender);
            user.CreateUser();
            //MessageBox.Show("User has been added successfully!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

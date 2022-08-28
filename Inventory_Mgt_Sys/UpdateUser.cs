using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCr = BCrypt.Net;

namespace Inventory_Mgt_Sys
{
    internal class UpdateUser : UserControl
    {
        private ComboBox gender;
        private Label label7;
        private ComboBox role;
        private Label label6;
        private Button Update;
        private Label label5;
        private Label label4;
        private TextBox password;
        private TextBox userName;
        private DateTimePicker dob;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox lastName;
        private TextBox searchField;
        private Button button1;
        private Label label8;
        private Button button2;
        private TextBox firstName;

        public UpdateUser()
        {
            InitializeComponent();
        }

      

        private void InitializeComponent()
        {
            this.gender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.searchField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(365, 390);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(182, 33);
            this.gender.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Gender";
            // 
            // role
            // 
            this.role.FormattingEnabled = true;
            this.role.Items.AddRange(new object[] {
            "Admin",
            "Attendant"});
            this.role.Location = new System.Drawing.Point(41, 489);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(182, 33);
            this.role.TabIndex = 29;
            this.role.Text = "Attendant";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Role";
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.SlateBlue;
            this.Update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Update.Location = new System.Drawing.Point(403, 646);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(112, 42);
            this.Update.TabIndex = 27;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Usename";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(43, 383);
            this.password.MaximumSize = new System.Drawing.Size(180, 40);
            this.password.MinimumSize = new System.Drawing.Size(180, 40);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(180, 40);
            this.password.TabIndex = 24;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(365, 270);
            this.userName.MaximumSize = new System.Drawing.Size(180, 40);
            this.userName.MinimumSize = new System.Drawing.Size(180, 40);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(180, 40);
            this.userName.TabIndex = 23;
            // 
            // dob
            // 
            this.dob.CustomFormat = "dd/MM/yyyy";
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dob.Location = new System.Drawing.Point(43, 270);
            this.dob.MaximumSize = new System.Drawing.Size(180, 40);
            this.dob.MinimumSize = new System.Drawing.Size(180, 40);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(180, 40);
            this.dob.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Date Of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Firstname";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(365, 162);
            this.lastName.MaximumSize = new System.Drawing.Size(180, 40);
            this.lastName.MinimumSize = new System.Drawing.Size(180, 40);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(180, 40);
            this.lastName.TabIndex = 18;
            this.lastName.TextChanged += new System.EventHandler(this.lastName_TextChanged);
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(43, 162);
            this.firstName.MaximumSize = new System.Drawing.Size(180, 40);
            this.firstName.MinimumSize = new System.Drawing.Size(180, 40);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(180, 40);
            this.firstName.TabIndex = 17;
            // 
            // searchField
            // 
            this.searchField.Location = new System.Drawing.Point(137, 63);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(150, 31);
            this.searchField.TabIndex = 32;
            this.searchField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(280, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 42);
            this.button1.TabIndex = 33;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "Search";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateBlue;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(297, 646);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 42);
            this.button2.TabIndex = 35;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdateUser
            // 
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.role);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Update);
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
            this.Name = "UpdateUser";
            this.Size = new System.Drawing.Size(599, 752);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        //onclick the user is updated
        private void Update_Click(object sender, EventArgs e)
        {
            string fname = this.firstName.Text;
            string lname = this.lastName.Text;
            string pswd_hash = Utils.hashPassword(this.password.Text);
            string role = this.role.Text;
            string uname = this.userName.Text;
            string gender = this.gender.Text;
            string dob = this.dob.Text;
            User user = new User(fname, lname, dob, role, pswd_hash, uname, gender);
            user.UpdateUser();
            MessageBox.Show("User has been updated successfully!");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        // onclik this searches for a user
        private void button1_Click(object sender, EventArgs e)
        {
            User userFound = User.Search(searchField.Text);
            if (userFound != null)
            {
                firstName.Text = userFound.FirstName;
                lastName.Text = userFound.LastName;
                password.Text = userFound.Password; 
                role.Text = userFound.Role; 
                gender.Text = userFound.Gender;
                userName.Text = userFound.UserName;
                dob.Text = userFound.DateOfBirth.ToString();
            }
            else
                MessageBox.Show(" oops,user does not exist.");

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }
        ///onclick the user is deleted
        private void button2_Click(object sender, EventArgs e)
        {
            string fname = this.firstName.Text;
            string lname = this.lastName.Text;
            string pswd_hash = Utils.hashPassword(this.password.Text);
            string role = this.role.Text;
            string uname = this.userName.Text;
            string gender = this.gender.Text;
            string dob = this.dob.Text;
            User user = new User(fname, lname, dob, role, pswd_hash, uname, gender);
            user.DeleteUser(uname);
            MessageBox.Show("User has been deleted");
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

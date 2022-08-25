using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.SuspendLayout();
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(139, 523);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(182, 33);
            this.gender.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 495);
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
            this.role.Location = new System.Drawing.Point(137, 603);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(182, 33);
            this.role.TabIndex = 29;
            this.role.Text = "Attendant";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 575);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Role";
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.SlateBlue;
            this.Update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Update.Location = new System.Drawing.Point(207, 653);
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
            this.label5.Location = new System.Drawing.Point(137, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Usename";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(137, 437);
            this.password.MaximumSize = new System.Drawing.Size(180, 40);
            this.password.MinimumSize = new System.Drawing.Size(180, 40);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(180, 40);
            this.password.TabIndex = 24;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(137, 343);
            this.userName.MaximumSize = new System.Drawing.Size(180, 40);
            this.userName.MinimumSize = new System.Drawing.Size(180, 40);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(180, 40);
            this.userName.TabIndex = 23;
            // 
            // dob
            // 
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob.Location = new System.Drawing.Point(137, 256);
            this.dob.MaximumSize = new System.Drawing.Size(180, 40);
            this.dob.MinimumSize = new System.Drawing.Size(180, 40);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(180, 40);
            this.dob.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Date Of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Firstname";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(139, 171);
            this.lastName.MaximumSize = new System.Drawing.Size(180, 40);
            this.lastName.MinimumSize = new System.Drawing.Size(180, 40);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(180, 40);
            this.lastName.TabIndex = 18;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(139, 89);
            this.firstName.MaximumSize = new System.Drawing.Size(180, 40);
            this.firstName.MinimumSize = new System.Drawing.Size(180, 40);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(180, 40);
            this.firstName.TabIndex = 17;
            // 
            // UpdateUser
            // 
            this.BackColor = System.Drawing.Color.Lavender;
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

        private void Update_Click(object sender, EventArgs e)
        {
            string fname = this.firstName.Text;
            string lname = this.lastName.Text;
            string pswd = this.password.Text;
            string role = this.role.Text;
            string uname = this.userName.Text;
            string gender = this.gender.Text;
            string dob = this.dob.Text;
            User user = new User(fname, lname, dob, role, pswd, uname, gender);
            user.UpdateUser();
            MessageBox.Show("User has been added successfully!");
        }
    }
}

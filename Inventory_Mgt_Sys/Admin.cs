using System;

namespace Inventory_Mgt_Sys
{
    public class Admin : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private CreateUser createUser;

        public Admin()
        {
            InitializeComponent();

        }

        private void InitializeComponent()
        {
            this.createUser = new Inventory_Mgt_Sys.CreateUser();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // createUser
            // 
            this.createUser.BackColor = System.Drawing.Color.Lavender;
            this.createUser.Location = new System.Drawing.Point(0, 0);
            this.createUser.Margin = new System.Windows.Forms.Padding(0);
            this.createUser.Name = "createUser";
            this.createUser.Size = new System.Drawing.Size(883, 635);
            this.createUser.TabIndex = 0;
            this.createUser.Load += new System.EventHandler(this.createUser_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Update User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Delete User";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "View Users";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 640);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 76);
            this.label8.TabIndex = 7;
            this.label8.Text = "Manage Product Categories";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(17, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Delete Product";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(17, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Update Product";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Add Product";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.createUser);
            this.panel2.Location = new System.Drawing.Point(216, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 632);
            this.panel2.TabIndex = 1;
            // 
            // Admin
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1119, 657);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.Load += new System.EventHandler(this.Class1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void Class1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createUser_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        override
        protected void OnClosed(EventArgs e)
        {
            var login = (Form1)Tag;
            login.Close();
        }
    }
}
namespace Inventory_Mgt_Sys
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
            this.label4 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(55, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(638, 48);
            this.label4.TabIndex = 1;
            this.label4.Text = "INVENTORY MANAGEMENT SYSTEM";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // userName
            // 
            this.userName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userName.Location = new System.Drawing.Point(146, 166);
            this.userName.MaximumSize = new System.Drawing.Size(200, 33);
            this.userName.MinimumSize = new System.Drawing.Size(200, 33);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(200, 33);
            this.userName.TabIndex = 0;
            this.userName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // password
            // 
            this.password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password.Location = new System.Drawing.Point(146, 289);
            this.password.MaximumSize = new System.Drawing.Size(200, 33);
            this.password.MinimumSize = new System.Drawing.Size(200, 33);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(200, 33);
            this.password.TabIndex = 1;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(179, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(234, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.userName);
            this.panel1.Location = new System.Drawing.Point(134, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 537);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 660);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label4;
        private TextBox userName;
        private TextBox password;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Panel panel1;
    }
}
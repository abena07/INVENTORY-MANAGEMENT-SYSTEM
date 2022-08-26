using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Mgt_Sys
{
    internal class AddProduct:UserControl
    {
        private Label label7;
        private Button Add;
        private Label label4;
        private TextBox ProductColor;
        private DateTimePicker Dop;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox ProductQty;
        private TextBox ProductCat;
        private TextBox ProductPrice;
        private Label label5;
        private TextBox ProductName;

        public AddProduct()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductColor = new System.Windows.Forms.TextBox();
            this.Dop = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductQty = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.ProductCat = new System.Windows.Forms.TextBox();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "ProductCat";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.SlateBlue;
            this.Add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add.Location = new System.Drawing.Point(408, 408);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(112, 42);
            this.Add.TabIndex = 27;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "ProductColor";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ProductColor
            // 
            this.ProductColor.Location = new System.Drawing.Point(331, 173);
            this.ProductColor.MaximumSize = new System.Drawing.Size(180, 40);
            this.ProductColor.MinimumSize = new System.Drawing.Size(180, 40);
            this.ProductColor.Name = "ProductColor";
            this.ProductColor.Size = new System.Drawing.Size(180, 40);
            this.ProductColor.TabIndex = 24;
            this.ProductColor.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // Dop
            // 
            this.Dop.CustomFormat = "dd/MM/yyyy";
            this.Dop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dop.Location = new System.Drawing.Point(329, 69);
            this.Dop.MaximumSize = new System.Drawing.Size(180, 40);
            this.Dop.MinimumSize = new System.Drawing.Size(180, 40);
            this.Dop.Name = "Dop";
            this.Dop.Size = new System.Drawing.Size(180, 40);
            this.Dop.TabIndex = 22;
            this.Dop.ValueChanged += new System.EventHandler(this.dob_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Date Of Purchase";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "ProductQty";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "ProductName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProductQty
            // 
            this.ProductQty.Location = new System.Drawing.Point(84, 173);
            this.ProductQty.MaximumSize = new System.Drawing.Size(180, 40);
            this.ProductQty.MinimumSize = new System.Drawing.Size(180, 40);
            this.ProductQty.Name = "ProductQty";
            this.ProductQty.Size = new System.Drawing.Size(180, 40);
            this.ProductQty.TabIndex = 18;
            this.ProductQty.TextChanged += new System.EventHandler(this.lastName_TextChanged);
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(88, 69);
            this.ProductName.MaximumSize = new System.Drawing.Size(180, 40);
            this.ProductName.MinimumSize = new System.Drawing.Size(180, 40);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(180, 40);
            this.ProductName.TabIndex = 17;
            this.ProductName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // ProductCat
            // 
            this.ProductCat.Location = new System.Drawing.Point(81, 284);
            this.ProductCat.MaximumSize = new System.Drawing.Size(180, 40);
            this.ProductCat.MinimumSize = new System.Drawing.Size(180, 40);
            this.ProductCat.Name = "ProductCat";
            this.ProductCat.Size = new System.Drawing.Size(180, 40);
            this.ProductCat.TabIndex = 31;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Location = new System.Drawing.Point(331, 284);
            this.ProductPrice.MaximumSize = new System.Drawing.Size(180, 40);
            this.ProductPrice.MinimumSize = new System.Drawing.Size(180, 40);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(180, 40);
            this.ProductPrice.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "ProductPrice";
            // 
            // AddProduct
            // 
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductCat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductColor);
            this.Controls.Add(this.Dop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductQty);
            this.Controls.Add(this.ProductName);
            this.Name = "AddProduct";
            this.Size = new System.Drawing.Size(662, 770);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string pname = this.ProductName.Text;
            string dop = this.Dop.Text;
            int pqty = int.Parse(this.ProductQty.Text);
            string pcolor = this.ProductColor.Text;
            string pcat = this.ProductCat.Text;
            int price = int.Parse(this.ProductPrice.Text);
          
            Product product = new Product(pname,dop,pqty,pcolor,pcat,price );
            
            product.AddProduct();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

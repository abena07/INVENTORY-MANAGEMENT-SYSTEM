using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Inventory_Mgt_Sys
{
    internal class UpdateProduct:UserControl
    {
        private Button button2;
        private Label label8;
        private Button button1;
        private TextBox searchField;
        private TextBox ProductCat;
        private Label label7;
        private Label label4;
        private TextBox ProductColor;
        private DateTimePicker Dop;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox ProductQty;
        private TextBox ProductName;
        private TextBox ProductPrice;
        private Label label5;
        private Button Update;

        public UpdateProduct()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.searchField = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.ProductCat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductColor = new System.Windows.Forms.TextBox();
            this.Dop = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductQty = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateBlue;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(326, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 42);
            this.button2.TabIndex = 54;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 53;
            this.label8.Text = "Search";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(285, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 42);
            this.button1.TabIndex = 52;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchField
            // 
            this.searchField.Location = new System.Drawing.Point(142, 63);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(150, 23);
            this.searchField.TabIndex = 51;
            this.searchField.TextChanged += new System.EventHandler(this.searchField_TextChanged);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.SlateBlue;
            this.Update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Update.Location = new System.Drawing.Point(432, 468);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(112, 42);
            this.Update.TabIndex = 46;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // ProductCat
            // 
            this.ProductCat.Location = new System.Drawing.Point(37, 372);
            this.ProductCat.MaximumSize = new System.Drawing.Size(180, 40);
            this.ProductCat.MinimumSize = new System.Drawing.Size(180, 40);
            this.ProductCat.Name = "ProductCat";
            this.ProductCat.Size = new System.Drawing.Size(180, 40);
            this.ProductCat.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 64;
            this.label7.Text = "ProductCat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 62;
            this.label4.Text = "ProductColor";
            // 
            // ProductColor
            // 
            this.ProductColor.Location = new System.Drawing.Point(350, 242);
            this.ProductColor.MaximumSize = new System.Drawing.Size(180, 40);
            this.ProductColor.MinimumSize = new System.Drawing.Size(180, 40);
            this.ProductColor.Name = "ProductColor";
            this.ProductColor.Size = new System.Drawing.Size(180, 40);
            this.ProductColor.TabIndex = 61;
            // 
            // Dop
            // 
            this.Dop.CustomFormat = "dd/MM/yyyy";
            this.Dop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dop.Location = new System.Drawing.Point(37, 236);
            this.Dop.MaximumSize = new System.Drawing.Size(180, 40);
            this.Dop.MinimumSize = new System.Drawing.Size(180, 40);
            this.Dop.Name = "Dop";
            this.Dop.Size = new System.Drawing.Size(180, 40);
            this.Dop.TabIndex = 60;
            this.Dop.Value = new System.DateTime(2022, 8, 30, 0, 0, 0, 0);
            this.Dop.ValueChanged += new System.EventHandler(this.Dop_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 59;
            this.label3.Text = "Date Of Purchase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 58;
            this.label2.Text = "ProductQty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "ProductName";
            // 
            // ProductQty
            // 
            this.ProductQty.Location = new System.Drawing.Point(350, 134);
            this.ProductQty.MaximumSize = new System.Drawing.Size(180, 40);
            this.ProductQty.MinimumSize = new System.Drawing.Size(180, 40);
            this.ProductQty.Name = "ProductQty";
            this.ProductQty.Size = new System.Drawing.Size(180, 40);
            this.ProductQty.TabIndex = 56;
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(39, 134);
            this.ProductName.MaximumSize = new System.Drawing.Size(180, 40);
            this.ProductName.MinimumSize = new System.Drawing.Size(180, 40);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(180, 40);
            this.ProductName.TabIndex = 55;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Location = new System.Drawing.Point(339, 372);
            this.ProductPrice.MaximumSize = new System.Drawing.Size(180, 40);
            this.ProductPrice.MinimumSize = new System.Drawing.Size(180, 40);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(180, 40);
            this.ProductPrice.TabIndex = 67;
            this.ProductPrice.TextChanged += new System.EventHandler(this.ProductPrice_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 66;
            this.label5.Text = "ProductPrice";
            // 
            // UpdateProduct
            // 
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductCat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductColor);
            this.Controls.Add(this.Dop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductQty);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.Update);
            this.Name = "UpdateProduct";
            this.Size = new System.Drawing.Size(617, 723);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ProductPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product productFound = Product.Search(searchField.Text);
            if (productFound != null)
            {
                ProductName.Text = productFound.ProductName;
                Dop.Text = productFound.Dop.ToString();
                ProductQty.Text = productFound.ProductQty.ToString();
                ProductColor.Text = productFound.ProductColor;
                ProductCat.Text = productFound.ProductCat;
                ProductPrice.Text = productFound.ProductPrice.ToString();
            }
            else
                MessageBox.Show(" oops,product does not exist.");
            
        }

        

        private void searchField_TextChanged(object sender, EventArgs e)
        {

        }
        //onlclick product is updated
        private void Update_Click(object sender, EventArgs e)
        {
            string name = this.ProductName.Text;
            string dop = this.Dop.Text;
            int qty = int.Parse(this.ProductQty.Text);
            string color = this.ProductColor.Text;
            string cat = this.ProductCat.Text;
            int price = int.Parse(this.ProductPrice.Text);
            
            Product product = new Product(name,dop,qty,color,cat,price);
            product.UpdateProduct();
            MessageBox.Show("Product has been updated successfully!");

        }
        // onclick the product is deleted
        private void button2_Click(object sender, EventArgs e)
        {
            string productname = this.ProductName.Text;
            string dop = this.Dop.Text;
            int qty = int.Parse(this.ProductQty.Text);
            string color = this.ProductColor.Text;
            string cat = this.ProductCat.Text;
            int price = int.Parse(this.ProductPrice.Text);

            Product product = new Product(productname, dop, qty, color, cat, price);
            product.DeleteProduct(productname);
            MessageBox.Show("Product has been deleted!");
        }

        private void Dop_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

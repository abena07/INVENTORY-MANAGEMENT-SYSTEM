using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Mgt_Sys
{
    internal class Attendant:UserControl
    {
        private TextBox ProductPrice;
        private Label label5;
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
        private Button button2;
        private Button Update;

        private void InitializeComponent()
        {
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.button2 = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductPrice
            // 
            this.ProductPrice.Location = new System.Drawing.Point(398, 406);
            this.ProductPrice.MaximumSize = new System.Drawing.Size(180, 40);
            this.ProductPrice.MinimumSize = new System.Drawing.Size(180, 40);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(180, 40);
            this.ProductPrice.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 83;
            this.label5.Text = "ProductPrice";
            // 
            // ProductCat
            // 
            this.ProductCat.Location = new System.Drawing.Point(96, 406);
            this.ProductCat.MaximumSize = new System.Drawing.Size(180, 40);
            this.ProductCat.MinimumSize = new System.Drawing.Size(180, 40);
            this.ProductCat.Name = "ProductCat";
            this.ProductCat.Size = new System.Drawing.Size(180, 40);
            this.ProductCat.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 81;
            this.label7.Text = "ProductCat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 80;
            this.label4.Text = "ProductColor";
            // 
            // ProductColor
            // 
            this.ProductColor.Location = new System.Drawing.Point(409, 276);
            this.ProductColor.MaximumSize = new System.Drawing.Size(180, 40);
            this.ProductColor.MinimumSize = new System.Drawing.Size(180, 40);
            this.ProductColor.Name = "ProductColor";
            this.ProductColor.Size = new System.Drawing.Size(180, 40);
            this.ProductColor.TabIndex = 79;
            // 
            // Dop
            // 
            this.Dop.CustomFormat = "dd/MM/yyyy";
            this.Dop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dop.Location = new System.Drawing.Point(96, 270);
            this.Dop.MaximumSize = new System.Drawing.Size(180, 40);
            this.Dop.MinimumSize = new System.Drawing.Size(180, 40);
            this.Dop.Name = "Dop";
            this.Dop.Size = new System.Drawing.Size(180, 40);
            this.Dop.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 77;
            this.label3.Text = "Date Of Purchase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 76;
            this.label2.Text = "ProductQty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 75;
            this.label1.Text = "ProductName";
            // 
            // ProductQty
            // 
            this.ProductQty.Location = new System.Drawing.Point(409, 168);
            this.ProductQty.MaximumSize = new System.Drawing.Size(180, 40);
            this.ProductQty.MinimumSize = new System.Drawing.Size(180, 40);
            this.ProductQty.Name = "ProductQty";
            this.ProductQty.Size = new System.Drawing.Size(180, 40);
            this.ProductQty.TabIndex = 74;
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(98, 168);
            this.ProductName.MaximumSize = new System.Drawing.Size(180, 40);
            this.ProductName.MinimumSize = new System.Drawing.Size(180, 40);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(180, 40);
            this.ProductName.TabIndex = 73;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateBlue;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(385, 502);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 42);
            this.button2.TabIndex = 72;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.SlateBlue;
            this.Update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Update.Location = new System.Drawing.Point(491, 502);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(112, 42);
            this.Update.TabIndex = 68;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            // 
            // Attendant
            // 
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
            this.Controls.Add(this.Update);
            this.Name = "Attendant";
            this.Size = new System.Drawing.Size(698, 613);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

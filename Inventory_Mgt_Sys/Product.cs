
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;

namespace Inventory_Mgt_Sys
{
	internal class Product
	{
		Db_Connection _connection;
		//prodductName
		private string productName;

		public string ProductName
			{
				get { return productName; }
	set { productName = value; }
			}

			//DateOfPurchase
			private DateOnly dop;

public DateOnly Dop
{
	get { return dop; }
	set { dop = value; }
}
//productqqty
private int productQty;

public int ProductQty
{
	get { return productQty; }
	set { productQty = value; }
}
//product color
private string productColor;

public string ProductColor
{
	get { return productColor; }
	set { productColor = value; }
}
///productCategory
private string productCategory;

public string ProductCategory
{
	get { return productCategory; }
	set { productCategory = value; }
}
		private int productPrice;

		public int ProductPrice
		{
			get { return productPrice; }
			set { productPrice = value; }
		}


		public Product(string productName, string dop, int productQty, string productColor, string productCategory, int productPrice)
{
	this.productName = productName;
	this.dop = DateOnly.Parse(dop, new CultureInfo("fr-FR"));
            this.productQty = productQty;
			this.productColor = productColor;
			this.productCategory = productCategory;
			this.productPrice = productPrice;

}
		//a query to add product
        public void AddProduct()
        {
            _connection = new();
            String insertQuery = $"INSERT INTO product(ProductName,Dop,ProductQty,ProductColor, ProductCat,ProductPrice)" +
			$"VALUES('{productName}', STR_TO_DATE('{dop}', '%m/%d/%Y') ,'{productQty}','{productColor}', '{productCategory}','{productPrice}')";
			try
			{
                MySqlCommand cmd = new(insertQuery, _connection.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product has beem added successfuly");


            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("fuss");
                

            }
        }




    }
}


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
private string productCat;

public string ProductCat
{
	get { return productCat; }
	set { productCat = value; }
}
		private int productPrice;

		public int ProductPrice
		{
			get { return productPrice; }
			set { productPrice = value; }
		}


		public Product(string productName, string dop, int productQty, string productColor, string productCat, int productPrice)
{
	this.productName = productName;
	this.dop = DateOnly.Parse(dop, new CultureInfo("fr-FR"));
            this.productQty = productQty;
			this.productColor = productColor;
			this.productCat = productCat;
			this.productPrice = productPrice;

}
		//a query to add product
        public void AddProduct()
        {
            _connection = new();
            String insertQuery = $"INSERT INTO product(ProductName,Dop,ProductQty,ProductColor, ProductCat,ProductPrice)" +
			$"VALUES('{productName}', STR_TO_DATE('{dop}', '%m/%d/%Y') ,'{productQty}','{productColor}', '{productCat}','{productPrice}')";
			try
			{
                MySqlCommand cmd = new(insertQuery, _connection.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product has been added successfuly");


            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("fuss");
                

            }
        }

        //a query to search for products
        public static Product Search(string productname)
        {
            Db_Connection _connection = new();
            string searchQuery = $"SELECT * FROM product WHERE userName = '{productname}'";
            Product productFound = null;
            try
            {
                MySqlCommand cmd = new(searchQuery, _connection.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    string ProductName = reader["ProductName"].ToString()!;
                    string Dop = DateTime.ParseExact(reader["Dop"].ToString()!, "M/d/yyyy hh:mm:ss tt",
                        CultureInfo.InvariantCulture).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string ProductQty = reader["ProductQty"].ToString()!;
                    string ProductColor = reader["ProductColor"].ToString()!;
                    string ProductCat  = reader["ProductCat"].ToString()!;
                    string ProductPrice = reader["ProductPrice"].ToString()!;


                    productFound = new(ProductName, Dop, int.Parse(ProductQty), ProductColor, ProductCat, int.Parse(ProductPrice));
                }

                return productFound; 
                Console.WriteLine("fuss");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return productFound;
            Console.WriteLine("fuss");



            

        }

        //function to update user
        public void UpdateProduct()
        {
            _connection = new();
            string updateQuery = $"UPDATE product SET ProductName='{ProductName}', Dop=STR_TO_DATE({Dop},'%m/%d/%Y'), Dop='{Dop}'" +
                $"ProductQty='{ProductQty}', ProductColor='{ProductColor}',ProductCat='{ProductCat}',ProductPrice='{ProductPrice}' WHERE ProductName='{ProductName}'";
            try
            {
                MySqlCommand cmd = new(updateQuery, _connection.conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("fuss");
                MessageBox.Show("Product has sucessfully been updated");

            }
        }


        // function to delete user
        public void DeleteProducr(string productname)
        {
            _connection = new();
            string deleteQuery = $"DELETE FROM product WHERE ProductName = '{productname}'";
            try
            {
                MySqlCommand cmd = new(deleteQuery, _connection.conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("fuss");
                MessageBox.Show("Product has sucessfully been updated");

            }
        }
    }




}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Threading.Tasks;

namespace Inventory_Mgt_Sys
{
    internal class Product
    {
			Db_Connection _connection;
			//prodductName
			private string productName;

			public string ProductName;
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

public Product(string productName, string dop, int productQty,string productColor,string productCat)
{
	this.productName = productName;
}




	}
}

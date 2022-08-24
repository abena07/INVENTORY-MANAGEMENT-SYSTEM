using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;



namespace Inventory_Mgt_Sys
{
    internal class Db_Connection
    {

        public MySqlConnection conn = new();
        public Db_Connection()
        {
            try
            {
                String connectionString = "server=localhost;database=inventory;uid=root;pwd=;";
                this.conn.ConnectionString = connectionString;
                Console.WriteLine("succes");
                //open the connection
                conn.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine("o, o, o");
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}

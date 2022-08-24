namespace Inventory_Mgt_Sys
{
    internal class Program
    {
        static Db_Connection connection;
        static void Main(string[] args)
        {
            connection = new Db_Connection();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
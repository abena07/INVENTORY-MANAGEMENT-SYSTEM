namespace Inventory_Mgt_Sys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
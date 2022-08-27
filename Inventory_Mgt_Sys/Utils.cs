using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace Inventory_Mgt_Sys
{
    public class Utils
    {
        public static string hashPassword(string password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] password_bytes = Encoding.ASCII.GetBytes(password);
            byte[] encrpted_bytes = sha1.ComputeHash(password_bytes);
            return Convert.ToBase64String(encrpted_bytes);
        }
    }
}

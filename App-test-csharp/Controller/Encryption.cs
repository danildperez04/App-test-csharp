using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary.Controller
{
    public class Encryption
    {
        public static string EncryptThisString(string input)
        {
            StringBuilder oResHash = new StringBuilder();

            using (SHA256 oHash = SHA256Managed.Create())
            {
                Encoding oEnc = Encoding.UTF8;
                byte[] baResult = oHash.ComputeHash(oEnc.GetBytes(input));

                foreach (byte b in baResult)
                    oResHash.Append(b.ToString("x2"));
            }

            return oResHash.ToString();
        }
    }
}

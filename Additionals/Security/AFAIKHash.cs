using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Additionals.Security
{

    public class AFAIKHash
    {

        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            data.All(b => { sBuilder.Append(b.ToString("x2")); return true; });
            return sBuilder.ToString();
        }

      

    }
}
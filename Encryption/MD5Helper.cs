using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    /// <summary>
    /// MD5Helper 的摘要说明。
    /// </summary>
    public class MD5Helper
    {
        /// <summary>
        /// 得到一个加密的字符串
        /// </summary>
        /// <param name="strIn">原始字符串</param>
        /// <returns>加密后字符串</returns>
        public static string GetMD5String(string strIn)
        {
            byte[] b = Encoding.Default.GetBytes(strIn);

            b = new MD5CryptoServiceProvider().ComputeHash(b);
            string strOut = "";
            for (int i = 0; i < b.Length; i++)
            {
                strOut += b[i].ToString("x").PadLeft(2, '2');
            }
            return strOut;
        }
    }
}

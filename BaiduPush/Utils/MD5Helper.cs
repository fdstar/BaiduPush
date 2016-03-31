using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Utils
{
    public static class MD5Helper
    {
        /// <summary>  
        /// 获取32位长度的Md5摘要  
        /// </summary>  
        /// <param name="inputStr"></param>  
        /// <param name="encoding"></param>  
        /// <returns></returns>  
        public static string GetMD5_32(this string inputStr, Encoding encoding = null)
        {
            RefEncoding(ref encoding);
            byte[] data = GetMD5(inputStr, encoding);
            StringBuilder tmp = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                tmp.Append(data[i].ToString("x2"));
            }
            //BitConverter.ToString(data).Replace('-', '\0');
            return tmp.ToString();
        }
        private static byte[] GetMD5(string inputStr, Encoding encoding)
        {
            using (MD5 md5Hash = MD5.Create())//MD5CryptoServiceProvider
            {
                return md5Hash.ComputeHash(encoding.GetBytes(inputStr));
            }
        }
        private static void RefEncoding(ref Encoding encoding)
        {
            if (encoding == null)
            {
                encoding = Encoding.Default;
            }
        }
    }
}

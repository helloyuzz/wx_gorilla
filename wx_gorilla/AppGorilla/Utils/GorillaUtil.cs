using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace com.wechat.gorilla {
    public class GorillaUtil {
        public static string UUID {
            get {
                return Guid.NewGuid().ToString().Replace("-", "");
            }
        }

        internal static int QueryInt(IQueryCollection query, string key) {
            return ParseInt(query[key]);
        }
        public static int ParseInt(object value) {
            int intValue = 0;
            if (value != null) {
                int.TryParse(value.ToString(), out intValue);
            }
            return intValue;
        }

        internal static string Md5(string pwd) {
            string result = "";
            using (MD5 md5 = MD5.Create()) {
                Byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(pwd));
                StringBuilder stringBuilder = new StringBuilder();
                foreach (Byte key in bytes) {
                    stringBuilder.Append(key.ToString("X2"));
                }
                result = stringBuilder.ToString();
            }
            return result;
        }        
    }
}

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla {
    public class GorillaUtil {
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
    }
}

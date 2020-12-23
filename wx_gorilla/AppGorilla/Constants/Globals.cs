using com.wechat.gorilla.Models;

namespace com.wechat.gorilla {
    public class Globals {
        static string _MySqlConnectionString = null;
        static string _MsSQLConnectionString = null;

        public static string MySqlConnectionString {
            get {
                // allowPublicKeyRetrieval=true;SslMode=None;
                if (string.IsNullOrEmpty(_MySqlConnectionString)) {
                    _MySqlConnectionString = AppConfigurtaionServices.Configuration["ConnectionString:MySql"];
                    if (string.IsNullOrEmpty(_MySqlConnectionString)) {
                        throw new ExceptionConnectionStringIsNull(SystemMessage.ConnectionStringIsNull);
                    }
                }
                return _MySqlConnectionString;
            }
        }
        public static string MsSqlConnectionString {
            get {
                if (string.IsNullOrEmpty(_MsSQLConnectionString)) {
                    _MsSQLConnectionString = AppConfigurtaionServices.Configuration["ConnectionString:MsSql"];
                    if (string.IsNullOrEmpty(_MsSQLConnectionString)) {
                        throw new ExceptionConnectionStringIsNull(SystemMessage.ConnectionStringIsNull);
                    }
                }
                return _MsSQLConnectionString;
            }
        }

        public static Account Cua { get; internal set; }

        public const string AuthCookieFlag = "AuthCookieFlag-Temp";
        public const string CopyRight = "蓝鹰追溯";
    }
}

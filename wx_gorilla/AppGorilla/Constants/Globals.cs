using com.wechat.gorilla.Models;
using System.Collections.Generic;

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

        public static string SessionKey_SwitchPanel = "KEY-SwitchPanel";
        public static string SessionKey_ActiveMenuId = "KEY-ActiveMenuId";
        public static string SessionKey_CUA = "KEY-CUA";

        public static User Current_user;

        public const string AuthCookieFlag = "AuthCookieFlag-Temp";
        public const string CopyRight = "蓝鹰追溯";
        private static List<NaviMenuItem> _list = null;
        public static List<NaviMenuItem> NaviMenus {
            get {
                if (_list == null || _list.Count <=0) {
                    _list = new List<NaviMenuItem>();
                    NaviMenuItem naviMenu_Index = new NaviMenuItem() {
                        Menu_id = "navMenu_Index",
                        MenuText = "Welcome",
                        AspPage = "/Index",
                        Menu_icons = "glyphicon glyphicon glyphicon-th menuIcon",
                    };
                    NaviMenuItem naviMenu_Project = new NaviMenuItem() {
                        Menu_id = "naviMenu_Project",
                        MenuText = "项目列表",
                        AspPage = "/Projects/Index",
                        Menu_icons = "glyphicon glyphicon glyphicon-flag menuIcon",
                    };
                    NaviMenuItem naviMenu_Subscribe = new NaviMenuItem() {
                        Menu_id = "naviMenu_Subscribe",
                        MenuText = "推送订阅",
                        AspPage = "/Index",
                        Menu_icons = "glyphicon glyphicon glyphicon-flash menuIcon",
                    };
                    //NaviMenuItem naviMenu_System = new NaviMenuItem() {
                    //    Menu_id = "naviMenu_System",
                    //    MenuText = "系统管理",
                    //    AspPage = "/Provinces/Index",
                    //    Menu_icons = "glyphicon glyphicon glyphicon-wrench menuIcon",
                    //};
                    //NaviMenuItem naviMenu_ChangePwd = new NaviMenuItem() {
                    //    Menu_id = "naviMenu_ChangePwd",
                    //    MenuText = "修改密码",
                    //    AspPage = "/ChangePwd",
                    //    Menu_icons = "glyphicon glyphicon glyphicon-save menuIcon",
                    //};
                    //NaviMenuItem naviMenu_AuditLog = new NaviMenuItem() {
                    //    Menu_id = "naviMenu_AuditLog",
                    //    MenuText = "日志审计",
                    //    AspPage = "/Index",
                    //    Menu_icons = "glyphicon glyphicon glyphicon-th menuIcon",
                    //};
                    //NaviMenuItem naviMenu_Privacy = new NaviMenuItem() {
                    //    Menu_id = "naviMenu_Privacy",
                    //    MenuText = "Privacy",
                    //    AspPage = "/Privacy",
                    //    Menu_icons = "glyphicon glyphicon glyphicon-th menuIcon",
                    //};
                    //NaviMenuItem naviMenu_Logout = new NaviMenuItem() {
                    //    Menu_id = "naviMenu_Logout",
                    //    MenuText = "注销",
                    //    AspPage = "/Logout",
                    //    Menu_icons = "glyphicon glyphicon glyphicon-th menuIcon",
                    //};
                    _list.Add(naviMenu_Index);
                    _list.Add(naviMenu_Project);
                    _list.Add(naviMenu_Subscribe);
                    //_list.Add(naviMenu_AuditLog);
                    //_list.Add(naviMenu_System);
                    //_list.Add(naviMenu_Privacy);
                    //_list.Add(naviMenu_ChangePwd);
                    //_list.Add(naviMenu_Logout);
                }
                return _list;
            }
        }
    }
}

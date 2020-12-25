using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla {
    public class ErrorCode {
        static SystemError _Failed_NameAlreadyExist = null;
        public static SystemError Error_DepartmentAlreadyExist {
            get {
                if (_Failed_NameAlreadyExist == null) {
                    _Failed_NameAlreadyExist = new SystemError(1, "已存在同名科室。");
                }
                return _Failed_NameAlreadyExist;
            }
        }

        internal static SystemError ParseCode(int error_code) {
            return Error_DepartmentAlreadyExist;
        }

        public class SystemError {
            public SystemError(int code, string msg) {
                Code = code;
                Msg = msg;
            }
            public int Code { get; set; }
            public string Msg { get; set; }
        }
    }
}

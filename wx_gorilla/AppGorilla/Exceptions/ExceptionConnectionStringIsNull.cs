using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla {
    public class ExceptionConnectionStringIsNull : Exception {
        public ExceptionConnectionStringIsNull(string message) : base(message) {
        }
    }
}

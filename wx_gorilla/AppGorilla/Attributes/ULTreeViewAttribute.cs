using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla {
    public class ULTreeViewAttribute :Attribute{
        public string ID { get; set; }
        public string PID { get; set; }
        public string TextField { get; set; }

        public ULTreeViewAttribute(string id, string pid,string textField) {
            this.ID = id;
            this.PID = pid;
            this.TextField = textField;
        }
    }
}

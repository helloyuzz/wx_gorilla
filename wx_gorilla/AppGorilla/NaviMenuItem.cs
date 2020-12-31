using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static com.wechat.gorilla.NaviMenuItem;

namespace com.wechat.gorilla {
    public class NaviMenuItem {
        public string Menu_id { get; set; }
        public string AspArea { get; set; } = "";
        public string AspPage { get; set; }
        public string Menu_icons { get; set; }
        public string MenuClass_default { get; set; } = "MenuClass_default";
        public string MenuClass_hover { get; set; } = "MenuClass_hover";
        public string MenuText { get; set; }
    }
}
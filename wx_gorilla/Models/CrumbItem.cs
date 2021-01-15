using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla.Models {
    public class CrumbItem {
        public CrumbItem(string text, string href) {
            Text = text;
            Href = href;
        }
        public CrumbItem(string text, bool isActive=true, bool isAria_current=true) {
            Text = text;
            IsActive = isActive;
            IsAriaCurrent = isAria_current;
        }
        public string Text { get; set; }
        public string Href { get; set; }
        public string OpenAsBlank { get; set; }
        public bool IsActive { get; set; }
        public bool IsAriaCurrent { get; set; }
        public string ActiveContent {
            get {
                if (IsActive) {
                    return "active";
                }
                return "";
            }
        }
        public string AriaContent {
            get {
                if (IsAriaCurrent) {
                    return "page";
                }
                return "";
            }
        }
        public string HtmlContent {
            get {
                string temp = "<li class=\"breadcrumb-item";
                if (IsActive) {
                    temp += " active";
                }
                temp += "\"";
                if (IsAriaCurrent) {
                    temp += "aria-current=\"page\"";
                }
                temp += ">";
                if (string.IsNullOrEmpty(Href) == false) {
                    temp += "<a href=\"" + Href + "\">" + Text + "</a>";
                } else {
                    temp += Text;
                }
                temp += "</li>";
                //  <li class="breadcrumb-item active" aria-current="page">Library</li>
                return temp;
            }
        }
    }
}

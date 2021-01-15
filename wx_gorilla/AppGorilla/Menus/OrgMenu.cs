using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla.Menus {
    public class OrgMenu {

        public OrgMenu(string menuText, string menuId, bool isFolder = false, bool isFile = false) {
            Menu_id = menuId;
            Menu_text = menuText;
            IsFolder = isFolder;
            IsFile = IsFile;
        }

        public string Menu_id { get; set; }
        public string Menu_text { get; set; }
        public string Menu_href { get; set; }
        public bool IsFolder { get;set; }
        public bool IsFile { get; set; }
        public List<OrgMenu> SubMenus { get; set; } = new List<OrgMenu>();
        public string HtmlContent {
            get {
                //string temp = "<ul id=\"topMenu\" class=\"list-group\">";
                string uuid = GorillaUtil.UUID;
                //temp += "<li id=\"li_" + uuid + "\" class=\"list-group-item border-0\" onclick=\"temp('ul_" + uuid + "')\">";
                //temp += "<span class=\"folder\">";
                //temp += "<i class=\"fas fa-angle-right rotate\" style=\"margin-right:3px;\"></i>";
                //temp += "<a href=\"" + Menu_href + "\">" + Menu_text;
                //temp += "</a>";
                //temp += "</span>";
                //temp += GetSubHtml(SubMenus,uuid);               
                //temp += "</li></ul>";
                string temp = GetSubHtml(this, uuid);
                return temp;
            }
        }

        private string GetSubHtml(OrgMenu orgMenu, string uuid) {
            string subHtml = "";
            string temp = "<ul id=\"ul_" + uuid + "\" class=\"list-group\">";
            string temp1 = temp;

            foreach (OrgMenu subMenu in orgMenu.SubMenus) {
            uuid = GorillaUtil.UUID;
                subHtml = GetSubHtml(subMenu, uuid);
                if (subHtml.Length<80) {//.Equals("<ul></ul>")) 
                    temp += "<li class=\"list-group-item border-0\">";
                    temp += "<span><i class=\"far fa-envelope-open ic-w mx-1\" style=\"margin-right:3px;\"></i><a href=\"#aa\">" + subMenu.Menu_text + "</a></span>";
                } else {           
                    temp += "<li class=\"list-group-item border-0\">";
                    temp += "<span><i class=\"fas fa-angle-right rotate\" style=\"margin-right:3px;\"></i><a onclick=\"temp('ul_" + uuid + "')\" href=\"#aa\">" + subMenu.Menu_text + "</a></span>";
                }
                temp += subHtml;
                temp += "</li>";
            }
            temp += "</ul>";
            if (temp.Equals(temp1 + "</ul>")) {
                temp = "";
            }
            return temp;
            //< ul >
            //           < li >< span class="file">Item 1.1.1</span></li>
            //       </ul>
        }
    }
}

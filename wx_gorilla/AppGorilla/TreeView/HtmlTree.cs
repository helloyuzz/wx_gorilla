using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla.TreeView {
    public class HtmlTree: RootTreeView {
        public HtmlTree() {
            this.HtmlID = GorillaUtil.NewUUID;
        }
        public HtmlTree(string htmlTitle) : this(){
            this.Text = htmlTitle;
        }
        public List<LiFlag> LiNodes { get; set; } = new List<LiFlag>();
        public string ExpandId { get; set; }
        public List<string> ExpandIds { get; set; }
        public bool ExpandAll { get; set; }
        public int ExpandLevel { get; set; }
        //public SpanFlag Title { get; set; } = new SpanFlag();
        public string ToHtmlContent {
            get {
                int level = 2;
                string htmlResult = "<ul class=\"ul_TreeView nodeLevel0\">";
                htmlResult += "<li class=\"li_TreeItem\">";
                if (string.IsNullOrEmpty(Text) == false) {
                    htmlResult += "<span class=\"caretMenu\"><a href=\"##\">" + Text + "</a></span>";
                }
                htmlResult += "<ul id=\"" + HtmlID + "\" class=\"nested  nodeLevel1\">";
                htmlResult += BuildLi(this,ref level);
                htmlResult += "</ul>";
                htmlResult += "</li>";
                htmlResult += "</ul>";

                return htmlResult;
            }
        }

        private string BuildLi(HtmlTree uLTreeView, ref int level) {
            string result = "";
            int tempLevel = level;
            bool levelChanged = false;
            foreach (LiFlag temp in uLTreeView.LiNodes) {
                string ul = BuildLi(temp.UL, ref level);
                result += "<li class=\"li_TreeItem\">";

                if (string.IsNullOrEmpty(ul) == false && level>1) {
                    result += "<span class=\"caretMenu\">";
                } else {
                    result += "<span class=\"caretMenuItem\">";
                }
                result += "<a href=\"##" + temp.A.Href + "\">" + temp.A.Text + "</a>";
                result += "</span>";
                if (string.IsNullOrEmpty(ul) == false) {
                    if (levelChanged == false) {
                        levelChanged = true;
                        level++;
                    } else {
                        level--;
                    }
                    result += "<ul class=\"nested nodeLevel" + tempLevel + "\">";
                    result += ul;
                    result += "</ul>";
                }
                result += "</li>";
            }

            return result;
        }
    }
    public class LiFlag : RootTreeView {
        public AFlag A { get; set; }
        public SpanFlag Span { get; set; }
        public HtmlTree UL { get; set; } = new HtmlTree();
    }
    public class SpanFlag : RootTreeView {
    }
    public class AFlag : RootTreeView {
        public string Href { get; set; }
    }
    public class RootTreeView {
        public RootTreeView() {
            this.HtmlID = GorillaUtil.NewUUID;
        }
        public string HtmlID { get; set; }
        public string ClassName { get; set; }
        public string Style { get; set; }
        public string Text { get; set; }
        public int MenuLevel { get; set; }
        public string OnClickEvent { get; set; }
    }
}

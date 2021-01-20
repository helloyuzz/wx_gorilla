using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace com.wechat.gorilla.TreeView {
    public class ULTreeView: RootTreeView {
        public ULTreeView() {
            this.HtmlID = GorillaUtil.NewUUID;
        }
        public ULTreeView(string htmlTitle) : this(){
            this.Title.HtmlText = htmlTitle;
        }
        public List<LiFlag> LiNodes { get; set; } = new List<LiFlag>();
        public string ExpandId { get; set; }
        public List<string> ExpandIds { get; set; }
        public bool ExpandAll { get; set; }
        public int ExpandLevel { get; set; }
        public SpanFlag Title { get; set; } = new SpanFlag();
        public string ToHtmlContent {
            get {
                int level = 1;
                string htmlResult = "";
                if (string.IsNullOrEmpty(HtmlText) == false) {
                    htmlResult += "<span>" + HtmlText + "</span>";
                }
                htmlResult += "<ul id=\"" + HtmlID + "\">";
                htmlResult += BuildLi(this,ref level);
                htmlResult += "</ul>";

                return htmlResult;
            }
        }

        private string BuildLi(ULTreeView uLTreeView,ref int level) {
            string result = "";

            foreach (LiFlag temp in uLTreeView.LiNodes) {
                result += "<li>";
                result += "<span class=\"caret\">";
                result += "     <a href=\"##" + temp.Span.A.Href + "\">";
                result += temp.Span.A.HtmlText;
                result += "     </a>";
                result += "</span>";
                string ul = BuildLi(temp.UL,ref level);
                if (string.IsNullOrEmpty(ul) == false) {
                    result += "<ul class=\"nested\">";
                    result += ul;
                    result += "</ul>";
                }
                result += "</li>";
            }

            return result;
        }
    }
    public class LiFlag : RootTreeView {
        public SpanFlag Span { get; set; }
        public ULTreeView UL { get; set; } = new ULTreeView();
    }
    public class SpanFlag : RootTreeView {
        public AFlag A { get; set; }
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
        public string HtmlText { get; set; }
        public int MenuLevel { get; set; }
        public string OnClickEvent { get; set; }
    }
}

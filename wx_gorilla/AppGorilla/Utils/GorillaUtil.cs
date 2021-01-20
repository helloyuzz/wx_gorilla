using com.wechat.gorilla.TreeView;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace com.wechat.gorilla {
    public class GorillaUtil {
        public static string NewUUID {
            get {
                return Guid.NewGuid().ToString().Replace("-", "");
            }
        }

        internal static int QueryInt(IQueryCollection query, string key) {
            return ParseInt(query[key]);
        }
        public static int ParseInt(object value) {
            int intValue = 0;
            if (value != null) {
                int.TryParse(value.ToString(), out intValue);
            }
            return intValue;
        }

        internal static string Md5(string pwd) {
            string result = "";
            using (MD5 md5 = MD5.Create()) {
                Byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(pwd));
                StringBuilder stringBuilder = new StringBuilder();
                foreach (Byte key in bytes) {
                    stringBuilder.Append(key.ToString("X2"));
                }
                result = stringBuilder.ToString();
            }
            return result;
        }

        internal static void TransToULTreeView<T>(IList<T> itemList, ULTreeView ulTreeView) {
            if (itemList == null || itemList.Count <= 0) {
                throw new Exception("TransToULTreeView<T>转换的数据对象为空。");
            }
            Type itemType = typeof(T);

            PropertyInfo p1 = null;        // Id Field
            PropertyInfo p2 = null;        // Pid Field
            PropertyInfo p3 = null;        // Text Field

            Attribute[] objectTypes = Attribute.GetCustomAttributes(itemList[0].GetType());
            foreach (Attribute item in objectTypes) {
                if (item is ULTreeViewAttribute) {
                    ULTreeViewAttribute temp = (ULTreeViewAttribute)item;
                    p1 = itemType.GetProperty(temp.ID);
                    p2 = itemType.GetProperty(temp.PID);
                    p3 = itemType.GetProperty(temp.TextField);
                    break;
                }
            }
            if (p1 == null && p2 == null && p3 == null) {
                throw new Exception("未指定" + itemType.ToString() + "的ULTreeView(\"Id\",\"Pid\",\"Text Field\")属性。");
            }

            int level = 1;
            BuildULFlag(itemList, ulTreeView, -1, ref level, p1, p2, p3);   
        }

        private static void BuildULFlag<T>(IList<T> itemList, ULTreeView ulTreeView, object argu_pid, ref int level, params PropertyInfo[] props) {
            IEnumerable<T> tempList = itemList.Where(x => props[1].GetValue(x).Equals(argu_pid));
            foreach (var item in tempList) {
                object id = props[0].GetValue(item);
                object pid = props[1].GetValue(item);
                object text = props[2].GetValue(item);

                AFlag a = new AFlag();
                a.HtmlText = text.ToString();

                SpanFlag span = new SpanFlag();
                span.ClassName = "caret";
                span.MenuLevel = level;
                span.A = a;

                LiFlag li = new LiFlag();
                li.Span = span;

                BuildULFlag(itemList, li.UL, id, ref level, props);
                level++;
                ulTreeView.LiNodes.Add(li);
            }
        }
    }
}

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace com.wechat.gorilla {
    public static class SessionExtensions {
        public static string SessionKey_SwitchPanel = "KEY-SwitchPanel";
        public static string SessionKey_ActiveMenuId = "KEY-ActiveMenuId";
        public static string SessionKey_CUA = "KEY-CurrentUserAccount";
        public static void Set<T>(this ISession session, string key, T value) {
            session.SetString(key, JsonSerializer.Serialize(value));
        }
        public static T Get<T>(this ISession session, string key) {
            var getSessionKey = session.GetString(key);
            return getSessionKey == null ? default : JsonSerializer.Deserialize<T>(getSessionKey);
        }
    }
}

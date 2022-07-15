﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace BankRPSSQL.Utils
{
    public static class SessionExtensions // all methods are static
    {
        // we will extend the ISession interface to provide
        // generic Set<T> and Get<T> type safe access to Session
        public static void Set<T>(this ISession session, string key, T val)
        {
            session.SetString(key, JsonConvert.SerializeObject(val));
        }
        public static T Get<T>(this ISession session, string key)
        {
            var objstr = session.GetString(key);
            if (objstr == null)
                return default(T);
            else
                return JsonConvert.DeserializeObject<T>(objstr);
        }
    }
}

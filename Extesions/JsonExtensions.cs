using System;
using Newtonsoft.Json;

namespace System
{
    public static class JsonExtesions
    {
        public static string ToJson(this object objeto)
        {
            return JsonConvert.SerializeObject(objeto);
        }

        public static T FromJson<T>(this string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}

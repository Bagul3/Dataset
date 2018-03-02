using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DataSets
{
    public static class JsonExtensions
    {
        public static string ToJson(this object value)
        {
            return JsonConvert.SerializeObject(value);
        }

        public static T As<T>(this JToken jToken)
        {
            return jToken == null ? default(T) : jToken.ToObject<T>();
        }

        public static T FromJson<T>(this string str)
        {
            return JsonConvert.DeserializeObject<T>(str,
                new JsonSerializerSettings() { Error = (sender, args) => { args.ErrorContext.Handled = true; } });
        }
    }
}

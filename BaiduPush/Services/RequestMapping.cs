using BaiduPush.Model.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Services
{
    /// <summary>
    /// Request属性与百度RestApi请求参数的对应关系
    /// </summary>
    internal class RequestMapping
    {
        private static readonly ConcurrentDictionary<string, Dictionary<PropertyInfo, string>> RequestDictionary
            = new ConcurrentDictionary<string, Dictionary<PropertyInfo, string>>();

        public static Dictionary<PropertyInfo, string> GetMapping<T>() where T : Request
        {
            return GetMapping(typeof(T));
        }
        public static Dictionary<PropertyInfo, string> GetMapping(Type type)
        {
            return RequestDictionary.GetOrAdd(type.FullName, (key) =>
            {
                var props = type.GetProperties();
                Dictionary<PropertyInfo, string> dic = new Dictionary<PropertyInfo, string>();
                foreach (var p in props)
                {
                    var attrs = (JsonPropertyAttribute[])p.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                    if (attrs.Length > 0)
                    {
                        dic.Add(p, attrs[0].PropertyName);
                    }
                }
                return dic;
            });
        }
    }
}

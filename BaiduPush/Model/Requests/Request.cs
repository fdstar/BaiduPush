using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Requests
{
    using Enums;
    using Newtonsoft.Json;
    using Utils;

    /// <summary>
    /// 百度云推送的公共请求部分
    /// </summary>
    [Serializable]
    public class Request
    {
        public Request()
        {
            this.Timestamp = DateTime.Now.ToUnixTimestamp();
        }
        /// <summary>
        /// 应用的api key,用于标识应用
        /// </summary>
        [JsonProperty(PropertyName = "apikey")]
        public string ApiKey { get; set; }
        /// <summary>
        /// 加密用的Key，参与签名生成但不会被传递，与ApiKey对应
        /// </summary>
        public string SecretKey { get; set; }
        /// <summary>
        /// 用户发起请求时的unix时间戳。本次请求签名的有效时间为该时间戳向后10分钟
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long Timestamp { get; set; }
        ///// <summary>
        ///// 调用参数签名值，与apikey成对出现。用于防止请求内容被篡改
        ///// </summary>
        //[JsonProperty(PropertyName = "sign")]
        //public string Sign { get; set; }
        /// <summary>
        /// 用户指定本次请求签名的失效时间。格式为unix时间戳形式，用于防止 replay 型攻击。为保证防止 replay攻击算法的正确有效，请保证客户端系统时间正确
        /// </summary>
        [JsonProperty(PropertyName = "expires")]
        public long? Expires { get; set; }
        /// <summary>
        /// 当一个应用同时支持多个设备平台类型（比如：Android和iOS），请务必设置该参数。其余情况可不设置
        /// 具体：(3：android 4：iOS)
        /// </summary>
        [JsonProperty(PropertyName = "device_type")]
        public DeviceType? DeviceType { get; set; }
    }
}

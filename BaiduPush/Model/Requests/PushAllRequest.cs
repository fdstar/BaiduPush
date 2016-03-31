using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Requests
{
    using Newtonsoft.Json;

    /// <summary>
    /// 向当前app下所有设备推送一条消息的请求实体
    /// </summary>
    [Serializable]
    public class PushAllRequest : PushRequestBaseWithDeploy
    {
        /// <summary>
        /// 定时推送，用于指定的实际发送时间，必须在当前时间60s以外，1年以内
        /// </summary>
        [JsonProperty(PropertyName = "send_time")]
        public long? SendTime { get; set; }
    }
}

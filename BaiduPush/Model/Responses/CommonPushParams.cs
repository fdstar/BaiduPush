using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Responses
{
    using Newtonsoft.Json;

    /// <summary>
    /// 推送相关的公共响应实体
    /// </summary>
    [Serializable]
    public abstract class CommonPushParams
    {
        /// <summary>
        /// 该条消息id
        /// </summary>
        [JsonProperty(PropertyName = "msg_id")]
        public string MsgId { get; set; }
        /// <summary>
        /// 消息的实际推送时间
        /// </summary>
        [JsonProperty(PropertyName = "send_time")]
        public long SendTime { get; set; }
    }
}

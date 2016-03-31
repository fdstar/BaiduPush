using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Responses
{
    using Newtonsoft.Json;

    /// <summary>
    /// 向当前app下所有设备推送一条消息的响应实体
    /// </summary>
    [Serializable]
    public class PushAllParams : CommonPushParams
    {
        /// <summary>
        /// 定时任务ID
        /// </summary>
        [JsonProperty(PropertyName = "timer_id")]
        public string TimerId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Responses
{
    using Enums;
    using Newtonsoft.Json;

    /// <summary>
    /// 查看还未执行的定时任务的响应实体
    /// </summary>
    [Serializable]
    public class TimerQueryListParams : CommonArrayParams<TimerQueryListResult>
    {
        /// <summary>
        /// 定时推送任务的总数量
        /// </summary>
        [JsonProperty(PropertyName = "total_num")]
        public int TotalNum { get; set; }
    }
    [Serializable]
    public class TimerQueryListResult 
    {
        /// <summary>
        /// 发送定时消息时返回的timer_id
        /// </summary>
        [JsonProperty(PropertyName = "timer_id")]
        public string TimerId { get; set; }
        /// <summary>
        /// 发送消息的内容
        /// </summary>
        [JsonProperty(PropertyName = "msg")]
        public string Msg { get; set; }
        /// <summary>
        /// 消息的实际推送时间
        /// </summary>
        [JsonProperty(PropertyName = "send_time")]
        public long SendTime { get; set; }
        /// <summary>
        /// 消息类型：0：透传消息；1：通知；2：带格式的消息；3：富媒体消息
        /// 此处居然与发送地方类型的说明不一致！
        /// </summary>
        [JsonProperty(PropertyName = "msg_type")]
        public int MsgType { get; set; }
        /// <summary>
        /// 消息发送范围： 0：tag组播；1：广播；2：批量单播；3：标签组合；4：精准推送；5：LBS推送；6：系统保留；7：单播；
        /// </summary>
        [JsonProperty(PropertyName = "range_type")]
        public RangeType RangeType { get; set; }
    }
}

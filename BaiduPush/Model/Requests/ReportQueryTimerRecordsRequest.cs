using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Requests
{
    using Newtonsoft.Json;

    /// <summary>
    /// 根据timer_id获取消息推送记录的请求实体
    /// </summary>
    [Serializable]
    public class ReportQueryTimerRecordsRequest : Request
    {
        /// <summary>
        /// 定时任务ID
        /// </summary>
        [JsonProperty(PropertyName = "timer_id")]
        public string TimerId { get; set; }
        /// <summary>
        /// 指定返回记录的起始索引位置，，默认为0
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public byte? Start { get; set; }
        /// <summary>
        /// 返回的记录条数,[1,100]，默认100
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public byte? Limit { get; set; }
        /// <summary>
        /// 指定查询起始时间范围，以服务端实际推送时间为准；默认为七天前的0点时间
        /// </summary>
        [JsonProperty(PropertyName = "range_start")]
        public long? RangeStart { get; set; }
        /// <summary>
        /// 指定查询截止时间范围，以服务端实际推送时间为准；默认时间为当前时间
        /// </summary>
        [JsonProperty(PropertyName = "range_end")]
        public long? RangeEnd { get; set; }
    }
}

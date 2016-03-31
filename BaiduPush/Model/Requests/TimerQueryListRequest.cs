using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Requests
{
    using Newtonsoft.Json;

    /// <summary>
    /// 查看还未执行的定时任务的请求实体，每个应用可设置的有效的定时任务有限制(目前为10个)
    /// </summary>
    [Serializable]
    public class TimerQueryListRequest : Request
    {
        /// <summary>
        /// 推送接口返回的timer_id唯一标识一个定时推送任务
        /// 如果指定该参数，将仅返回该timer_id对应定时任务的相关信息
        /// </summary>
        [JsonProperty(PropertyName = "timer_id")]
        public string TimerId { get; set; }
        /// <summary>
        /// 指定返回记录的起始索引位置，默认为0
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public byte? Start { get; set; }
        /// <summary>
        /// 返回的记录条数,[1,10]，默认10
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public byte? Limit { get; set; }
    }
}

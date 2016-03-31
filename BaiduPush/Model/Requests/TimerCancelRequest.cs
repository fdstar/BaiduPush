using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Requests
{
    using Newtonsoft.Json;

    /// <summary>
    /// 取消尚未执行定时推送任务的请求实体
    /// </summary>
    [Serializable]
    public class TimerCancelRequest : Request
    {
        /// <summary>
        /// 定时任务ID，只有未被执行并且距离实际执行时间一分钟以上的定时任务才能被取消
        /// </summary>
        [JsonProperty(PropertyName = "timer_id")]
        public string TimerId { get; set; }
    }
}

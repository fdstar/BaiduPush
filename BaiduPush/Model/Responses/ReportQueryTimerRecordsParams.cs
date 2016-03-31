using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Responses
{
    using Newtonsoft.Json;

    /// <summary>
    /// 根据timer_id获取消息推送记录的响应实体
    /// </summary>
    [Serializable]
    public class ReportQueryTimerRecordsParams : CommonArrayParams<ReportQueryTimerRecordsResult>
    {
        /// <summary>
        /// 定时任务ID
        /// </summary>
        [JsonProperty(PropertyName = "timer_id")]
        public string TimerId { get; set; }
    }
    [Serializable]
    public class ReportQueryTimerRecordsResult : CommonPushResult
    {
    }
}

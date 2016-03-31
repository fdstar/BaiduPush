using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Responses
{
    using Newtonsoft.Json;

    /// <summary>
    /// 根据msg_id获取消息推送报告的响应实体
    /// </summary>
    [Serializable]
    public class ReportQueryMsgStatusParams : CommonArrayParams<ReportQueryMsgStatusResult>
    {
        /// <summary>
        /// 结果数量
        /// </summary>
        [JsonProperty(PropertyName = "total_num")]
        public int TotalNum { get; set; }
    }
    [Serializable]
    public class ReportQueryMsgStatusResult : CommonPushResult
    {
        /// <summary>
        /// 成功到达数
        /// </summary>
        [JsonProperty(PropertyName = "success")]
        public int Success { get; set; }
    }
}

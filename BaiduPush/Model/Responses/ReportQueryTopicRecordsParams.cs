using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Responses
{
    using Newtonsoft.Json;

    /// <summary>
    /// 根据分类主题获取消息推送记录的响应实体
    /// </summary>
    [Serializable]
    public class ReportQueryTopicRecordsParams : CommonArrayParams<ReportQueryTopicRecordsResult>
    {
        /// <summary>
        /// 分类主题名称
        /// </summary>
        [JsonProperty(PropertyName = "topic_id")]
        public string TopicId { get; set; }
    }
    public class ReportQueryTopicRecordsResult : CommonPushResult
    {
    }
}

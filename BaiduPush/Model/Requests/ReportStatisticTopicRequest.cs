using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Requests
{
    using Newtonsoft.Json;

    /// <summary>
    /// 统计当前应用下一个分类主题消息数量的请求实体(支持单播、批量单播)
    /// </summary>
    [Serializable]
    public class ReportStatisticTopicRequest : Request
    {
        /// <summary>
        /// 一个已使用过的分类主题
        /// </summary>
        [JsonProperty(PropertyName = "topic_id")]
        public string TopicId { get; set; }
    }
}

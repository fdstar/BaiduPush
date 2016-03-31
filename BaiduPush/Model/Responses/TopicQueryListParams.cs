using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Responses
{
    using Newtonsoft.Json;

    /// <summary>
    /// 查询推送过程中使用过的分类主题列表的响应实体
    /// </summary>
    [Serializable]
    public class TopicQueryListParams : CommonArrayParams<TopicQueryListResult>
    {
        /// <summary>
        /// 所使用过的分类主题总数
        /// </summary>
        [JsonProperty(PropertyName = "total_num")]
        public int TotalNum { get; set; }
    }
    [Serializable]
    public class TopicQueryListResult : CommonPushResult
    {
        /// <summary>
        /// 总的到达数，-1代表数据未ready
        /// </summary>
        [JsonProperty(PropertyName = "ack_cnt")]
        public int AckCnt { get; set; }
        /// <summary>
        /// 第一次发送时间
        /// </summary>
        [JsonProperty(PropertyName = "ctime")]
        public long Ctime { get; set; }
        /// <summary>
        /// 最后一次发送时间
        /// </summary>
        [JsonProperty(PropertyName = "mtime")]
        public long Mtime { get; set; }
        /// <summary>
        /// 总的推送目标数
        /// </summary>
        [JsonProperty(PropertyName = "push_cnt")]
        public int PushCnt { get; set; }
        /// <summary>
        /// 分类主题名称
        /// </summary>
        [JsonProperty(PropertyName = "topic_id")]
        public string TopicId { get; set; }
    }
}

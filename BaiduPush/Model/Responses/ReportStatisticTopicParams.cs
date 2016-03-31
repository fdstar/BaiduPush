using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Responses
{
    using Newtonsoft.Json;

    /// <summary>
    /// 统计当前应用下一个分类主题消息数量的响应实体
    /// </summary>
    [Serializable]
    public class ReportStatisticTopicParams
    {
        /// <summary>
        /// 所发的分类主题总数
        /// </summary>
        [JsonProperty(PropertyName = "total_num")]
        public int TotalNum { get; set; }
        /// <summary>
        /// 结果集合，key为统计信息所在当天0点0分时间戳
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public Dictionary<long, ReportStatisticTopicResult> Result { get; set; }
    }
    public class ReportStatisticTopicResult
    {
        /// <summary>
        /// 当天消息到达数
        /// </summary>
        [JsonProperty(PropertyName = "ack")]
        public int Ack { get; set; }
    }
}

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
    public class AppQueryTagsParams : CommonArrayParams<ReportQueryTopicRecordsResult>
    {
        /// <summary>
        /// Tag总数
        /// </summary>
        [JsonProperty(PropertyName = "total_num")]
        public int TotalNum { get; set; }
    }
    public class AppQueryTagsResult
    {
        /// <summary>
        /// 标签ID
        /// </summary>
        [JsonProperty(PropertyName = "tid")]
        public int TId { get; set; }
        /// <summary>
        /// 标签名
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }
        /// <summary>
        /// 用于进一步描述标签的附件信息
        /// </summary>
        [JsonProperty(PropertyName = "info")]
        public string Info { get; set; }
        /// <summary>
        /// 标签类型（已废弃，请勿依赖该字段进行开发）
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public int Type { get; set; }
        /// <summary>
        /// 标签创建时间，unix时间戳
        /// </summary>
        [JsonProperty(PropertyName = "createtime")]
        public long Createtime { get; set; }
    }
}

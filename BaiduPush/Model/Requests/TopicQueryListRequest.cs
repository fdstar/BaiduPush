using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Requests
{
    using Newtonsoft.Json;

    /// <summary>
    /// 查询推送过程中使用过的分类主题列表的请求实体
    /// </summary>
    [Serializable]
    public class TopicQueryListRequest : Request
    {
        /// <summary>
        /// 指定返回记录的起始索引位置，默认为0
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public byte? Start { get; set; }
        /// <summary>
        /// 返回的记录条数,[1,20]，默认20
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public byte? Limit { get; set; }
    }
}

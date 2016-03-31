using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Requests
{
    using Newtonsoft.Json;

    /// <summary>
    /// 查询应用tag的请求实体
    /// </summary>
    [Serializable]
    public class AppQueryTagsRequest : Request
    {
        /// <summary>
        /// 标签名称，不传则获取应用下所有标签信息
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }
        /// <summary>
        /// 指定返回记录的起始索引位置，默认为0
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public byte? Start { get; set; }
        /// <summary>
        /// 返回的记录条数,[1,100]，默认100
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public byte? Limit { get; set; }
    }
}

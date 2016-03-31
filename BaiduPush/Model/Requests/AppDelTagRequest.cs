using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Requests
{
    using Newtonsoft.Json;

    /// <summary>
    /// 删除一个已存在tag的请求实体
    /// </summary>
    [Serializable]
    public class AppDelTagRequest : Request
    {
        /// <summary>
        /// 标签名称，1~128字节，但不能为 default
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }
    }
}

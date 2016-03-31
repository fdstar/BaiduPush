using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Responses
{
    using Newtonsoft.Json;

    /// <summary>
    /// 创建一个空标签组的请求实体
    /// </summary>
    [Serializable]
    public class AppCreateTagParams
    {
        /// <summary>
        /// 标签名
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }
        /// <summary>
        /// 状态 0：创建成功； 1：创建失败
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public byte Result { get; set; }
    }
}

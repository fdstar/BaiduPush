using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Requests
{
    using Newtonsoft.Json;

    /// <summary>
    /// 推送消息或通知给指定的标签的请求实体
    /// </summary>
    [Serializable]
    public class PushTagsRequest : PushAllRequest
    {
        public PushTagsRequest()
        {
            this.Type = 1;
        }
        /// <summary>
        /// 推送的标签类型，目前固定值为 1
        /// </summary>
        public int Type { get; }
        /// <summary>
        /// 已创建的tag名称
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Requests
{
    using Newtonsoft.Json;

    /// <summary>
    /// 从tag中批量解绑设备的请求实体
    /// </summary>
    [Serializable]
    public class TagDelDevicesRequest : Request
    {
        /// <summary>
        /// 标签名称，1~128字节，但不能为 default
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }
        /// <summary>
        /// 对应一批设备, 为一组channel_id（最少1个，最多为10个）组成的json数组字符串	
        /// </summary>
        [JsonProperty(PropertyName = "channel_ids")]
        public string ChannelIds { get; set; }
    }
}

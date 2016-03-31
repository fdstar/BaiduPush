using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Requests
{
    using Newtonsoft.Json;

    /// <summary>
    /// 推送消息给批量设备（批量单播）的请求实体
    /// </summary>
    [Serializable]
    public class PushBatchDeviceRequest : PushRequestBase
    {
        /// <summary>
        /// 一组channel_id（最多为一万个）组成的json数组字符串
        /// </summary>
        [JsonProperty(PropertyName = "channel_ids")]
        public string ChannelIds { get; set; }
        /// <summary>
        /// 分类主题名称，可为空，字母、数字及下划线组成，长度限制为1~128
        /// </summary>
        [JsonProperty(PropertyName = "topic_id")]
        public string TopicId { get; set; }
    }
}

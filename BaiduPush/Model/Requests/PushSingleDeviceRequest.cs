using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Requests
{
    using Newtonsoft.Json;

    /// <summary>
    /// 推送消息给单个设备的请求实体
    /// </summary>
    [Serializable]
    public class PushSingleDeviceRequest : PushRequestBaseWithDeploy
    {
        /// <summary>
        /// 唯一对应一台设备，必须为端上初始化channel成功之后返回的channel_id
        /// </summary>
        [JsonProperty(PropertyName = "channel_id")]
        public string ChannelId { get; set; }
    }
}

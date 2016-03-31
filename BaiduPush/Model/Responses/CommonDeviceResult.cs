using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Responses
{
    using Newtonsoft.Json;

    /// <summary>
    /// 设备相关的公共响应实体
    /// </summary>
    [Serializable]
    public abstract class CommonDeviceResult
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        [JsonProperty(PropertyName = "channel_id")]
        public string ChannelId { get; set; }
        /// <summary>
        /// 状态 0：添加/删除成功； 1：添加/删除失败
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public byte Result { get; set; }
    }
}

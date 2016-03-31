using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Responses
{
    using Newtonsoft.Json;

    /// <summary>
    /// 从tag中批量解绑设备的响应实体
    /// </summary>
    [Serializable]
    public class TagDelDevicesParams
    {
        /// <summary>
        /// 每个元素表示对应的一个channel_id是否删除成功
        /// </summary>
        [JsonProperty(PropertyName = "devices")]
        public List<TagDelDevicesResult> Devices { get; set; }
    }
    public class TagDelDevicesResult : CommonDeviceResult
    {
    }
}

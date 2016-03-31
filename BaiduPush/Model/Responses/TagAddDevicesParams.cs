using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Responses
{
    using Newtonsoft.Json;

    /// <summary>
    /// 向tag中批量添加设备的响应实体
    /// </summary>
    [Serializable]
    public class TagAddDevicesParams
    {
        /// <summary>
        /// 每个元素表示对应的一个channel_id是否添加成功
        /// </summary>
        [JsonProperty(PropertyName = "devices")]
        public List<TagAddDevicesResult> Devices { get; set; }
    }
    public class TagAddDevicesResult : CommonDeviceResult
    {
    }
}

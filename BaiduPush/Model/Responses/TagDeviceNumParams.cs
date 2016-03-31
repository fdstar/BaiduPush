using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Responses
{
    using Newtonsoft.Json;

    /// <summary>
    /// 查询某个tag关联设备数量的响应实体
    /// </summary>
    [Serializable]
    public class TagDeviceNumParams
    {
        /// <summary>
        /// 标签中设备的数量
        /// </summary>
        [JsonProperty(PropertyName = "device_num")]
        public int DeviceNum { get; set; }
    }
}

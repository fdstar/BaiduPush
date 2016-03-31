using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Requests
{
    using Newtonsoft.Json;

    /// <summary>
    /// 查询某个tag关联设备数量的请求实体
    /// </summary>
    [Serializable]
    public class TagDeviceNumRequest : Request
    {
        /// <summary>
        /// 标签名称，1~128字节
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Responses
{
    using Newtonsoft.Json;

    [Serializable]
    public class Response
    {
        /// <summary>
        /// 该次请求的Id
        /// </summary>
        [JsonProperty(PropertyName = "request_id")]
        public ulong RequestId { get; set; }
    }

    [Serializable]
    public class Response<T> : Response
    {
        /// <summary>
        /// 响应实体
        /// </summary>
        [JsonProperty(PropertyName = "response_params")]
        public T ResponseParams { get; set; }
    }
}

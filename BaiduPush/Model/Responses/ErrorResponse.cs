using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Responses
{
    using Newtonsoft.Json;

    public class ErrorResponse : Response
    {
        /// <summary>
        /// 错误标志，具体见 http://push.baidu.com/doc/restapi/error_code
        /// </summary>
        [JsonProperty(PropertyName = "error_code")]
        public int ErrorCode { get; set; }
        /// <summary>
        /// 错误描述
        /// </summary>
        [JsonProperty(PropertyName = "error_msg")]
        public string ErrorMsg { get; set; }
    }
}

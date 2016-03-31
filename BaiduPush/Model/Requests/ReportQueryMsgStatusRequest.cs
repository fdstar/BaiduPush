using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Requests
{
    using Newtonsoft.Json;
    /// <summary>
    /// 根据msg_id获取消息推送报告的请求实体
    /// </summary>
    [Serializable]
    public class ReportQueryMsgStatusRequest : Request
    {
        /// <summary>
        /// 推送接口返回的msg_id，支持一个由msg_id组成的json数组
        /// </summary>
        [JsonProperty(PropertyName = "msg_id")]
        public string MsgId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Responses
{
    using Enums;
    using Newtonsoft.Json;

    [Serializable]
    public class CommonPushResult : CommonPushParams
    {
        /// <summary>
        /// 推送状态
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public PushStatus Status { get; set; }
    }
}

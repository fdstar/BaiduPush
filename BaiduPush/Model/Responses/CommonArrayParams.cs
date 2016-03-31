using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Responses
{
    using Newtonsoft.Json;
    [Serializable]
    public abstract class CommonArrayParams<T>
    {
        /// <summary>
        /// 数组对象，每项内容为一条消息的状态
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public List<T> Result { get; set; }
    }
}

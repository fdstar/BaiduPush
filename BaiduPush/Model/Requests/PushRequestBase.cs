using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Requests
{
    using Enums;
    using Newtonsoft.Json;

    /// <summary>
    /// 所有Push请求实体的基类
    /// </summary>
    [Serializable]
    public abstract class PushRequestBase : Request
    {
        /// <summary>
        /// 消息类型,取值如下：0：消息；1：通知。默认为0
        /// </summary>
        [JsonProperty(PropertyName = "msg_type")]
        public MsgType? MsgType { get; set; }
        /// <summary>
        /// 消息内容，json格式
        /// 当MsgType.Message时，此处格式无限制
        /// 当MsgType.Notice时，该部分需为AndroidNotice或IOSNotice的Json序列化字符串
        /// </summary>
        [JsonProperty(PropertyName = "msg")]
        public string Msg { get; set; }
        /// <summary>
        /// 相对于当前时间的消息过期时间，单位为秒，输入限制为，0~604800(86400*7)，默认为5小时(18000秒)
        /// </summary>
        [JsonProperty(PropertyName = "msg_expires")]
        public uint? MsgExpires { get; set; }
    }

    public abstract class PushRequestBaseWithDeploy: PushRequestBase
    {
        /// <summary>
        /// 设置iOS应用的部署状态，仅iOS应用推送时使用
        /// 取值为：1：开发状态；2：生产状态 若不指定，则默认设置为生产状态。
        /// </summary>
        [JsonProperty(PropertyName = "deploy_status")]
        public byte? DeployStatus { get; set; }
    }
}

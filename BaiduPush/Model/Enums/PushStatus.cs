using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Enums
{
    /// <summary>
    /// 推送状态
    /// </summary>
    public enum PushStatus
    {
        /// <summary>
        /// 已发送
        /// </summary>
        Completed = 0,
        /// <summary>
        /// 未发送
        /// </summary>
        NotSent = 1,
        /// <summary>
        /// 发送中
        /// </summary>
        Sending = 2,
        /// <summary>
        /// 失败
        /// </summary>
        Failure = 3
    }
}

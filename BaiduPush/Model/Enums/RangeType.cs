using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Enums
{
    public enum RangeType
    {
        /// <summary>
        /// tag组播
        /// </summary>
        TagMulticast = 0,
        /// <summary>
        /// 广播
        /// </summary>
        Broadcast = 1,
        /// <summary>
        /// 批量单播
        /// </summary>
        BulkUnicast = 2,
        /// <summary>
        /// 标签组合
        /// </summary>
        TagCombination = 3,
        /// <summary>
        /// 精准推送
        /// </summary>
        PrecisionPush = 4,
        /// <summary>
        /// LBS推送
        /// </summary>
        LBSPush = 5,
        /// <summary>
        /// 系统保留
        /// </summary>
        SystemReservation = 6,
        /// <summary>
        /// 单播
        /// </summary>
        Unicast = 7
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Enums
{
    /// <summary>
    /// 通知的基本样式
    /// </summary>
    [Flags]
    public enum NotificationBasicStyle
    {
        /// <summary>
        /// 可清除
        /// </summary>
        CanBeRemoved = 0x1,
        /// <summary>
        /// 振动
        /// </summary>
        Vibration = 0x2,
        /// <summary>
        /// 响铃
        /// </summary>
        Bell = 0x4
    }
}

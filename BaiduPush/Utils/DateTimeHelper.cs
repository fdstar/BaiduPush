using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Utils
{
    public static class DateTimeHelper
    {
        /// <summary>
        /// 将指定时间转换为Unix时间戳 4.6开始可以通过DateTimeOffset.ToUnixTimeSeconds来转换
        /// </summary>
        /// <param name="dateTime">要转换的时间</param>
        /// <returns>Unix时间戳，单位秒</returns>
        public static long ToUnixTimestamp(this DateTime dateTime)
        {
            var timeSpan = dateTime - GetGMTStartTime(dateTime.Kind);
            return Convert.ToInt64(timeSpan.TotalSeconds);
        }
        /// <summary>
        /// 将Unix时间戳转化为对应的时间
        /// </summary>
        /// <param name="timestamp">Unix时间戳，单位秒</param>
        /// <param name="kind"></param>
        /// <returns>转化得到的时间</returns>
        public static DateTime ToDateTime(this long timestamp, DateTimeKind kind = DateTimeKind.Unspecified)
        {
            return GetGMTStartTime(kind).AddSeconds(timestamp);
        }
        private static DateTime GetGMTStartTime(DateTimeKind kind = DateTimeKind.Unspecified)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, kind);
        }
    }
}

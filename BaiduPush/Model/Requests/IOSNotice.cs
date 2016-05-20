using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Requests
{
    /// <summary>
    /// IOS通知格式，说明部分地址 http://push.baidu.com/doc/restapi/msg_struct
    /// </summary>
    [Serializable]
    public class IOSNotice
    {
        /// <summary>
        /// 获取IOS通知字典，其它自定义字段可以在返回后通过Add方法加入字典
        /// </summary>
        /// <param name="apsAlert">要通知的主题部分，为string时则IOS直接通知，其它数据则IOS可以自行控制</param>
        /// <param name="contentAvailable"></param>
        /// <param name="sound"></param>
        /// <param name="badge"></param>
        /// <returns></returns>
        public static IDictionary<string, object> GetStandardNotice(object apsAlert, string contentAvailable = null, string sound = null, int? badge = null)
        {
            var dic = new Dictionary<string, object>
            {
                { "alert",apsAlert}
            };
            if (!string.IsNullOrEmpty(contentAvailable))
            {
                dic.Add("content-available", contentAvailable);
            }
            if (!string.IsNullOrEmpty(sound))
            {
                dic.Add("sound", sound);
            }
            if (badge.HasValue)
            {
                dic.Add("badge", badge);
            }
            return new Dictionary<string, object>
            {
                {"aps",dic}
            };
        }
    }
}

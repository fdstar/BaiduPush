using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Model.Responses
{
    using Newtonsoft.Json;

    /// <summary>
    /// 统计APP设备数的响应实体
    /// </summary>
    [Serializable]
    public class ReportStatisticDeviceParams
    {
        /// <summary>
        /// 统计结果集的条数
        /// </summary>
        [JsonProperty(PropertyName = "total_num")]
        public int TotalNum { get; set; }
        /// <summary>
        /// 结果集合，key为统计信息所在当天0点0分时间戳
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public Dictionary<long, ReportStatisticDeviceResult> Result { get; set; }
    }
    public class ReportStatisticDeviceResult
    {
        /// <summary>
        /// 当天新增用户数
        /// </summary>
        [JsonProperty(PropertyName = "new_term")]
        public int NewTerm { get; set; }
        /// <summary>
        /// 当天解绑用户数
        /// </summary>
        [JsonProperty(PropertyName = "del_term")]
        public int DelTerm { get; set; }
        /// <summary>
        /// 当天在线用户数
        /// </summary>
        [JsonProperty(PropertyName = "online_term")]
        public int OnlineTerm { get; set; }
        /// <summary>
        /// 当天累计终端数
        /// </summary>
        [JsonProperty(PropertyName = "addup_term")]
        public int AddupTerm { get; set; }
        /// <summary>
        /// 有效channelId总数，等于addup_term 减去 del_term
        /// </summary>
        [JsonProperty(PropertyName = "total_term")]
        public int TotalTerm { get; set; }
    }
}

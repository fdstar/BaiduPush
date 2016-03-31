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
    /// Android通知格式
    /// </summary>
    [Serializable]
    public class AndroidNotice
    {
        /// <summary>
        /// 通知标题，可以为空；如果为空则设为appid对应的应用名
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        /// <summary>
        /// 通知文本内容，不能为空
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        /// <summary>
        /// android客户端自定义通知样式，如果没有设置默认为0
        /// </summary>
        [JsonProperty(PropertyName = "notification_builder_id")]
        public byte? NotificationBuilderId { get; set; }
        /// <summary>
        /// 只有notification_builder_id为0时有效
        /// 如果想选择任意两种或三种通知样式，notification_basic_style的值即为对应样式数值相加后的值
        /// </summary>
        [JsonProperty(PropertyName = "notification_basic_style")]
        public NotificationBasicStyle? NotificationBasicStyle { get; set; }
        /// <summary>
        /// 点击通知后的行为
        /// </summary>
        [JsonProperty(PropertyName = "open_type")]
        public OpenType? OpenType { get; set; }
        /// <summary>
        /// 需要打开的Url地址，OpenType为OpenType.OpenUrl有效
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        /// <summary>
        /// OpenType为OpenType.CustomBehavior有效
        /// Android端SDK会把pkg_content字符串转换成Android Intent,通过该Intent打开对应app组件
        /// 所以pkg_content字符串格式必须遵循Intent uri格式，最简单的方法可以通过Intent方法toURI()获取
        /// </summary>
        [JsonProperty(PropertyName = "pkg_content")]
        public string PkgContent { get; set; }
        /// <summary>
        /// 自定义内容，键值对，Json对象形式(可选)；在android客户端，这些键值对将以Intent中的extra进行传递
        /// 说白了就是序列化对象得到的Json字符串
        /// </summary>
        [JsonProperty(PropertyName = "custom_content")]
        public string CustomContent { get; set; }
    }
}

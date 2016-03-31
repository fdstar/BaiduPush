using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Exceptions
{
    using BaiduPush.Model.Responses;

    /// <summary>
    /// 当BaiduPush发生错误时，返回的异常对象
    /// </summary>
    public class BaiduPushException : Exception
    {
        public BaiduPushException(ErrorResponse error)
            : base(error == null ? string.Empty : error.ErrorMsg)
        {
            this.Error = error;
        }
        /// <summary>
        /// 错误信息
        /// </summary>
        public ErrorResponse Error { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Services
{
    using Model.Requests;
    using Model.Responses;
    public class TimerCancel : BaiduApiBase<TimerCancelRequest, Response>
    {
        private const string extUrl = "timer/cancel";
        protected override string ExtRestApiUrl
        {
            get
            {
                return extUrl;
            }
        }
    }
}

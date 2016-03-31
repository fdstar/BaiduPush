using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Services
{
    using Model.Requests;
    using Model.Responses;
    public class TimerQueryList : BaiduApiBase<TimerQueryListRequest, Response<TimerQueryListParams>>
    {
        private const string extUrl = "timer/query_list";

        public override bool AllowCallWithGet
        {
            get
            {
                return true;
            }
        }
        protected override string ExtRestApiUrl
        {
            get
            {
                return extUrl;
            }
        }
    }
}

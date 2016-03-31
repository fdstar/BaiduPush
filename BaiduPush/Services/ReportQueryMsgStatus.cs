using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Services
{
    using Model.Requests;
    using Model.Responses;
    public class ReportQueryMsgStatus : BaiduApiBase<ReportQueryMsgStatusRequest, Response<ReportQueryMsgStatusParams>>
    {
        private const string extUrl = "report/query_msg_status";

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

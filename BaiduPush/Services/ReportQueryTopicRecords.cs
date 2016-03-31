using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Services
{
    using Model.Requests;
    using Model.Responses;
    public class ReportQueryTopicRecords : BaiduApiBase<ReportQueryTopicRecordsRequest, Response<ReportQueryTopicRecordsParams>>
    {
        private const string extUrl = "report/query_topic_records";

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

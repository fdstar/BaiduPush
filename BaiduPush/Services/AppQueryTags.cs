using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Services
{
    using Model.Requests;
    using Model.Responses;
    public class AppQueryTags : BaiduApiBase<AppQueryTagsRequest, Response<AppQueryTagsParams>>
    {
        private const string extUrl = "app/query_tags";

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

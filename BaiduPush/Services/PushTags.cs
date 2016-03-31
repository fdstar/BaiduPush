using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Services
{
    using Model.Requests;
    using Model.Responses;
    public class PushTags : BaiduApiBase<PushTagsRequest, Response<PushTagsParams>>
    {
        private const string extUrl = "push/tags";

        protected override string ExtRestApiUrl
        {
            get
            {
                return extUrl;
            }
        }
    }
}

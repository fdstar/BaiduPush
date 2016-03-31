using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Services
{
    using Model.Requests;
    using Model.Responses;
    public class PushAll : BaiduApiBase<PushAllRequest, Response<PushAllParams>>
    {
        private const string extUrl = "push/all";
        protected override string ExtRestApiUrl
        {
            get
            {
                return extUrl;
            }
        }
    }
}

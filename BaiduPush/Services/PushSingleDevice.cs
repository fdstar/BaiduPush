using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Services
{
    using Model.Requests;
    using Model.Responses;
    public class PushSingleDevice : BaiduApiBase<PushSingleDeviceRequest, Response<PushSingleDeviceParams>>
    {
        private const string extUrl = "push/single_device";

        protected override string ExtRestApiUrl
        {
            get
            {
                return extUrl;
            }
        }
    }
}

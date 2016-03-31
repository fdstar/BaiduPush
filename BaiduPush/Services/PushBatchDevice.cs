using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Services
{
    using Model.Requests;
    using Model.Responses;
    public class PushBatchDevice : BaiduApiBase<PushBatchDeviceRequest, Response<PushBatchDeviceParams>>
    {
        private const string extUrl = "push/batch_device";

        protected override string ExtRestApiUrl
        {
            get
            {
                return extUrl;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Services
{
    using Model.Requests;
    using Model.Responses;
    public class TagDelDevices : BaiduApiBase<TagDelDevicesRequest, Response<TagDelDevicesParams>>
    {
        private const string extUrl = "tag/del_devices";
        protected override string ExtRestApiUrl
        {
            get
            {
                return extUrl;
            }
        }
    }
}

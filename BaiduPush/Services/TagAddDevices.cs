using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Services
{
    using Model.Requests;
    using Model.Responses;
    public class TagAddDevices : BaiduApiBase<TagAddDevicesRequest, Response<TagAddDevicesParams>>
    {
        private const string extUrl = "tag/add_devices";
        protected override string ExtRestApiUrl
        {
            get
            {
                return extUrl;
            }
        }
    }
}

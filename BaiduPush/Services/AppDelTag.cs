using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Services
{
    using Model.Requests;
    using Model.Responses;
    public class AppDelTag : BaiduApiBase<AppDelTagRequest, Response<AppDelTagParams>>
    {
        private const string extUrl = "app/del_tag";
        protected override string ExtRestApiUrl
        {
            get
            {
                return extUrl;
            }
        }
    }
}

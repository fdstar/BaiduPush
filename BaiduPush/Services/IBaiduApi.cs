using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Services
{
    using Model.Requests;
    using Model.Responses;
    public interface IBaiduApi<TRequest, TResponse>
        where TRequest : Request
        where TResponse : Response
    {
        /// <summary>
        /// 请求Rest Api，如果访问出错，将产生异常BaiduPushException
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<TResponse> Call(TRequest request);
    }
}

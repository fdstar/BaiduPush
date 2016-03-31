using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Services
{
    using Exceptions;
    using Model.Requests;
    using Model.Responses;
    using Newtonsoft.Json;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text.RegularExpressions;
    using System.Web;
    using Utils;
    public abstract class BaiduApiBase<TRequest, TResponse> : IBaiduApi<TRequest, TResponse>
        where TRequest : Request
        where TResponse : Response
    {
        #region Fields
        private const string HttpPost = "POST";
        private const string HttpGet = "GET";
        private string _httpMethod = HttpPost;
        /// <summary>
        /// 百度云推送的Rest Api网址，不包含
        /// </summary>
        public static string PrevRestApiUrl = "http://api.tuisong.baidu.com/rest/3.0/";
        /// <summary>
        /// Rest Api请求需要的UA
        /// </summary>
        private static readonly string UserAgent;
        #endregion

        #region .Oct
        static BaiduApiBase()
        {
            string osVersion = Environment.OSVersion.VersionString;
            string netVersion = Environment.Version.ToString();
            string sdkName = "BaiduPush SDK";
            UserAgent = string.Format("BCCS_SDK/3.0 ({0}) .NET/{1} ({2})", osVersion, netVersion, sdkName);
        }
        #endregion

        #region Properties
        /// <summary>
        /// 是否允许通过Get的方式请求Api，默认设置不允许
        /// </summary>
        public virtual bool AllowCallWithGet
        {
            get
            {
                return false;
            }
        }
        /// <summary>
        /// 通过哪种方式请求资源，只支持GET、POST，默认POST
        /// </summary>
        public string HttpMethod
        {
            get
            {
                return this._httpMethod;
            }
            set
            {
                if (string.Equals(value, HttpPost, StringComparison.OrdinalIgnoreCase)
                    || (AllowCallWithGet && string.Equals(value, HttpGet, StringComparison.OrdinalIgnoreCase)))
                {
                    this._httpMethod = value;
                }
            }
        }
        /// <summary>
        /// 要访问的Api地址部分（不包含公共部分，格式为{class}/{method}）
        /// </summary>
        protected abstract string ExtRestApiUrl { get; }
        #endregion

        #region Methods
        /// <summary>
        /// 请求Rest Api，如果访问出错，将产生异常BaiduPushException
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async virtual Task<TResponse> Call(TRequest request)
        {
            var dic = this.GetSortedDicionary(request);
            string sign = this.GetSecuritySign(dic, request.SecretKey);
            dic.Add("sign", sign);//生成的签名需要加入字典
            var response = await this.CallApi(dic);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                //根据百度错误定义，只有状态为200的才是正确响应
                var error = JsonConvert.DeserializeObject<ErrorResponse>(await response.Content.ReadAsStringAsync());
                throw new BaiduPushException(error);
            }
            else
            {
                string result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TResponse>(result);
            }
        }
        /// <summary>
        /// 将请求实体转化为SortedDictionary，默认通过反射实现，如觉得存在性能问题，可以在子类重写
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        protected virtual SortedDictionary<string, string> GetSortedDicionary(TRequest request)
        {
            SortedDictionary<string, string> dic = new SortedDictionary<string, string>();
            foreach (var kv in RequestMapping.GetMapping<TRequest>())
            {
                var value = kv.Key.GetValue(request);
                if (value != null)
                {
                    string str = null;
                    if (value.GetType().IsEnum)
                    {
                        str = Convert.ToInt32(value).ToString();
                    }
                    else
                    {
                        str = value.ToString().Trim();
                    }
                    if (!string.IsNullOrEmpty(str))
                    {
                        dic.Add(kv.Value, str);
                    }
                }
            }
            return dic;
        }
        /// <summary>
        /// 按百度云推送的要求生成签名，签名规则 MD5( urlencode( $http_method$url$k1=$v1$k2=$v2$k3=$v3$secret_key ))
        /// </summary>
        /// <param name="dic"></param>
        /// <param name="secretKey"></param>
        /// <returns></returns>
        private string GetSecuritySign(SortedDictionary<string, string> dic, string secretKey)
        {
            StringBuilder tmp = new StringBuilder();
            tmp.Append(this.HttpMethod.ToUpper());//http method
            tmp.Append(PrevRestApiUrl);//请求的url
            tmp.Append(ExtRestApiUrl);//请求的url
            foreach (var kv in dic)//签名内容
            {
                tmp.Append(kv.Key);
                tmp.Append('=');
                tmp.Append(kv.Value);
            }
            tmp.Append(secretKey);//末尾添加secretKey
            var str = HttpUtility.UrlEncode(tmp.ToString(), Encoding.UTF8);
            str = Regex.Replace(str, @"(?<=%).{2}", m => m.Value.ToUpper());//关键一段，将编码后%后面的两位转义符Upper，没这段必定签名错误
            return MD5Helper.GetMD5_32(str, Encoding.UTF8);
        }
        private async Task<HttpResponseMessage> CallApi(IDictionary<string, string> dic)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json") { CharSet = "utf-8" });
            client.DefaultRequestHeaders.Add("UserAgent", UserAgent);//关于UA这段API是在扯淡么？这段注销一样可以访问 http://push.baidu.com/doc/restapi/sdk_developer
            HttpResponseMessage response;
            string url = string.Format("{0}{1}", PrevRestApiUrl, this.ExtRestApiUrl);
            if (string.Equals(this.HttpMethod, HttpPost, StringComparison.OrdinalIgnoreCase))
            {
                //POST
                var httpContent = new FormUrlEncodedContent(dic);
                httpContent.Headers.ContentType.CharSet = "utf-8";
                response = await client.PostAsync(url, httpContent);
            }
            else
            {
                //GET
                StringBuilder tmp = new StringBuilder();
                foreach (var kv in dic)
                {
                    tmp.Append('&');
                    tmp.Append(kv.Key);
                    tmp.Append('=');
                    tmp.Append(HttpUtility.UrlEncode(kv.Value, Encoding.UTF8));
                }
                if (tmp.Length > 0)
                {
                    tmp.Remove(0, 1);
                }
                response = await client.GetAsync(string.Format("{0}?{1}", url, tmp.ToString()));
            }
            return response;
        }
        #endregion
    }
}

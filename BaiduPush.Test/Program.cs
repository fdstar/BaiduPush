using BaiduPush.Model.Enums;
using BaiduPush.Model.Requests;
using BaiduPush.Services;
using BaiduPush.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiduPush.Test
{
    class Program
    {
        static List<KeyValuePair<string, string>> BaiduKeys = new List<KeyValuePair<string, string>>()
        {
            new KeyValuePair<string, string>("uKT5SAmy4FpvfGHQlCOMhgeg","kRI0OBGobUh7blAujIOBhQbVk9VUYInQ"),
            new KeyValuePair<string, string>("ifNH0dX1VG9D37Hec8Fq9Cvd","sDRlohkkRFVIoplkfg1qKzhQXpQTsucH"),
        };
        static void Main(string[] args)
        {
            //string channelId = "3911702798220008642";
            //PushSingleDeviceTest(channelId);
            PushSingleDeviceTestWithIOS();
            //PushAllTest();
            //ReportStatisticDeviceTest();
            //ReportQueryMsgStatusTest("[\"4138210314396792811\",\"2313034595722776003\"]");
            Console.ReadLine();
        }
        static async void PushSingleDeviceTestWithIOS()
        {
            PushSingleDeviceRequest request = new PushSingleDeviceRequest();
            request.ApiKey = "10uTP0v1PDrn3jGoQVW1IB4G";
            request.SecretKey = "ikPAPv6k4bWq7CLfyD0NjFMTWkquYuzw";
            request.DeviceType = DeviceType.IOS;
            request.ChannelId = "5128334595467232977";
            request.MsgType = MsgType.Notice;
            dynamic aps = $"Test Msg Send To Single IOS Device { request.ChannelId}";
            request.Msg = JsonConvert.SerializeObject(IOSNotice.GetStandardNotice(aps));
            request.DeployStatus = 1;

            PushSingleDevice push = new PushSingleDevice();
            try
            {
                var response = await push.Call(request);
                Console.WriteLine($"PushSingleDevice Response MsgId:{response.ResponseParams.MsgId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static async void PushSingleDeviceTest(string channelId)
        {
            PushSingleDeviceRequest request = new PushSingleDeviceRequest();
            FillKey(request);
            request.ChannelId = channelId;
            request.Msg = $"Test Msg Send To Single Device {channelId}";
            PushSingleDevice push = new PushSingleDevice();
            try
            {
                var response = await push.Call(request);
                Console.WriteLine($"PushSingleDevice Response MsgId:{response.ResponseParams.MsgId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void FillKey(Request request, int idx = 0)
        {
            request.ApiKey = BaiduKeys[idx].Key;
            request.SecretKey = BaiduKeys[idx].Value;
            request.DeviceType = DeviceType.Android;
            request.Expires = DateTime.Now.AddHours(1).ToUnixTimestamp();
        }
        static async void PushAllTest()
        {
            PushAllRequest request = new PushAllRequest();
            FillKey(request);
            request.Msg = $"Test Msg Send To All Devices";
            PushAll push = new PushAll();
            try
            {
                var response = await push.Call(request);
                Console.WriteLine($"PushAll Response MsgId:{response.ResponseParams.MsgId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static async void ReportStatisticDeviceTest()
        {
            ReportStatisticDeviceRequest request = new ReportStatisticDeviceRequest();
            FillKey(request);
            ReportStatisticDevice push = new ReportStatisticDevice();
            try
            {//当没有任何设备时，api返回的数据就是个坑，返回的是"result":[]，而不是"result":{}
                push.HttpMethod = "GET";
                var response = await push.Call(request);
                Console.WriteLine($"ReportStatisticDevice TotalNum :{response.ResponseParams.TotalNum}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static async void ReportQueryMsgStatusTest(string msgId = null)
        {
            //4138210314396792811
            ReportQueryMsgStatusRequest request = new ReportQueryMsgStatusRequest();
            request.MsgId = msgId;
            FillKey(request);
            ReportQueryMsgStatus push = new ReportQueryMsgStatus();
            try
            {//推送状态有坑，api说明上没有-1的，实际却可以查出来
                var response = await push.Call(request);
                Console.WriteLine($"ReportQueryMsgStatus TotalNum :{response.ResponseParams.TotalNum}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

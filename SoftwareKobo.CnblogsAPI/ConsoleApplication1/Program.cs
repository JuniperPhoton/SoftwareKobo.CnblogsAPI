﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareKobo.CnblogsAPI.Service;
using Newtonsoft.Json;
using SoftwareKobo.CnblogsAPI.Model;
using Newtonsoft.Json.Linq;
using SoftwareKobo.CnblogsAPI.Extension;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = UserService.LoginAsync("h82258652", "842053625").Result;
        //    var h = UserService.SendArticleCommentAsync(cookie, "h82258652", 4168444, "由api发送测试", 0).Result;
              var newsDetail = NewsService.DetailAsync(509690).Result;
             var html= newsDetail.SendCommentAsync(cookie,"测试当中fggggggggggggggggggggaghwfffffffffffffff！！！").Result;


            //   string j= "{\"IsSuccess\":true,\"Message\":\"just test\",\"Duration\":\"373\"}";

            //var xxx=            JsonConvert.DeserializeObject<JObject>(j);

        }
    }
}

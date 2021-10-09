﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MSDev.PddOpenSdk.AspNetCore;
using MSDev.PddOpenSdk.Models;
using PddOpenSdk.AspNetCore;
using System;

namespace Sample
{
    public class MyHostService : PddSocketHostServiceBase
    {

        public MyHostService(ILogger<MyHostService> logger, IServiceProvider services, IOptions<PddOptions> options) : base(logger, services, options)
        {
            // 可在此处设置心中间隔，会覆盖配置中的值 
            HeartBeatSeconds = 5;
        }

        public override void OnMessage()
        {
            // 接收信息
            client.MessageReceived.Subscribe((message) =>
             {
                 var msg = JsonSerializer.Deserialize<SocketMessageModel>(message.Text);
                 if (msg.CommandType.ToLower().Equals("heartbeat"))
                 {
                     // TODO:心跳报文不处理
                 }
                 else
                 {
                     // TODO:自定义处理逻辑
                     _logger.LogInformation("报文:" + msg.Message.Content);
                     using (var scope = Services.CreateScope())
                     {
                         // 获取你自己的数据库上下文服务
                         //var context = scope.ServiceProvider.GetRequiredService<DbContext>();
                     }
                 }
             });
        }

    }
}

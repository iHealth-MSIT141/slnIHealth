using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using prjiHealth.Models;
using prjIHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CoreMVC_SignalR_Chat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user , message);
        }
        //    // 用戶連線 ID 列表
        //    //public static List<string> ConnIDList = new List<string>();
        //    /// <summary>
        //    /// 連線事件
        //    /// </summary>
        //    /// <returns></returns>    
        //    /// 
        //    class ChatUser
        //    {
        //        public string ConnectionId { get; set; }
        //        public string userName { get; set; }
        //    }

        //    private static readonly List<ChatUser> chatUsers = new List<ChatUser>();

        //    //then you do inside your class:



        //       public override async Task OnConnectedAsync()
        //    {
        //        if (chatUsers.Where(p => p.ConnectionId == Context.ConnectionId).FirstOrDefault() == null)
        //        {
        //            chatUsers.Add(new ChatUser { ConnectionId=Context.ConnectionId, userName="user" });
        //        }
        //        // 更新連線 ID 列表

        //        string jsonString = JsonConvert.SerializeObject(chatUsers);
        //        await Clients.All.SendAsync("UpdList", jsonString);

        //        // 更新個人 ID

        //        await Clients.Client(chatUsers[0].ConnectionId).SendAsync("UpdSelfID", chatUsers[0].ConnectionId);

        //        // 更新聊天內容
        //        //await Clients.All.SendAsync("UpdContent", "新連線 ID: " + chatUsers[0].ConnectionId);
        //        await Clients.All.SendAsync("UpdContent");
        //        await base.OnConnectedAsync();



        //        //if (ConnIDList.Where(p => p == Context.ConnectionId).FirstOrDefault() == null)
        //        //{
        //        //    ConnIDList.Add(Context.ConnectionId);
        //        //}
        //        // 更新連線 ID 列表
        //        //string jsonString = JsonConvert.SerializeObject(ConnIDList);
        //        //await Clients.All.SendAsync("UpdList", jsonString);

        //        //// 更新個人 ID
        //        //await Clients.Client(Context.ConnectionId).SendAsync("UpdSelfID", Context.ConnectionId);

        //        //// 更新聊天內容
        //        //await Clients.All.SendAsync("UpdContent", "新連線 ID: " + Context.ConnectionId);

        //        //await base.OnConnectedAsync();
        //    }

        //    /// <summary>
        //    /// 離線事件
        //    /// </summary>
        //    /// <param name="ex"></param>
        //    /// <returns></returns>
        //    //public override async Task OnDisconnectedAsync(Exception ex)
        //    //{
        //    //    string id = ConnIDList.Where(p => p == Context.ConnectionId).FirstOrDefault();
        //    //    if (id != null)
        //    //    {
        //    //        ConnIDList.Remove(id);
        //    //    }
        //    //    // 更新連線 ID 列表
        //    //    string jsonString = JsonConvert.SerializeObject(ConnIDList);
        //    //    await Clients.All.SendAsync("UpdList", jsonString);

        //    //    // 更新聊天內容
        //    //    await Clients.All.SendAsync("UpdContent", "已離線 ID: " + Context.ConnectionId);

        //    //    await base.OnDisconnectedAsync(ex);
        //    //}

        //    /// <summary>
        //    /// 傳遞訊息
        //    /// </summary>
        //    /// <param name="user"></param>
        //    /// <param name="message"></param>
        //    /// <param name="id"></param>
        //    /// <returns></returns>
        //    public async Task SendMessage(string selfID, string message, string sendToID)
        //    {
        //        if (string.IsNullOrEmpty(sendToID))
        //        {
        //            await Clients.All.SendAsync("UpdContent", selfID + " 說: " + message);
        //        }
        //        else
        //        {
        //            // 接收人
        //            await Clients.Client(sendToID).SendAsync("UpdContent", selfID + " 私訊向你說: " + message);

        //            // 發送人
        //            await Clients.Client(Context.ConnectionId).SendAsync("UpdContent", "你向 " + sendToID + " 私訊說: " + message);
        //        }
        //    }
    }

}
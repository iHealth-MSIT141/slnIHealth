using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Hubs;

namespace prjIHealth.Hubs
{  
    
    
    [HubName("chat")]
    public class signalR:Hub
    {
        //HubName 這個特性是為了讓客戶端知道如何建立與伺服器端對應服務的代理物件，
        //如果沒有設定該屬性，則以伺服器端的服務類名字作為 HubName 的預設值
     
       
            public void Send(string clientName, string message)
            {
                // Call the addSomeMessage method to update clients.
                //Clients.All.addSomeMessage(clientName, message);
            }
       

    }
}

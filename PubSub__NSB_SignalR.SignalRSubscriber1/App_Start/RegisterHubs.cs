using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.SignalR;

[assembly: PreApplicationStartMethod(typeof(PubSub__NSB_SignalR.SignalRSubscriber1.RegisterHubs), "Start")]

namespace PubSub__NSB_SignalR.SignalRSubscriber1
{
    public class RegisterHubs
    {
        public static void Start()
        {
            var config = new HubConfiguration
            {
                EnableCrossDomain = true
            };

            RouteTable.Routes.MapHubs(config);
        }
    }
}

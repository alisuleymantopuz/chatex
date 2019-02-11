using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Owin;


namespace ChatEx.Server
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR("/chatex", new HubConfiguration());
            GlobalHost.Configuration.MaxIncomingWebSocketMessageSize = null;
        }
    }
}
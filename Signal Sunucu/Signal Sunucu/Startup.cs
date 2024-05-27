using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Signal_Sunucu.Startup))]

namespace Signal_Sunucu
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			//app.MapSignalR("/signalr", new Microsoft.AspNet.SignalR.HubConfiguration());
			app.MapSignalR();
		}
	}
}
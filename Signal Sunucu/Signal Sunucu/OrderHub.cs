using Microsoft.AspNet.SignalR;
using System;

namespace Signal_Sunucu
{
	public class RestaurantHub : Hub
	{
		//public void SendOrderUpdate(string orderDetails)
		//{
		//	// Loglama
		//	Console.WriteLine("SendOrderUpdate tetiklendi.. ");
		//	// İstemcilerle iletişim kurmak için metot
		//	Clients.All.updateOrderStatus(orderDetails);
		//}

		public void MasaDurumDegisti()
		{
			Console.WriteLine("Masa Durumu Değişti =>" + DateTime.Now);
			Clients.All.MasaDurumDegisti();
		}

		//public void BakiyeDegisti()
		//{
		//	Console.WriteLine("Bakiye Degisti ");
		//	Clients.All.BakiyeDegisti();
		//}

		public void BildirimAlindi()
		{
			Console.WriteLine("BildirimAlindi tetiklendi =>" + DateTime.Now);
			Clients.All.BildirimAlindi();

		}
		public void OdemeBildirim()
		{
			Console.WriteLine("OdemeBildirim tetiklendi =>" + DateTime.Now);
			Clients.All.OdemeBildirim();

		}
		public void SiparisAlindi()
		{
			Console.WriteLine("SiparisAlindi tetiklendi =>" + DateTime.Now);
			Clients.All.SiparisAlindi();
		}

		public void OdemeAlindi()
		{
			Console.WriteLine("OdemeAlindi tetiklendi =>" + DateTime.Now);
			Clients.All.OdemeAlindi();
		}
	}
}
using System;
using Microsoft.Owin.Hosting;

namespace Signal_Sunucu
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string url = "http://192.168.1.150:8080/";
			try
			{
				using (WebApp.Start<Startup>(url))
				{
					Console.WriteLine($"SignalR server started at {url}");
					Console.WriteLine("Press Enter to exit...");
					Console.ReadLine();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Lütfen Yönetici Olarak Çalıştırıp Tekar Deneyiniz:{ex}");
			}
		}
	}
}
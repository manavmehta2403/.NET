﻿// See https://aka.ms/new-console-template for more information

namespace ASP.NETConsole
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World");
			CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
			{
				webBuilder.UseStartup<Startup>();
			});
	}
}
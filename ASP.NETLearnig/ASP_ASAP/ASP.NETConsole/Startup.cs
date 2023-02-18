﻿namespace ASP.NETConsole
{
	public class Startup
	{
		public void ConfigurationService(IServiceCollection	service) 
		{
			
		}	

		public void Configure(IApplicationBuilder applicationBuilder, IWebHostEnvironment webHostEnvironment)
		{
			applicationBuilder.UseRouting();

			applicationBuilder.UseEndpoints(endpoints => 
			{
				endpoints.MapGet("/",async  context =>
				{
					await context.Response.WriteAsync("Hello World");
				});
			});
		}
	}
}

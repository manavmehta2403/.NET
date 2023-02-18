using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMvcCore();

var app = builder.Build();

app.Use(async (context, next) =>
{
	await context.Response.WriteAsync("First Middleware\n");
	await next(); // allow to get the routing from the next middle ware

	//return back to first middle ware

	await context.Response.WriteAsync("First Middleware Back\n");
});

app.Use(async (context, next) =>
{
	await context.Response.WriteAsync("Second Middleware\n");
	await next(); // allow to get the routing from the next middle ware

	//return back to second middle ware

	await context.Response.WriteAsync("Second Middleware Back\n");
});

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Map("/", () => $"Hello World!\n{app.Environment.EnvironmentName}\n");

app.Map("/mapmiddleware", () => "Mapmiddleware\n");

app.Run();

using ContosoCrafts.Model;
using ContosoCrafts.Service;
using Microsoft.AspNetCore.Http;
using System.Data;
using System.Text.Json;
using ContosoCrafts;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddTransient<ProductService>();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(
	endpoints =>
	endpoints.MapGet("/products", (context) =>
	{
		var products = app.Services.GetService<ProductService?>().GetProducts();
		var json = JsonSerializer.Serialize<IEnumerable<Product>>(products);
		return context.Response.WriteAsync(json);
	}));
app.MapRazorPages();
app.MapControllers();

app.Run();

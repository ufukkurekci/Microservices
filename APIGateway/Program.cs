using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MMLib.Ocelot.Provider.AppConfiguration;
using MMLib.SwaggerForOcelot.DependencyInjection;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOcelot().AddAppConfiguration();
builder.Services.AddSwaggerForOcelot(builder.Configuration);
builder.Services.AddControllers();
builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
{
	config.AddOcelotWithSwaggerSupport(option =>
	{
		option.Folder = "OcelotConfig";
	});
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOcelot();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseSwaggerForOcelotUI(option =>
{
	option.PathToSwaggerGenerator = "/swagger/docs";
}).UseOcelot().Wait();


app.UseAuthorization();

app.MapControllers();

app.Run();
